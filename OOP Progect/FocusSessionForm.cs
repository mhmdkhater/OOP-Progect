using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Drawing.Drawing2D;

namespace OOP_Progect
{
    public partial class FocusSessionForm : Form
    {
        SettingsData settings = new SettingsData();
        string filePath = "settings.json";

        SessionForm mainForm;

        public FocusSessionForm(SessionForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        // =========================
        // Load
        // =========================
        private void FocusSessionForm_Load(object sender, EventArgs e)
        {
            fadeTimer.Start();

            LoadSettings();
            ApplySettingsToUI();
            ApplyRoundedUI();
        }

        // =========================
        // Settings
        // =========================
        void LoadSettings()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                settings = JsonSerializer.Deserialize<SettingsData>(json) ?? new SettingsData();
            }
            else
            {
                settings = new SettingsData()
                {
                    DefaultFocus = 60,
                    DefaultBreak = 10
                };
            }
        }

        void ApplySettingsToUI()
        {
            numericFocus.Value = settings.DefaultFocus;
            numericBreak.Value = settings.DefaultBreak;
        }

        // =========================
        // UI (Rounded)
        // =========================
        void ApplyRoundedUI()
        {
            this.Shown += (s, e) =>
            {
                panelMain.Region = new Region(GetRoundedPath(panelMain.ClientRectangle, 25));
                panelShadow.Region = new Region(GetRoundedPath(panelShadow.ClientRectangle, 25));

                buttonStartSession.Region = new Region(GetRoundedPath(buttonStartSession.ClientRectangle, 20));
                buttonCancel.Region = new Region(GetRoundedPath(buttonCancel.ClientRectangle, 20));
                buttonAddApp.Region = new Region(GetRoundedPath(buttonAddApp.ClientRectangle, 15));

                numericFocus.Region = new Region(GetRoundedPath(numericFocus.ClientRectangle, 10));
                numericBreak.Region = new Region(GetRoundedPath(numericBreak.ClientRectangle, 10));

                checkedListApps.Region = new Region(GetRoundedPath(checkedListApps.ClientRectangle, 15));
            };
        }

        // =========================
        // Buttons
        // =========================
        private void buttonAddApp_Click(object sender, EventArgs e)
        {
            string appName = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter App Name:",
                "Add Distraction",
                ""
            );

            if (!string.IsNullOrWhiteSpace(appName))
            {
                checkedListApps.Items.Add(appName, true);
            }
        }

        private void buttonStartSession_Click(object sender, EventArgs e)
        {
            int focusTime = (int)numericFocus.Value;
            int breakTime = (int)numericBreak.Value;

            List<string> selectedApps = new List<string>();

            foreach (object item in checkedListApps.CheckedItems)
            {
                selectedApps.Add(item?.ToString() ?? "");
            }

            TimerForm timerForm = new TimerForm(focusTime, breakTime, selectedApps, mainForm);
            timerForm.Show();

            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        // =========================
        // Animation
        // =========================
        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05;
            else
                fadeTimer.Stop();
        }

        // =========================
        // Helper
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