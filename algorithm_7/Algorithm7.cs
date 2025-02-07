using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestIntegersAmongThree
{
    public  class Algorithm7
    {
        public  int FindTheLargestNumber(int x, int y, int z)
        {
            int maxNumber = Math.Max(x,Math.Max(y,z));


            return maxNumber;
        }

    }
}
