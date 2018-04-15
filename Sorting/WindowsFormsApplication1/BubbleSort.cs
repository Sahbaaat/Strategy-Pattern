using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class BubbleSort : SortAlgorithmInterface
    {
        public  int[] sort(int[] array)
        {
            int temp;
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = n-1; j > i ; j--)
                    if (array[j] < array[j - 1])
                    {
                        temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
            return array;
        }
    }
}
