

/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16


Console.Write("Введите  число: A  ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите  число: B  ");
int numberB = Convert.ToInt32(Console.ReadLine());


int sum = 1;
for (int i = 1; i <= numberB; i++)
{
    
    sum = sum * numberA;
    //int sum =  Convert.ToInt32(Math.Pow(numberA, numberB));
    //Console.WriteLine( sum );
    
}

Console.WriteLine($"Результат возведения {numberA} в {numberB} степень = {sum} ");
*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите  число:  ");
string number =Console.ReadLine();
Console.WriteLine( number );

for (int i = 0; i <= number; i++)
{
  sum = sum + number % 10; // последняя цифра
  number = number / 10; // следущая с конца цифра

  //sum = sum + number;
}
Console.WriteLine($"Сумма цифр числа {number} = {sum} ");


//int counter = Convert.ToString(number).Length;
//int Sum = 0;
//Console.WriteLine( counter );
//Console.WriteLine( number[i] );


/*for (int i = 0; i <= counter; i++)
{
    
    Sum = Sum + number[i];
}
//Console.WriteLine( Convert.ToInt32(Console.ReadLine(Sum)) );
*/








/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


/*

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine($"\nЗадача 27. Выдаёт сумму цифр в числе");
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN){
    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine($"\nЗадача 29. Ряд чисел преобразует в массив");
Console.Write("Введите ряд чисел, разделенных запятой : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

// функция удаления пробелов из строки 
string RemovingSpaces (string series){
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}

//  функция  проверки на правильность ввода 
void СheckNumber2 (int  series){

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else {
          Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

      }
      */