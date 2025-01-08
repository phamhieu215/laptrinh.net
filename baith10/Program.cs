using System;
using System.Collections.Generic;

namespace baith10

{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo List chứa các số thực
            List<double> numbers = new List<double>();

            // Nhập vào 5 số thực từ bàn phím
            Console.WriteLine("Nhập vào 5 số thực:");
            for (int i = 0; i < 5; i++)
            {
                double number;
                string input;
                bool isValid;
                do
                {
                    Console.Write($"Nhập số thứ {i + 1}: ");
                    input = Console.ReadLine();
                    isValid = double.TryParse(input, out number);

                    if (!isValid)
                    {
                        Console.WriteLine("Vui lòng nhập một số thực hợp lệ.");
                    }
                }
                while (!isValid);

                numbers.Add(number);
            }

            // Sắp xếp danh sách theo thứ tự tăng dần
            numbers.Sort();

            // In ra danh sách đã sắp xếp
            Console.WriteLine("\nDanh sách sau khi sắp xếp:");
            PrintList(numbers);

            // Kiểm tra và xóa các số âm trong danh sách
            numbers.RemoveAll(n => n < 0);

            // In ra danh sách sau khi xóa các số âm
            Console.WriteLine("\nDanh sách sau khi xóa các số âm:");
            PrintList(numbers);

            // Nhập số x bất kỳ và chèn vào vị trí đúng thứ tự
            Console.Write("\nNhập một số x bất kỳ để chèn vào danh sách: ");
            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Vui lòng nhập một số thực hợp lệ.");
            }

            // Chèn số x vào đúng vị trí thứ tự
            int insertIndex = numbers.BinarySearch(x);
            if (insertIndex < 0) insertIndex = ~insertIndex; // Lấy vị trí đúng nếu không tìm thấy

            numbers.Insert(insertIndex, x);

            // In ra danh sách sau khi chèn số x
            Console.WriteLine("\nDanh sách sau khi chèn số x:");
            PrintList(numbers);
        }

        // Hàm in ra danh sách
        static void PrintList(List<double> list)
        {
            foreach (var number in list)
            {
                Console.WriteLine(number);
            }
        }
    }
}

