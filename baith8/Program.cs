using System;
using System.Reflection.Metadata;
namespace baith8
    {
        class Program
        {
            static void Main(string[] args)
            {
            // Nhập kích thước mảng
                int n;
                Console.Write("Nhập số lượng phần tử của mảng: ");
                n = int.Parse(Console.ReadLine());

                // Khởi tạo mảng số nguyên
                int[] arr = new int[n];

                // Nhập các phần tử vào mảng
                Console.WriteLine("Nhập các phần tử của mảng:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhập phần tử thứ {i + 1}: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                // Tính tổng các phần tử lẻ trong mảng
                int sum = 0;
                foreach (var item in arr)
                {
                    if (item % 2 != 0)  // Kiểm tra nếu phần tử là số lẻ
                    {
                        sum += item;
                    }
                }

                // In ra tổng các phần tử lẻ
                Console.WriteLine($"Tổng các phần tử lẻ trong mảng là: {sum}");
            }
        }
    }


