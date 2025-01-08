using System;

namespace BaiTap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap bac luong (BacLuong): ");
            double bacLuong = double.Parse(Console.ReadLine());

            Console.Write("Nhap ngay cong (NgayCong): ");
            int ngayCong = int.Parse(Console.ReadLine());

            Console.Write("Nhap phu cap (PhuCap): ");
            double phuCap = double.Parse(Console.ReadLine());

            // Tính NCTL
            int nctl;
            if (ngayCong < 25)
            {
                nctl = ngayCong;
            }
            else
            {
                nctl = 25 + (ngayCong - 25) * 2;
            }

            // Tính tiền thực lĩnh
            double tienLinh = bacLuong * 1490000 * nctl + phuCap;

            // Hiển thị kết quả
            Console.WriteLine($"Tien thuc linh (TienLinh): {tienLinh:N0} VND");
        }
    }
}
