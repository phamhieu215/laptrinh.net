using System;
namespace baith9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập chuỗi từ người dùng
            Console.Write("Nhập vào một chuỗi ký tự: ");
            string input = Console.ReadLine();

            // Kiểm tra tính đối xứng của chuỗi
            if (IsPalindrome(input))
            {
                Console.WriteLine("Chuỗi bạn nhập là đối xứng.");
            }
            else
            {
                Console.WriteLine("Chuỗi bạn nhập không phải là đối xứng.");
            }
        }

        // Phương thức kiểm tra chuỗi đối xứng (palindrome)
        static bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false; // Nếu có ký tự không giống nhau thì không phải đối xứng
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
