using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Schedule
{
    class CheckRule
    {
        public CheckRule()
        {
            TotalStr = "";
        }
        public string TotalCheck(object[,] array_merge)
        {
            daily10(array_merge);
            weekly7(array_merge);
            weekly48(array_merge);
            if (TotalStr == "")
                return "均符合勞健保";
            else
                return TotalStr;
        }
        private int CauculateTimes(string str)
        {
            str += "/0/0";  //gurantee value2 is exist
            string[] strArray = str.Split(new char[2] {'-' , '/'});
            int Value1 = int.Parse(strArray[1]) - int.Parse(strArray[0]);
            int Value2 = int.Parse(strArray[3]) - int.Parse(strArray[2]);
            if (Value1 <= 0 )
            {
                Value1 += 12;
            }
            if (Value2 < 0)
            {
                Value2 += 12;
            }
            return Value1 + Value2;
        }
        public string daily10(object[,] array_merge)
            {
                string str = "";
                for (int i = 0; i < 24; i++)
                {
                 for (int j = 2; j < 33; j++)
                    {
                        if (array_merge[i, 0] != null && array_merge[i, j] != null && CauculateTimes(array_merge[i, j].ToString()) > 10)
                        {
                            string stradd = array_merge[i, 0].ToString() + " 的第 " + (j - 1) + "天超過十小時\n";
                            str += stradd;
                        }

                    }
                }
                TotalStr += str;
                return str;
            }
        public string weekly7(object[,] array_merge)
        {
            string str = ""; 
            for (int i = 0; i < 24; i++)
            {
                int count7 = 0;
                for (int j = 2; j < 33; j++)
                {
                    if (array_merge[i, 0] != null && array_merge[i, j] != null && CauculateTimes(array_merge[i, j].ToString()) > 0)
                    {
                        count7++;
                        if (count7 == 7)
                        {
                            string stradd = array_merge[i, 0].ToString() + " 的第 " + (j - 7) + " 天~第 " +(j-1) + " 天已連續上班七天\n";
                            str += stradd;
                        }

                    }
                    else
                        count7 = 0;
                }
            }
            TotalStr += str;
            return str;
        }
        public string weekly48(object[,] array_merge)
        {
            string str = "";
            for (int i = 0; i < 24; i++)
            {
                for (int j = 2; j < 27; j++)
                {
                    int count48 = 0;
                    for (int k = 0; k < 7; k++)
                        if (array_merge[i, 0] != null && array_merge[i, j+k] != null && CauculateTimes(array_merge[i, j+k].ToString()) > 0)
                        {
                            count48 += CauculateTimes(array_merge[i, j+k].ToString());
                        }
                    if (count48 > 48)
                    {
                        string stradd = array_merge[i, 0].ToString() + " 的第 " + (j - 1) + " 天~第 " + (j + 5) + " 天已超過48小時\n";
                        str += stradd;
                    }

                }
            }
            TotalStr += str;
            return str;
        }

        private string TotalStr;
    }
}
