// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Например:
// 456 --> 5
// 782 --> 8
// 918 --> 1

Console.WriteLine("Введите трёхзначное число: ");
int number1 = int.Parse(Console.ReadLine()!);
number1 = NumberSelection(number1);
ShowSecondFigure(number1);

int NumberSelection(int number)
{
    if (number < 100 | number > 999)
    {
        return 0;
    }
    else
    {
        return number;
    }
}

void ShowSecondFigure(int number)
{
    if (number != 0)
    {
        int result = number % 100 / 10;
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Введённое число не  является трёхзначным");
    }
}


