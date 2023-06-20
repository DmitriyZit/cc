// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

/*Console.Write("Введите колличество строк массива : ");
int numrows = Convert.ToInt32(Console.ReadLine());

    
Console.Write("Введите колличество столбцов массива : ");
int numcolum = Convert.ToInt32(Console.ReadLine());

if (numrows!= numcolum) //проверяем массив что бвы он был квадратным
{
    Console.WriteLine("Error");
    return;
}


void PrintArray(int[,] matr) //печатаем массив
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
int[,] FillArray(int[,] matr) //Заполняем массив случайными 
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

void ColumnsPerRow(int[,] matr) // int [,] ColumnsPerRow(int[,] matr) //строки в столбцы если не void то return
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
//return matrixx; //если не void
}


int[,] matrix = new int[numrows, numcolum]; //создаем массив
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine("Исходная матрица");
PrintArray(matrix);
Console.WriteLine("Перевернутая матрица");
//ChangeString(matrix);
ColumnsPerRow(matrix);
//PrintArray(ColumnsPerRow(matrix)); //выводит на экран результат метода 
//PrintArray(matrix);
//ChangeLines( matrix);

*/

//находим наименьшее и удаляем строку и столбец
int rows = 3;
int colums = 3;

int[,] mat = new int[rows, colums];

int min = int.MaxValue; //берем что это число минимальное
int rowIndexOfMinValue = 0;
int columIndexOfMinValue = 0;

for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        mat[i,j] = new Random().Next(1, 11);
        Console.Write(mat[i,j] + "\t");
        if (min > mat[i,j])
        {
            min = mat[i,j];
            rowIndexOfMinValue = i;
            columIndexOfMinValue = j;

        }
    }
    Console.WriteLine();
}

Console.WriteLine($"min: {min}, координаты: ({rowIndexOfMinValue}, {columIndexOfMinValue} )");

for (int i = 0; i < mat.GetLength(0); i++)
{
     if (rowIndexOfMinValue != i) //исключил строку
     {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
        
        if (columIndexOfMinValue != j) //исключил столбец
        {
            Console.Write(mat[i,j] + "\t");            
           
        }
        }
     }
     Console.WriteLine();
}

