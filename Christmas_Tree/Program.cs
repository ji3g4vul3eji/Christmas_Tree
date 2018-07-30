using System;


namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入目標層數");
            int n = int.Parse(Console.ReadLine());
            int space, star;
            for (int height = 1; height <= n; height++)                    //目標層數
            {
                for (space = n; space - height > 0; space--)             //空格數=總層數-第n層
                {
                    Console.Write(" ");
                }
                for (star = 1; star <= height * 2 - 1; star++)              //星星數=層數*2-1
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

