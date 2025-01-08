namespace baith4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bang cuu chuong");
            for(int i =1; i <=9 ; i++)
            {
                Console.WriteLine($"\nBảng cửu chương {i}:");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
            Console.ReadLine();
        }
    }
}
