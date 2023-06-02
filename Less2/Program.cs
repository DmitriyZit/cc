int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2> result) result = arg2;
    if (arg3> result) result = arg3;
    return result;
}

int a1 = 10;
int a2 = 500000;
int a3 = 15;
int b1 = 1660;
int b2 = 58;
int b3 = 155;
int c1 = 140;
int c2 = 45;
int c3 = 15;

//int max = a1;
//if (b1 > max) max = b1;
//if (c1 > max) max = c1;
//

/*int max1 = Max(a1,b1,c1);
int max2 = Max(a2,b2,c2);
int max3 = Max(a3,b3,c3);

Console.WriteLine(max1);
Console.WriteLine(max2);
Console.WriteLine(max3);
*/
int max = Max(Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3));
Console.WriteLine(max);



