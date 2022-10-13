Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine();

if(userName.ToLower() == "маша")
{
    Console.Write("Ура, это же ");
}
else
{
    Console.Write("Привет, ");
 
}
Console.WriteLine(userName);