// Задача 2. Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого элемента в массиве нет

Console.Write("Введите кол-во строк в двумерном массиве:\t");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов в двумерном массиве:\t");
int col = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[row, col];

int[] arrayPosition = new int[2];

Console.Write("Введите через запятую или пробел позицию элемента массива, который вас интересует: \t");
string enterPosition = Console.ReadLine();
char[] entPos = new char[] {' ', ','};
string[] position = enterPosition.Split(entPos, StringSplitOptions.RemoveEmptyEntries);
int positionRow = Convert.ToInt32(position[0]);
int positionCol = Convert.ToInt32(position[1]);

void FillArray(int[,] arr)
{
    Random number = new Random();
    
    for(int i = 0; i < arr.GetLength(0); i++)
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = number.Next();            
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

void PrintElementArray(int[,] arr)
{
    string result = string.Empty;
   if(positionRow < row && positionCol < col)
        {
            Console.WriteLine($"Элемент на позиции [{positionRow}, {positionCol}] = " + array[positionRow, positionCol]);
        }
        else
        {   
           Console.WriteLine("Такой позиции нет в границах этого массива");
        } 
}

FillArray(array);
Console.WriteLine("---------------------------------------------------------");
PrintArray(array);
Console.WriteLine("---------------------------------------------------------");
GetElementArray(array);



