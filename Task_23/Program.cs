/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int end, i;
Console.WriteLine("Приветствую в программе, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.Write("Введите конечное число N: ");
end = int.Parse(Console.ReadLine());
Console.WriteLine("Таблица кубов чисел от 1 до N.");
for (i = 1; i <= end; i++)
{
    if (i % 5==0)
    Console.WriteLine($"{Math.Pow(i, 3)}");
    else
    Console.Write($"{Math.Pow(i, 3)}      ");
}