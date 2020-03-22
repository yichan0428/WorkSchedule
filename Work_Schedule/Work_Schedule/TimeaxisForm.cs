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
    public partial class TimeaxisForm : Form
    {
        public string[,] stringarray;
        public TimeaxisForm()
        {
            InitializeComponent();
        }
        public TimeaxisForm(string[,] stringarray)
        {
            this.stringarray = stringarray;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            GenerateName();
            GenerateDay();
            GenerateTimeAxis();
        }
        private void GenerateName()
        {
            if (comboBox1.SelectedIndex < 15)
            {
                timeAxis1.TimeName0.Text = this.stringarray[0, 0];
                timeAxis1.TimeName1.Text = this.stringarray[1, 0];
                timeAxis1.TimeName2.Text = this.stringarray[2, 0];
                timeAxis1.TimeName3.Text = this.stringarray[3, 0];
                timeAxis1.TimeName4.Text = this.stringarray[4, 0];
                timeAxis1.TimeName5.Text = this.stringarray[5, 0];
                timeAxis1.TimeName6.Text = this.stringarray[6, 0];
                timeAxis1.TimeName7.Text = this.stringarray[7, 0];
                timeAxis1.TimeName8.Text = this.stringarray[8, 0];
                timeAxis1.TimeName9.Text = this.stringarray[9, 0];
                timeAxis1.TimeName10.Text = this.stringarray[10, 0];
                timeAxis1.TimeName11.Text = this.stringarray[11, 0];
            }
            else
            {
                timeAxis1.TimeName0.Text = this.stringarray[12, 0];
                timeAxis1.TimeName1.Text = this.stringarray[13, 0];
                timeAxis1.TimeName2.Text = this.stringarray[14, 0];
                timeAxis1.TimeName3.Text = this.stringarray[15, 0];
                timeAxis1.TimeName4.Text = this.stringarray[16, 0];
                timeAxis1.TimeName5.Text = this.stringarray[17, 0];
                timeAxis1.TimeName6.Text = this.stringarray[18, 0];
                timeAxis1.TimeName7.Text = this.stringarray[19, 0];
                timeAxis1.TimeName8.Text = this.stringarray[20, 0];
                timeAxis1.TimeName9.Text = this.stringarray[21, 0];
                timeAxis1.TimeName10.Text = this.stringarray[22, 0];
                timeAxis1.TimeName11.Text = this.stringarray[23, 0];
            }
        }
        private void GenerateDay()
        {
            timeAxis1.DayText.Text = (comboBox1.SelectedIndex + 1).ToString() + "日";
        }
        private void GenerateTimeAxis()
        {
            if (comboBox1.SelectedIndex <= 14)   //let different day show different bar , 0 is upshcedule and 1 is downschedule 
            {
                timeAxis1.GenerateTotalBar(stringarray, 0, comboBox1.SelectedIndex + 2);

            }
            else
            {
                timeAxis1.GenerateTotalBar(stringarray, 1, comboBox1.SelectedIndex + 2);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateName();
            GenerateDay();
            GenerateTimeAxis();
        }
        public void resetstringarray(string[,] stringarray)
        {
            this.stringarray = stringarray;
        }
    }
}
