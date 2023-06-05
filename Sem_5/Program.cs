/*Console.Write("Введите 1 число : ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число : ");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите операцию : ");
char sign = char.Parse(Console.ReadLine());


int Calcul( int a , int b, char sign)
{
    int result = 0;
    if(sign == '+')
    {
        result = a + b;
       
    }
    else
    {
        result = a - b;
    }
    return result;
}
Console.WriteLine(Calcul(Number1, Number2, sign));
//Console.WriteLine($"сумма равна {result} ");
*/

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3 , 9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
//  сумма отрицательных равна -20.

/*Console.Write("Введите нижнюю границу : ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите верхнюю границу : ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину массива : ");
int size = Convert.ToInt32(Console.ReadLine());

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resArray = new int[size];
    for (int i=0; i< resArray.Length; i++)
    {
        resArray[i] =new Random().Next(minValue, maxValue + 1);

    }
    return resArray;
}

int[] array = GetArray(size, minValue, maxValue);

Console.WriteLine($"Массив: [ {String.Join("; ", array)}]");

int PositivSum = 0;
int NegativSum = 0;
for (int i = 0; i < array.Length; i++)
{
 /* if (array[i] > 0)
    {
    PositivSum = PositivSum + array[i];

    }
    else 
    {
    NegativSum = NegativSum + array[i];
    }
    */
    // Тернарный оператор
//     // условие ? значение_ист : значение_ложное
//     positiveSum += array[i] > 0 ? array[i] : 0; // Если число поло-е, то прибавляю array[i] 
//     // иначе - прибавляю 0
//     negativeSum += array[i] < 0 ? array[i] : 0;
 //   PositivSum += array[i] > 0 ? array[i] : 0;
 //   NegativSum += array[i] < 0 ? array[i] : 0;
//}

//Console.WriteLine("Сумма положительных чисел = " + PositivSum);
//Console.WriteLine("Сумма отрицательных чисел = " + NegativSum);


/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на
 соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

/*Console.Write("Введите нижнюю границу массива : ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите верхнюю границу массива : ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину массива : ");
int size = Convert.ToInt32(Console.ReadLine());

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resArray = new int[size];
    for (int i=0; i< resArray.Length; i++)
    {
        resArray[i] =new Random().Next(minValue, maxValue + 1);

    }
    return resArray;
}

int[] array = GetArray(size, minValue, maxValue);

Console.WriteLine($"Массив: [ {String.Join("; ", array)}]");

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
if (array[i] > 0)
    {
    array[i] = array[i] * -1;

    }
    else 
    {
    array[i] = array[i] * -1;
    }
    
}
Console.WriteLine($"Массив: [ {String.Join("; ", array)}]");
*/
/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

Console.Write("Введите нижнюю границу массива : ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите верхнюю границу массива : ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину массива : ");
int size = Convert.ToInt32(Console.ReadLine());

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resArray = new int[size];
    for (int i=0; i< resArray.Length; i++)
    {
        resArray[i] =new Random().Next(minValue, maxValue + 1);

    }
    return resArray;
}

int[] array = GetArray(size, minValue, maxValue);

Console.WriteLine($"Массив: [ {String.Join("; ", array)}]");

Console.Write("Введите число  : ");
int numberS = Convert.ToInt32(Console.ReadLine());
 

bool Find(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
   
        if (array[i] == number)
        {
               
            return true;
        }

       // else
       //     return false;
       // }
    
    }
return false;
 }
 


if (Find(array, numberS))
{
    Console.WriteLine($"число {numberS} есть в массиве[ {String.Join("; ", array)}]");
}

else
{
    Console.WriteLine($"число {numberS} нет в массиве [ {String.Join("; ", array)}]");
}
/*if(res > 0)
{
Console.WriteLine($"число {number} есть в массиве[ {String.Join("; ", array)}]");
}
else
{
Console.WriteLine($"число {number} нет в массиве [ {String.Join("; ", array)}]");
}
*/
