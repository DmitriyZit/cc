/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Write("Введите колличество строк массива : ");
int numrows = Convert.ToInt32(Console.ReadLine());

    
Console.Write("Введите колличество столбцов массива : ");
int numcolum = Convert.ToInt32(Console.ReadLine());

void PrintArray(double[,] matr)
{
    //int[,] matrix = new int[3, 4];
    //matrix[1, 1] = 55;
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
     for (int j = 0; j < matr.GetLength(1); j++)
     {
        //Console.Write($"{matr[i, j]},");
        Console.Write("\t" + matr[i, j].ToString("f2"));
     }
    Console.WriteLine();
    }
}
double[,] FillArray(double[,] matr)
{
    //int[,] matrix = new int[3, 4];
    //matrix[1, 1] = 55;
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
         matr[i,j] = new Random().NextDouble() * 10; //Random().Next(1,10);
        // Console.Write($"{matrix[i, j]},"); numrows, numcolum +1
        //matr[i,j] = Math.Round(matr, 2);
        }
    //Console.WriteLine();
    }
    return matr;
}
double[,] matrix = new double[numrows, numcolum];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

/*Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/


/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Дополнительное:

Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

