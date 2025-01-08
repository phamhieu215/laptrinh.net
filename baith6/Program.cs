
namespace baith6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("nhap so trong khoang 1 den 100: ");
            number = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("So khong hop le vui long nhap le");
                number = int.Parse(Console.ReadLine());
            }
            while (number < 1 || number > 100);
            Console.WriteLine($"so {number} la hop le");
            Console.ReadLine();
        }
    }
}

