﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Rec(int number)
{
    int i = 1;
    if (i > number) return i;
    Console.WriteLine(number);
    number--;
    return Rec(number);
}
Rec(number);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int SumFromMtoN(int numberM, int numberN)
{
    if (numberM == numberN) return 0;
    return numberN += SumFromMtoN(numberM, numberN - 1);
}
int sum = SumFromMtoN(numberM - 1, numberN);
Console.WriteLine($"Сумма элементов в промежутке от {numberM} до {numberN} = {sum}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29