// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

Console.Write("Введите колличество строк двумерного массива:  ");
int sizeRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов двумерного массива:  ");
int sizeCol = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[sizeRow, sizeCol];

void FillArray(int[,] arr)
{
    Random fill = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = fill.Next(100);
        }
        
    }
}

void ArrangeElementsArray(int[,] arr)
{
    int[] arraySort = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arraySort[j] = arr[i,j];            
        }
        Array.Sort(arraySort);
        Array.Reverse(arraySort);

        for(int j=0; j<arr.GetLength(1); j++)
        {
            arr[i, j] = arraySort[j];
        }
      
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
ArrangeElementsArray(array);
PrintArray(array);