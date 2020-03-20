namespace Work_Schedule
{
    partial class SettingControl
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
            this.weekly7CheckBox = new System.Windows.Forms.CheckBox();
            this.weekly48CheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.daily10CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // weekly7CheckBox
            // 
            this.weekly7CheckBox.AutoSize = true;
            this.weekly7CheckBox.Checked = true;
            this.weekly7CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.weekly7CheckBox.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weekly7CheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.weekly7CheckBox.Location = new System.Drawing.Point(344, 421);
            this.weekly7CheckBox.Name = "weekly7CheckBox";
            this.weekly7CheckBox.Size = new System.Drawing.Size(233, 28);
            this.weekly7CheckBox.TabIndex = 10;
            this.weekly7CheckBox.Text = " 不得連續上班七天";
            this.weekly7CheckBox.UseVisualStyleBackColor = true;
            // 
            // weekly48CheckBox
            // 
            this.weekly48CheckBox.AutoSize = true;
            this.weekly48CheckBox.Checked = true;
            this.weekly48CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.weekly48CheckBox.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weekly48CheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.weekly48CheckBox.Location = new System.Drawing.Point(344, 360);
            this.weekly48CheckBox.Name = "weekly48CheckBox";
            this.weekly48CheckBox.Size = new System.Drawing.Size(365, 28);
            this.weekly48CheckBox.TabIndex = 11;
            this.weekly48CheckBox.Text = " 一周(一~日)不得超過 48 小時";
            this.weekly48CheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(296, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "請勾選勞基法檢查規則";
            // 
            // daily10CheckBox
            // 
            this.daily10CheckBox.AutoSize = true;
            this.daily10CheckBox.Checked = true;
            this.daily10CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.daily10CheckBox.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.daily10CheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.daily10CheckBox.Location = new System.Drawing.Point(344, 301);
            this.daily10CheckBox.Name = "daily10CheckBox";
            this.daily10CheckBox.Size = new System.Drawing.Size(281, 28);
            this.daily10CheckBox.TabIndex = 11;
            this.daily10CheckBox.Text = " 一天不得超過 10 小時";
            this.daily10CheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weekly7CheckBox);
            this.Controls.Add(this.daily10CheckBox);
            this.Controls.Add(this.weekly48CheckBox);
            this.Name = "SettingControl";
            this.Size = new System.Drawing.Size(1060, 814);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox weekly7CheckBox;
        public System.Windows.Forms.CheckBox weekly48CheckBox;
        public System.Windows.Forms.CheckBox daily10CheckBox;
    }
}
