using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm8
{
    public  class ClassAlgoritma8
    {
        public static int[] Rotate(int[] x)
        {
            int left=0, right=x.Length-1;

            while (left < right)
            {
                int temp = x[left];
                x[left] = x[right];
                x[right] = temp;

                left++;
                right--;
            }
            return x;

        }
    }
}
