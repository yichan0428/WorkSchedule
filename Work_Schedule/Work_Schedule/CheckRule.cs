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
        public string TotalCheck(string[,] s,bool a,bool b,bool c)
        {
            if (a == true)
                daily10(s);
            if (b == true)
                weekly7(s);
            if (c == true)
                weekly48(s);
            if (TotalStr == "")
                return "均符合勞健保";
            else
                return TotalStr;
        }
        public int CauculateTimes(string str)
        {

            try
            {
                str += "/0/0";  //gurantee value2 is exist
                string[] strArray = str.Split(new char[2] { '-', '/' });
                int Value1 = int.Parse(strArray[1]) - int.Parse(strArray[0]);
                int Value2 = int.Parse(strArray[3]) - int.Parse(strArray[2]);
                if (Value1 <= 0)
                {
                    Value1 += 12;
                }
                if (Value2 < 0)
                {
                    Value2 += 12;
                }
                return Value1 + Value2;
            }
            catch
            {
                return 0;
            }
        }
        public string daily10(string[,] s)
            {
                string str = "";
                for (int i = 0; i < 24; i++)
                {
                 for (int j = 2; j < 33; j++)
                    {
                        if (s[i, 0] != "" && s[i, j] != "" && CauculateTimes(s[i, j]) > 10)
                        {
                            string stradd = s[i, 0] + " 的第 " + (j - 1) + "天超過十小時\n";
                            str += stradd;
                        }

                    }
                }
                TotalStr += str;
                return str;
            }
        public string weekly7(string[,] s)
        {
            string str = ""; 
            for (int i = 0; i < 24; i++)
            {
                int count7 = 0;
                for (int j = 2; j < 33; j++)
                {
                    if (s[i, 0] != "" && s[i, j] != "" && CauculateTimes(s[i, j]) > 0)
                    {
                        count7++;
                        if (count7 == 7)
                        {
                            string stradd = s[i, 0] + " 的第 " + (j - 7) + " 天~第 " +(j-1) + " 天已連續上班七天\n";
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
        public string weekly48(string[,] s)
        {
            string str = "";
            for (int i = 0; i < 24; i++)
            {
                for (int j = 2; j < 27; j++)
                {
                    int count48 = 0;
                    for (int k = 0; k < 7; k++)
                        if (s[i, 0] != "" && s[i, j+k] != "" && CauculateTimes(s[i, j+k]) > 0)
                        {
                            count48 += CauculateTimes(s[i, j+k]);
                        }
                    if (count48 > 48)
                    {
                        string stradd = s[i, 0] + " 的第 " + (j - 1) + " 天~第 " + (j + 5) + " 天已超過48小時\n";
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
