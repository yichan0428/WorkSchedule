namespace Work_Schedule
{
    partial class TimeControl
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timeAxis4 = new Work_Schedule.TimeAxis();
            this.timeAxis3 = new Work_Schedule.TimeAxis();
            this.timeAxis2 = new Work_Schedule.TimeAxis();
            this.timeAxis1 = new Work_Schedule.TimeAxis();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gray;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 100;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("DFKai-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(469, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timeAxis4
            // 
            this.timeAxis4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.timeAxis4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeAxis4.Location = new System.Drawing.Point(553, 390);
            this.timeAxis4.Name = "timeAxis4";
            this.timeAxis4.Size = new System.Drawing.Size(494, 360);
            this.timeAxis4.TabIndex = 2;
            // 
            // timeAxis3
            // 
            this.timeAxis3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.timeAxis3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeAxis3.Location = new System.Drawing.Point(19, 390);
            this.timeAxis3.Name = "timeAxis3";
            this.timeAxis3.Size = new System.Drawing.Size(494, 360);
            this.timeAxis3.TabIndex = 2;
            // 
            // timeAxis2
            // 
            this.timeAxis2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.timeAxis2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeAxis2.Location = new System.Drawing.Point(553, 30);
            this.timeAxis2.Name = "timeAxis2";
            this.timeAxis2.Size = new System.Drawing.Size(494, 360);
            this.timeAxis2.TabIndex = 2;
            // 
            // timeAxis1
            // 
            this.timeAxis1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.timeAxis1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeAxis1.Location = new System.Drawing.Point(19, 30);
            this.timeAxis1.Name = "timeAxis1";
            this.timeAxis1.Size = new System.Drawing.Size(494, 360);
            this.timeAxis1.TabIndex = 2;
            // 
            // TimeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.timeAxis4);
            this.Controls.Add(this.timeAxis3);
            this.Controls.Add(this.timeAxis2);
            this.Controls.Add(this.timeAxis1);
            this.Controls.Add(this.comboBox1);
            this.Name = "TimeControl";
            this.Size = new System.Drawing.Size(1060, 750);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private TimeAxis timeAxis1;
        private TimeAxis timeAxis2;
        private TimeAxis timeAxis3;
        private TimeAxis timeAxis4;
    }
}
