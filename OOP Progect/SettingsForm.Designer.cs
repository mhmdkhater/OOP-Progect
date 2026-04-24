namespace OOP_Progect
{
    partial class SettingsForm
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
            labelTitle = new Label();
            label6 = new Label();
            panelAppearance = new Panel();
            checkSilentMode = new CheckBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            checkSound = new CheckBox();
            panelSession = new Panel();
            label7 = new Label();
            label1 = new Label();
            numericDefaultFocus = new NumericUpDown();
            label2 = new Label();
            numericDefaultBreak = new NumericUpDown();
            buttonBack = new Button();
            panelAppearance.SuspendLayout();
            panelSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericDefaultFocus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDefaultBreak).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(234, 18);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(192, 41);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "⚙️ Settings ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(248, 68);
            label6.Name = "label6";
            label6.Size = new Size(201, 20);
            label6.TabIndex = 13;
            label6.Text = "Customize your experience.";
            // 
            // panelAppearance
            // 
            panelAppearance.BackColor = Color.FromArgb(150, 0, 0, 0);
            panelAppearance.Controls.Add(checkSilentMode);
            panelAppearance.Controls.Add(label3);
            panelAppearance.Controls.Add(label5);
            panelAppearance.Controls.Add(label4);
            panelAppearance.Controls.Add(checkSound);
            panelAppearance.ForeColor = Color.FromArgb(150, 0, 0, 0);
            panelAppearance.Location = new Point(106, 100);
            panelAppearance.Name = "panelAppearance";
            panelAppearance.Size = new Size(514, 142);
            panelAppearance.TabIndex = 12;
            // 
            // checkSilentMode
            // 
            checkSilentMode.BackColor = Color.Transparent;
            checkSilentMode.Location = new Point(239, 53);
            checkSilentMode.Name = "checkSilentMode";
            checkSilentMode.Size = new Size(20, 20);
            checkSilentMode.TabIndex = 13;
            checkSilentMode.UseVisualStyleBackColor = false;
            checkSilentMode.CheckedChanged += checkSilentMode_CheckedChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 53);
            label3.Name = "label3";
            label3.Size = new Size(200, 20);
            label3.TabIndex = 12;
            label3.Text = "Silent Mode (No Popups) 🔕";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(150, 0, 0, 0);
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(18, 11);
            label5.Name = "label5";
            label5.Size = new Size(124, 28);
            label5.TabIndex = 11;
            label5.Text = "Appearance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(150, 0, 0, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(46, 92);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 10;
            label4.Text = "Enable Sound Effects 🔊";
            // 
            // checkSound
            // 
            checkSound.BackColor = Color.Transparent;
            checkSound.ForeColor = Color.White;
            checkSound.Location = new Point(239, 92);
            checkSound.Name = "checkSound";
            checkSound.Size = new Size(14, 13);
            checkSound.TabIndex = 2;
            checkSound.UseVisualStyleBackColor = false;
            checkSound.CheckedChanged += checkSound_CheckedChanged;
            // 
            // panelSession
            // 
            panelSession.BackColor = Color.FromArgb(150, 0, 0, 0);
            panelSession.Controls.Add(label7);
            panelSession.Controls.Add(label1);
            panelSession.Controls.Add(numericDefaultFocus);
            panelSession.Controls.Add(label2);
            panelSession.Controls.Add(numericDefaultBreak);
            panelSession.ForeColor = Color.FromArgb(150, 0, 0, 0);
            panelSession.Location = new Point(106, 259);
            panelSession.Name = "panelSession";
            panelSession.Size = new Size(514, 125);
            panelSession.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(150, 0, 0, 0);
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(18, 12);
            label7.Name = "label7";
            label7.Size = new Size(168, 28);
            label7.TabIndex = 0;
            label7.Text = "Session Defaults";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(150, 0, 0, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 49);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 4;
            label1.Text = "Default Focus Time (mins) :";
            // 
            // numericDefaultFocus
            // 
            numericDefaultFocus.BackColor = Color.FromArgb(40, 40, 70);
            numericDefaultFocus.ForeColor = Color.White;
            numericDefaultFocus.Location = new Point(290, 49);
            numericDefaultFocus.Name = "numericDefaultFocus";
            numericDefaultFocus.Size = new Size(69, 27);
            numericDefaultFocus.TabIndex = 3;
            numericDefaultFocus.Value = new decimal(new int[] { 60, 0, 0, 0 });
            numericDefaultFocus.ValueChanged += numericDefaultFocus_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(150, 0, 0, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(46, 80);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 6;
            label2.Text = "Default Break Time (mins) :";
            // 
            // numericDefaultBreak
            // 
            numericDefaultBreak.BackColor = Color.FromArgb(40, 40, 70);
            numericDefaultBreak.ForeColor = Color.White;
            numericDefaultBreak.Location = new Point(290, 82);
            numericDefaultBreak.Name = "numericDefaultBreak";
            numericDefaultBreak.Size = new Size(69, 27);
            numericDefaultBreak.TabIndex = 5;
            numericDefaultBreak.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericDefaultBreak.ValueChanged += numericDefaultBreak_ValueChanged;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Navy;
            buttonBack.ForeColor = Color.FromArgb(192, 192, 255);
            buttonBack.Location = new Point(646, 363);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(120, 40);
            buttonBack.TabIndex = 15;
            buttonBack.Text = "🔙 Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click_1;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.رابع_فورم;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(label6);
            Controls.Add(panelSession);
            Controls.Add(labelTitle);
            Controls.Add(panelAppearance);
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            panelAppearance.ResumeLayout(false);
            panelAppearance.PerformLayout();
            panelSession.ResumeLayout(false);
            panelSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericDefaultFocus).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDefaultBreak).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label label6;
        private Panel panelAppearance;
        private Label label5;
        private Label label4;
        private CheckBox checkSound;
        private Panel panelSession;
        private Label label7;
        private Label label1;
        private NumericUpDown numericDefaultFocus;
        private Label label2;
        private NumericUpDown numericDefaultBreak;
        private Button buttonBack;
        private Label label3;
        private CheckBox checkSilentMode;
    }
}