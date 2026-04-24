namespace OOP_Progect
{
    partial class SessionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelwelcome = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panelSidebar = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            label9 = new Label();
            buttonSettings = new Button();
            buttonStart = new Button();
            label8 = new Label();
            panelStreak = new Panel();
            label5 = new Label();
            labelStraek = new Label();
            label7 = new Label();
            panelPoints = new Panel();
            label4 = new Label();
            labelPoints = new Label();
            label1 = new Label();
            button1 = new Button();
            timerSidebar = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelStreak.SuspendLayout();
            panelPoints.SuspendLayout();
            SuspendLayout();
            // 
            // labelwelcome
            // 
            labelwelcome.AutoSize = true;
            labelwelcome.BackColor = Color.Transparent;
            labelwelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelwelcome.ForeColor = Color.White;
            labelwelcome.Location = new Point(208, 11);
            labelwelcome.Name = "labelwelcome";
            labelwelcome.Size = new Size(230, 82);
            labelwelcome.TabIndex = 0;
            labelwelcome.Text = "Welcome back,\r\n User 👋";
           
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(208, 103);
            label3.Name = "label3";
            label3.Size = new Size(242, 23);
            label3.TabIndex = 6;
            label3.Text = "\"Stay focused, Stay sharp 💪\"";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
            panel1.Controls.Add(panelSidebar);
            panel1.Controls.Add(buttonSettings);
            panel1.Controls.Add(buttonStart);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panelStreak);
            panel1.Controls.Add(panelPoints);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(labelwelcome);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 452);
            panel1.TabIndex = 8;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Navy;
            panelSidebar.Controls.Add(button8);
            panelSidebar.Controls.Add(button7);
            panelSidebar.Controls.Add(button6);
            panelSidebar.Controls.Add(button5);
            panelSidebar.Controls.Add(button4);
            panelSidebar.Controls.Add(label9);
            panelSidebar.Location = new Point(13, 71);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(0, 500);
            panelSidebar.TabIndex = 12;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = SystemColors.ButtonFace;
            button8.Location = new Point(36, 165);
            button8.Name = "button8";
            button8.Size = new Size(116, 40);
            button8.TabIndex = 5;
            button8.Text = "🗓️ History";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.Firebrick;
            button7.Location = new Point(36, 278);
            button7.Name = "button7";
            button7.Size = new Size(116, 40);
            button7.TabIndex = 4;
            button7.Text = "➜] Logout";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(36, 221);
            button6.Name = "button6";
            button6.Size = new Size(116, 40);
            button6.TabIndex = 3;
            button6.Text = "⚙️ Settings";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(36, 119);
            button5.Name = "button5";
            button5.Size = new Size(129, 40);
            button5.TabIndex = 2;
            button5.Text = "▶️ Start Session";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(36, 73);
            button4.Name = "button4";
            button4.Size = new Size(116, 40);
            button4.TabIndex = 1;
            button4.Text = "𓃑 Dashboard";
            button4.UseVisualStyleBackColor = false;
            
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 0, 64);
            label9.Location = new Point(13, 0);
            label9.Name = "label9";
            label9.Size = new Size(163, 56);
            label9.TabIndex = 0;
            label9.Text = "           🕚\r\n Focus Guardian";
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.FromArgb(0, 0, 192);
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSettings.ForeColor = SystemColors.ButtonHighlight;
            buttonSettings.Location = new Point(271, 380);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(201, 40);
            buttonSettings.TabIndex = 11;
            buttonSettings.Text = " ⚙️ Settings";
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += button3_Click;
            buttonSettings.MouseEnter += buttonSettings_MouseEnter;
            buttonSettings.MouseLeave += buttonSettings_MouseLeave;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(0, 0, 192);
            buttonStart.FlatAppearance.BorderSize = 0;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStart.ForeColor = Color.White;
            buttonStart.Location = new Point(271, 307);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(201, 50);
            buttonStart.TabIndex = 10;
            buttonStart.Text = " ▶️ Start New Session";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += button2_Click;
            buttonStart.MouseEnter += button2_MouseEnter;
            buttonStart.MouseLeave += button2_MouseLeave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(238, 255);
            label8.Name = "label8";
            label8.Size = new Size(143, 28);
            label8.TabIndex = 9;
            label8.Text = "Quick Actions";
            // 
            // panelStreak
            // 
            panelStreak.BackColor = Color.FromArgb(0, 0, 64);
            panelStreak.Controls.Add(label5);
            panelStreak.Controls.Add(labelStraek);
            panelStreak.Controls.Add(label7);
            panelStreak.Location = new Point(475, 141);
            panelStreak.Name = "panelStreak";
            panelStreak.Size = new Size(200, 100);
            panelStreak.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(128, 30);
            label5.Name = "label5";
            label5.Size = new Size(60, 41);
            label5.TabIndex = 2;
            label5.Text = "🔥";
            // 
            // labelStraek
            // 
            labelStraek.AutoSize = true;
            labelStraek.BackColor = Color.Transparent;
            labelStraek.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStraek.ForeColor = Color.White;
            labelStraek.Location = new Point(43, 42);
            labelStraek.Name = "labelStraek";
            labelStraek.Size = new Size(35, 41);
            labelStraek.TabIndex = 1;
            labelStraek.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(33, 12);
            label7.Name = "label7";
            label7.Size = new Size(56, 23);
            label7.TabIndex = 0;
            label7.Text = "Streak";
            // 
            // panelPoints
            // 
            panelPoints.BackColor = Color.FromArgb(0, 0, 64);
            panelPoints.Controls.Add(label4);
            panelPoints.Controls.Add(labelPoints);
            panelPoints.Controls.Add(label1);
            panelPoints.Location = new Point(238, 141);
            panelPoints.Name = "panelPoints";
            panelPoints.Size = new Size(200, 100);
            panelPoints.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(128, 30);
            label4.Name = "label4";
            label4.Size = new Size(60, 41);
            label4.TabIndex = 2;
            label4.Text = "🏆";
            // 
            // labelPoints
            // 
            labelPoints.AutoSize = true;
            labelPoints.BackColor = Color.Transparent;
            labelPoints.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPoints.ForeColor = Color.White;
            labelPoints.Location = new Point(43, 42);
            labelPoints.Name = "labelPoints";
            labelPoints.Size = new Size(35, 41);
            labelPoints.TabIndex = 1;
            labelPoints.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 12);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 0;
            label1.Text = "Points";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(103, 14);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 1;
            button1.Text = "☰";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timerSidebar
            // 
            timerSidebar.Interval = 10;
            timerSidebar.Tick += timerSidebar_Tick;
            // 
            // SessionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.تاني_فورم;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "SessionForm";
            Text = "SessionForm";
            Load += SessionForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelStreak.ResumeLayout(false);
            panelStreak.PerformLayout();
            panelPoints.ResumeLayout(false);
            panelPoints.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelwelcome;
        private Label label3;
        private Panel panel1;
        private Button button1;
        private Panel panelPoints;
        private Label label4;
        private Label labelPoints;
        private Label label1;
        private Panel panelStreak;
        private Label label5;
        private Label labelStraek;
        private Label label7;
        private Button buttonStart;
        private Label label8;
        private Button buttonSettings;
        private Panel panelSidebar;
        private Label label9;
        private Button button4;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private System.Windows.Forms.Timer timerSidebar;
    }
}