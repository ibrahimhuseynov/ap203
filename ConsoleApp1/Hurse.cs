using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Hurse:Animal
    {
       public  static int TotalCount { get=>_totalCount; }
        public static  int _totalCount;
        public Hurse()
        {
            _totalCount++;
        }
        public string Sort { get; set; }   
    }
}
