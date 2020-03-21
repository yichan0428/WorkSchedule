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
        //private bool Dragging = false;
        //private Point StartPoint = new Point(0, 0);
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SettingButton.Height;
            SidePanel.Top = SettingButton.Top;
            settingControl1.BringToFront();
            settingControl1.Location = new Point(0, 0);
            SubTitle.Text = "勞健保設定";
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ScheduleButton.Height;
            SidePanel.Top = ScheduleButton.Top;
            scheduleControl1.BringToFront();
            scheduleControl1.Location = new Point(0, 0);
            SubTitle.Text = "  班表";
            scheduleControl1.daily10 = settingControl1.daily10CheckBox.Checked;  // determine whether settingcontrol works
            scheduleControl1.weekly7 = settingControl1.weekly7CheckBox.Checked;
            scheduleControl1.weekly48= settingControl1.weekly48CheckBox.Checked;
        }

        private void TimeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = TimeButton.Height;
            SidePanel.Top = TimeButton.Top;
            timeControl1.BringToFront();
            timeControl1.Location = new Point(0, 0);
            SubTitle.Text = " 時間表";
            scheduleControl1.objtostring();    //reset stringarray to show the value in schedulecontrol
            timeControl1.timeaxis(scheduleControl1.axisarray);   //throw the array value in schedulecontrol to timecontrol by public method 
        }

        private void SalaryButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SalaryButton.Height;
            SidePanel.Top = SalaryButton.Top;
            salaryControl1.BringToFront();
            salaryControl1.Location = new Point(0, 0);
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
/*        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
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
*/
        private void QuationMarkButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\t                        排班系統使用說明      \n\n"+
                            "班表輸入時\n"+
                            "  1.可以使用12/24小時制排班，\n"+
                            "      ex：7 - 12 (5小時)  ,  7 - 7 (12小時)  ,  7 - 19 (12小時)\n" +
                            "     ★注意★\n" + 
                            "       7 - 8  判定為1小時而非13小時，如需排定13小時需輸入7 - 20\n" +
                            "       7 - 11 判定為早上，如需排定晚上須輸入 19 - 23\n\n" +
                            "  2.兩段班制請使用 \" / \" 來做區隔\n" +
                            "      ex：7 - 1 / 5 - 9　(10小時)\n");
        }
    }
}
