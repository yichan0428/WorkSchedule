using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Schedule
{
    public partial class TimeControl : UserControl
    {
        public string[,] stringarray;
        public int i;   //4*i
        public TimeControl()
        {
            InitializeComponent();
            comboBox1.Items.Add("第1日~第4日");
            comboBox1.Items.Add("第5日~第8日");
            comboBox1.Items.Add("第9日~第12日");
            comboBox1.Items.Add("第13日~第16日");
            comboBox1.Items.Add("第17日~第20日");
            comboBox1.Items.Add("第21日~第24日");
            comboBox1.Items.Add("第25日~第28日");
            comboBox1.Items.Add("第29日~第31日");
            comboBox1.SelectedIndex = 0;
        }

        public void timeaxis(string[,] stringarray)
        {
            this.stringarray = stringarray;    //throw the stringarray in schedulecontrol into stringarray in timecontrol, then it can be used in timecontrol 
            TimeName0.Text = this.stringarray[0, i];
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            i = comboBox1.SelectedIndex;
   
            
            //timeaxis(stringarray);  // refresh data 
        }
    }
}
