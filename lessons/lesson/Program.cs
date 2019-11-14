using System;
using System.Threading;
using System.Threading.Tasks;

namespace lesson
{
    class Program
    {
      //  static void Main(string[] args)
      //  {
            //int d = 0;
            //int s=0;
            //int a = Convert.ToInt32( Console.ReadLine());
            //for (int i = 1; i <= a; i++)
            //{
                
                  
            //    if (a % i == 0) {
            //        Console.WriteLine(i);
            //        s = s + i;
            //        d = d + 1;
               
            //    }
            //}
            //Console.WriteLine("hamma soni yig'indisi  "+s+"   shuncha son bor "+d );

           // ------------------------------------------------------------------------------------------------------------------------------


            static void Factorial(int n)
            {
                int result = 1;
                for(int i=1;i<=n;i++)
                {
                    result *= i;
                }

                Thread.Sleep(5000);
                Console.WriteLine($"Факториал равен {result}");
            }
            static async void FactorialAsync(int n)
            {
                await Task.Run(() => Factorial(n));
            }
            static void Main(string[] args)
            {
                FactorialAsync(5);
                FactorialAsync(6);
                Console.WriteLine("Некоторая работа");
                Console.Read();
            }



        }
       
    }

