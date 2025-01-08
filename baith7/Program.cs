using System.Reflection.Metadata;

namespace baith7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            while (true)
            {
                Console.Write("Nhập cạnh a: ");
                if (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập một số nguyên.");
                    continue; // Yêu cầu nhập lại
                }

                Console.Write("Nhập cạnh b: ");
                if (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập một số nguyên.");
                    continue; // Yêu cầu nhập lại
                }

                Console.Write("Nhập cạnh c: ");
                if (!int.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập một số nguyên.");
                    continue; // Yêu cầu nhập lại
                }
                if (a + b > c && a + c > b && c + b > a)
                {
                    int chuVi = a + b + c;
                    double s = (a + b + c) / 2.0;
                    double dienTich = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                    Console.WriteLine($"chu vi tam giac la : {chuVi}");
                    Console.WriteLine($"dien tich tam giac la: {dienTich:f3}");
                }
                else
                {
                    Console.WriteLine("3 canh khong phai 3 canh tam giac");
                }
            }
            
            Console.ReadLine();


        }
    }
}
