/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное число


Console.WriteLine("Введите 1 число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2 число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
Console.WriteLine ("Число  " +firstNumber + " Является максимальным");
}
else
{
Console.WriteLine ("Число  " +secondNumber + " Является максимальным");
}
*/

// Задача 4: Напишите программу, 
//которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.

/*Console.WriteLine("Введите 1 число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2 число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 3 число");
int threeNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;

    if (max > secondNumber)
    {
         max = firstNumber;
         //Console.WriteLine ("Число  " +max + "является максимальным" );
    }
    else
    {
         max = secondNumber;
         //Console.WriteLine ("Число  " +max + "является максимальным" );
    }
        if (max < threeNumber)
        {
            max = threeNumber;
        }
        else
        {
           // max = max;
        }
Console.WriteLine ("Число  " +max + " является максимальным" );
/*

 Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).



Console.WriteLine("Введите  число");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number % 2 == 0)
{
    Console.WriteLine ("Число  " +Number + " является Четным" );
}
else
{
    Console.WriteLine ("Число  " +Number + " является нечетным" );
}
*/

/*
Задача 8: Напишите программу, 
которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
*/

Console.WriteLine("Введите  число");
int Number = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i <= Number)
{
   Console.WriteLine(i);
   i +=2; 
}
