/*Задача 2
Михаил интересуется созданием простых чисел. Его интересуют
простые числа с некоторыми характеристиками:
• число сгенерировано случайным образом;
• его квадрат не оканчивается на 1;
• сумма его цифр лежит в диапазоне от 10 до 20
Сгенерировать пять простых чисел, удовлетворяющих пожеланиям
Михаила, и вывести их на экран.
Пример
97 397 83 317 383*/

int GetNumber()
{
    int number = new Random().Next(1, 1000);
    return number;
}

int GetSumNumber(int numGen)
{
    int sum = 0;
    int num = 0;    

    while(numGen > 0)
    {
        num = numGen % 10;
        sum += num;
        numGen /= 10;
    }

    return sum;
}

int SquareNumberNotEndOne(int num)
{
    if(num*num % 10 != 1)
    {
        return 1;
    }
    else
    {
        return 0;
    }
}

int count = 0;

while( count < 5)
{
    int newNumber = GetNumber();
    int resultSum = GetSumNumber(newNumber);
    if(SquareNumberNotEndOne(newNumber) == 1 && GetSumNumber(newNumber) < 20 && GetSumNumber(newNumber) > 10)
    {
        Console.Write($"{newNumber} ");
        count++;
    }
}