using System;
namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write(" nhap a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write(" nhap b =");
            b = int.Parse(Console.ReadLine());
            if (a == 0 && b == 0)
            {
                Console.WriteLine("phuong trinh vo so nghiem");
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine("phuong trinh vo nghiem");
            }
            else
            {
                double x = -(double)b / a; // Ép kiểu để chia ra số thực
                Console.WriteLine($"Phương trình có nghiệm x = {x}");

            }
        }
    }
}
