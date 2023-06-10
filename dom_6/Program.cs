/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2


Console.Write("Введите нижнюю границу массива : ");
double minValue = Convert.ToInt32(Console.ReadLine());

    
Console.Write("Введите верхнюю границу массива : ");
double maxValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину массива : ");
double size = Convert.ToInt32(Console.ReadLine());


if (minValue <100 || minValue > 1000)
    {
        Console.WriteLine($"число {minValue} не трехзначное");
        Console.WriteLine("Попробуйте снова");       
    return;
    }


        if (maxValue <100 || maxValue > 1000)
        {
            Console.WriteLine($"число {maxValue} не трехзначное");
            Console.WriteLine("Попробуйте снова");       
    return;
        }
    

double[] GetArray(double size, double minValue, double maxValue)
{
    double[] resArray = new double[size];
    for (double i=0; i< resArray.Length; i++)
*/

 //   Задача 39: Напишите программу, 
// которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
/*
 double[] GetArray(double size, double min, double max)
 {
     double[] array = new double[size];

     for (double i = 0; i < size; i++)
     {
         array[i] = new Random().Next(min, max + 1);
     }

     return array;
 }

 double[] resultArray = GetArray(5, 0, 10); // size = 10, min = 0, max = 10
 Console.WriteLine($"Исходный массив: [{String.Join("; ", resultArray)}]");

 // Способ №1. Через резервный массив 
 double[] CopyReverseArray(double[] arr)
 {
     double[] reverseArr = new double[arr.Length]; // размер копии = размер ориг. массива
     for (double left = 0, right = arr.Length - 1; left < reverseArr.Length; left++, right--)
     {
         reverseArr[left] = arr[right]; // reverseArr[0] = arr[1], reverseArr[1] = arr[0]
     }
     return reverseArr;
 }
 double[] reverse = CopyReverseArray(resultArray); // CopyReverseArray(resultArray)
 Console.WriteLine($"Перевернутый массив: [{String.Join("; ", reverse)}]");

 // Способ №2. Через вспом. переменную 
 void ReverseArray(double[] arr)
 {
     for (double i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
     {
         double temp = arr[i]; // Для массива arr[10,20,30]; temp = arr[0] => temp = 10
         arr[i] = arr[j]; // arr[0] = arr[2]: [arr[2],20,arr[2]] => [30,20,30];
         arr[j] = temp; // [30,20,temp] => temp = 10 => [30,20,10]
     }
 }
 ReverseArray(resultArray);
 Console.WriteLine($"Перевернутый массив: [{String.Join("; ", resultArray)}]");
 */

 /*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

Console.Write("Введите колличество чисел : ");
double numberOfnumbers = Convert.ToInt32(Console.ReadLine());
double[] GetArray(double size)
 {
     double[] array = new double[numberOfnumbers];

     for (double i = 0; i < numberOfnumbers; i++)
     {
         Console.Write("Введите число : ");
         array[i] = Convert.ToInt32(Console.ReadLine());
         
     }

     return array;
 }
double[] resultArray = GetArray(numberOfnumbers);
Console.WriteLine($"массив: [{String.Join("; ", resultArray)}]");

//double Positiv()
 //{
    double morezero = 0;
    double lesszero = 0;
    for (double i = 0; i < numberOfnumbers; i++)
     {
        if(resultArray[i] > 0)
        {
           morezero = morezero + 1; 
        }
        else
        
         lesszero = lesszero + 1;
     }  
   
Console.WriteLine("Число положительных чисел = " + morezero  + "  Число отрицательных = " + lesszero);

*/



/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

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


