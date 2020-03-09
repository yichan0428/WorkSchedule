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
    public partial class TimeAxis : UserControl
    {
        double Value1, Value2, Value3, Value4;
        string[,] stringarray;
        public TimeAxis()
        {
            InitializeComponent();
        }
        public void GenerateTotalBar(string[,] stringarray,int name,int day)
        {
            this.stringarray = stringarray;
            if (name ==0)
            {
                GenerateSingleBar(TimeBar0, RTimeBar0, 0, day);
                GenerateSingleBar(TimeBar1, RTimeBar1, 1, day);
                GenerateSingleBar(TimeBar2, RTimeBar2, 2, day);
                GenerateSingleBar(TimeBar3, RTimeBar3, 3, day);
                GenerateSingleBar(TimeBar4, RTimeBar4, 4, day);
                GenerateSingleBar(TimeBar5, RTimeBar5, 5, day);
                GenerateSingleBar(TimeBar6, RTimeBar6, 6, day);
                GenerateSingleBar(TimeBar7, RTimeBar7, 7, day);
                GenerateSingleBar(TimeBar8, RTimeBar8, 8, day);
                GenerateSingleBar(TimeBar9, RTimeBar9, 9, day);
                GenerateSingleBar(TimeBar10, RTimeBar10, 10, day);
                GenerateSingleBar(TimeBar11, RTimeBar11, 11, day);
            }
            else
            {
                GenerateSingleBar(TimeBar0, RTimeBar0, 12, day);
                GenerateSingleBar(TimeBar1, RTimeBar1, 13, day);
                GenerateSingleBar(TimeBar2, RTimeBar2, 14, day);
                GenerateSingleBar(TimeBar3, RTimeBar3, 15, day);
                GenerateSingleBar(TimeBar4, RTimeBar4, 16, day);
                GenerateSingleBar(TimeBar5, RTimeBar5, 17, day);
                GenerateSingleBar(TimeBar6, RTimeBar6, 18, day);
                GenerateSingleBar(TimeBar7, RTimeBar7, 19, day);
                GenerateSingleBar(TimeBar8, RTimeBar8, 20, day);
                GenerateSingleBar(TimeBar9, RTimeBar9, 21, day);
                GenerateSingleBar(TimeBar10, RTimeBar10, 22, day);
                GenerateSingleBar(TimeBar11, RTimeBar11, 23, day);
            }
            
        }
        private void GenerateSingleBar(Panel TimeBar, Panel RTimeBar, int i ,int day)
        {
            getstringvalue(stringarray[i, day]);
            if (Value1 != 0)
            {
                if (Value1 >= Value2)
                    Value2 += 12;
                else if (Value1 < 7)
                {
                    Value1 += 12;
                    Value2 += 12;
                }
                TimeBar.Left = 72 + Convert.ToInt16((Value1 - 7) * 24);
                TimeBar.Width = Convert.ToInt16((Value2 - Value1) * 24);
            }
            else
            {
                TimeBar.Width = 0;
            }

            if (Value3 != 0)
            {
                if (Value3 < 12)
                    Value3 += 12;
                Value4 += 12;
                RTimeBar.Left = 72 + Convert.ToInt16((Value3 - 7) * 24);
                RTimeBar.Width = Convert.ToInt16((Value4 - Value3) * 24);
            }
            else
            {
                RTimeBar.Width = 0;
            }

        }

        private void getstringvalue(string str)
        {
            try
            {
                str += "/0/0";  //gurantee value is exist
                string[] strArray = str.Split(new char[2] { '-', '/' });
                Value1 = Convert.ToDouble(strArray[0]);
                Value2 = Convert.ToDouble(strArray[1]);
                Value3 = Convert.ToDouble(strArray[2]);
                Value4 = Convert.ToDouble(strArray[3]);
            }
            catch
            {
                Value1 = 0;
                Value2 = 0;
                Value3 = 0;
                Value4 = 0;
            }
        }
    }
}
