// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Write("Введите колличество строк двумерного массива:  ");
int sizeRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов двумерного массива:  ");
int sizeCol = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число для заполнения двумерного массива:  ");
int maxNumber = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[sizeRow, sizeCol];

void FillArray(int[,] arr)
{
    Random fill = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = fill.Next(maxNumber);
        }
        
    }
}
int CalculateElementArrayFistRow(int[,] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.GetLength(1); i++)
    {
        sum += arr[0, i];
    }

    return sum;
}


int SearchMinSumElementRowArray(int[,] arr)
{
    
    int sumFinish = CalculateElementArrayFistRow(array);
    int rowMinSum = 0;
    int sumRange = 0;
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumRange += arr[i,j];            
        }
                
        if(sumRange <= sumFinish)
        {
            sumFinish = sumRange;
            rowMinSum = i + 1;            
        }

        sumRange = 0;      
    }
    
    return rowMinSum;
}

void PrintArray(int[,] arr)
{
     for(int i = 0; i < arr.GetLength(0); i++)
     {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
     }
        
}

FillArray(array);
int res = SearchMinSumElementRowArray(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {res} строка.");
PrintArray(array);