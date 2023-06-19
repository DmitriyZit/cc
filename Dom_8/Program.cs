/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Write("Введите колличество строк массива : ");
int numrows = Convert.ToInt32(Console.ReadLine());

    
Console.Write("Введите колличество столбцов массива : ");
int numcolum = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[,] matr)
{
    //int[,] matrix = new int[3, 4];
    //matrix[1, 1] = 55;
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
     for (int j = 0; j < matr.GetLength(1); j++)
     {
        //Console.Write($"{matr[i, j]},");
        Console.Write("\t" + matr[i, j]);
        //.ToString("f1")
     }
    Console.WriteLine();
    }
}

int[,] FillArray(int[,] matr)
{
    //int[,] matrix = new int[3, 4];
    //matrix[1, 1] = 55;
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
         matr[i,j] = new Random().Next(10 , 10); //Random().Next(1,10);
        // Console.Write($"{matrix[i, j]},"); numrows, numcolum +1
        //matr[i,j] = Math.Round(matr, 2);
        }
    //Console.WriteLine();
    }
    return matr;
}
    int[,] matrix = new int[numrows, numcolum];
    //PrintArray(matrix);
    FillArray(matrix);
    Console.WriteLine();
    PrintArray(matrix);

    // int x = 0;
    // //int y = 0;
    // Console.Write("Введите координаты по строке : ");
    // int х = Convert.ToInt32(Console.ReadLine());

    // Console.Write("Введите координаты по столбцу : ");
    // int y = Convert.ToInt32(Console.ReadLine());

    // if (x <= numrows && y <= numcolum)
    // {
    //     Console.WriteLine("такое число есть и оно равно  " + matrix[x,y]);
    // }
    //  else           
    //     Console.WriteLine("такого числа нет");

      void Replase()
    {
        
        for (int i = 2; i < numrows; i+=2)
        {
                    
             for(int j = 2; j < numcolum; j = j+2)
            {
             matrix[i,j] =  (int)Math.Pow(matrix[i,j] , 2);//[i,j] * matrix[i,j];
            }   
        }
        Console.WriteLine();
         PrintArray(matrix);
    }
    Replase();
    



/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/





/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/




/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)


ДОПОЛНИТЕЛЬНАЯ. Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

Начиная с этого урока, учитывается чистота программного кода (именования методов и переменных в нужных стилях, нет "A" и прочего индусского кода).
Имя отражает суть переменной или метода
*/


