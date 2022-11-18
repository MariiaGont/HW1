Console.WriteLine("На вход принимается число и выдаётся, является ли оно чётным.");
Console.WriteLine("Введите число.");

int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 1)
{
    Console.WriteLine("Введённое число не является чётным.");
}
else
{
    Console.WriteLine("Введённое число является чётным.");
}  