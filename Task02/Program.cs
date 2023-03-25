 //программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Enter first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"Первое число больше {num1}");
    Console.WriteLine($"Второе число меньше {num2}");
}
else
{
    Console.WriteLine($"Второе число больше {num2}");
    Console.WriteLine($"Первое число меньше {num1}");
}