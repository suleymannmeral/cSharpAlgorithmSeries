using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csAlgorithm6
{
      public class Alogrithm6
    {
        public string algoritmhm(string text)     
        {
          
           var s = text.Substring(text.Length-1);


            return s+text+s;
        }
    }
}
