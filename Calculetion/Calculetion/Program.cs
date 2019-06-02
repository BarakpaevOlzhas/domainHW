using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculetion
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = 1;

            for (int i = 1;i < 100001; i++)
            {
                num = num * i;
            }                        
        }
    }
}
