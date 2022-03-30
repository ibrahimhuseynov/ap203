using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Sheep:Animal 
    {
        static int _totalcount;
        public static int TotalCount { get => _totalcount; }     
        public Sheep()
        {
            _totalcount++;  
        }
        public static void  GetInfo()
        {
            Console.WriteLine(TotalCount);
        }

    }
}
