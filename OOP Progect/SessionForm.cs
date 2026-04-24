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
            }
            catch
            {
                MessageBox.Show("Error loading user data");
                userData = new UserData();
            }

            RefreshUI();
        }

        void SaveData()
        {
            string json = JsonSerializer.Serialize(userData);
            File.WriteAllText(userFilePath, json);
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
            List<SessionRecord> sessions;

            if (File.Exists(sessionFilePath))
            {
                string json = File.ReadAllText(sessionFilePath);
                sessions = JsonSerializer.Deserialize<List<SessionRecord>>(json) ?? new List<SessionRecord>();
            }
            else
            {
                sessions = new List<SessionRecord>();
            }

            sessions.Add(new SessionRecord
            {
                Date = date,
                Duration = duration,
                BreakTime = breakTime,
                Status = status
            });

            string updatedJson = JsonSerializer.Serialize(sessions, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(sessionFilePath, updatedJson);
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
        
    }
}