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

        
        public ScheduleControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get datagridview data in a 2d array
            var array = new object[UpSchedule.RowCount, UpSchedule.ColumnCount];
            string[,] strarray = new string[12, 17];
            foreach (DataGridViewRow i in UpSchedule.Rows)
            {
                if (i.IsNewRow) continue;
                foreach (DataGridViewCell j in i.Cells)
                {
                    array[j.RowIndex, j.ColumnIndex] = j.Value;
                }
            }

            CheckRule checkrule = new CheckRule();
            //string str = "" + UpSchedule.Rows[0].Cells[0].Value;
            //MessageBox.Show("" + checkrule.daily8(str));
            MessageBox.Show(checkrule.daily8(array));
        }
    }
}
