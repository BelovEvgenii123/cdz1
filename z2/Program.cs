﻿Console.Clear();
Console.WriteLine("Напишите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int b = int.Parse(Console.ReadLine());
while (a==b)
{
   Console.WriteLine("Числа равны, Введите заново") ;
Console.WriteLine("Напишите первое число");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число");
b = int.Parse(Console.ReadLine());
}
if (a>=b)
{
Console.Write("max="+ a);
Console.Write("min="+ b);
}
else 
Console.Write("max="+ b);
Console.Write("mmin="+ a);