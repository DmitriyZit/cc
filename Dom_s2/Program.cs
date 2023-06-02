/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*
Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
    {
    Console.WriteLine("Число не трехзначное");
    }
 
else
    {

        Console.WriteLine($"Введенное число {number} ");
        int result = number / 10 % 10;
        Console.WriteLine($"Вторая цифра {result} ");

    }
*/



/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6


Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int result = -1;

if (number < 100)
    {
        Console.WriteLine("Третьего числа нет");

    }
else
    {
        while (number > 999)
        {
            number = number / 10;    
        }    
        result = number % 10;
    }  

Console.WriteLine(result);

*/
//int result = 


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

//int index = 0;
Console.WriteLine("Введите число от 1 до 7 ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7) 

{
            //while (index < 3)

            for (int index = 0; index < 3;)
            {
                //Console.WriteLine(index);
    
                Console.WriteLine("Число не входит в Дни недели ");
                Console.WriteLine("Введите число от 1 до 7 ");
                int numberNew = Convert.ToInt32(Console.ReadLine());
                number = numberNew;
                
                //Console.WriteLine(number);
                if (number >= 1 & number <= 7)
                   {
                    if (number == 6 | number == 7)
                        {
                            
                            Console.WriteLine("Поздравляю это выходной день");
                        }
                    else
                        {
                            Console.WriteLine("Сожалею это не выходной день");
                        }
                
            break;    
                    
                    }
                index++;
                Console.WriteLine("К сожалению Вы использовали все свои попытки");
                
                //Console.WriteLine(index);
                
            
                      
                   
            }
   //         
}
else
{
        if (number == 6 | number == 7)
        {
            Console.WriteLine("Поздравляю это выходной день");
        }
        else
        {
            Console.WriteLine("Сожалею это не выходной день");
        }
    //Console.WriteLine(number);
}
   

 //Console.WriteLine("Неудача");

