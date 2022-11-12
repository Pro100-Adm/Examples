// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

float AskUser()
{
Console.Write("Введите число: ");
string Ask = Console.ReadLine();
try
{
    float op = float.Parse(Ask);
    return op;
}
catch (Exception)
{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}

float Div(float op1, float op2)
{
    float result;
    result = op1/op2;
    Console.WriteLine(result);
    return result;
}


Div(AskUser(), AskUser());