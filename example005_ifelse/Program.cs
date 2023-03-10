Console.Write("Введите своё имя ");
string username = Console.ReadLine();
if(username.ToLower() == "lisa")
{
    Console.WriteLine("Любимая привет!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}