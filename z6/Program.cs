﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("Напишите первое число");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0)
    Console.Write ("да");
else
    Console.Write ("Нет");

