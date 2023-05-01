// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// Например:
// 6 --> да
// 7 --> да
// 1 --> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number1 = int.Parse(Console.ReadLine()!);
WeekendOrNot(number1);

void WeekendOrNot(int number)
{
    if (number > 5 & number < 8)
    {
        Console.WriteLine(number + " --> да");
    }
    else if (number > 0 & number < 6)
    {
        Console.WriteLine(number + " --> нет");
    }
    else
    {
        Console.WriteLine("Введенная цифра не соответствует дню недели");
    }
} 
