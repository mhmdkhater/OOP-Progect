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
        void LoadSettings()
        {
            if (File.Exists(settingsFilePath))
            {
                string json = File.ReadAllText(settingsFilePath);
                settings = JsonSerializer.Deserialize<SettingsData>(json) ?? new SettingsData();
            }
        }
        SettingsData settings = new SettingsData();
        string settingsFilePath = "settings.json";

        int timeLeft;
        int originalFocusTime;
        int breakTime;

        List<string> apps;
        SessionForm mainForm;

        public TimerForm(int focusMinutes, int breakMinutes, List<string> selectedApps, SessionForm form)
        {
            InitializeComponent();

            mainForm = form;

            timeLeft = focusMinutes * 60;
            originalFocusTime = focusMinutes;
            breakTime = breakMinutes;
            apps = selectedApps;

            labelTimer.Text = TimeSpan.FromSeconds(timeLeft).ToString(@"mm\:ss");
            timer1.Start();
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
            buttonComplete.Visible = false;
            buttonEnd.Visible = true;

            // Load settings مرة واحدة بس
            if (File.Exists(settingsFilePath))
            {
                string json = File.ReadAllText(settingsFilePath);
                settings = JsonSerializer.Deserialize<SettingsData>(json) ?? new SettingsData();
            }

            // UI Style
            labelTitle.BackColor = Color.FromArgb(20, 20, 40);
            labelMotivation.BackColor = Color.FromArgb(20, 20, 40);
            labelTimer.BackColor = Color.FromArgb(20, 20, 40);
            label1.BackColor = Color.FromArgb(20, 20, 40);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadSettings();
            if (timeLeft <= 0)
                return;

            timeLeft--;

            labelTimer.Text = TimeSpan.FromSeconds(timeLeft).ToString(@"mm\:ss");

            if (timeLeft == 0)
            {
                timer1.Stop();

                // تسجيل النجاح
                mainForm.AddSession(
                    DateTime.Now.ToString("yyyy-MM-dd"),
                    originalFocusTime + " min",
                    breakTime + " min",
                    SessionStatus.Success
                );

                if (!settings.SilentMode)
                    MessageBox.Show("Session Completed 🔥");

                buttonEnd.Visible = false;
                buttonComplete.Visible = true;
            }
        }

        private void buttonEnd_Click_1(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Yes;

            if (!settings.SilentMode)
            {
                result = MessageBox.Show(
                    "Are you sure you want to end this session early?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
            }

            if (result == DialogResult.Yes)
            {
                timer1.Stop();

                // تسجيل الفشل
                mainForm.AddSession(
                    DateTime.Now.ToString("yyyy-MM-dd"),
                    originalFocusTime + " min",
                    breakTime + " min",
                    SessionStatus.Failed
                );

                mainForm.UpdateStats(0, false);

                if (!settings.SilentMode)
                    MessageBox.Show("Session Failed ❌");

                mainForm.Show();
                this.Close();
            }
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            if (!settings.SilentMode)
                MessageBox.Show("Great job! Session Completed ✅");

            mainForm.UpdateStats(10, true);

            mainForm.Show();
            this.Close();
        }
        
    }
}