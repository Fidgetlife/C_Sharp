/*Задача 1: Задайте значение N. Напишите программу, которая выведет
 все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Write("Задайте значение N:  ");
int numberN = Convert.ToInt32(Console.ReadLine());

void DecreaseNumber(int num)
{
    if(num != 0)
    {
        Console.Write($"{num}, ");
        num -= 1;
        DecreaseNumber(num);
    }    
}

DecreaseNumber(numberN);
