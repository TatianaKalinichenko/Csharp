// 7. Напишите программу, которая 
// 1. принимает на вход трёхзначное число 
// 2. и на выходе показывает последнюю цифру этого числа.

// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное целое число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number *= -1;
}

if (number >= 100 && number <= 999)
{
    int result = (number % 10);
    Console.WriteLine("Последняя цифра введенного числа:" + result);
}
else
{
    Console.WriteLine("Введенное число не является трехзначным");
}
