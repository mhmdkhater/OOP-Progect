namespace OOP_Progect
{
    partial class TimerForm
    {

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelTitle = new Label();
            labelMotivation = new Label();
            labelTimer = new Label();
            label1 = new Label();
            buttonEnd = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonComplete = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(277, 43);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(296, 46);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "🎯 Focus Session";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMotivation
            // 
            labelMotivation.AutoSize = true;
            labelMotivation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMotivation.ForeColor = Color.White;
            labelMotivation.Location = new Point(249, 100);
            labelMotivation.Name = "labelMotivation";
            labelMotivation.Size = new Size(359, 28);
            labelMotivation.TabIndex = 1;
            labelMotivation.Text = "Stay focused . Great things take time .";
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTimer.ForeColor = Color.White;
            labelTimer.Location = new Point(323, 187);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(212, 89);
            labelTimer.TabIndex = 2;
            labelTimer.Text = "00:00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(373, 292);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 3;
            label1.Text = "Focus Time ";
            // 
            // buttonEnd
            // 
            buttonEnd.BackColor = Color.IndianRed;
            buttonEnd.FlatAppearance.BorderSize = 0;
            buttonEnd.FlatStyle = FlatStyle.Flat;
            buttonEnd.ForeColor = Color.White;
            buttonEnd.Location = new Point(358, 402);
            buttonEnd.Name = "buttonEnd";
            buttonEnd.Size = new Size(134, 29);
            buttonEnd.TabIndex = 4;
            buttonEnd.Text = "⏹️End Session";
            buttonEnd.UseVisualStyleBackColor = false;
            buttonEnd.Click += buttonEnd_Click_1;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // buttonComplete
            // 
            buttonComplete.BackColor = Color.MediumSeaGreen;
            buttonComplete.FlatAppearance.BorderSize = 0;
            buttonComplete.FlatStyle = FlatStyle.Flat;
            buttonComplete.ForeColor = Color.White;
            buttonComplete.Location = new Point(358, 402);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(134, 29);
            buttonComplete.TabIndex = 5;
            buttonComplete.Text = "✅ Complete";
            buttonComplete.UseVisualStyleBackColor = false;
            buttonComplete.Visible = false;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // TimerForm
            // 
            BackColor = Color.FromArgb(20, 20, 40);
            BackgroundImage = Properties.Resources.خامس_فورم;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(867, 516);
            Controls.Add(buttonComplete);
            Controls.Add(buttonEnd);
            Controls.Add(label1);
            Controls.Add(labelTimer);
            Controls.Add(labelMotivation);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TimerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Timer Form";
            ResumeLayout(false);
            PerformLayout();




        }

        #endregion

        private Label labelTitle;
        private Label labelMotivation;
        private Label labelTimer;
        private Label label1;
        private Button buttonEnd;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components;
        private Button buttonComplete;
    }
}