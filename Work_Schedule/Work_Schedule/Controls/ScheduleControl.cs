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
        public string[,] stringarray = new string[24, 33];
        public string[,] axisarray = new string[24, 33];
        public string longstring = "";
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
            MessageBox.Show(checkrule.TotalCheck(stringarray, daily10, weekly7, weekly48));
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            objtostring();
            Properties.Settings.Default.Test = longstring;          
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();

        }
        private void Open_Click(object sender, EventArgs e)
        {
            load();
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

        }

        private void ScheduleControl_Load(object sender, EventArgs e)
        {
            //
            // Add rows initially
            //
            UpSchedule.Rows.Add(12);
            DownSchedule.Rows.Add(12);
            SetTimes();
            YearComboBox.SelectedIndex = 1;
            MonthComboBox.SelectedIndex = 2;

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
            try 
            {
                string[] SaveArray = (Properties.Settings.Default.Test).Split(new char[1] { '@' });
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
                MessageBox.Show("請先儲存第一筆資料再進行載入");
            }
        }

        private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTimes();
        }

        private void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTimes();
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
                DateTime datavalue = new DateTime(year.SelectedIndex + 2019, month.SelectedIndex + 1, i);
                string weekshow = "";
                switch (datavalue.DayOfWeek.ToString())
                {
                    case "Monday": weekshow = "一"; break;
                    case "Tuesday": weekshow = "二"; break;
                    case "Wednesday": weekshow = "三"; break;
                    case "Thursday": weekshow = "四"; break;
                    case "Friday": weekshow = "五"; break;
                    case "Saturday": weekshow = "六"; break;
                    case "Sunday": weekshow = "日"; break;
                }
                day.HeaderText = i + " " +weekshow;                   
            }
            catch
            {
                day.HeaderText = "";
            }

        }
    }
        
}
