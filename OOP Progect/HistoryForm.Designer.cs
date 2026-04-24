namespace OOP_Progect
{
    partial class HistoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            labelTitle = new Label();
            dataGridHistory = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Duration = new DataGridViewTextBoxColumn();
            BreakTime = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            buttonBack = new Button();
            label1 = new Label();
            label2 = new Label();
            buttonClear = new Button();
            panelTable = new Panel();
            buttonReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridHistory).BeginInit();
            panelTable.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(88, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(284, 46);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "  Session History";
            // 
            // dataGridHistory
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 30, 60);
            dataGridHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridHistory.BackgroundColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 30, 60);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridHistory.ColumnHeadersHeight = 45;
            dataGridHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridHistory.Columns.AddRange(new DataGridViewColumn[] { Date, Duration, BreakTime, Status });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(25, 25, 50);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridHistory.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridHistory.EnableHeadersVisualStyles = false;
            dataGridHistory.Location = new Point(12, 15);
            dataGridHistory.Name = "dataGridHistory";
            dataGridHistory.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(25, 25, 50);
            dataGridHistory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridHistory.Size = new Size(693, 207);
            dataGridHistory.TabIndex = 1;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            // 
            // Duration
            // 
            Duration.HeaderText = "Duration";
            Duration.MinimumWidth = 6;
            Duration.Name = "Duration";
            // 
            // BreakTime
            // 
            BreakTime.HeaderText = "Break";
            BreakTime.MinimumWidth = 6;
            BreakTime.Name = "BreakTime";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(30, 30, 60);
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(53, 382);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(120, 40);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "🔙 Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(137, 55);
            label1.Name = "label1";
            label1.Size = new Size(249, 23);
            label1.TabIndex = 3;
            label1.Text = "Track your progress over time . ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(41, 9);
            label2.Name = "label2";
            label2.Size = new Size(68, 46);
            label2.TabIndex = 4;
            label2.Text = "🕚";
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.MediumPurple;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(607, 382);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(139, 40);
            buttonClear.TabIndex = 5;
            buttonClear.Text = "🗑️  Clear History";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // panelTable
            // 
            panelTable.BackColor = Color.FromArgb(30, 30, 60);
            panelTable.Controls.Add(dataGridHistory);
            panelTable.Location = new Point(41, 96);
            panelTable.Name = "panelTable";
            panelTable.Size = new Size(715, 237);
            panelTable.TabIndex = 6;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.FromArgb(0, 0, 192);
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.ForeColor = Color.White;
            buttonReset.Location = new Point(309, 382);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(164, 40);
            buttonReset.TabIndex = 7;
            buttonReset.Text = "♻️  Reset Progress";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.خامس_فورم_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonReset);
            Controls.Add(panelTable);
            Controls.Add(buttonClear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonBack);
            Controls.Add(labelTitle);
            Name = "HistoryForm";
            Text = "HistoryForm";
            Load += HistoryForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridHistory).EndInit();
            panelTable.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private DataGridView dataGridHistory;
        private Button buttonBack;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button buttonClear;
        private Panel panelTable;
        private Button buttonReset;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Duration;
        private DataGridViewTextBoxColumn BreakTime;
        private DataGridViewTextBoxColumn Status;
    }
}