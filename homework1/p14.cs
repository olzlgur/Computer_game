using System;
using System.Collections.Generic;
using System.Text;

namespace homework2
{
    class p14
    {
        public static void Main()
        {
            string[] names = {
                                 "홍길동", "김철수", "최하니",
                                 "이길상", "권태기", "장만옥"
                              };
            int[] scores = { 48, 75, 62, 90, 84, 28 };
            int i, j;
            string s;
            for (i = 0; i < 6; i++)
            {
                Console.Write(names[i] + " " + scores[i] + " ");
                for (j = 0; j < scores[i] / 5; j++)
                {
                    Console.Write("*");
                }
                if (scores[i] < 50)
                    s = "조금 부족!";
                else if (scores[i] < 70)
                    s = "보통입니다.";
                else if (scores[i] < 90)
                    s = "잘 했습니다.";
                else
                    s = "매우 잘 했습니다!";
                Console.WriteLine(" " + s);
            }
        }
    }
}

/*
    홍길동 48 ********* 조금 부족!
    김철수 75 *************** 잘 했습니다.
    최하니 62 ************ 보통입니다.
    이길상 90 ****************** 매우 잘 했습니다!
    권태기 84 **************** 잘 했습니다.
    장만옥 28 ***** 조금 부족!
 */