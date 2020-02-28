namespace Work_Schedule
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.SalaryButton = new System.Windows.Forms.Button();
            this.TimeButton = new System.Windows.Forms.Button();
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.home1 = new Work_Schedule.Controls.Home();
            this.scheduleControl1 = new Work_Schedule.ScheduleControl();
            this.settingControl1 = new Work_Schedule.SettingControl();
            this.salaryControl1 = new Work_Schedule.SalaryControl();
            this.timeControl1 = new Work_Schedule.TimeControl();
            this.MenuPanel.SuspendLayout();
            this.DesktopPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.SidePanel);
            this.MenuPanel.Controls.Add(this.button6);
            this.MenuPanel.Controls.Add(this.SalaryButton);
            this.MenuPanel.Controls.Add(this.TimeButton);
            this.MenuPanel.Controls.Add(this.ScheduleButton);
            this.MenuPanel.Controls.Add(this.SettingButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(150, 933);
            this.MenuPanel.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.SidePanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SidePanel.Location = new System.Drawing.Point(0, 229);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(12, 64);
            this.SidePanel.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(12, 888);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(33, 34);
            this.button6.TabIndex = 3;
            this.button6.Text = "?";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // SalaryButton
            // 
            this.SalaryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SalaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SalaryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SalaryButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SalaryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SalaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalaryButton.Font = new System.Drawing.Font("AR YanKaiB5 Ultra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SalaryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SalaryButton.Image = ((System.Drawing.Image)(resources.GetObject("SalaryButton.Image")));
            this.SalaryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalaryButton.Location = new System.Drawing.Point(12, 478);
            this.SalaryButton.Name = "SalaryButton";
            this.SalaryButton.Size = new System.Drawing.Size(138, 64);
            this.SalaryButton.TabIndex = 0;
            this.SalaryButton.Text = " 薪資";
            this.SalaryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SalaryButton.UseVisualStyleBackColor = false;
            this.SalaryButton.Click += new System.EventHandler(this.SalaryButton_Click);
            // 
            // TimeButton
            // 
            this.TimeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TimeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TimeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TimeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.TimeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeButton.Font = new System.Drawing.Font("AR YanKaiB5 Ultra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimeButton.Image = ((System.Drawing.Image)(resources.GetObject("TimeButton.Image")));
            this.TimeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimeButton.Location = new System.Drawing.Point(12, 395);
            this.TimeButton.Name = "TimeButton";
            this.TimeButton.Size = new System.Drawing.Size(138, 64);
            this.TimeButton.TabIndex = 0;
            this.TimeButton.Text = " 時間表";
            this.TimeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TimeButton.UseVisualStyleBackColor = false;
            this.TimeButton.Click += new System.EventHandler(this.TimeButton_Click);
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ScheduleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ScheduleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ScheduleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ScheduleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScheduleButton.Font = new System.Drawing.Font("AR YanKaiB5 Ultra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ScheduleButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScheduleButton.Image = ((System.Drawing.Image)(resources.GetObject("ScheduleButton.Image")));
            this.ScheduleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ScheduleButton.Location = new System.Drawing.Point(12, 312);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(138, 64);
            this.ScheduleButton.TabIndex = 0;
            this.ScheduleButton.Text = " 班表";
            this.ScheduleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ScheduleButton.UseVisualStyleBackColor = false;
            this.ScheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SettingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SettingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SettingButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.Font = new System.Drawing.Font("AR YanKaiB5 Ultra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SettingButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SettingButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingButton.Image")));
            this.SettingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingButton.Location = new System.Drawing.Point(12, 229);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(138, 64);
            this.SettingButton.TabIndex = 0;
            this.SettingButton.Text = " 勞健保設定";
            this.SettingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingButton.UseVisualStyleBackColor = false;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.DesktopPanel.Controls.Add(this.home1);
            this.DesktopPanel.Controls.Add(this.scheduleControl1);
            this.DesktopPanel.Controls.Add(this.settingControl1);
            this.DesktopPanel.Controls.Add(this.salaryControl1);
            this.DesktopPanel.Controls.Add(this.timeControl1);
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(150, 120);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(1005, 813);
            this.DesktopPanel.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("AR YanKaiB5 Ultra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(929, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 28);
            this.button4.TabIndex = 0;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("AR YanKaiB5 Ultra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(963, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 28);
            this.button5.TabIndex = 0;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 20);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(55, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 120);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR WeiBeiB5 Bold", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(219, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "排班系統";
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.TitlePanel.Controls.Add(this.label1);
            this.TitlePanel.Controls.Add(this.panel2);
            this.TitlePanel.Controls.Add(this.panel1);
            this.TitlePanel.Controls.Add(this.button5);
            this.TitlePanel.Controls.Add(this.button4);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(150, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1005, 120);
            this.TitlePanel.TabIndex = 1;
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1005, 814);
            this.home1.TabIndex = 4;
            // 
            // scheduleControl1
            // 
            this.scheduleControl1.Location = new System.Drawing.Point(0, 0);
            this.scheduleControl1.Name = "scheduleControl1";
            this.scheduleControl1.Size = new System.Drawing.Size(1005, 814);
            this.scheduleControl1.TabIndex = 3;
            // 
            // settingControl1
            // 
            this.settingControl1.Location = new System.Drawing.Point(0, 0);
            this.settingControl1.Name = "settingControl1";
            this.settingControl1.Size = new System.Drawing.Size(1005, 814);
            this.settingControl1.TabIndex = 2;
            // 
            // salaryControl1
            // 
            this.salaryControl1.Location = new System.Drawing.Point(0, -1);
            this.salaryControl1.Name = "salaryControl1";
            this.salaryControl1.Size = new System.Drawing.Size(1005, 814);
            this.salaryControl1.TabIndex = 1;
            // 
            // timeControl1
            // 
            this.timeControl1.Location = new System.Drawing.Point(0, 0);
            this.timeControl1.Name = "timeControl1";
            this.timeControl1.Size = new System.Drawing.Size(1005, 814);
            this.timeControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1155, 933);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuPanel.ResumeLayout(false);
            this.DesktopPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Panel DesktopPanel;
        private System.Windows.Forms.Button SalaryButton;
        private System.Windows.Forms.Button TimeButton;
        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TitlePanel;
        private TimeControl timeControl1;
        private SalaryControl salaryControl1;
        private ScheduleControl scheduleControl1;
        private SettingControl settingControl1;
        private Controls.Home home1;
    }
}

