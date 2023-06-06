// ДОМАШНЯЯ РАБОТА

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
    {
        resArray[i] =new Random().Next(minValue, maxValue + 1);

    }
    return resArray;
}

int[] array = GetArray(size, minValue, maxValue);

Console.WriteLine($"Массив: [ {String.Join("; ", array)}]");

//Console.WriteLine(array[0]);
int Res = 0;

for (int i = 0; i < array.Length; i++)
{
    
    if (( array[i]) % 2  == 0 )
       {
        //Console.WriteLine(( array[i]   +"  Четное" ));
        Res = Res + 1;
       }

       //else
       // {
            // Console.WriteLine(( array[i]   +"  НЕ Четное" ));
       // }
        
    
    //Console.WriteLine("Кол-во четных " + Res);
}

Console.WriteLine($"в массиве:  [ {String.Join("; ", array)}] количество чётных чисел = {Res}");
*/
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resArray = new int[size];
    for (int i=0; i< resArray.Length; i++)
    {
        resArray[i] =new Random().Next(minValue, maxValue + 1);

    }
    return resArray;
}

int[] array = GetArray(6, -10, 10);

Console.WriteLine($"Массив: [ {String.Join("; ", array)}]");
int sum = 0;
for (int i = 1; i < array.Length; i = i+2)
{
   // if (( array[i]) / 2  != 0 )
   // {
       sum = sum + array[i];
   // }

}
//return sum;
Console.WriteLine(sum);


/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

