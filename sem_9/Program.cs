
Console.Write("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите колличество столбцов массива : ");
// int colums = Convert.ToInt32(Console.ReadLine());

int Factorial(int number)
{
    if (number == 1) return 1
    return number * Factorial(number - 1);
}

Console.WriteLine($"Факториал числа {n} = {Factorial(n)}" );