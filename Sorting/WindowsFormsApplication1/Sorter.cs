using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Sorter
    {
       public  SortAlgorithmInterface strategy { get; set; }
        public  Sorter (SortAlgorithmInterface s)
        {
            strategy = s;
        }
        public int[] sort(int[] array)
        {
            return strategy.sort(array);
        }
    }
}
