using System.Drawing.Drawing2D;
using System.Text.Json;

namespace OOP_Progect
{
    public partial class SessionForm : Form
    {
        bool isSidebarExpanded = false;

        string userName;

        public UserData userData = new UserData();
        string userFilePath = "userdata.json";

        string sessionFilePath = "sessions.json";
        SettingsData settings = new SettingsData();

        public SessionForm(string name)
        {
            InitializeComponent();
            userName = name;
            labelwelcome.Text = $"Welcome back,\n{userName} 👋";
        }

        // =========================
        // Load
        // =========================
        private void SessionForm_Load(object sender, EventArgs e)
        {
            // Rounded UI
            buttonStart.Region = new Region(GetRoundedPath(buttonStart.ClientRectangle, 20));
            buttonSettings.Region = new Region(GetRoundedPath(buttonSettings.ClientRectangle, 20));
            panelPoints.Region = new Region(GetRoundedPath(panelPoints.ClientRectangle, 25));
            panelStreak.Region = new Region(GetRoundedPath(panelStreak.ClientRectangle, 25));
            panelSidebar.Region = new Region(GetRoundedPath(panelSidebar.ClientRectangle, 25));

            LoadUserData();
            LoadSettings();
        }

        // =========================
        // Sound
        // =========================
        void PlayClickSound()
        {
            if (!settings.EnableSound) return;

            System.Media.SystemSounds.Asterisk.Play();
        }

        // =========================
        // Settings
        // =========================
        void LoadSettings()
        {
            if (File.Exists("settings.json"))
            {
                string json = File.ReadAllText("settings.json");
                settings = JsonSerializer.Deserialize<SettingsData>(json) ?? new SettingsData();
            }
        }

        // =========================
        // User Data
        // =========================
        void LoadUserData()
        {
            try
            {
                if (File.Exists(userFilePath))
                {
                    string json = File.ReadAllText(userFilePath);
                    userData = JsonSerializer.Deserialize<UserData>(json) ?? new UserData();
                }
                else
                {
                    userData = new UserData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
                userData = new UserData();
            }

            RefreshUI();
        }

        void SaveData()
        {
            try
            {
                string json = JsonSerializer.Serialize(userData);
                File.WriteAllText(userFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        // =========================
        // UI Update
        // =========================
        public void RefreshUI()
        {
            labelPoints.Text = userData.Points.ToString();
            labelStraek.Text = userData.Streak.ToString();
            UpdateStreakUI();
        }

        private void UpdateStreakUI()
        {
            if (userData.Streak == 0)
                labelStraek.ForeColor = Color.Gray;
            else if (userData.Streak < 3)
                labelStraek.ForeColor = Color.Orange;
            else if (userData.Streak < 5)
                labelStraek.ForeColor = Color.DarkOrange;
            else
                labelStraek.ForeColor = Color.Red;
        }

        public void UpdateStats(int earnedPoints, bool success)
        {
            userData.Points += earnedPoints;

            if (success)
                userData.Streak++;
            else
                userData.Streak = 0;

            RefreshUI();
            SaveData();
        }

        // =========================
        // Sessions
        // =========================
        public void AddSession(string date, string duration, string breakTime, SessionStatus status)
        {
            try
            {
                // 1. تعريف مصفوفة الكائنات
                SessionRecord[] sessions;

                // 2. قراءة الداتا القديمة (إن وجدت)
                if (File.Exists(sessionFilePath))
                {
                    string json = File.ReadAllText(sessionFilePath);
                    // بنقرأ الداتا كمصفوفة مش كـ List
                    sessions = JsonSerializer.Deserialize<SessionRecord[]>(json) ?? new SessionRecord[0];
                }
                else
                {
                    // لو مفيش ملف، بنعمل مصفوفة فاضية
                    sessions = new SessionRecord[0];
                }

                // 3. تجهيز الجلسة الجديدة
                SessionRecord newSession = new SessionRecord
                {
                    Date = date,
                    Duration = duration,
                    BreakTime = breakTime,
                    Status = status
                };

                // 4. التريكة بتاعت المصفوفة: نعمل مصفوفة جديدة أكبر بواحد
                SessionRecord[] updatedSessions = new SessionRecord[sessions.Length + 1];

                // 5. ننقل الداتا القديمة للمصفوفة الجديدة
                for (int i = 0; i < sessions.Length; i++)
                {
                    updatedSessions[i] = sessions[i];
                }

                // 6. نحط الجلسة الجديدة في آخر مكان في المصفوفة
                updatedSessions[sessions.Length] = newSession;

                // 7. الحفظ
                SaveSessionToTxt(newSession); // حفظ الـ TXT زي ما إنت عامل

                // نحفظ المصفوفة الجديدة في الـ JSON
                string updatedJson = JsonSerializer.Serialize(updatedSessions, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(sessionFilePath, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving session: " + ex.Message);
            }
        }

        // =========================
        // Navigation Buttons
        // =========================
        private void button2_Click(object sender, EventArgs e)
        {
            PlayClickSound();

            FocusSessionForm form = new FocusSessionForm(this);
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlayClickSound();

            SettingsForm form = new SettingsForm(this);
            form.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HistoryForm form = new HistoryForm(this);
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FocusSessionForm form = new FocusSessionForm(this);
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm(this);
            form.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // =========================
        // Sidebar
        // =========================
        private void button1_Click(object sender, EventArgs e)
        {
            panelSidebar.Visible = true;

            if (!timerSidebar.Enabled)
                timerSidebar.Start();
        }

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            int speed = 10;

            if (isSidebarExpanded)
            {
                panelSidebar.Width -= speed;

                if (panelSidebar.Width <= 0)
                {
                    panelSidebar.Width = 0;
                    timerSidebar.Stop();
                    isSidebarExpanded = false;
                }
            }
            else
            {
                panelSidebar.Width += speed;

                if (panelSidebar.Width >= 200)
                {
                    panelSidebar.Width = 200;
                    timerSidebar.Stop();
                    isSidebarExpanded = true;
                }
            }

            panelSidebar.Region = new Region(GetRoundedPath(panelSidebar.ClientRectangle, 25));
        }

        // =========================
        // Hover Effects
        // =========================
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            buttonStart.BackColor = Color.Purple;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            buttonStart.BackColor = Color.MediumPurple;
        }

        private void buttonSettings_MouseEnter(object sender, EventArgs e)
        {
            buttonSettings.BackColor = Color.Purple;
        }

        private void buttonSettings_MouseLeave(object sender, EventArgs e)
        {
            buttonSettings.BackColor = Color.MediumPurple;
        }

        // =========================
        // Rounded Helper
        // =========================
        GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);

            path.CloseFigure();
            return path;
        }
        void SaveSessionToTxt(SessionRecord session)
        {
            try
            {
                string line = $"{session.Date} | {session.Duration} | {session.BreakTime} | {session.Status}";
                File.AppendAllText("sessions.txt", line + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving TXT: " + ex.Message);
            }
        }

    }

}