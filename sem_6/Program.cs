
/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2


Console.Write("Введите нижнюю границу массива : ");
int minValue = Convert.ToInt32(Console.ReadLine());

    
Console.Write("Введите верхнюю границу массива : ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину массива : ");
int size = Convert.ToInt32(Console.ReadLine());


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
    

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resArray = new int[size];
    for (int i=0; i< resArray.Length; i++)
*/

 //   Задача 39: Напишите программу, 
// которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

 int[] GetArray(int size, int min, int max)
 {
     int[] array = new int[size];

     for (int i = 0; i < size; i++)
     {
         array[i] = new Random().Next(min, max + 1);
     }

     return array;
 }

 int[] resultArray = GetArray(10, 0, 10); // size = 10, min = 0, max = 10
 Console.WriteLine($"Исходный массив: [{String.Join("; ", resultArray)}]");

// Способ №1. Через резервный массив 
// int[] CopyReverseArray(int[] arr)
// {
//     int[] reverseArr = new int[arr.Length]; // размер копии = размер ориг. массива
//     for (int left = 0, right = arr.Length - 1; left < reverseArr.Length; left++, right--)
//     {
//         reverseArr[left] = arr[right]; // reverseArr[0] = arr[1], reverseArr[1] = arr[0]
//     }
//     return reverseArr;
// }
// int[] reverse = CopyReverseArray(resultArray); // CopyReverseArray(resultArray)
// Console.WriteLine($"Перевернутый массив: [{String.Join("; ", reverse)}]");