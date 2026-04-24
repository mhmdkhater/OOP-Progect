using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text.Json;

namespace OOP_Progect
{
    public partial class HistoryForm : Form
    {
        SessionForm previousForm;

        public HistoryForm(SessionForm form)
        {
            InitializeComponent();
            previousForm = form;

            this.Shown += HistoryForm_Shown;
            this.Resize += (s, e) => ApplyRounded();
            this.Activated += (s, e) => LoadData();
        }

        // =========================
        // Events
        // =========================
        private void HistoryForm_Shown(object sender, EventArgs e)
        {
            ApplyRounded();
            LoadData();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            SetupDataGridStyle();
            StyleButtons();
        }

        // =========================
        // Data
        // =========================
        void LoadData()
        {
            dataGridHistory.Rows.Clear();

            if (!File.Exists("sessions.json"))
                return;

            string json = File.ReadAllText("sessions.json");

            List<SessionRecord> sessions =
                JsonSerializer.Deserialize<List<SessionRecord>>(json)
                ?? new List<SessionRecord>();

            foreach (var session in sessions)
            {
                int row = dataGridHistory.Rows.Add();

                dataGridHistory.Rows[row].Cells[0].Value = session.Date;
                dataGridHistory.Rows[row].Cells[1].Value = session.Duration;
                dataGridHistory.Rows[row].Cells[2].Value = session.BreakTime;
                dataGridHistory.Rows[row].Cells[3].Value = session.Status.ToString();
            }

            dataGridHistory.ClearSelection();
            ColorStatus();
        }

        // =========================
        // UI Style
        // =========================
        void SetupDataGridStyle()
        {
            dataGridHistory.BorderStyle = BorderStyle.None;
            dataGridHistory.BackgroundColor = panelTable.BackColor;
            dataGridHistory.EnableHeadersVisualStyles = false;

            dataGridHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 60);
            dataGridHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            dataGridHistory.DefaultCellStyle.BackColor = Color.FromArgb(25, 25, 50);
            dataGridHistory.DefaultCellStyle.ForeColor = Color.White;

            dataGridHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 60);

            dataGridHistory.DefaultCellStyle.SelectionBackColor = Color.MediumPurple;
            dataGridHistory.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridHistory.RowTemplate.Height = 35;
            dataGridHistory.GridColor = Color.FromArgb(50, 50, 80);

            dataGridHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridHistory.RowHeadersVisible = false;
        }

        void StyleButtons()
        {
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.BackColor = Color.FromArgb(40, 40, 70);
            buttonBack.ForeColor = Color.White;
            buttonBack.Region = new Region(GetRoundedPath(buttonBack.ClientRectangle, 20));

            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.BackColor = Color.MediumPurple;
            buttonClear.ForeColor = Color.White;
            buttonClear.Region = new Region(GetRoundedPath(buttonClear.ClientRectangle, 20));
        }

        // =========================
        // Status Color
        // =========================
        void ColorStatus()
        {
            foreach (DataGridViewRow row in dataGridHistory.Rows)
            {
                if (row.Cells[3].Value == null) continue;

                string status = row.Cells[3].Value.ToString();

                if (status == "Success")
                    row.Cells[3].Style.ForeColor = Color.LimeGreen;
                else if (status == "Failed")
                    row.Cells[3].Style.ForeColor = Color.Red;
            }
        }

        // =========================
        // Rounded UI
        // =========================
        void ApplyRounded()
        {
            panelTable.Region = new Region(GetRoundedPath(panelTable.ClientRectangle, 25));
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

        // =========================
        // Buttons
        // =========================
        private void buttonBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to clear all history?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                File.WriteAllText("sessions.json", "[]");
                dataGridHistory.Rows.Clear();

                MessageBox.Show("History cleared!");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to reset your progress?",
                "Reset Progress",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                previousForm.userData.Points = 0;
                previousForm.userData.Streak = 0;

                string json = JsonSerializer.Serialize(previousForm.userData);
                File.WriteAllText("userdata.json", json);

                previousForm.RefreshUI();

                MessageBox.Show("Progress reset successfully!");
            }
        }
        private void HistoryForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}