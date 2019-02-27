using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexatorApp
{
    public class IndexArr
    {
        private int[] arr;
        public static int lenght = 5;

        public IndexArr()
        {
            arr = new int[lenght];
        }

        public int this[int index]
        {
            get
            {
                return arr[index];
            }

            set
            {
                arr[index] = value * value;
            }
        }

    }
}
