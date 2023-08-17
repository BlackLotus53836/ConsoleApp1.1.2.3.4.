int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Первое число больше второго.");
    Console.WriteLine("Второе число меньше первого.");
}
else if (num1 < num2)
{
    Console.WriteLine("Второе число больше первого.");
    Console.WriteLine("Первое число меньше второго.");
}
else
{
    Console.WriteLine("Числа равны.");
}

