Console.Write("Введите своё имя: ");
string username = Console.ReadLine();

if(username.ToLower == "masha")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
