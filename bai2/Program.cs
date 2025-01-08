using System;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("chieu dai hcn la: ");
            double a = NhapSoThucDuong();
            Console.Write("chieu rong hcn: ");
            double b = NhapSoThucDuong();

            double chuVi = (a + b) * 2;
            double dienTich = a * b;

            Console.WriteLine($"Chu vi hcn la: {chuVi}");
            Console.WriteLine($"Dien tich hcn la: {dienTich}");
        }

        static double NhapSoThucDuong()
        {
            double number;
            number=double.Parse( Console.ReadLine() );
            while (true) // Lặp đến khi nhập đúng
            {
                if ( number > 0)
                {
                    return number; // Trả về số nếu hợp lệ
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập một số thực dương!");
                    Console.Write("Nhập lại: ");
                }
            }
        }
    }
}