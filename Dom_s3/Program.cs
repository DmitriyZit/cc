/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/




Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
//if (number = 0)
//{
  //  Console.WriteLine("Это не число ");
//}
Console.WriteLine( number);
if (number < 10000 || number > 99999) 

{
           
    
                Console.WriteLine("Число не пятизначное ");
                //Console.WriteLine("Введите пятизначное число: ");
}
else
{
    int nW = number / 10000;
    Console.WriteLine( "Первое число    " + nW);
    int nEnd = number % 10;
    Console.WriteLine( "пятое число     " + nEnd);

        if (nW != nEnd)
    {
       Console.WriteLine("Число   " + number + "  не является палиндромом " );
    }
    else
    {
        int Nt = number / 1000 % 10;
        Console.WriteLine( "Второе число    " + Nt);
        int NF = number / 10 % 10; 
        Console.WriteLine( "Четвертое число " + NF);
        if (Nt == NF)
        {
            Console.WriteLine( "Число   " + number + "   является палиндромом " );
        }
        else 
        {
            Console.WriteLine( "Число   " + number + "  не является палиндромом " );
        }


    }
}


/*Задача 21
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите число x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите число x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());



double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));


Console.WriteLine($"Расстояние между точками А:({x1},{y1},{z1}) и В:({x2},{y2},{z2})  равно: {Math.Round(d, 2)}");

*/



/*Задача 23
Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 1;
for (i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 3) + "\t");
}

*/