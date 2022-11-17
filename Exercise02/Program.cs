Console.WriteLine("На вход принимается два числа и выдаётся, какое число большее, а какое меньшее.");
Console.WriteLine("Введите первое число.");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число.");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if (numberFirst > numberSecond)
{
    Console.WriteLine(numberFirst);
}
else
{
    Console.WriteLine(numberSecond);
}