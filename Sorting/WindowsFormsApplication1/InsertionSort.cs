using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class InsertionSort : SortAlgorithmInterface
    {
        public int[] sort (int[] array)
        {
            //Form1 f = new Form1();
            //f.startstopwatch();

            int k;
            int key;
            for (int i = 1; i < array.Length; i++)
            {
                 key = array[i];
                 k = i;
                while (k > 0 && array[k - 1] > key)
                {

                array[k] = array[k - 1];
                    k = k - 1;
                }

            array[k] = key;
            }

            return array;

        }
    }
}
