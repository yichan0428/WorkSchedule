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
    public partial class ScheduleControl : UserControl
    {
        /*If you want to call any value in schedulecontrol, 
          you need to declare a public item to get value inderectly*/
        public bool daily10, weekly7, weekly48;
        public string[,] crossarray = new string[24, 45];
        public string[,] stringarray = new string[24, 33];
        public string[,] axisarray = new string[24, 33];
        public string longstring = "";
        private bool comboboxcount = false;
        private bool Issave = false;
        private int comboboxyearpreviosvalue = 0;
        private int comboboxmonthpreviosvalue = 2;
        private int day1value;
        private int day31value;

        string[] SaveArray2;
        //
        //
        //    
        public ScheduleControl()
        {
            InitializeComponent();
            
        }
        //
        //
        //
        private void button1_Click(object sender, EventArgs e)
        {
            objtostring();
            CheckRule checkrule = new CheckRule();
            MessageBox.Show(checkrule.TotalCheck(crossarray, daily10, weekly7, weekly48,day1value, day31value, getpreviosbound(),getthisbound()));
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            objtostring();

            if (Issave == true)
            {
                storestring(comboboxyearpreviosvalue + 20, comboboxmonthpreviosvalue + 1);
                comboboxyearpreviosvalue = YearComboBox.SelectedIndex;    //due to save data when selectedIndex_Changed
                comboboxmonthpreviosvalue = MonthComboBox.SelectedIndex;
                Issave = false;
            }
                
            else
            {
                storestring(YearComboBox.SelectedIndex + 20, MonthComboBox.SelectedIndex + 1);                
            }
                
                
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();

        }
        public void objtostring()
        {
            // get datagridview data in a 2d array
            var array = new object[UpSchedule.RowCount, UpSchedule.ColumnCount];
            foreach (DataGridViewRow i in UpSchedule.Rows)
            {
                if (i.IsNewRow) continue;
                foreach (DataGridViewCell j in i.Cells)
                {
                    array[j.RowIndex, j.ColumnIndex] = j.Value;
                }
            }
            var array_down = new object[DownSchedule.RowCount, DownSchedule.ColumnCount];
            foreach (DataGridViewRow i in DownSchedule.Rows)
            {
                if (i.IsNewRow) continue;
                foreach (DataGridViewCell j in i.Cells)
                {
                    array_down[j.RowIndex, j.ColumnIndex] = j.Value;
                }
            }
            //
            //merge two object array
            //
            var array_merge = new object[24, 33];

            for (int i = 0; i < 12; i++)        //left and up is upschedule,left and down is empty
            {
                for (int j = 0; j < 17; j++)
                {
                    if (array[i, j] != null)
                        array_merge[i, j] = array[i, j];
                }
            }
            for (int i = 12; i < 24; i++)       //name column should be merged with downschedule name
            {
                int CountSame = 0;
                for (int j = 0; j < 12; j++)
                {
                    if (array_down[i - 12, 0] != null && array_merge[j, 0] != null && array_down[i - 12, 0].ToString() == array_merge[j, 0].ToString())
                    {
                        CountSame++;
                        array_merge[i, 0] = null;
                        for (int a = 17; a < 33; a++)
                        {
                            array_merge[j, a] = array_down[i - 12, a - 15];
                        }
                    }
                }
                if (CountSame == 0)
                {
                    array_merge[i, 0] = array_down[i - 12, 0];
                    for (int a = 17; a < 33; a++)
                    {
                        array_merge[i, a] = array_down[i - 12, a - 15];
                    }
                }
            }
            var axismerge = new object[24, 33];
            for (int i = 0; i < 12; i++)        //left and up is upschedule
            {
                for (int j = 0; j < 17; j++)
                {
                    if (array[i, j] != null)
                        axismerge[i, j] = array[i, j];
                }
            }
            for (int i = 12; i < 24; i++)        //right and down is downschedule
            {
                if (array_down[i-12, 0] != null)
                    axismerge[i , 0] = array_down[i - 12, 0];
                for (int j = 17; j < 33; j++)
                {
                    if (array_down[i-12, j-15] != null)
                        axismerge[i , j] = array_down[i -12, j-15];
                }
            }

            //
            //convert arraymerge and axismerge to stringarray and axisarray seperately
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 33; j++)
                {
                    if (array_merge[i, j] == null)
                        stringarray[i, j] = "";
                    else
                        stringarray[i, j] = array_merge[i, j].ToString();
                }
            }
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 33; j++)
                {
                    if (axismerge[i, j] == null)
                        axisarray[i, j] = "";
                    else
                        axisarray[i, j] = axismerge[i, j].ToString();
                }
            }
            //
            //longstring is used to make properties.setting
            //
            longstring = "";         //initialize
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    if (array[i, j] == null)
                        longstring += "@";
                    else
                    {
                        longstring += array[i, j].ToString();
                        longstring += "@";
                    }
                        
                }
            }
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    if (array_down[i, j] == null)
                        longstring += "@";
                    else
                    {
                        longstring += array_down[i, j].ToString();
                        longstring += "@";
                    }

                }
            }
            //
            //getacrossarray  (seperate stringarray)      acrossarray is 2(name title)+6(prevoius month)+15(upschedule)+16(downschedule)+6(next month)
            //
            for (int i = 0; i < 24; i++)
            {
                crossarray[i, 0] = stringarray[i, 0];
                crossarray[i, 1] = stringarray[i, 1];
                for (int j = 2; j < 33; j++)
                {
                    crossarray[i, j + 6] = stringarray[i, j];
                }
            }
            //First :get the last 6 days in previous month and throw into crossarray
            string[] SaveArray;
            string previousstr;
            if (MonthComboBox.SelectedIndex == 0)
                previousstr = loadstring(YearComboBox.SelectedIndex + 19, 12);
            else
                previousstr = loadstring(YearComboBox.SelectedIndex + 20, MonthComboBox.SelectedIndex);
            try
            {
                SaveArray = previousstr.Split(new char[1] { '@' });
                for (int j = 204; j < 403; j += 18)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        if (SaveArray[j] != "" && SaveArray[j] == crossarray[i, 0])
                        {
                            for (int a = 0; a < 6; a++)
                            {
                                crossarray[i, a + 2] = SaveArray[j + (getpreviosbound() - 14 - 5) + a];
                            }

                        }
                    }
                }
            }
            catch{}
            //Second :get the first 6 days in next month and throw into crossarray
            
            string nextstr;
            if (MonthComboBox.SelectedIndex == 12)
                nextstr = loadstring(YearComboBox.SelectedIndex + 21, 1);
            else
                nextstr = loadstring(YearComboBox.SelectedIndex + 20, MonthComboBox.SelectedIndex+2);
            try
            {
                SaveArray2 = nextstr.Split(new char[1] { '@' });

                for (int j = 0; j < 188; j += 17)
                {
                    for (int i = 0; i < 24; i++)
                    {
                        if (SaveArray2[j] != "" && SaveArray2[j] == crossarray[i, 0])
                        {
                            for (int a = 0; a < (6 + 31 - getthisbound()); a++)
                            {
                                crossarray[i, a + getthisbound() + 8] = SaveArray2[j + a + 2];
                            }

                        }
                    }
                }
            }
            catch {}
            

        }

        private void ScheduleControl_Load(object sender, EventArgs e)
        {
            //
            // Add rows initially
            //
            UpSchedule.Rows.Add(12);
            DownSchedule.Rows.Add(12);
            
            YearComboBox.SelectedIndex = 0;
            MonthComboBox.SelectedIndex = 2;
            SetTimes();
            comboboxcount = true;
            load();
        

            //
            //disable sort in every columns
            //
            foreach (DataGridViewColumn column in UpSchedule.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in DownSchedule.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        public void load()
        {
            string str = loadstring(YearComboBox.SelectedIndex+20, MonthComboBox.SelectedIndex+1);
            try
            {
                string[] SaveArray = str.Split(new char[1] { '@' });
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 17; j++)
                    {
                        UpSchedule.Rows[i].Cells[j].Value = SaveArray[i * 17 + j];
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 18; j++)
                    {
                        DownSchedule.Rows[i].Cells[j].Value = SaveArray[17 * 12 + i * 18 + j];
                    }
                }
            }
            catch
            {
                initialize();
            }    


        }

        private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxcount == true)
            {
                Issave = true;
                SaveButton.PerformClick();
                load();
                SetTimes();
            }         
        }

        private void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxcount == true)
            {
                Issave = true;
                SaveButton.PerformClick();
                load();
                SetTimes();
            }
        }
        private void SetTimes()
        {
            SetTimesDetail(YearComboBox, MonthComboBox, day1, 1);
            SetTimesDetail(YearComboBox, MonthComboBox, day2, 2);
            SetTimesDetail(YearComboBox, MonthComboBox, day3, 3);
            SetTimesDetail(YearComboBox, MonthComboBox, day4, 4);
            SetTimesDetail(YearComboBox, MonthComboBox, day5, 5);
            SetTimesDetail(YearComboBox, MonthComboBox, day6, 6);
            SetTimesDetail(YearComboBox, MonthComboBox, day7, 7);
            SetTimesDetail(YearComboBox, MonthComboBox, day8, 8);
            SetTimesDetail(YearComboBox, MonthComboBox, day9, 9);
            SetTimesDetail(YearComboBox, MonthComboBox, day10, 10);
            SetTimesDetail(YearComboBox, MonthComboBox, day11, 11);
            SetTimesDetail(YearComboBox, MonthComboBox, day12, 12);
            SetTimesDetail(YearComboBox, MonthComboBox, day13, 13);
            SetTimesDetail(YearComboBox, MonthComboBox, day14, 14);
            SetTimesDetail(YearComboBox, MonthComboBox, day15, 15);
            SetTimesDetail(YearComboBox, MonthComboBox, day16, 16);
            SetTimesDetail(YearComboBox, MonthComboBox, day17, 17);
            SetTimesDetail(YearComboBox, MonthComboBox, day18, 18);
            SetTimesDetail(YearComboBox, MonthComboBox, day19, 19);
            SetTimesDetail(YearComboBox, MonthComboBox, day20, 20);
            SetTimesDetail(YearComboBox, MonthComboBox, day21, 21);
            SetTimesDetail(YearComboBox, MonthComboBox, day22, 22);
            SetTimesDetail(YearComboBox, MonthComboBox, day23, 23);
            SetTimesDetail(YearComboBox, MonthComboBox, day24, 24);
            SetTimesDetail(YearComboBox, MonthComboBox, day25, 25);
            SetTimesDetail(YearComboBox, MonthComboBox, day26, 26);
            SetTimesDetail(YearComboBox, MonthComboBox, day27, 27);
            SetTimesDetail(YearComboBox, MonthComboBox, day28, 28);
            SetTimesDetail(YearComboBox, MonthComboBox, day29, 29);
            SetTimesDetail(YearComboBox, MonthComboBox, day30, 30);
            SetTimesDetail(YearComboBox, MonthComboBox, day31, 31);
        }

        private void SetTimesDetail(ComboBox year, ComboBox month, DataGridViewTextBoxColumn day ,int i)
        {
            try
            {               
                DateTime datavalue = new DateTime(year.SelectedIndex + 2020, month.SelectedIndex + 1, i);
                string weekshow = "";
                switch (datavalue.DayOfWeek.ToString())
                {
                    case "Monday"   : weekshow = "一";  break;
                    case "Tuesday"  : weekshow = "二";  break;
                    case "Wednesday": weekshow = "三";  break;
                    case "Thursday" : weekshow = "四";  break;
                    case "Friday"   : weekshow = "五";  break;
                    case "Saturday" : weekshow = "六";  break;
                    case "Sunday"   : weekshow = "日";  break;
                }
                //get day1 and day31 value to checkrule
                DateTime datavalue2 = new DateTime(year.SelectedIndex + 2020, month.SelectedIndex + 1, 1);
                DateTime datavalue3 = new DateTime(year.SelectedIndex + 2020, month.SelectedIndex + 1, 1);
                switch (datavalue2.DayOfWeek.ToString())
                {
                    case "Monday":  day1value = 1; break;
                    case "Tuesday":  day1value = 2; break;
                    case "Wednesday":  day1value = 3; break;
                    case "Thursday":  day1value = 4; break;
                    case "Friday":  day1value = 5; break;
                    case "Saturday":  day1value = 6; break;
                    case "Sunday":  day1value = 7; break;
                }
                switch (datavalue3.DayOfWeek.ToString())
                {
                    case "Monday": day31value = 1; break;
                    case "Tuesday": day31value = 2; break;
                    case "Wednesday": day31value = 3; break;
                    case "Thursday": day31value = 4; break;
                    case "Friday": day31value = 5; break;
                    case "Saturday": day31value = 6; break;
                    case "Sunday": day31value = 7; break;
                }

                day.HeaderText = i + " " +weekshow;                   
            }
            catch
            {
                day.HeaderText = "";
            }

        }
        private void storestring(int y , int m)
        {
            switch(y*100+m)
            {
                case 2001: Properties.Settings.Default.Store2001 = longstring; break;
                case 2002: Properties.Settings.Default.Store2002 = longstring; break;
                case 2003: Properties.Settings.Default.Store2003 = longstring; break;
                case 2004: Properties.Settings.Default.Store2004 = longstring; break;
                case 2005: Properties.Settings.Default.Store2005 = longstring; break;
                case 2006: Properties.Settings.Default.Store2006 = longstring; break;
                case 2007: Properties.Settings.Default.Store2007 = longstring; break;
                case 2008: Properties.Settings.Default.Store2008 = longstring; break;
                case 2009: Properties.Settings.Default.Store2009 = longstring; break;
                case 2010: Properties.Settings.Default.Store2010 = longstring; break;
                case 2011: Properties.Settings.Default.Store2011 = longstring; break;
                case 2012: Properties.Settings.Default.Store2012 = longstring; break;
                case 2101: Properties.Settings.Default.Store2101 = longstring; break;
                case 2102: Properties.Settings.Default.Store2102 = longstring; break;
                case 2103: Properties.Settings.Default.Store2103 = longstring; break;
                case 2104: Properties.Settings.Default.Store2104 = longstring; break;
                case 2105: Properties.Settings.Default.Store2105 = longstring; break;
                case 2106: Properties.Settings.Default.Store2106 = longstring; break;
                case 2107: Properties.Settings.Default.Store2107 = longstring; break;
                case 2108: Properties.Settings.Default.Store2108 = longstring; break;
                case 2109: Properties.Settings.Default.Store2109 = longstring; break;
                case 2110: Properties.Settings.Default.Store2110 = longstring; break;
                case 2111: Properties.Settings.Default.Store2111 = longstring; break;
                case 2112: Properties.Settings.Default.Store2112 = longstring; break;
                case 2201: Properties.Settings.Default.Store2201 = longstring; break;
                case 2202: Properties.Settings.Default.Store2202 = longstring; break;
                case 2203: Properties.Settings.Default.Store2203 = longstring; break;
                case 2204: Properties.Settings.Default.Store2204 = longstring; break;
                case 2205: Properties.Settings.Default.Store2205 = longstring; break;
                case 2206: Properties.Settings.Default.Store2206 = longstring; break;
                case 2207: Properties.Settings.Default.Store2207 = longstring; break;
                case 2208: Properties.Settings.Default.Store2208 = longstring; break;
                case 2209: Properties.Settings.Default.Store2209 = longstring; break;
                case 2210: Properties.Settings.Default.Store2210 = longstring; break;
                case 2211: Properties.Settings.Default.Store2211 = longstring; break;
                case 2212: Properties.Settings.Default.Store2212 = longstring; break;
                
            }

        }
        private string loadstring(int y, int m)
        {
            string str = "";
            switch (y * 100 + m)
            {

                case 2001: str = Properties.Settings.Default.Store2001; break;
                case 2002: str = Properties.Settings.Default.Store2002; break;
                case 2003: str = Properties.Settings.Default.Store2003; break;
                case 2004: str = Properties.Settings.Default.Store2004; break;
                case 2005: str = Properties.Settings.Default.Store2005; break;
                case 2006: str = Properties.Settings.Default.Store2006; break;
                case 2007: str = Properties.Settings.Default.Store2007; break;
                case 2008: str = Properties.Settings.Default.Store2008; break;
                case 2009: str = Properties.Settings.Default.Store2009; break;
                case 2010: str = Properties.Settings.Default.Store2010; break;
                case 2011: str = Properties.Settings.Default.Store2011; break;
                case 2012: str = Properties.Settings.Default.Store2012; break;
                case 2101: str = Properties.Settings.Default.Store2101; break;
                case 2102: str = Properties.Settings.Default.Store2102; break;
                case 2103: str = Properties.Settings.Default.Store2103; break;
                case 2104: str = Properties.Settings.Default.Store2104; break;
                case 2105: str = Properties.Settings.Default.Store2105; break;
                case 2106: str = Properties.Settings.Default.Store2106; break;
                case 2107: str = Properties.Settings.Default.Store2107; break;
                case 2108: str = Properties.Settings.Default.Store2108; break;
                case 2109: str = Properties.Settings.Default.Store2109; break;
                case 2110: str = Properties.Settings.Default.Store2110; break;
                case 2111: str = Properties.Settings.Default.Store2111; break;
                case 2112: str = Properties.Settings.Default.Store2112; break;
                case 2201: str = Properties.Settings.Default.Store2201; break;
                case 2202: str = Properties.Settings.Default.Store2202; break;
                case 2203: str = Properties.Settings.Default.Store2203; break;
                case 2204: str = Properties.Settings.Default.Store2204; break;
                case 2205: str = Properties.Settings.Default.Store2205; break;
                case 2206: str = Properties.Settings.Default.Store2206; break;
                case 2207: str = Properties.Settings.Default.Store2207; break;
                case 2208: str = Properties.Settings.Default.Store2208; break;
                case 2209: str = Properties.Settings.Default.Store2209; break;
                case 2210: str = Properties.Settings.Default.Store2210; break;
                case 2211: str = Properties.Settings.Default.Store2211; break;
                case 2212: str = Properties.Settings.Default.Store2212; break;
                default: str = "";break;
            }

            return str;
        }

        private void initialize()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    UpSchedule.Rows[i].Cells[j].Value = "";
                }
            }
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    DownSchedule.Rows[i].Cells[j].Value = "";
                }
            }
        }
        private int getpreviosbound()
        {
            //
            // get previous month bounded day
            //
            int PreviousMonthBound = 31;
            for (int i = 31; i > 28; i--)
            {
                try
                {
                    if (MonthComboBox.SelectedIndex == 0)
                    {
                        DateTime datavalue = new DateTime(YearComboBox.SelectedIndex + 2019, 12, i);
                        datavalue.DayOfWeek.ToString();
                    }

                    else
                    {
                        DateTime datavalue = new DateTime(YearComboBox.SelectedIndex + 2020, MonthComboBox.SelectedIndex, i);
                        datavalue.DayOfWeek.ToString();
                    }
                }
                catch
                {
                    PreviousMonthBound = i - 1;
                }
            }
            return PreviousMonthBound;
        }
        private int getthisbound()
        {
            //
            // get previous month bounded day
            //
            int thisMonthBound = 31;
            for (int i = 31; i > 28; i--)
            {
                try
                {
                    if (MonthComboBox.SelectedIndex == 12)
                    {
                        DateTime datavalue = new DateTime(YearComboBox.SelectedIndex + 2021, 1, i);
                        datavalue.DayOfWeek.ToString();
                    }

                    else
                    {
                        DateTime datavalue = new DateTime(YearComboBox.SelectedIndex + 2020, MonthComboBox.SelectedIndex + 1, i);
                        datavalue.DayOfWeek.ToString();
                    }
                }
                catch
                {
                    thisMonthBound = i - 1;
                }
            }
            return thisMonthBound;
        }
    }

}
