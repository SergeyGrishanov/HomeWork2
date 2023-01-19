// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);
int b = a / 10;
int result = b % 10;

Console.WriteLine($"Трехзначное число {a} => Второе число {result}");