/*Реализовать алгоритм, который выводит на экран возрастающую
последовательность случайных чисел от 1 до 1000. Как только сумма цифр
очередного числа в последовательности достигнет 26, остановить генерацию,
вывести на экран сообщение «Stop».
Примеры
5 9 50 69 255 899 Stop
50 633 655 700 854 999 Stop*/

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

int numberGeneration = GetNumber();

while(GetSumNumber(numberGeneration) < 26)
{
    Console.Write($"{numberGeneration} ");
    numberGeneration = GetNumber();
    
} 

Console.Write($"{numberGeneration} ");
Console.Write("Stop");


    



