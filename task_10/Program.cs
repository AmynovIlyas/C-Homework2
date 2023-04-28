// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Например:
// 456 --> 5
// 782 --> 8
// 918 --> 1

Console.WriteLine("Введите трёхзначное число: ");
int number1 = int.Parse(Console.ReadLine()!);
ShowSecondFigure(number1);


void ShowSecondFigure(int number)
{
    int result = number % 100 / 10;
    Console.WriteLine("Second figure this number: " + result);
}

