﻿//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.Clear();

Console.WriteLine("Введитк число");
int a = int.Parse(Console.ReadLine()!);
for (int i = 0; i <= a; i += 2)
{
    Console.WriteLine(i);
}
