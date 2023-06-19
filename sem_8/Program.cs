// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Write("Введите колличество строк массива : ");
int numrows = Convert.ToInt32(Console.ReadLine());

    
Console.Write("Введите колличество столбцов массива : ");
int numcolum = Convert.ToInt32(Console.ReadLine());

if (numrows!= numcolum)
{
    Console.WriteLine("Error");
    return;
}


void PrintArray(int[,] matr)
{
    
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
     for (int j = 0; j < matr.GetLength(1); j++)
     {
        
        Console.Write("\t" + matr[i, j].ToString("f1"));
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

// меняем строку 1 на последнюю
// void ChangeString(int[,] matr)
// {
//     int lastString = matr.GetLength(0) -1;
//     for (int i = 0; i < matr.GetLength(1); i++)
//     {
//         int temp = matr[0,i];
//         matr[0,i] = matr[lastString, i];
//         matr[lastString, i] = temp;
//     }
// }

void ColumnsPerRow(int[,] matr) // int [,] ColumnsPerRow(int[,] matr)
    // int j = 0;
{
    int[,] matrixx = new int[matr.GetLength(0) ,matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matrixx[i,j] = matr[j,i];
        }
    }
      
       //Console.WriteLine();
       PrintArray(matrixx);
//return matrixx;
}

int[,] matrix = new int[numrows, numcolum];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine("Исходная матрица");
PrintArray(matrix);
Console.WriteLine("Перевернутая матрица");
//ChangeString(matrix);
ColumnsPerRow(matrix);
//PrintArray(ColumnsPerRow(matrix));
//PrintArray(matrix);
//ChangeLines( matrix);