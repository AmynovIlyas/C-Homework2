// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
// Например:
// 645 --> 5
// 78 --> третьей цифры нет
// 32679 --> 6

Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);
int count1 = CountsDigits(number1);
FindThirdDigit(number1);


int CountsDigits(int number)
{
    int count = 0;
    while (number != 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

void FindThirdDigit(int number)
{
    if (count1 > 2)
    {
        int x = Convert.ToInt32(Math.Pow(10, count1 - 2));
        int y = Convert.ToInt32(Math.Pow(10, count1 - 3));
        int result = number % x / y;
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}






