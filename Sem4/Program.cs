// Задача 24: Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


/*Console.Write("Введите  число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= number; i++)
{
    sum += i;
    Console.WriteLine( $"Сумма чисел от 1 до {i} = {sum}  " );
}
Console.WriteLine( $"Сумма чисел от 1 до {number} = {sum}  " );


Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5


Console.Write("Введите  число: ");
string number1 = (Console.ReadLine());

Console.WriteLine( number1 );
int kol = number1.Length;
Console.WriteLine($"Колличество цифр в строке {number1} = " + kol );

//int i = 0;
int number = Convert.ToInt32(Console.ReadLine());
//int number1 = number;
//Console.WriteLine($"Колличество цифр  ");
    int i = 1;
    int N = 0;
    N = number;
for (i = 0; number != 0; i++)
    {
         number = number / 10;
        // Console.WriteLine($"Колличество цифр в {number} = {i}" );
    }

Console.WriteLine($"Колличество цифр в {N} = {i}"  );
/*else
{
    Console.WriteLine($"Колличество цифр в {number} = " + 1 );
}

*/



// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
int size = 8;
int[] array = new int[size]; // Массив из 8 элементов: в массиве изначально 8 нулей
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    // array[i] = new Random().Next(0, 2)
    array[i] = rand.Next(2);
    // Console.Write(array[i] + " ");
}

Console.WriteLine($"Массив: [ {String.Join("; ",array)} ]");