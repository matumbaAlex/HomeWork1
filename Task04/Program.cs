
Console.Write("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;

// if(num2>max) max = num2;
// if(num3>max) max = num3;
// Console.Write($"{max} число большее");

if(num1>num2 && num1>num3) Console.Write($"{num1} число большее");
if(num2>num1 && num2>num3) Console.Write($"{num2} число большее");
if(num3>num1 && num3>num2) Console.Write($"{num3} число большее");
