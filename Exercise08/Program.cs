Console.WriteLine("На вход принимается положительное число, и выдаются все чётные числа от 1 до введённого числа.");
Console.WriteLine("Введите положительное число.");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (count < number)
{
    Console.Write(count + " ");
    count = count + 2;
}
if (number < 0)
{
    Console.WriteLine("Введённое число не является положительным.");
}