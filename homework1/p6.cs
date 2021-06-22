using System;
using System.Collections.Generic;
using System.Text;

namespace homework1
{
    class p6
    {
        public static void Main()
        {
            int[,] a = { { 10, 20 }, { 30, 40 }, { 50, 60 } };
            a[1, 1] = 0;
            Console.WriteLine(a[1, 0]);
        }
    }

}

// 결과
// 30