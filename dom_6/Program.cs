

 /*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Write("Введите колличество чисел : ");
int numberOfnumbers = Convert.ToInt32(Console.ReadLine());
int[] GetArray(int size)
 {
     int[] array = new int[numberOfnumbers];

     for (int i = 0; i < numberOfnumbers; i++)
     {
         Console.Write("Введите число : ");
         array[i] = Convert.ToInt32(Console.ReadLine());
         
     }

     return array;
 }
int[] resultArray = GetArray(numberOfnumbers);
Console.WriteLine($"массив: [{String.Join("; ", resultArray)}]");

//double Positiv()
 //{
    int morezero = 0;
    int lesszero = 0;
    for (int i = 0; i < numberOfnumbers; i++)
     {
        if(resultArray[i] > 0)
        {
           morezero = morezero + 1; 
        }
        else
        
         lesszero = lesszero + 1;
     }  
   
Console.WriteLine("Число положительных чисел = " + morezero  + "  Число отрицательных = " + lesszero);





/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите координаты b1 : ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты k1 : ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты b2 : ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты k2 : ");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = 0;
double y = 0;
x = (b2-b1) / (k1-k2);
y = k1 * (b2-b1) / (k1 - k2) + b1;
Console.WriteLine("Точка пересечения x = " + Math.Round(x, 2)  + "  y = " + Math.Round(y, 2) );

*/
