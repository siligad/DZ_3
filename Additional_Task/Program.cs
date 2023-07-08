/*
Модифицировать программу из 19 задания и сделать так, чтобы проверялись не только цифры, но и строчки.
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
string SomeSymbols;
Console.Write("Введите пять символов: ");
SomeSymbols = Console.ReadLine();
if (SomeSymbols.Length != 5)
    while(SomeSymbols.Length != 5)
    {
        Console.Write("Вы не ввели 5 символов, повторите ввод: ");
        SomeSymbols = Console.ReadLine();
    }
if (SomeSymbols[0] == SomeSymbols[4] && SomeSymbols[1] == SomeSymbols[3])
    Console.Write("Введённая последовательность полином");
    else
    Console.Write("Введённая последовательность не полином");