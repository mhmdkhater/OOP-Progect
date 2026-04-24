namespace OOP_Progect
{
    partial class FocusSessionForm
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
            labelFocus = new Label();
            numericFocus = new NumericUpDown();
            labelBreak = new Label();
            numericBreak = new NumericUpDown();
            labelApps = new Label();
            checkedListApps = new CheckedListBox();
            buttonAddApp = new Button();
            buttonStartSession = new Button();
            buttonCancel = new Button();
            panel2 = new Panel();
            panelMain = new Panel();
            panelShadow = new Panel();
            fadeTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericFocus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBreak).BeginInit();
            panel2.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // labelFocus
            // 
            labelFocus.AutoSize = true;
            labelFocus.BackColor = Color.Transparent;
            labelFocus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFocus.ForeColor = Color.White;
            labelFocus.Location = new Point(75, 23);
            labelFocus.Name = "labelFocus";
            labelFocus.Size = new Size(173, 20);
            labelFocus.TabIndex = 0;
            labelFocus.Text = "Focus Duration (mins) :";
            // 
            // numericFocus
            // 
            numericFocus.BackColor = Color.Navy;
            numericFocus.BorderStyle = BorderStyle.FixedSingle;
            numericFocus.ForeColor = Color.White;
            numericFocus.Location = new Point(266, 21);
            numericFocus.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            numericFocus.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericFocus.Name = "numericFocus";
            numericFocus.Size = new Size(123, 27);
            numericFocus.TabIndex = 1;
            numericFocus.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // labelBreak
            // 
            labelBreak.AutoSize = true;
            labelBreak.BackColor = Color.Transparent;
            labelBreak.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBreak.ForeColor = Color.White;
            labelBreak.Location = new Point(75, 71);
            labelBreak.Name = "labelBreak";
            labelBreak.Size = new Size(146, 20);
            labelBreak.TabIndex = 2;
            labelBreak.Text = "Break Time (mins) :";
            // 
            // numericBreak
            // 
            numericBreak.BackColor = Color.Navy;
            numericBreak.BorderStyle = BorderStyle.FixedSingle;
            numericBreak.ForeColor = Color.White;
            numericBreak.Location = new Point(266, 69);
            numericBreak.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numericBreak.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericBreak.Name = "numericBreak";
            numericBreak.Size = new Size(123, 27);
            numericBreak.TabIndex = 3;
            numericBreak.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // labelApps
            // 
            labelApps.AutoSize = true;
            labelApps.BackColor = Color.Transparent;
            labelApps.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelApps.ForeColor = Color.White;
            labelApps.Location = new Point(75, 124);
            labelApps.Name = "labelApps";
            labelApps.Size = new Size(143, 20);
            labelApps.TabIndex = 4;
            labelApps.Text = "Block Distractions :";
            // 
            // checkedListApps
            // 
            checkedListApps.BackColor = Color.Navy;
            checkedListApps.BorderStyle = BorderStyle.None;
            checkedListApps.ForeColor = Color.White;
            checkedListApps.FormattingEnabled = true;
            checkedListApps.Location = new Point(154, 156);
            checkedListApps.Name = "checkedListApps";
            checkedListApps.Size = new Size(150, 44);
            checkedListApps.TabIndex = 5;
            // 
            // buttonAddApp
            // 
            buttonAddApp.FlatAppearance.BorderSize = 0;
            buttonAddApp.FlatStyle = FlatStyle.Flat;
            buttonAddApp.ForeColor = Color.White;
            buttonAddApp.Location = new Point(215, 206);
            buttonAddApp.Name = "buttonAddApp";
            buttonAddApp.Size = new Size(122, 29);
            buttonAddApp.TabIndex = 6;
            buttonAddApp.Text = " ➕Add App";
            buttonAddApp.UseVisualStyleBackColor = true;
            buttonAddApp.Click += buttonAddApp_Click;
            // 
            // buttonStartSession
            // 
            buttonStartSession.BackColor = Color.Purple;
            buttonStartSession.FlatAppearance.BorderSize = 0;
            buttonStartSession.FlatStyle = FlatStyle.Flat;
            buttonStartSession.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStartSession.ForeColor = Color.White;
            buttonStartSession.Location = new Point(48, 270);
            buttonStartSession.Name = "buttonStartSession";
            buttonStartSession.Size = new Size(200, 45);
            buttonStartSession.TabIndex = 7;
            buttonStartSession.Text = "Start Session";
            buttonStartSession.UseVisualStyleBackColor = false;
            buttonStartSession.Click += buttonStartSession_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Gray;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(275, 270);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(200, 45);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(150, 0, 0, 0);
            panel2.Controls.Add(panelMain);
            panel2.Controls.Add(panelShadow);
            panel2.Location = new Point(-1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 448);
            panel2.TabIndex = 9;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(150, 0, 0, 0);
            panelMain.Controls.Add(buttonCancel);
            panelMain.Controls.Add(labelFocus);
            panelMain.Controls.Add(buttonStartSession);
            panelMain.Controls.Add(numericFocus);
            panelMain.Controls.Add(buttonAddApp);
            panelMain.Controls.Add(numericBreak);
            panelMain.Controls.Add(labelBreak);
            panelMain.Controls.Add(labelApps);
            panelMain.Controls.Add(checkedListApps);
            panelMain.Location = new Point(144, 42);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(500, 350);
            panelMain.TabIndex = 0;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(150, 0, 0, 0);
            panelShadow.Location = new Point(136, 33);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(514, 367);
            panelShadow.TabIndex = 9;
            // 
            // fadeTimer
            // 
            fadeTimer.Interval = 30;
            fadeTimer.Tick += fadeTimer_Tick;
            // 
            // FocusSessionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.تالت_فورم;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Name = "FocusSessionForm";
            Opacity = 0D;
            Text = "FocusSessionForm";
            Load += FocusSessionForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericFocus).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBreak).EndInit();
            panel2.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelFocus;
        private NumericUpDown numericFocus;
        private Label labelBreak;
        private NumericUpDown numericBreak;
        private Label labelApps;
        private CheckedListBox checkedListApps;
        private Button buttonAddApp;
        private Button buttonStartSession;
        private Button buttonCancel;
        private Panel panel1;
        private Panel panel2;
        private Panel panelMain;
        private Panel panelShadow;
        private System.Windows.Forms.Timer fadeTimer;
    }
}