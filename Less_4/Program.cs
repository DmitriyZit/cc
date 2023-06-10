
/*string[,] table= new string[2,5];
table[1, 2] = "слово";
for (int rows =0 ; rows < 2 ; rows++)
{
    for (int colums = 0; colums < 5; colums++)
    {
        Console.WriteLine($"-{table[rows, colums]}-");
    }
}

void PrintArray(int[,] matr)
{
    //int[,] matrix = new int[3, 4];
    //matrix[1, 1] = 55;
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
     for (int j = 0; j < 4; j++)
     {
        Console.Write($"-{matr[i, j]}-");
     }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    //int[,] matrix = new int[3, 4];
    //matrix[1, 1] = 55;
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
         matr[i,j] = new Random().Next(1,10);
        // Console.Write($"-{matrix[i, j]}-");
        }
    //Console.WriteLine();
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

*/

double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if(n== 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
//Console.WriteLine(Factorial(33)); 