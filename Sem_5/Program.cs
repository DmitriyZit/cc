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

Console.Write("Введите нижнюю границу : ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите верхнюю границу : ");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resArray = new int[size];
    for (int i=0; i< resArray.Length; i++)
    {
        resArray[i] =new Random().Next(minValue, maxValue + 1);

    }
    return resArray;
}

int[] array = GetArray(12, minValue, maxValue);

Console.WriteLine($"Массив: [ {String.Join("; ", array)}]");

int PositivSum = 0;
int NegativSum = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i] > 0)
{
    PositivSum = PositivSum + array[i];

}
else 
{
    NegativSum = NegativSum + array[i];
}
}
Console.WriteLine("Сумма положительных чисел = " + PositivSum);
Console.WriteLine("Сумма отрицательных чисел = " + NegativSum);