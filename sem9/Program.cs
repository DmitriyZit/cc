
Console.Write("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите колличество столбцов массива : ");
// int colums = Convert.ToInt32(Console.ReadLine());

// int Factorial(int number)//Факториал
// {
//     if (number == 1) return 1;
//     return number * Factorial(number - 1);
// }

//Числа от 1 до n
// string PrintNumbers(int start, int end)
// {
//     if(start == end) return start.ToString();
//     return start + ", "+ PrintNumbers(start + 1,end);
// }
// Console.WriteLine(PrintNumbers(1 , n) );

//Console.WriteLine($"Факториал числа {n} = {Factorial(n)}" );

// на входе число и их сумма

int GetSum(int number)
{
    if (number == 0) return 0;

    return number % 10 + GetSum(number / 10);  
}
Console.WriteLine(GetSum(n) );