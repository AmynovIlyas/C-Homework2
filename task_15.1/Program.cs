// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// Например:
// 6 --> да
// 7 --> да
// 1 --> нет

int Prompt(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int number1 = Prompt("Введите цифру, обозначающую день недели: ");
if (DayOfTheWeek(number1))
{
    WeekendOrNot(number1);
}

void WeekendOrNot(int number)
{
    if (number > 5)
    {
        Console.WriteLine("Ура! Выходной!");
    }
    else 
    {
        Console.WriteLine("Придётся поработать");
    }
}

bool DayOfTheWeek(int number)
{
    if (number > 7 | number < 1)
    {
        Console.WriteLine("Это не день недели!");
        return false; 
    }
    return true;
}



// int number = Prompt("Введите трёхзначное число: ");
// if (number < 100 | number > 999)
// {
//     Console.WriteLine("Вы ввели не трёхзначное число, пожалуйста, повторите ввод");
//     return;
// }
// Console.WriteLine($"Вторая цифра введённого числа --> {number / 10 % 10}");


// int GetThirdRank(int number)
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;
// }

// bool ValidateNumber(int number)
// {
//     if (number < 100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//         return false;
//     }
//     return true;
// }

// int number = Prompt("Введите число: ");
// if (ValidateNumber(number))
// {
//     Console.WriteLine(GetThirdRank(number));
// }
