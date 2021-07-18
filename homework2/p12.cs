using System;
using System.Collections.Generic;
using System.Text;

namespace homework2
{
    class p12
    {
        public static void Main()
        {
            int a;
            for (a = 5; a <= 8; a++)
            {
                Console.Write(a + " / 3 = " + a / 3);
                switch (a % 3)
                {
                    case 1:
                        Console.WriteLine(" : 나머지는 1입니다.");
                        break;
                    case 2:
                        Console.WriteLine(" : 나머지는 2입니다.");
                        break;
                    default:
                        Console.WriteLine(" : 나머지는 0입니다.");
                        break;
                }
            }
        }

    }
}

// 결과
/*
    5 / 3 = 1 : 나머지는 2입니다.
    6 / 3 = 2 : 나머지는 0입니다.
    7 / 3 = 2 : 나머지는 1입니다.
    8 / 3 = 2 : 나머지는 2입니다. 
*/