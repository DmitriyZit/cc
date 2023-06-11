/*
Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
Задайте двумерный массив. Найдите элементы, 
у которых оба индекса чётные, и замените эти элементы на их квадраты.
*/

void PrintArray(int[,] matr)
{
    //int[,] matrix = new int[3, 4];
    //matrix[1, 1] = 55;
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
     for (int j = 0; j < 4; j++)
     {
        Console.Write($"{matr[i, j]}");
     }
    Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    //int[,] matrix = new int[3, 4];
    //matrix[1, 1] = 55;
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
         matr[i,j] = new Random().Next(1,10);
        // Console.Write($"{matrix[i, j]}");
        }
    //Console.WriteLine();
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);