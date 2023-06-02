Console.Write("Введите имя пользователя   ");
string username = Console.ReadLine();

if(username.ToLower() == "dima")
{   
    Console.Write("Ура это dima");
}
else
{
    Console.Write("Привет ,  ");
    Console.WriteLine(username);
}
