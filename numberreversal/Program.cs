using System;

namespace numberreversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem p = new Problem();
            p.reverseNumber(12345);
        }
    }

    class Problem
    {
        public void reverseNumber(int num) // 12345
        {
            int remainder = 0;
            int num1 = num;
            int x = 0;
            int i = 0;
            int r = 0;
            while (num1 > 0)
            {             
                remainder = num1 % 10;
                x = x*10 + remainder ;               
                num1 = num1/ (10);
                i++;
             }
            Console.Write(x);
        }
    }
}
//10 100 1000 10000