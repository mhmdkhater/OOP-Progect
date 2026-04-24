namespace OOP_Progect
{
    partial class WelcomeForm
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

        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxName = new TextBox();
            labelMotivation = new Label();
            buttonStart = new Button();
            label2 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();

            // label1
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Emoji", 19.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 18);
            label1.Name = "label1";
            label1.Size = new Size(264, 46);
            label1.Text = "Focus Guardian";

            // textBoxName
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.BackColor = Color.FromArgb(30, 30, 40);
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Segoe UI", 10.2F);
            textBoxName.ForeColor = Color.White;
            textBoxName.Location = new Point(121, 122);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 30);

            // labelMotivation
            labelMotivation.Anchor = AnchorStyles.Bottom;
            labelMotivation.BackColor = Color.Transparent;
            labelMotivation.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            labelMotivation.ForeColor = Color.White;
            labelMotivation.Location = new Point(120, 380);
            labelMotivation.Name = "labelMotivation";
            labelMotivation.Size = new Size(580, 38);
            labelMotivation.Text = "...";
            labelMotivation.TextAlign = ContentAlignment.MiddleCenter;

            // buttonStart
            buttonStart.Anchor = AnchorStyles.None;
            buttonStart.BackColor = Color.FromArgb(120, 80, 225);
            buttonStart.FlatAppearance.BorderSize = 0;
            buttonStart.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 64);
            buttonStart.FlatAppearance.MouseOverBackColor = Color.Purple;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            buttonStart.ForeColor = Color.White;
            buttonStart.Location = new Point(133, 190);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 35);
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;

            // label2
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(102, 73);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.Text = "Enter Your Name :";

            // panel1
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
            panel1.Controls.Add(labelMotivation);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 459);

            // panel3
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(150, 0, 0, 0);
            panel3.Controls.Add(buttonStart);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBoxName);
            panel3.Location = new Point(212, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(363, 245);

            // panel2
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(120, 371);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 60);

            // WelcomeForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.اول_فورم;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(796, 459);
            Controls.Add(panel1);
            Name = "WelcomeForm";
            Text = "Focus Guardian";
            WindowState = FormWindowState.Maximized;
            Load += WelcomeForm_Load;

            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        private Label label1;
        private TextBox textBoxName;
        private Label labelMotivation;
        private Button buttonStart;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}