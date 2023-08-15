// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Например:
// 456 --> 5
// 782 --> 8
// 918 --> 1


int number = Prompt("Введите трёхзначное число: ");
if (CheckDigit(number))
{
    ShowSecondFigure(number);
}


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

bool CheckDigit(int num)
{
    if(num < 100 | num > 999)
    {
        Console.WriteLine("Введённое число не является трёхзначным");
        return false;
    }
    return true;
}

void ShowSecondFigure(int num)
{
    int result = num % 100 / 10;
    Console.WriteLine($"{num} --> {result}"); 
}

