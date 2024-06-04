using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num = random.Next(-100, 101);
            int guess = 0;
            int count = 10;
            while (count > 0)
            {
                Console.Write("数字を当ててください（-100から100まで）、残り{0}回のチャンス", count);
                try
                {
                    guess = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("不正な数値が入力されました");
                }
                if (guess < num)
                {
                    Console.WriteLine("ヒント:もっと大きな数");
                    count--;
                }
                else if (guess > num)
                {
                    Console.WriteLine("ヒント：もっと小さな数");
                    count--;
                }
                else 
                {
                    Console.WriteLine("正解!");
                    count = -1;
                    //Console.ReadKey();
                }
            }
            if (count == 0)
            {
                Console.WriteLine("残る0回、負けました。正しい数は{0}でした", num);
            }

            Console.Write("\nPress any key to exit... ");
            Console.ReadKey();

        }
    }
}
