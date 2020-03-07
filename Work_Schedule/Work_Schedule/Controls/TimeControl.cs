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
        public int a = 0;   //4*i
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
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateName();
            GenerateDay();
            timeAxis1.GenerateTotalBar(stringarray, comboBox1.SelectedIndex * 4 + 2);
            timeAxis2.GenerateTotalBar(stringarray, comboBox1.SelectedIndex * 4 + 3);
            timeAxis3.GenerateTotalBar(stringarray, comboBox1.SelectedIndex * 4 + 4);
            if (comboBox1.SelectedIndex < 7)
                timeAxis4.GenerateTotalBar(stringarray, comboBox1.SelectedIndex * 4 + 5);
        }
        public void timeaxis(string[,] stringarray)
        {
            this.stringarray = stringarray;    //throw the stringarray in schedulecontrol into stringarray in timecontrol, then it can be used in timecontrol 
            comboBox1.SelectedIndex = 0;
            timeAxis1.GenerateTotalBar(stringarray, comboBox1.SelectedIndex * 4 + 2);
            timeAxis2.GenerateTotalBar(stringarray, comboBox1.SelectedIndex * 4 + 3);
            timeAxis3.GenerateTotalBar(stringarray, comboBox1.SelectedIndex * 4 + 4);
            if (comboBox1.SelectedIndex < 7)
                timeAxis4.GenerateTotalBar(stringarray, comboBox1.SelectedIndex * 4 + 5);
        }

        private void GenerateName()
        {
            if (comboBox1.SelectedIndex <= 3)
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

                timeAxis2.TimeName0.Text = this.stringarray[0, 0];
                timeAxis2.TimeName1.Text = this.stringarray[1, 0];
                timeAxis2.TimeName2.Text = this.stringarray[2, 0];
                timeAxis2.TimeName3.Text = this.stringarray[3, 0];
                timeAxis2.TimeName4.Text = this.stringarray[4, 0];
                timeAxis2.TimeName5.Text = this.stringarray[5, 0];
                timeAxis2.TimeName6.Text = this.stringarray[6, 0];
                timeAxis2.TimeName7.Text = this.stringarray[7, 0];
                timeAxis2.TimeName8.Text = this.stringarray[8, 0];
                timeAxis2.TimeName9.Text = this.stringarray[9, 0];
                timeAxis2.TimeName10.Text = this.stringarray[10, 0];
                timeAxis2.TimeName11.Text = this.stringarray[11, 0];

                timeAxis3.TimeName0.Text = this.stringarray[0, 0];
                timeAxis3.TimeName1.Text = this.stringarray[1, 0];
                timeAxis3.TimeName2.Text = this.stringarray[2, 0];
                timeAxis3.TimeName3.Text = this.stringarray[3, 0];
                timeAxis3.TimeName4.Text = this.stringarray[4, 0];
                timeAxis3.TimeName5.Text = this.stringarray[5, 0];
                timeAxis3.TimeName6.Text = this.stringarray[6, 0];
                timeAxis3.TimeName7.Text = this.stringarray[7, 0];
                timeAxis3.TimeName8.Text = this.stringarray[8, 0];
                timeAxis3.TimeName9.Text = this.stringarray[9, 0];
                timeAxis3.TimeName10.Text = this.stringarray[10, 0];
                timeAxis3.TimeName11.Text = this.stringarray[11, 0];

                timeAxis4.TimeName0.Text = this.stringarray[0, 0];
                timeAxis4.TimeName1.Text = this.stringarray[1, 0];
                timeAxis4.TimeName2.Text = this.stringarray[2, 0];
                timeAxis4.TimeName3.Text = this.stringarray[3, 0];
                timeAxis4.TimeName4.Text = this.stringarray[4, 0];
                timeAxis4.TimeName5.Text = this.stringarray[5, 0];
                timeAxis4.TimeName6.Text = this.stringarray[6, 0];
                timeAxis4.TimeName7.Text = this.stringarray[7, 0];
                timeAxis4.TimeName8.Text = this.stringarray[8, 0];
                timeAxis4.TimeName9.Text = this.stringarray[9, 0];
                timeAxis4.TimeName10.Text = this.stringarray[10, 0];
                timeAxis4.TimeName11.Text = this.stringarray[11, 0];

                if (comboBox1.SelectedIndex == 3)
                {
                    timeAxis4.TimeName0.Text = this.stringarray[12, 0];
                    timeAxis4.TimeName1.Text = this.stringarray[13, 0];
                    timeAxis4.TimeName2.Text = this.stringarray[14, 0];
                    timeAxis4.TimeName3.Text = this.stringarray[15, 0];
                    timeAxis4.TimeName4.Text = this.stringarray[16, 0];
                    timeAxis4.TimeName5.Text = this.stringarray[17, 0];
                    timeAxis4.TimeName6.Text = this.stringarray[18, 0];
                    timeAxis4.TimeName7.Text = this.stringarray[19, 0];
                    timeAxis4.TimeName8.Text = this.stringarray[20, 0];
                    timeAxis4.TimeName9.Text = this.stringarray[21, 0];
                    timeAxis4.TimeName10.Text = this.stringarray[22, 0];
                    timeAxis4.TimeName11.Text = this.stringarray[23, 0];
                }

            }
            if (comboBox1.SelectedIndex > 3)
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

                timeAxis2.TimeName0.Text = this.stringarray[12, 0];
                timeAxis2.TimeName1.Text = this.stringarray[13, 0];
                timeAxis2.TimeName2.Text = this.stringarray[14, 0];
                timeAxis2.TimeName3.Text = this.stringarray[15, 0];
                timeAxis2.TimeName4.Text = this.stringarray[16, 0];
                timeAxis2.TimeName5.Text = this.stringarray[17, 0];
                timeAxis2.TimeName6.Text = this.stringarray[18, 0];
                timeAxis2.TimeName7.Text = this.stringarray[19, 0];
                timeAxis2.TimeName8.Text = this.stringarray[20, 0];
                timeAxis2.TimeName9.Text = this.stringarray[21, 0];
                timeAxis2.TimeName10.Text = this.stringarray[22, 0];
                timeAxis2.TimeName11.Text = this.stringarray[23, 0];

                timeAxis3.TimeName0.Text = this.stringarray[12, 0];
                timeAxis3.TimeName1.Text = this.stringarray[13, 0];
                timeAxis3.TimeName2.Text = this.stringarray[14, 0];
                timeAxis3.TimeName3.Text = this.stringarray[15, 0];
                timeAxis3.TimeName4.Text = this.stringarray[16, 0];
                timeAxis3.TimeName5.Text = this.stringarray[17, 0];
                timeAxis3.TimeName6.Text = this.stringarray[18, 0];
                timeAxis3.TimeName7.Text = this.stringarray[19, 0];
                timeAxis3.TimeName8.Text = this.stringarray[20, 0];
                timeAxis3.TimeName9.Text = this.stringarray[21, 0];
                timeAxis3.TimeName10.Text = this.stringarray[22, 0];
                timeAxis3.TimeName11.Text = this.stringarray[23, 0];

                timeAxis4.TimeName0.Text = this.stringarray[12, 0];
                timeAxis4.TimeName1.Text = this.stringarray[13, 0];
                timeAxis4.TimeName2.Text = this.stringarray[14, 0];
                timeAxis4.TimeName3.Text = this.stringarray[15, 0];
                timeAxis4.TimeName4.Text = this.stringarray[16, 0];
                timeAxis4.TimeName5.Text = this.stringarray[17, 0];
                timeAxis4.TimeName6.Text = this.stringarray[18, 0];
                timeAxis4.TimeName7.Text = this.stringarray[19, 0];
                timeAxis4.TimeName8.Text = this.stringarray[20, 0];
                timeAxis4.TimeName9.Text = this.stringarray[21, 0];
                timeAxis4.TimeName10.Text = this.stringarray[22, 0];
                timeAxis4.TimeName11.Text = this.stringarray[23, 0];

            }
        }  
        private void GenerateDay()
        {
            timeAxis1.DayText.Text = (comboBox1.SelectedIndex * 4 + 1).ToString() + "日";
            timeAxis2.DayText.Text = (comboBox1.SelectedIndex * 4 + 2).ToString() + "日";
            timeAxis3.DayText.Text = (comboBox1.SelectedIndex * 4 + 3).ToString() + "日";
            timeAxis4.DayText.Text = (comboBox1.SelectedIndex * 4 + 4).ToString() + "日";
            if (comboBox1.SelectedIndex == 7)
                timeAxis4.DayText.Text = "";
        }


    }
}
