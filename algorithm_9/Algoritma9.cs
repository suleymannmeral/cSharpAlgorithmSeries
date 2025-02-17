using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_9
{
    public class Algoritma9
    {
        public string Algorithm9(string text)
        {
            string threeCopy = $"{text[0]}{text[1]}";
            return String.Concat(Enumerable.Repeat(threeCopy, 3));
           

        }

    }
}
