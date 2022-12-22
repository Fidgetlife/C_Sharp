// Задача 3. Задайте двумерный массив из трехзначных целых чисел (не менее 100 элементов).
// В каждом столбце найдите среднее арифметическое среди тех элементов, которые являются палиндромами (если палиндромов нет, то среднее арифметическое считать равным 0). 
// Полученные средние арифметические занести в одномерный массив.
// Например, задан массив:
// 100 404 504 225
// 550 478 800 363
// 505 101 410 479
// => [505, 252.5, 0, 363 ]

Console.Write("Введите кол-во строк (желательно не меньше 10) массива:  ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов (желательно не меньше 10) массива:  ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[row, col];

void FillArray(int[,] arr)
{
    Random pushNumber = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToInt32(pushNumber.Next(100, 999));
        }
    }
}

double sumNumber = 0;
double amountElement = 0;
    
double[] arrayAverage = new double[array.GetLength(1)];

void EnumerationArray(int[,] arr)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            if(arr[i, j] % 10 == arr[i, j] / 100)
            {
                sumNumber += arr[i, j];
                amountElement++;
            }            
            
        }
        
        if(amountElement != 0)
        {
            double res = Math.Round(sumNumber / amountElement, 2);
            arrayAverage[j] = res;
        }
        else
        {
            arrayAverage[j] = 0;
        }
        sumNumber = 0;
        amountElement = 0;
    }
}

void PrintArrayArithmeticMean(double[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
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
EnumerationArray(array);
Console.WriteLine("\n-------------------------------------------------------------");
PrintArray(array);
Console.WriteLine("-------------------------------------------------------------");
PrintArrayArithmeticMean(arrayAverage);
Console.WriteLine("\n");
