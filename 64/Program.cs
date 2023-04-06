//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void OutPutNamber (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    OutPutNamber (number - 1);
}


Console.Clear();
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
OutPutNamber(number);