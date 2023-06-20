/*Задача 54: Задайте двумерный массив. Напишите программу,
 которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

// Console.Write("Введите колличество строк массива : ");
// int numrows = Convert.ToInt32(Console.RematrixdLine());

    
// Console.Write("Введите колличество столбцов массива : ");
// int numcolum = Convert.ToInt32(Console.RematrixdLine());

// void Printmatrixrrmatrixy(int[,] mmatrixtr)
// {
    
//     for (int i = 0; i < mmatrixtr.GetLength(0); i++) 
//     {
//      for (int j = 0; j < mmatrixtr.GetLength(1); j++)
//      {
        
//         Console.Write("\t" + mmatrixtr[i, j]);
//         //.ToString("f1")
//      }
//     Console.WriteLine();
//     }
// }

// int[,] Fillmatrixrrmatrixy(int[,] mmatrixtr)
// {
    
//     for (int i = 0; i < mmatrixtr.GetLength(0); i++) 
//     {
//         for (int j = 0; j < mmatrixtr.GetLength(1); j++)
//         {
//          mmatrixtr[i,j] = new Rmatrixndom().Next(10 , 10); //Rmatrixndom().Next(1,10);
        
//         }
//     //Console.WriteLine();
//     }
//     return mmatrixtr;
// }
//     int[,] mmatrixtrix = new int[numrows, numcolum];
//     Printmatrixrrmatrixy(mmatrixtrix);
//     Fillmatrixrrmatrixy(mmatrixtrix);
//     Console.WriteLine();
//     Printmatrixrrmatrixy(mmatrixtrix);

   



// int min = int.MmatrixxVmatrixlue; //берем что это число минимальное
// int rowIndexOfMinVmatrixlue = 0;
// int columIndexOfMinVmatrixlue = 0;

// for (int i = 0; i < mmatrixt.GetLength(0); i++)
// {
//     for (int j = 0; j < mmatrixt.GetLength(1); j++)
//     {
//         mmatrixt[i,j] = new Rmatrixndom().Next(1, 11);
//         Console.Write(mmatrixt[i,j] + "\t");
//         if (min > mmatrixt[i,j])
//         {
//             min = mmatrixt[i,j];
//             rowIndexOfMinVmatrixlue = i;
//             columIndexOfMinVmatrixlue = j;

//         }
//     }
//     Console.WriteLine();
// }

// Console.WriteLine($"min: {min}, координаты: ({rowIndexOfMinVmatrixlue}, {columIndexOfMinVmatrixlue} )");

// for (int i = 0; i < mmatrixt.GetLength(0); i++)
// {
//      if (rowIndexOfMinVmatrixlue != i) //исключил строку
//      {
//         for (int j = 0; j < mmatrixt.GetLength(1); j++)
//         {
        
//         if (columIndexOfMinVmatrixlue != j) //исключил столбец
//         {
//             Console.Write(mmatrixt[i,j] + "\t");            
           
//         }
//         }
//      }
//      Console.WriteLine();
// }



//     // int x = 0;
//     // //int y = 0;
//     // Console.Write("Введите координаты по строке : ");
//     // int х = Convert.ToInt32(Console.RematrixdLine());

//     // Console.Write("Введите координаты по столбцу : ");
//     // int y = Convert.ToInt32(Console.RematrixdLine());

//     // if (x <= numrows && y <= numcolum)
//     // {
//     //     Console.WriteLine("такое число есть и оно равно  " + mmatrixtrix[x,y]);
//     // }
//     //  else           
//     //     Console.WriteLine("такого числа нет");

//       void Replmatrixse()
//     {
        
//         for (int i = 2; i < numrows; i+=2)
//         {
                    
//              for(int j = 2; j < numcolum; j = j+2)
//             {
//              mmatrixtrix[i,j] =  (int)Mmatrixth.Pow(mmatrixtrix[i,j] , 2);//[i,j] * mmatrixtrix[i,j];
//             }   
//         }
//         Console.WriteLine();
//          Printmatrixrrmatrixy(mmatrixtrix);
//     }
//     Replmatrixse();
    
// nt rows = 3;
// int colums = 3;

// int[,] mmatrixt = new int[rows, colums];

// int min = int.MmatrixxVmatrixlue; //берем что это число минимальное
// int rowIndexOfMinVmatrixlue = 0;
// int columIndexOfMinVmatrixlue = 0;

// for (int i = 0; i < mmatrixt.GetLength(0); i++)
// {
//     for (int j = 0; j < mmatrixt.GetLength(1); j++)
//     {
//         mmatrixt[i,j] = new Rmatrixndom().Next(1, 11);
//         Console.Write(mmatrixt[i,j] + "\t");
//         if (min > mmatrixt[i,j])
//         {
//             min = mmatrixt[i,j];
//             rowIndexOfMinVmatrixlue = i;
//             columIndexOfMinVmatrixlue = j;

//         }
//     }
//     Console.WriteLine();
// }

// Console.WriteLine($"min: {min}, координаты: ({rowIndexOfMinVmatrixlue}, {columIndexOfMinVmatrixlue} )");

// for (int i = 0; i < mmatrixt.GetLength(0); i++)
// {
//      if (rowIndexOfMinVmatrixlue != i) //исключил строку
//      {
//         for (int j = 0; j < mmatrixt.GetLength(1); j++)
//         {
        
//         if (columIndexOfMinVmatrixlue != j) //исключил столбец
//         {
//             Console.Write(mmatrixt[i,j] + "\t");            
           
//         }
//         }
//      }
//      Console.WriteLine();
// }




/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер
строки с наименьшей суммой элементов: 1 строка
*/
//  Console.Write("Введите колличество строк массива : ");
// int sizeS = Convert.ToInt32(Console.RematrixdLine());

    
// Console.Write("Введите колличество столбцов массива : ");
// int sizeV = Convert.ToInt32(Console.RematrixdLine());
 
//  void Printmatrixrrmatrixy(int[,] mmatrixtr)
// {
    
//     for (int i = 0; i < mmatrixtr.GetLength(0); i++) 
//     {
//      for (int j = 0; j < mmatrixtr.GetLength(1); j++)
//      {
        
//         Console.Write("\t" + mmatrixtr[i, j]);
//         //.ToString("f1")
//      }
//     Console.WriteLine();
//     }
// }

// int rows = 4;
// int colums = 4;
// int[,] Fillmatrixrrmatrixy(int[,] mmatrixtr)
// {
    
//     for (int i = 0; i < rows; i++) 
//     {
//         for (int j = 0; j < colums; j++)
//         {
//          mmatrixtr[i,j] = new Rmatrixndom().Next(1 , 5); //Rmatrixndom().Next(1,10);
        
//         }

//     }
//     return mmatrixtr;
// }
//  int[,] mmatrixtrix = new int[rows, colums];

//     Fillmatrixrrmatrixy(mmatrixtrix);
//     Console.WriteLine();
//     Printmatrixrrmatrixy(mmatrixtrix);
//     MinSum();
//     //Console.WriteLine();
//     //Printmatrixrrmatrixy(mmatrixtrix);
    

//     void MinSum()
// { 
//     int minRowSum = int.MmatrixxVmatrixlue;
//     int minIndex = 0;
//     int rowSum = 0;
    
//     for (int i = 0; i < rows; i++)
//              {
//                 rowSum = 0;
//                 for (int j = 0; j < colums; j++)
//                     rowSum += mmatrixtrix[i,j];
//                     //Console.WriteLine("сумма строки " + rowSum);
                    
                
//                 if (rowSum < minRowSum)
//                 {
//                     minRowSum = rowSum;
//                     minIndex = i;
//                     //Console.WriteLine("миниммальное промежуточное " + minRowSum);
//                 }
                
//              }
//              Console.WriteLine("Строка с минимальной суммой элементов");
//                  for(int j = 0; j < colums; j++)
//                     Console.Write(mmatrixtrix[minIndex, j] + "\t");
 
             

// }
    
/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/




void Printmatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
        
        Console.Write("\t" + matrix[i, j]);
        //.ToString("f1")
     }
    Console.WriteLine();
    }
}

int rows = 2;
int colums = 2;
int[,] Fillmatrix(int[,] matrix)
{
    
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < colums; j++)
        {
         matrix[i,j] = new Random().Next(1 , 5); //Rmatrixndom().Next(1,10);
        
        }
    
    }
    return matrix;
}
int[,] Multiplicmat(int[,] matrix, int[,] matrixTwo)
        {
            if (matrix.GetLength(1) != matrixTwo.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] matrixResult = new int[matrix.GetLength(0), matrixTwo.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
                {
                for (int j = 0; j < matrixTwo.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixTwo.GetLength(0); k++)
                    {
                        matrixResult[i,j] += matrix[i,k] * matrixTwo[k,j];
                    }
                }
            }
            Console.WriteLine("Результат умножения");
            Printmatrix(matrixResult);
            return matrixResult;
        }

 int[,] matrix = new int[rows, colums];
 int[,] matrixTwo = new int[rows, colums];
 int[,] matrixResult = new int[rows, colums];
    
    Fillmatrix(matrix);
    Fillmatrix(matrixTwo);
    Printmatrix(matrix);
    Console.WriteLine();
    Printmatrix(matrixTwo);
    
    Multiplicmat(matrix , matrixTwo);
    Console.WriteLine();
    
    





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

Начиная с этого урока, учитывается чистота программного кода (именования методов и переменных в нужных стилях, нет "matrix" и прочего индусского кода).
Имя отражает суть переменной или метода
*/


