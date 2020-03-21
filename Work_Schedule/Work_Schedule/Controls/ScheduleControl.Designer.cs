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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.DownSchedule = new System.Windows.Forms.DataGridView();
            this.DownName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownTitle = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.day16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveButton = new System.Windows.Forms.Button();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.UpSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(2, 475);
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
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 145);
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
            this.UpSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UpSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UpSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            this.UpSchedule.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.UpSchedule.Location = new System.Drawing.Point(38, 75);
            this.UpSchedule.Name = "UpSchedule";
            this.UpSchedule.RowHeadersVisible = false;
            this.UpSchedule.RowTemplate.Height = 24;
            this.UpSchedule.ShowCellToolTips = false;
            this.UpSchedule.Size = new System.Drawing.Size(967, 310);
            this.UpSchedule.TabIndex = 1289;
            // 
            // UpName
            // 
            this.UpName.HeaderText = "姓名";
            this.UpName.Name = "UpName";
            this.UpName.Width = 65;
            // 
            // UpTitle
            // 
            this.UpTitle.HeaderText = "職稱";
            this.UpTitle.Items.AddRange(new object[] {
            "",
            "工時",
            "正職",
            "實習組長",
            "組長",
            "儲備幹部",
            "儲備店長",
            "副店長",
            "店長"});
            this.UpTitle.Name = "UpTitle";
            this.UpTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UpTitle.Width = 75;
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
            this.CheckButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CheckButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.CheckButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
            this.CheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckButton.Font = new System.Drawing.Font("DFKai-SB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CheckButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckButton.Image = ((System.Drawing.Image)(resources.GetObject("CheckButton.Image")));
            this.CheckButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckButton.Location = new System.Drawing.Point(810, 8);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(130, 46);
            this.CheckButton.TabIndex = 1290;
            this.CheckButton.Text = "勞健保檢查";
            this.CheckButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DownSchedule
            // 
            this.DownSchedule.AllowUserToAddRows = false;
            this.DownSchedule.AllowUserToDeleteRows = false;
            this.DownSchedule.AllowUserToResizeColumns = false;
            this.DownSchedule.AllowUserToResizeRows = false;
            this.DownSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DownSchedule.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DownSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DownSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DownSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DownName,
            this.DownTitle,
            this.day16,
            this.day17,
            this.day18,
            this.day19,
            this.day20,
            this.day21,
            this.day22,
            this.day23,
            this.day24,
            this.day25,
            this.day26,
            this.day27,
            this.day28,
            this.day29,
            this.day30,
            this.day31});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DownSchedule.DefaultCellStyle = dataGridViewCellStyle4;
            this.DownSchedule.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DownSchedule.Location = new System.Drawing.Point(35, 411);
            this.DownSchedule.Name = "DownSchedule";
            this.DownSchedule.RowHeadersVisible = false;
            this.DownSchedule.RowTemplate.Height = 24;
            this.DownSchedule.ShowCellToolTips = false;
            this.DownSchedule.Size = new System.Drawing.Size(1024, 310);
            this.DownSchedule.TabIndex = 1289;
            // 
            // DownName
            // 
            this.DownName.HeaderText = "姓名";
            this.DownName.Name = "DownName";
            this.DownName.Width = 66;
            // 
            // DownTitle
            // 
            this.DownTitle.HeaderText = "職稱";
            this.DownTitle.Items.AddRange(new object[] {
            "",
            "工時",
            "正職",
            "實習組長",
            "組長",
            "儲備幹部",
            "儲備店長",
            "副店長",
            "店長"});
            this.DownTitle.Name = "DownTitle";
            this.DownTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DownTitle.Width = 75;
            // 
            // day16
            // 
            this.day16.HeaderText = "16";
            this.day16.Name = "day16";
            this.day16.Width = 55;
            // 
            // day17
            // 
            this.day17.HeaderText = "17";
            this.day17.Name = "day17";
            this.day17.Width = 55;
            // 
            // day18
            // 
            this.day18.HeaderText = "18";
            this.day18.Name = "day18";
            this.day18.Width = 55;
            // 
            // day19
            // 
            this.day19.HeaderText = "19";
            this.day19.Name = "day19";
            this.day19.Width = 55;
            // 
            // day20
            // 
            this.day20.HeaderText = "20";
            this.day20.Name = "day20";
            this.day20.Width = 55;
            // 
            // day21
            // 
            this.day21.HeaderText = "21";
            this.day21.Name = "day21";
            this.day21.Width = 55;
            // 
            // day22
            // 
            this.day22.HeaderText = "22";
            this.day22.Name = "day22";
            this.day22.Width = 55;
            // 
            // day23
            // 
            this.day23.HeaderText = "23";
            this.day23.Name = "day23";
            this.day23.Width = 55;
            // 
            // day24
            // 
            this.day24.HeaderText = "24";
            this.day24.Name = "day24";
            this.day24.Width = 55;
            // 
            // day25
            // 
            this.day25.HeaderText = "25";
            this.day25.Name = "day25";
            this.day25.Width = 55;
            // 
            // day26
            // 
            this.day26.HeaderText = "26";
            this.day26.Name = "day26";
            this.day26.Width = 55;
            // 
            // day27
            // 
            this.day27.HeaderText = "27";
            this.day27.Name = "day27";
            this.day27.Width = 55;
            // 
            // day28
            // 
            this.day28.HeaderText = "28";
            this.day28.Name = "day28";
            this.day28.Width = 55;
            // 
            // day29
            // 
            this.day29.HeaderText = "29";
            this.day29.Name = "day29";
            this.day29.Width = 55;
            // 
            // day30
            // 
            this.day30.HeaderText = "30";
            this.day30.Name = "day30";
            this.day30.Width = 55;
            // 
            // day31
            // 
            this.day31.HeaderText = "31";
            this.day31.Name = "day31";
            this.day31.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.day31.Width = 55;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("DFKai-SB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Location = new System.Drawing.Point(955, 8);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(92, 46);
            this.SaveButton.TabIndex = 1290;
            this.SaveButton.Text = " 儲存";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // YearComboBox
            // 
            this.YearComboBox.Font = new System.Drawing.Font("DFKai-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YearComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Items.AddRange(new object[] {
            " 2020年  ",
            " 2021年",
            " 2022年"});
            this.YearComboBox.Location = new System.Drawing.Point(104, 25);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(80, 24);
            this.YearComboBox.TabIndex = 1291;
            this.YearComboBox.SelectedIndexChanged += new System.EventHandler(this.YearComboBox_SelectedIndexChanged);
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.Font = new System.Drawing.Font("DFKai-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MonthComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
            " 1月",
            " 2月",
            " 3月",
            " 4月",
            " 5月",
            " 6月",
            " 7月",
            " 8月",
            " 9月",
            " 10月",
            " 11月",
            " 12月"});
            this.MonthComboBox.Location = new System.Drawing.Point(199, 25);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(62, 24);
            this.MonthComboBox.TabIndex = 1291;
            this.MonthComboBox.SelectedIndexChanged += new System.EventHandler(this.MonthComboBox_SelectedIndexChanged);
            // 
            // ScheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.DownSchedule);
            this.Controls.Add(this.UpSchedule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleControl";
            this.Size = new System.Drawing.Size(1059, 814);
            this.Load += new System.EventHandler(this.ScheduleControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CheckButton;
        public System.Windows.Forms.DataGridView UpSchedule;
        public System.Windows.Forms.DataGridView DownSchedule;
        private System.Windows.Forms.Button SaveButton;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn DownName;
        private System.Windows.Forms.DataGridViewComboBoxColumn DownTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn day16;
        private System.Windows.Forms.DataGridViewTextBoxColumn day17;
        private System.Windows.Forms.DataGridViewTextBoxColumn day18;
        private System.Windows.Forms.DataGridViewTextBoxColumn day19;
        private System.Windows.Forms.DataGridViewTextBoxColumn day20;
        private System.Windows.Forms.DataGridViewTextBoxColumn day21;
        private System.Windows.Forms.DataGridViewTextBoxColumn day22;
        private System.Windows.Forms.DataGridViewTextBoxColumn day23;
        private System.Windows.Forms.DataGridViewTextBoxColumn day24;
        private System.Windows.Forms.DataGridViewTextBoxColumn day25;
        private System.Windows.Forms.DataGridViewTextBoxColumn day26;
        private System.Windows.Forms.DataGridViewTextBoxColumn day27;
        private System.Windows.Forms.DataGridViewTextBoxColumn day28;
        private System.Windows.Forms.DataGridViewTextBoxColumn day29;
        private System.Windows.Forms.DataGridViewTextBoxColumn day30;
        private System.Windows.Forms.DataGridViewTextBoxColumn day31;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
