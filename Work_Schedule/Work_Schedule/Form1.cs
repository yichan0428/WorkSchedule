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
        public MainForm()
        {
            InitializeComponent();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SettingButton.Height;
            SidePanel.Top = SettingButton.Top;
            settingControl1.BringToFront();
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ScheduleButton.Height;
            SidePanel.Top = ScheduleButton.Top;
            scheduleControl1.BringToFront();
        }

        private void TimeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = TimeButton.Height;
            SidePanel.Top = TimeButton.Top;
            timeControl1.BringToFront();
        }

        private void SalaryButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SalaryButton.Height;
            SidePanel.Top = SalaryButton.Top;
            salaryControl1.BringToFront();
        }

    }
}
