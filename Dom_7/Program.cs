/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9


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
        Console.Write("\t" + matr[i, j].ToString("f1"));
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
         matr[i,j] = new Random().Nextint() * 10; //Random().Next(1,10);
        // Console.Write($"{matrix[i, j]},"); numrows, numcolum +1
        //matr[i,j] = Math.Round(matr, 2);
        }
    //Console.WriteLine();
    }
    return matr;
}
int[,] matrix = new int[numrows, numcolum];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

*/

/*Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет


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
         matr[i,j] = new Random().Next(1 , 100); //Random().Next(1,10);
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

    int x = 0;
    //int y = 0;
    Console.Write("Введите координаты по строке : ");
    int х = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координаты по столбцу : ");
    int y = Convert.ToInt32(Console.ReadLine());

    if (x <= numrows && y <= numcolum)
    {
        Console.WriteLine("такое число есть и оно равно  " + matrix[x,y]);
    }
     else           
        Console.WriteLine("такого числа нет");
    
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

Console.Write("Введите колличество строк массива : ");
int numrows = Convert.ToInt32(Console.ReadLine());

    
Console.Write("Введите колличество столбцов массива : ");
int numcolum = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[,] matr)
{
    
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
     for (int j = 0; j < matr.GetLength(1); j++)
     {
        
        Console.Write("\t" + matr[i, j]);
        
     }
    Console.WriteLine();
    }
}

int[,] FillArray(int[,] matr)
{
   
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
         matr[i,j] = new Random().Next(1 , 10); //Random().Next(1,10);
       
        }
    //Console.WriteLine();
    }
    return matr;
}
  
    
    int[,] matrix = new int[numrows, numcolum];
    

   
    void Average()
{ 
    int sum = 0;
    for (int j = 0; j < numcolum; j++)
    {
       sum = 0;
    
    
        for (int i = 0; i < numrows; i++)
        {
            sum = sum + matrix[i,j];

            
              
           
        }
        Console.WriteLine( $"Среднее арифмитическое столбца {j} = {Math.Round( (double) sum / numrows , 1)} "); 
     
    }   
    
    
    
 }
    //Average();

    //int sum = 0;
    //int j = 0;

    void Dioganal()
    { 
        int sum = 0;
        int j = 0;
    
             for (int i = 0; i < numrows; i++)
            {
              sum = sum + matrix[i,j];
            

              j = j + 1;
            }
            Console.WriteLine();
             Console.WriteLine ($"Сумма по диагонали = {sum} ");
    }

    FillArray(matrix);
    Console.WriteLine();
    PrintArray(matrix);
    Average();
    Dioganal();
    
    