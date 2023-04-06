// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.WriteLine("Введите начальное число M:");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальное число M:");
int N = int.Parse(Console.ReadLine());


void NumberSumm (int numberM, int numberN, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов =  {sum}"); 
        return;
    }
    sum = sum + (M++);
    NumberSumm(numberM, numberN, sum);
}


NumberSumm(M, N, 0);
