/* Задача 2: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите число М: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int result = 0;

void SummerNumber(int m, int n)
{
    if(m <= n)
    {
        result += m;
        m += 1;
        SummerNumber(m, n);
    }
}

void OutputOnDisplay ()
{
    SummerNumber(numberM, numberN);
    Console.Write(result);
}

OutputOnDisplay();