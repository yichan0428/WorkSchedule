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
        public string TotalCheck(string[,] s,bool a,bool b,bool c,int day1value, int day31value, int previousbound,int thisbound)
        {
            if (a == true)
                daily10(s, thisbound);
            if (b == true)
                weekly7(s, previousbound,thisbound);
            if (c == true)
                weekly48(s,day1value, previousbound,thisbound);
            if (TotalStr == "")
                return "均符合勞健保";
            else
                return TotalStr;
        }
        public double CauculateTimes(string str)
        {

            try
            {
                str += "/0/0";  //gurantee value2 is exist
                string[] strArray = str.Split(new char[2] { '-', '/' });
                Double Value1 = Convert.ToDouble(strArray[1]) - Convert.ToDouble(strArray[0]);
                Double Value2 = Convert.ToDouble(strArray[3]) - Convert.ToDouble(strArray[2]);
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
        public string daily10(string[,] s, int thisbound)
        {
            string str = "";
            bool IsTrue = false;
            for (int i = 0; i < 24; i++)
            {
                string stradd = "";
                bool Isdaily10 = false;
                for (int j = 8; j < thisbound + 8; j++)
                {

                    if (s[i, 0] != "" && s[i, j] != "" && CauculateTimes(s[i, j]) > 10)
                    {
                        
                        
                        if (IsTrue == false)
                        {
                            IsTrue = true;
                            str += "------------違反【一日不得超過 10 小時】-----------\n";
                        }
                        if (Isdaily10 == false)
                        {
                            Isdaily10 = true;
                            stradd = s[i, 0] + " ： 第 " + (j - 7);
                        }
                        else
                        {
                            stradd += "、" + (j - 7);
                        }
                    }
                }
                if (s[i, 0] != "" && Isdaily10 == true)
                {
                    stradd += " 日\n";
                }
                str += stradd;
            }
            TotalStr += str;
            return str;
        }
        public string weekly7(string[,] s,int previousbound, int thisbound)
        {
            string str = "";
            bool IsTrue = false;
            for (int i = 0; i < 24; i++)
            {             
                int count7 = 0;
                for (int j = 2; j < 45; j++)
                {
                    if (s[i, 0] != "" && s[i, j] != "" && CauculateTimes(s[i, j]) > 0)
                    {
                        count7++;
                        if (count7 == 7)
                        {
                            if (IsTrue == false)
                            {
                                IsTrue = true;
                                str += "\n-------------違反【不得連續上班七日】--------------\n";
                            }
                            
                            string stradd;
                            if (j - 13 <= 0)
                            {
                                stradd = s[i, 0] + " : 上個月第 " + (j - 13 + previousbound) + " 日 ~ 第 " + (j - 7) + " 日\n";
                            }
                            else if (j - 13 > thisbound)
                            {
                                stradd = "";
                            }
                            else if (j - 7 > thisbound)
                            {
                                stradd = s[i, 0] + " ： 第 " + (j - 13) + " 天 ~ 下個月第 " + (j - 7 - thisbound) + " 日\n";
                            }
                            else
                            {
                                stradd = s[i, 0] + " ： 第 " + (j - 13) + "  ~  " + (j - 7) + " 日\n";
                            }
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
        public string weekly48(string[,] s, int day1value,int previousbound, int thisbound)
        {
            string str = "";
            int IsTrue = 0;
            for (int i = 0; i < 24; i++)
            {
                for (int j = 8-(day1value-1); j < thisbound + 8; j+=7)
                {
                    double count48 = 0;
                    for (int k = 0; k < 7; k++)
                        if (s[i, 0] != "" && s[i, j+k] != "" && CauculateTimes(s[i, j+k]) > 0)
                        {
                            count48 += CauculateTimes(s[i, j+k]);
                        }
                    if (count48 > 48)
                    {
                        if (IsTrue == 0)
                        {
                            IsTrue++;
                            str += "\n------違反【一周 (一 ~ 日) 不得超過 48 小時】------\n";
                        }
                        string stradd;
                        if (j - 7 <= 0)
                        {
                            stradd = s[i, 0] + " ： 上個月第 " + (j - 7 + previousbound) + " 日 ~ 第 " + (j - 1) + " 日\n";
                        }
                        
                        else if (j - 1 > thisbound)
                        {
                            stradd = s[i, 0] + " ： 第 " + (j - 7) + " 天 ~ 下個月第 " + (j - 1 - thisbound) + " 日\n";
                        }
                        else
                        {
                            stradd = s[i, 0] + " ： 第 " + (j - 7) + "  ~  " + (j - 1) + " 日\n";
                        }
                            
                        str += stradd;
                    }

                }
            }
            TotalStr += str;
            return str;
        }
        // 
        //version : check weekly48 in any consecutive 7 days
        //
        //public string weekly48(string[,] s)
        //{
        //    string str = "";
        //    for (int i = 0; i < 24; i++)
        //    {
        //        for (int j = 2; j < 27; j++)
        //        {
        //            double count48 = 0;
        //            for (int k = 0; k < 7; k++)
        //                if (s[i, 0] != "" && s[i, j + k] != "" && CauculateTimes(s[i, j + k]) > 0)
        //                {
        //                    count48 += CauculateTimes(s[i, j + k]);
        //                }
        //            if (count48 > 48)
        //            {
        //                string stradd = s[i, 0] + " 的第 " + (j - 1) + " 天~第 " + (j + 5) + " 天已超過48小時\n";
        //                str += stradd;
        //            }

        //        }
        //    }
        //    TotalStr += str;
        //    return str;
        //}

        private string TotalStr;
        
    }
}
