using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace OOP_Progect
{
    public partial class SettingsForm : Form
    {
        SessionForm previousForm;
        SettingsData settings = new SettingsData();
        string filePath = "settings.json";

        public SettingsForm(SessionForm form)
        {
            InitializeComponent();
            previousForm = form;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            
            // Rounded Panels
            panelAppearance.Region = new Region(GetRoundedPath(panelAppearance.ClientRectangle, 20));
            panelSession.Region = new Region(GetRoundedPath(panelSession.ClientRectangle, 20));

            // Load Settings
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                settings = JsonSerializer.Deserialize<SettingsData>(json) ?? new SettingsData();
            }
            checkSilentMode.Checked = settings.SilentMode;


            // Apply Values
            checkSound.Checked = settings.EnableSound;
            numericDefaultFocus.Value = settings.DefaultFocus;
            numericDefaultBreak.Value = settings.DefaultBreak;
            
            // UI Styling
            panelAppearance.BackColor = Color.FromArgb(150, 0, 0, 0);
            panelSession.BackColor = Color.FromArgb(150, 0, 0, 0);

            checkSound.BackColor = Color.Transparent;
            checkSound.ForeColor = Color.White;

            StyleControls(this);
        }

        void SaveSettings()
        {
            string json = JsonSerializer.Serialize(settings);
            File.WriteAllText(filePath, json);
        }

        void StyleControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Label || c is CheckBox)
                {
                    c.BackColor = Color.Transparent;
                    c.ForeColor = Color.White;
                }

                if (c is NumericUpDown num)
                {
                    num.BackColor = Color.FromArgb(40, 40, 70);
                    num.ForeColor = Color.White;
                    num.BorderStyle = BorderStyle.FixedSingle;
                }

                if (c is Panel)
                {
                    c.BackColor = Color.FromArgb(40, 40, 70);
                }

                if (c.HasChildren)
                {
                    StyleControls(c);
                }
            }
        }

        private void numericDefaultFocus_ValueChanged(object sender, EventArgs e)
        {
            settings.DefaultFocus = (int)numericDefaultFocus.Value;
            SaveSettings();
        }

        private void numericDefaultBreak_ValueChanged(object sender, EventArgs e)
        {
            settings.DefaultBreak = (int)numericDefaultBreak.Value;
            SaveSettings();
        }

        private void checkSound_CheckedChanged(object sender, EventArgs e)
        {
            settings.EnableSound = checkSound.Checked;
            SaveSettings();
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

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

        

        private void checkSilentMode_CheckedChanged_1(object sender, EventArgs e)
        {
            

            settings.SilentMode = checkSilentMode.Checked;
            SaveSettings();
        }
    }
}