using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Schedule
{
    public partial class MainForm : Form
    {
        private bool Dragging = false;
        private Point StartPoint = new Point(0, 0);
        public MainForm()
        {
            InitializeComponent();
            
        }
        private void QuationMark_Click(object sender, EventArgs e)
        {
            MessageBox.Show("在此處新增使用說明");
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SettingButton.Height;
            SidePanel.Top = SettingButton.Top;
            settingControl1.BringToFront();
            SubTitle.Text = "勞健保設定";
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ScheduleButton.Height;
            SidePanel.Top = ScheduleButton.Top;
            scheduleControl1.BringToFront();
            SubTitle.Text = "  班表";
        }

        private void TimeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = TimeButton.Height;
            SidePanel.Top = TimeButton.Top;
            timeControl1.BringToFront();
            SubTitle.Text = " 時間表";
        }

        private void SalaryButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SalaryButton.Height;
            SidePanel.Top = SalaryButton.Top;
            salaryControl1.BringToFront();
            SubTitle.Text = "  薪資";
            MessageBox.Show("此功能尚未啟用");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimumButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // 拖曳視窗
        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void TitlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(e.X - this.StartPoint.X, e.Y - this.StartPoint.Y);
            }
        }

        private void TitlePanel_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void QuationMarkButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("使用說明：(待新增)");
        }
    }
}
