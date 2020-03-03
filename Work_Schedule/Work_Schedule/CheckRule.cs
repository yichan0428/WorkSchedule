using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Schedule
{
    class CheckRule
    {
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
        public string daily8(object[,] array)
            {
            string str = "";
                for (int i = 0; i < 12 ;i++)
                {
                    for (int j = 2; j <= 16; j++)
                    {

                            if (array[i, 0] != null && array[i, j] != null && CauculateTimes(array[i, j].ToString()) > 8)
                            {
                                string stradd = array[i, 0].ToString() + " 的第 " + (j - 1) + "天超過八小時\n";
                                str += stradd;
                            }
                        
                    }
                }
            if (str == "")
                return "均符合勞健保";
            else
                return str;
            }
        public bool weekly7(string[] str)
        {
            int count7 = 0;
            for (int i = 0; i < 15; i++)
            {
                if (CauculateTimes(str[i]) > 0)
                {
                    count7++;
                    if (count7 == 7)
                    {
                        return true;
                    }
                }
            }
            
            return true;
        } 
    }
}
