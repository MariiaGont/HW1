Console.WriteLine("Введите положительное число.");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (number > 0)
{
    if (count < number)
    {
        Console.Write(count + " ");
        count = count + 2;
    }
}
if (number < 0)
{
    Console.WriteLine("Введённое число не является положительным.");
}

