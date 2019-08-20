using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelNumberTest();
        }

        static void ExcelNumberTest()
        {
            ExcelNumber excel = new ExcelNumber();
            Console.WriteLine(  excel.TitleToNumber("Z"));
            Console.ReadKey();
        }
    }
}
