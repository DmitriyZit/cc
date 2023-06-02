

/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16


Console.Write("Введите  число: A  ");
int PromA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите  число: B  ");
int PromB = Convert.ToInt32(Console.ReadLine());


int sum = 1;
for (int i = 1; i <= PromB; i++)
{
    
    sum = sum * PromA;
    //int sum =  Convert.ToInt32(Math.Pow(PromA, PromB));
    //Console.WriteLine( sum );
    
}

Console.WriteLine($"Результат возведения {PromA} в {PromB} степень = {sum} ");
*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12


Console.Write("Введите  число:  ");
int Prom =Convert.ToInt32(Console.ReadLine());
//Console.WriteLine( Prom );
int PromVv = Prom;
int summ = 0;
for (int i = 0; i <= Prom; i++)
{
    
  summ = summ + Prom % 10; // последняя цифра
  Prom = Prom / 10; // следущая с конца цифра

  //sum = sum + Prom;
}
Console.WriteLine($"Сумма цифр числа {PromVv} = {summ} ");

*/


/*
Задача 29: Напишите программу, которая задаёт массив из 
8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Write("Введите ряд чисел, разделенных запятой : ");
string? Numbers = Console.ReadLine();
//int Proms =Convert.ToInt32(Console.ReadLine());
string Prom = Numbers;
//string Prom = String.Empty;

string Replase(string Prom, char oldValue, char newValue)
{
  string Res = String.Empty;
  int length = Prom.Length;
  for (int i = 0; i < length; i++)
  {
    if(Prom[i] == oldValue) Res = Res + $"{newValue}";
      
    else Res = Res + $"{Prom[i]}";
       
  }
  return Res;
}
String New = Replase(Prom, ',' , '1'); //Заполняю , 1
String New_t = Replase(New, ' ' , '1'); //Заполняю пробелы 1

Console.WriteLine(New_t);  
int number;
bool New_tu = int.TryParse(New_t, out number); // number не 0 если цифры
//Console.WriteLine(number); 
  if (number != 0) //если number не равно 0
       {
          Console.WriteLine($"Массив: [ {String.Join("; ",Numbers)} ]");
        }      
  else 
        {
          Console.WriteLine($"Ошибка ввода. Вводите только цифры.");
        }


    


