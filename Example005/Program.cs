// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine();
if(username == "Алексей")
{
Console.WriteLine("Ура, это же АЛЕКСЕЙ!");
}
else
{
Console.Write("Привет, ");
Console.WriteLine(username);
}