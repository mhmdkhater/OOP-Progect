namespace OOP_Progect
{
    partial class TimerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            labelTitle = new Label();
            labelMotivation = new Label();
            labelTimer = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonComplete = new Button();
            label2 = new Label();
            listBoxApps = new ListBox();
            panel1 = new Panel();
            buttonEnd = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(126, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(296, 46);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "🎯 Focus Session";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMotivation
            // 
            labelMotivation.AutoSize = true;
            labelMotivation.BackColor = Color.Transparent;
            labelMotivation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMotivation.ForeColor = Color.White;
            labelMotivation.Location = new Point(126, 66);
            labelMotivation.Name = "labelMotivation";
            labelMotivation.Size = new Size(347, 28);
            labelMotivation.TabIndex = 1;
            labelMotivation.Text = "Stay focused. Great things take time.";
            labelMotivation.Click += labelMotivation_Click;
            // 
            // labelTimer
            // 
            labelTimer.Anchor = AnchorStyles.None;
            labelTimer.AutoSize = true;
            labelTimer.BackColor = Color.Transparent;
            labelTimer.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTimer.ForeColor = Color.White;
            labelTimer.Location = new Point(166, 148);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(212, 89);
            labelTimer.TabIndex = 1;
            labelTimer.Text = "00:00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(220, 261);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 3;
            label1.Text = "Focus Time";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // buttonComplete
            // 
            buttonComplete.Anchor = AnchorStyles.None;
            buttonComplete.BackColor = Color.MediumSeaGreen;
            buttonComplete.FlatAppearance.BorderSize = 0;
            buttonComplete.FlatStyle = FlatStyle.Flat;
            buttonComplete.ForeColor = Color.White;
            buttonComplete.Location = new Point(220, 380);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(134, 29);
            buttonComplete.TabIndex = 1;
            buttonComplete.Text = "✅ Complete";
            buttonComplete.UseVisualStyleBackColor = false;
            buttonComplete.Visible = false;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(417, 112);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 7;
            label2.Text = "Selected Apps";
            // 
            // listBoxApps
            // 
            listBoxApps.BackColor = SystemColors.MenuHighlight;
            listBoxApps.BorderStyle = BorderStyle.None;
            listBoxApps.ForeColor = Color.White;
            listBoxApps.FormattingEnabled = true;
            listBoxApps.Location = new Point(504, 148);
            listBoxApps.Name = "listBoxApps";
            listBoxApps.Size = new Size(115, 160);
            listBoxApps.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
            panel1.Controls.Add(buttonEnd);
            panel1.Controls.Add(buttonComplete);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(listBoxApps);
            panel1.Controls.Add(labelTimer);
            panel1.Controls.Add(labelMotivation);
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(133, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 461);
            panel1.TabIndex = 1;
            // 
            // buttonEnd
            // 
            buttonEnd.BackColor = Color.FromArgb(192, 0, 0);
            buttonEnd.FlatStyle = FlatStyle.Flat;
            buttonEnd.ForeColor = Color.White;
            buttonEnd.Location = new Point(220, 380);
            buttonEnd.Name = "buttonEnd";
            buttonEnd.Size = new Size(134, 29);
            buttonEnd.TabIndex = 9;
            buttonEnd.Text = "End Session";
            buttonEnd.UseVisualStyleBackColor = false;
            buttonEnd.Click += buttonEnd_Click_1;
            // 
            // TimerForm
            // 
            BackColor = Color.FromArgb(20, 20, 40);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(867, 516);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TimerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Timer Form";
            WindowState = FormWindowState.Maximized;
            Deactivate += TimerForm_Deactivate;
            Load += TimerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Label labelMotivation;
        private Label labelTimer;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button buttonComplete;
        private Label label2;
        private ListBox listBoxApps;
        private Panel panel1;
        private Button buttonEnd;
    }
}