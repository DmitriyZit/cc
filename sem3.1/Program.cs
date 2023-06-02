
/*Console.WriteLine("Введите число от 1 до 999 ");
int number = Convert.ToInt32(Console.ReadLine());
number = number * 2;

Console.WriteLine();
Console.WriteLine(number);

Console.ReadKey();


Console.WriteLine("Введите число x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число y ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("1 Четверть");
}


else if (x < 0 && y > 0)
{
    Console.WriteLine("2 Четверть");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("3 Четверть");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("4 Четверть");
}


else 
{
    Console.WriteLine("Это ось");
}



Console.WriteLine("Введите число x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
//Math.Pow(x2 - x1, 2) => Math.Pow(число, степень)
//

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine(d);
Console.WriteLine($"Расстояние между точками А:({x1},{y1}) и В:({x2},{y2})  равно: {Math.Round(d, 4)}");

*/

Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 1;
for (i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 3) + "\t");
}