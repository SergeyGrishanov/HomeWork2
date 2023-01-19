// Альтернативная (лучшаая) программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Цифры считать справа налево).
Console.Clear();

Console.WriteLine("Введите любое число: ");
int number = int.Parse(Console.ReadLine()!);

int result = number / 100;

if (result > 10 || result != 0)
{
    result = result % 10;
    Console.WriteLine($"Третья цифра: {result}");
}
else
{
    Console.WriteLine($"Третьей цифры нет"); 
}
