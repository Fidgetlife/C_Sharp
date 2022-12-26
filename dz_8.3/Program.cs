// Задача 3: Задайте две квадратные матрицы одинакового размера. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица:
// 18 20
// 15 18

Console.Write("Введите размер размер прямоугольной мартицы:  ");
int rowArr = Convert.ToInt32(Console.ReadLine());
int colArr = rowArr;

int[,] arrayOne = new int[rowArr, colArr];
int[,] arrayTwo = new int[rowArr, colArr];
int[,] arrayMultiplication = new int [rowArr, colArr];

void FillArray(int[,] arr)
{
    Random fill = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = fill.Next(10);
        }        
    }
}

void MultiplicationArray(int[,] arrRes,int[,] arr1, int[,] arr2)
{
    for(int i = 0; i < arr1.GetLength(0); i++)
    {
        for(int j = 0; j < arr2.GetLength(1); j++)
        {
            for(int k = 0; k < arr2.GetLength(0); k++)
            {
                arrRes[i, j] += arr1[i, k] * arr2[k, j];
            }        
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

FillArray(arrayOne);
FillArray(arrayTwo);
MultiplicationArray(arrayMultiplication, arrayOne, arrayTwo);
PrintArray(arrayOne);
Console.Write("\n");
PrintArray(arrayTwo);
Console.Write("\n");
PrintArray(arrayMultiplication);