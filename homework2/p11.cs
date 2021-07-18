using System;
using System.Collections.Generic;
using System.Text;

namespace homework2
{
    class p11
    {
        public static void Main()
        {
            int a, b = 1;
            for (a = 0; a < 4; a++)
            {
                if (a + b == 2)
                    continue;
                Console.WriteLine(a + " + " + b + " = " + (a + b));
            }
        }

    }
}

// 결과
/*
    0 + 1 = 1
    2 + 1 = 3
    3 + 1 = 4
 */