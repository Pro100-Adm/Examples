﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int AskUser()
{
Console.Write("Введите число: ");
string Ask = Console.ReadLine();
try
{
    int op = int.Parse(Ask);
    return op;
}
catch (Exception)
{
    Console.Write("Введите верное число!");
    return AskUser();
}
}

int Summ(int op1, int op2)
{
    int result;
    result = op1+op2;
    Console.WriteLine(result);
    return result;
}


Summ(AskUser(), AskUser());