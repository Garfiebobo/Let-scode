using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ExcelNumber
    {
        int num = 0;
        public int TitleToNumber(string s)
        {
            char[] charlist = s.ToArray();
            int min = Convert.ToSByte('A');
            int sum = 0;
            for (int i = 0; i < charlist.Length; i++)
            {
                 int current=Convert.ToSByte(charlist[i])+1;
                 sum = sum * 26 + current-min;
            }
            return sum;
        }
    }
}
