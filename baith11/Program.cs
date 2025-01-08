using System;
using System.IO;

namespace baith11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Đọc file văn bản có sẵn
            string inputFilePath = "input.txt";  // Đường dẫn tới file đầu vào
            string outputFilePath = "output.txt";  // Đường dẫn tới file đầu ra

            try
            {
                // Kiểm tra xem file đầu vào có tồn tại không
                if (!File.Exists(inputFilePath))
                {
                    Console.WriteLine("File không tồn tại.");
                    return;
                }

                // Đọc nội dung của file đầu vào
                string fileContent = File.ReadAllText(inputFilePath);

                // Chuyển nội dung thành chữ hoa
                string upperCaseContent = fileContent.ToUpper();

                // Ghi nội dung chữ hoa vào file đầu ra
                File.WriteAllText(outputFilePath, upperCaseContent);

                // Đếm số từ trong nội dung
                int wordCount = CountWords(fileContent);

                // Chèn số lượng từ vào cuối file văn bản chữ hoa
                File.AppendAllText(outputFilePath, $"\nSố từ trong file: {wordCount}");

                // Thông báo hoàn tất
                Console.WriteLine("Chương trình đã thực hiện xong!");
                Console.WriteLine($"File chữ hoa đã được lưu tại: {outputFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        // Hàm đếm số từ trong nội dung
        static int CountWords(string text)
        {
            // Tách nội dung thành mảng từ và đếm số từ
            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}

