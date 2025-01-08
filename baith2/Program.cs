using System;
using System.Collections.Generic;


namespace baith2
{

    namespace TachDay
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                // Khai báo các danh sách để lưu trữ số chẵn và số lẻ
                List<int> evenNumbers = new List<int>();    // Dãy số chẵn
                List<int> oddNumbers = new List<int>();     // Dãy số lẻ

                // Nhập dãy số từ bàn phím
                Console.WriteLine("Nhập một chuỗi các số nguyên cách nhau bởi dấu cách: ");
                string input = Console.ReadLine();

                // Kiểm tra nếu người dùng không nhập gì
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Không có dữ liệu nhập vào.");
                    return; // Thoát nếu không có dữ liệu
                }

                // Tách chuỗi nhập vào thành các phần tử
                string[] numbers = input.Split(' ');

                // Duyệt qua từng phần tử để phân loại số chẵn và số lẻ
                foreach (var numStr in numbers)
                {
                    if (string.IsNullOrWhiteSpace(numStr)) continue; // Bỏ qua phần tử trống

                    try
                    {
                        int number = int.Parse(numStr); // Chuyển chuỗi thành số nguyên

                        // Phân loại số chẵn và số lẻ
                        if (number % 2 == 0)
                        {
                            evenNumbers.Add(number); // Số chẵn
                        }
                        else
                        {
                            oddNumbers.Add(number); // Số lẻ
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"'{numStr}' không phải là số nguyên hợp lệ.");
                    }
                }

                // In ra dãy số chẵn
                Console.WriteLine("Dãy số chẵn:");
                foreach (var num in evenNumbers)
                {
                    Console.Write(num + " ");
                }

                // In ra dãy số lẻ
                Console.WriteLine("\nDãy số lẻ:");
                foreach (var num in oddNumbers)
                {
                    Console.Write(num + " ");
                }
                Console.ReadLine();
            }
        }
    }
}
