using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace OOP_Progect
{
    public partial class TimerForm : Form
    {
        SettingsData settings = new SettingsData();
        string settingsFilePath = "settings.json";

        int timeLeft;
        int originalFocusTime;
        int breakTime;

        string[] apps;
        SessionForm mainForm;

        // متغير لمنع التداخل عند ظهور رسائل الـ MessageBox
        bool isDialogActive = false;

        public TimerForm(int focusMinutes, int breakMinutes, string[] selectedApps, SessionForm form)
        {
            InitializeComponent();

            mainForm = form;
            timeLeft = focusMinutes * 60;
            originalFocusTime = focusMinutes;
            breakTime = breakMinutes;
            apps = selectedApps;

            if (apps != null && apps.Length > 0)
            {
                listBoxApps.Items.Clear();
                foreach (string app in apps)
                {
                    listBoxApps.Items.Add(app);
                }
            }
            else
            {
                listBoxApps.Items.Add("No apps selected");
            }

            labelTimer.Text = TimeSpan.FromSeconds(timeLeft).ToString(@"mm\:ss");
        }

        void LoadSettings()
        {
            try
            {
                if (File.Exists(settingsFilePath))
                {
                    string json = File.ReadAllText(settingsFilePath);
                    settings = JsonSerializer.Deserialize<SettingsData>(json) ?? new SettingsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading settings: " + ex.Message);
                settings = new SettingsData();
            }
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            LoadSettings();

            buttonComplete.Visible = false;
            buttonEnd.Visible = true;

            // UI Style
            labelTitle.BackColor = Color.FromArgb(20, 20, 40);
            labelMotivation.BackColor = Color.FromArgb(20, 20, 40);
            labelTimer.BackColor = Color.FromArgb(20, 20, 40);
            label1.BackColor = Color.FromArgb(20, 20, 40);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft <= 0) return;

            timeLeft--;
            labelTimer.Text = TimeSpan.FromSeconds(timeLeft).ToString(@"mm\:ss");

            if (timeLeft == 0)
            {
                timer1.Stop();

                mainForm.AddSession(
                    DateTime.Now.ToString("yyyy-MM-dd"),
                    originalFocusTime + " min",
                    breakTime + " min",
                    SessionStatus.Success
                );

                if (!settings.SilentMode)
                {
                    isDialogActive = true;
                    MessageBox.Show("Session Completed 🔥");
                    isDialogActive = false;
                }

                buttonEnd.Visible = false;
                buttonComplete.Visible = true;
            }
        }

        private void buttonEnd_Click_1(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Yes;

            if (!settings.SilentMode)
            {
                isDialogActive = true;
                result = MessageBox.Show(
                    "Are you sure you want to end this session early?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                isDialogActive = false;
            }

            if (result == DialogResult.Yes)
            {
                isDialogActive = true;
                timer1.Stop();

                mainForm.AddSession(
                    DateTime.Now.ToString("yyyy-MM-dd"),
                    originalFocusTime + " min",
                    breakTime + " min",
                    SessionStatus.Failed
                );

                mainForm.UpdateStats(0, false);

                if (!settings.SilentMode)
                {
                    MessageBox.Show("Session Failed ❌");
                }

                mainForm.Show();
                this.Close();
            }
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            if (!settings.SilentMode)
            {
                isDialogActive = true;
                MessageBox.Show("Great job! Session Completed ✅");
                isDialogActive = false;
            }

            mainForm.UpdateStats(10, true);
            mainForm.Show();
            this.Close();
        }

        private void TimerForm_Deactivate(object sender, EventArgs e)
        {
            if (timeLeft > 0 && timer1.Enabled && !isDialogActive)
            {
                isDialogActive = true;

                if (!settings.SilentMode)
                {
                    System.Media.SystemSounds.Exclamation.Play();
                }

                MessageBox.Show("Don't ruin your hard work! Get back to studying and stay focused! 😡",
                                "Focus Guardian - Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                this.Activate();
                isDialogActive = false;
            }
        }

        private void labelMotivation_Click(object sender, EventArgs e) { }
    }
}