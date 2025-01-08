using System;

namespace bai 5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập số nguyên từ 1 đến 7
            Console.Write("Nhập số nguyên từ 1 đến 7: ");
            int soThu = int.Parse(Console.ReadLine());

            // Sử dụng switch để in ra thứ trong tuần tương ứng
            switch (soThu)
            {
                case 1:
                    Console.WriteLine("chu nhat");
                    break;
                case 2:
                    Console.WriteLine("thu hai");
                    break;
                case 3:
                    Console.WriteLine("thu ba");
                    break;
                case 4:
                    Console.WriteLine("Thu tu");
                    break;
                case 5:
                    Console.WriteLine("Thu nam");
                    break;
                case 6:
                    Console.WriteLine("Thu sau");
                    break;
                case 7:
                    Console.WriteLine("Thu bay");
                    break;
                default:
                    Console.WriteLine("Số nhập vào không hợp lệ! Vui lòng nhập số từ 1 đến 7.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
