using System;
using System.Collections.Generic;
using System.Text;

namespace homework1
{
    class p8
    {
        enum Animal{ mouse, cat, bird, dog = 100, koala, pig = 200, lion };
        public static void Main()
        {
            Animal a;
            a = Animal.dog;
            Console.WriteLine(Animal.cat);
            Console.WriteLine((int)Animal.dog);
            Console.WriteLine((int)Animal.lion);
            Console.WriteLine(a);
        }

    }
}

// 결과
// cat
// 100
// 201
// dog