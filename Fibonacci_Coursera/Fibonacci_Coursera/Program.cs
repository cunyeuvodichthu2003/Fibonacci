using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Coursera
{
    internal class Program
    {
        static ulong Fibonacci(int n)
        {
            ulong[] number = new ulong[2];
            number[0] = 0;
            number[1] = 1;
            for (int i = 2; i < n; i++) 
            {
                number[1] = number[1] + number[0];
                number[0] = number[1] - number[0];
            }
            return number[1];
        }
        static ulong Fibonacci_Slow(int n)
        {
            if (n == 1)
                return 1;
            if(n==0)
                return 0;
            else 
                return Fibonacci(n-1) + Fibonacci(n-2);
        }
        static void Main(string[] args)
        {
            //TestRun();
            //TestRunLastDigitOfSum();
            Console.WriteLine(LastDigitOfSum(5));
            Console.ReadLine();
            

        }
        static void TestRun()
        {

            while (true)
            {
                Random random = new Random();
                int n = random.Next(2, 100000);
                ulong Fast = Fibonacci(n);
                ulong Slow = Fibonacci_Slow(n);

                Console.WriteLine(n);
                if (Fast == Slow)
                {
                    Console.WriteLine("Ok!!!");
                }
                else
                {
                    Console.WriteLine("Wrong Answear: " + Fast + "&&&&&&" + Slow);
                    Console.ReadLine();
                    break;
                } 
            }
        }
        static void TestRunLastDigit()
        {

            while (true)
            {
                Random random = new Random();
                int n = random.Next(2, 100000);
                char Fast = LastDigit(Fibonacci(n));
                char Slow = LastDigit(Fibonacci_Slow(n));

                Console.WriteLine(n);
                if (Fast == Slow)
                {
                    Console.WriteLine("Ok!!!");
                }
                else
                {
                    Console.WriteLine("Wrong Answear: " + Fast + "&&&&&&" + Slow);
                    Console.ReadLine();
                    break;
                }
            }
        }
        static void TestRunLastDigitOfSum()
        {

            while (true)
            {
                Random random = new Random();
                int n = random.Next(2, 100000);
                int Fast = LastDigitOfSum(n);
                int Slow = LastDigitOfSumSlow(n);

                Console.WriteLine(n);
                if (Fast == Slow)
                {
                    Console.WriteLine("Ok!!!");
                }
                else
                {
                    Console.WriteLine("Wrong Answear: " + Fast + "&&&&&&" + Slow);
                    Console.ReadLine();
                    break;
                }
            }
        }
        static char LastDigit(ulong x)
        {
            return x.ToString().Last();
        }
        static int FiboModulo(ulong x,int m)
        {
            return (int)x % m;
        }
        static int LastDigitOfSum(int n)
        {
            int sum = 1;
            for (int i = 2;i<n;i++)
            {
                sum = sum + (LastDigit(Fibonacci(n)) - '0');
            }
            if (n == 0)
                sum = 0;
            return sum;
        }
        static int LastDigitOfSumSlow(int n)
        {
            int sum = 1;
            for (int i = 2; i < n; i++)
            {
                sum = sum + (LastDigit(Fibonacci_Slow(n)) - '0');
            }
            if (n == 0)
                sum = 0;
            return sum;
        }
    }
}
