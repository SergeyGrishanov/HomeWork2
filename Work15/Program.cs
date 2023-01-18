// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int sub = 6;
int sun = 7;

if(num == sub || num == sun)
{
    Console.WriteLine($"Да");
}
else
{
    Console.WriteLine($"Нет");
}