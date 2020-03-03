namespace Work_Schedule
{
    partial class ScheduleControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpSchedule = new System.Windows.Forms.DataGridView();
            this.UpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpTitle = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.day1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UpSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 22);
            this.dateTimePicker1.TabIndex = 1288;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(5, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 174);
            this.label2.TabIndex = 1287;
            this.label2.Text = "下\r\n半\r\n月\r\n排\r\n班\r\n表";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(5, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 174);
            this.label1.TabIndex = 1286;
            this.label1.Text = "上\r\n半\r\n月\r\n排\r\n班\r\n表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpSchedule
            // 
            this.UpSchedule.AllowUserToAddRows = false;
            this.UpSchedule.AllowUserToDeleteRows = false;
            this.UpSchedule.AllowUserToResizeColumns = false;
            this.UpSchedule.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UpSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UpSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UpName,
            this.UpTitle,
            this.day1,
            this.day2,
            this.day3,
            this.day4,
            this.day5,
            this.day6,
            this.day7,
            this.day8,
            this.day9,
            this.day10,
            this.day11,
            this.day12,
            this.day13,
            this.day14,
            this.day15});
            this.UpSchedule.Location = new System.Drawing.Point(36, 63);
            this.UpSchedule.Name = "UpSchedule";
            this.UpSchedule.RowHeadersVisible = false;
            this.UpSchedule.RowTemplate.Height = 24;
            this.UpSchedule.ShowCellToolTips = false;
            this.UpSchedule.Size = new System.Drawing.Size(966, 328);
            this.UpSchedule.TabIndex = 1289;
            this.UpSchedule.Rows.Add(12);
            // 
            // UpName
            // 
            this.UpName.HeaderText = "姓名";
            this.UpName.Name = "UpName";
            this.UpName.Width = 70;
            // 
            // UpTitle
            // 
            this.UpTitle.HeaderText = "職稱";
            this.UpTitle.Name = "UpTitle";
            this.UpTitle.Width = 70;
            // 
            // day1
            // 
            this.day1.HeaderText = "1";
            this.day1.Name = "day1";
            this.day1.Width = 55;
            // 
            // day2
            // 
            this.day2.HeaderText = "2";
            this.day2.Name = "day2";
            this.day2.Width = 55;
            // 
            // day3
            // 
            this.day3.HeaderText = "3";
            this.day3.Name = "day3";
            this.day3.Width = 55;
            // 
            // day4
            // 
            this.day4.HeaderText = "4";
            this.day4.Name = "day4";
            this.day4.Width = 55;
            // 
            // day5
            // 
            this.day5.HeaderText = "5";
            this.day5.Name = "day5";
            this.day5.Width = 55;
            // 
            // day6
            // 
            this.day6.HeaderText = "6";
            this.day6.Name = "day6";
            this.day6.Width = 55;
            // 
            // day7
            // 
            this.day7.HeaderText = "7";
            this.day7.Name = "day7";
            this.day7.Width = 55;
            // 
            // day8
            // 
            this.day8.HeaderText = "8";
            this.day8.Name = "day8";
            this.day8.Width = 55;
            // 
            // day9
            // 
            this.day9.HeaderText = "9";
            this.day9.Name = "day9";
            this.day9.Width = 55;
            // 
            // day10
            // 
            this.day10.HeaderText = "10";
            this.day10.Name = "day10";
            this.day10.Width = 55;
            // 
            // day11
            // 
            this.day11.HeaderText = "11";
            this.day11.Name = "day11";
            this.day11.Width = 55;
            // 
            // day12
            // 
            this.day12.HeaderText = "12";
            this.day12.Name = "day12";
            this.day12.Width = 55;
            // 
            // day13
            // 
            this.day13.HeaderText = "13";
            this.day13.Name = "day13";
            this.day13.Width = 55;
            // 
            // day14
            // 
            this.day14.HeaderText = "14";
            this.day14.Name = "day14";
            this.day14.Width = 55;
            // 
            // day15
            // 
            this.day15.HeaderText = "15";
            this.day15.Name = "day15";
            this.day15.Width = 55;
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CheckButton.Location = new System.Drawing.Point(728, 416);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(96, 46);
            this.CheckButton.TabIndex = 1290;
            this.CheckButton.Text = "勞健保檢查";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.UpSchedule);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleControl";
            this.Size = new System.Drawing.Size(1005, 814);
            ((System.ComponentModel.ISupportInitialize)(this.UpSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView UpSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpName;
        private System.Windows.Forms.DataGridViewComboBoxColumn UpTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn day1;
        private System.Windows.Forms.DataGridViewTextBoxColumn day2;
        private System.Windows.Forms.DataGridViewTextBoxColumn day3;
        private System.Windows.Forms.DataGridViewTextBoxColumn day4;
        private System.Windows.Forms.DataGridViewTextBoxColumn day5;
        private System.Windows.Forms.DataGridViewTextBoxColumn day6;
        private System.Windows.Forms.DataGridViewTextBoxColumn day7;
        private System.Windows.Forms.DataGridViewTextBoxColumn day8;
        private System.Windows.Forms.DataGridViewTextBoxColumn day9;
        private System.Windows.Forms.DataGridViewTextBoxColumn day10;
        private System.Windows.Forms.DataGridViewTextBoxColumn day11;
        private System.Windows.Forms.DataGridViewTextBoxColumn day12;
        private System.Windows.Forms.DataGridViewTextBoxColumn day13;
        private System.Windows.Forms.DataGridViewTextBoxColumn day14;
        private System.Windows.Forms.DataGridViewTextBoxColumn day15;
        private System.Windows.Forms.Button CheckButton;
    }
}
