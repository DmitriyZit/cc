﻿// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
Console.Write("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());

string GetNunbersString(int start, int end)
{
    if(start == 1) return start.ToString();
    return start + ", " + GetNunbersString(start - 1, end);

}
Console.WriteLine(GetNunbersString(n, 1));
*/

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
Console.Write("Введите число : ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());

int SumWithin(int start, int end)
{
    if(start == end) return start;
    return start + SumWithin(start + 1 , end);
}
Console.WriteLine(SumWithin(m , n));
*/

// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число : ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());


int Akkermann(int m, int n)
 {
            
            if (m == 0)
                return n + 1;
            if (n == 0)
                return Akkermann(m - 1, 1);
            return Akkermann(m - 1, Akkermann(m, n - 1));
}
Console.WriteLine(Akkermann(m , n));