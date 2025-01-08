using System;
namespace baith3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string pt;
            Console.Write("a = ");
            a=double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b=double.Parse(Console.ReadLine());
            Console.Write("nhap phep toan: ");
            pt =Console.ReadLine();
            switch (pt)
            {
                case "+":
                    Console.WriteLine("{0}+{1}= {2}", a, b, a + b);
                    break;
                case "-":
                    Console.WriteLine("{0}-{1}= {2}", a, b, a - b);
                    break;
                case "*":
                    Console.WriteLine("{0}*{1}= {2}", a, b, a * b);
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("phep chia khong thuc hien duoc");
                    }
                    else
                    {
                        Console.WriteLine("{0}/{1}= {2}", a, b, a / b);
                    }
                    break;
                default:
                         Console.WriteLine("khong co phep tinh");
                        break;
            }
            Console.ReadLine();
        }
            
    }
}
