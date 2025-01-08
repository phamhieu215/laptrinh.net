// See https://aka.ms/new-console-template for more information
int n;
Console.Write(" n: ");
n=int.Parse(Console.ReadLine());
// Kiểm tra n là số chẵn hay số lẻ
if (n % 2 == 0)
{
    Console.WriteLine($"{n} la so chan.");
}
else
{
    Console.WriteLine($"{n} la so le.");
}

// Kiểm tra n là số âm hay không âm
if (n >= 0)
{
    Console.WriteLine($"{n} la so khong am.");
}
else
{
    Console.WriteLine($" {n} la so am.");
}
        