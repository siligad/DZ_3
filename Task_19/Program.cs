/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
int number;
int first;
int second;
int third;
int fourth;
int fifth;
Console.Write("Введите пятизначное число: ");
number=int.Parse(Console.ReadLine());
if(number>100000 || number<10000)
{
    while (number>100000 || number<10000)
    {
        Console.Write("Вы ввели не пятизначное число, повторите ввод: ");
        number=int.Parse(Console.ReadLine());
    }
}
first=number%10;
second=number/10%10;
//third=number/100%10;
fourth=number/1000%10;
fifth=number/10000%10;
if (first==fifth && second==fourth)
     Console.WriteLine("Да");
     else
     Console.WriteLine("Нет");