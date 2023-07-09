// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumItemes(int num1, int num2)
{
    if (num1 > num2) return 0;
    return num1 + SumItemes(++num1, num2);
}

int number1 = InputNum("Введите целое число 1: ");
int number2 = InputNum("Введите целое число 2: ");
Console.WriteLine(SumItemes(number1, number2));
