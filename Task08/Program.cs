﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Enter  number N:");
int numberN = Convert.ToInt32(Console.ReadLine());
// int count = 2;
//  while (count <= numberN)
//  {
//      Console.Write($"{count} ");
//      count += 2;
//  }
for (int count = 2; count <= numberN; count+=2)
{
    Console.Write($"{count} ");
}