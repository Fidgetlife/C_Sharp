// Задача 1. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// Тип данных для элементов выбрать double, наличие ненулевой дробной части обязательно.
// m = 3, n = 4.
// 0.5 7.96 -2.78 -0.2
// 1.7 -3.3 8.574 -9.9
// 8.5 7.87 -7.1 9.15



Console.Write("Введите кол-во строк в двумерном массиве:\t");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов в двумерном массиве:\t");
int col = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[row, col];

void FillArray(double[,] arr)
{
    Random number = new Random();
    
    for(int i = 0; i < arr.GetLength(0); i++)
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = number.NextDouble()*10;            
        }
}

void PrintArray(double[,] arr)
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
Console.WriteLine("---------------------------------------------------------");
PrintArray(array);