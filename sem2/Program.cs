/*void GenNumber(int[] arr)
{
    Random rnd = new Random();
    for (int i=0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(10, 100);
    }

}
int[] arr = new int[10];


GenNumber(arr);

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
    int a = arr[i] % 10;
    int b = arr[i] / 10;
    if(a > b)

    {
        Console.WriteLine($"Наибольшая цифра чмсла {arr[i]} = "  + a);
    }
    else
    {
        Console.WriteLine($"Наибольшая цифра чмсла {arr[i]} = "  +b);
    }   
}
*/







/*Random rnd = new Random();
int rndNum = rnd.Next(10, 100); //Генерирует число 10-99
Console.WriteLine(rndNum);
int a = rndNum % 10; //первая цифра
int b = rndNum / 10; // вторая цифра
if(a>b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}
*/

//int 
Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 100; //первая цифра
int b = number % 10; // 3 цифра
int result = 0;
result = a*10+b;
Console.WriteLine(result);
