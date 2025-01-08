namespace baith5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("nhap vao mot so trong khoang 1 den 100: ");
            number=int.Parse(Console.ReadLine());
            while (number < 1 || number > 100)
            {
                Console.WriteLine("so nhap khong hop le vui long nhap lai:");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"so {number} la hop le");
            Console.ReadLine();
        }
    }
}
