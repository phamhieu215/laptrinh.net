using System;

namespace CheckPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập số nguyên n
            Console.Write("Nhập số nguyên n: ");
            int n = int.Parse(Console.ReadLine());

            // Kiểm tra nếu n nhỏ hơn 2 thì không phải số nguyên tố
            if (n <= 1)
            {
                Console.WriteLine($"{n} không phải là số nguyên tố.");
                return;
            }

            // Kiểm tra nếu n là số nguyên tố
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) // Nếu có ước số nào trong khoảng từ 2 đến căn bậc hai của n
                {
                    isPrime = false;
                    break;
                }
            }

            // In kết quả
            if (isPrime)
            {
                Console.WriteLine($"{n} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"{n} không phải là số nguyên tố.");
            }
        }
    }
}
