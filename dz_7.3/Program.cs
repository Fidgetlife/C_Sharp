// Задача 3. Задайте двумерный массив из трехзначных целых чисел (не менее 100 элементов).
// В каждом столбце найдите среднее арифметическое среди тех элементов, которые являются палиндромами (если палиндромов нет, то среднее арифметическое считать равным 0). 
// Полученные средние арифметические занести в одномерный массив.
// Например, задан массив:
// 100 404 504 225
// 550 478 800 363
// 505 101 410 479
// => [505, 252.5, 0, 363 ]

int[,] array = new int[10, 10];

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

int EnumerationElement(int num)
{
    int sumNumber = 0;
    int amountElement = 0;
    double result = 0;


}

double[] arrayAverage = new double[array.GetLength(1)];
int count = 0;

void EnumerationArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(1); i++)
    {
        for(int j = 0; j < arr.GetLength(0); j++)
        {
            if(arr[i, j] % 10 == arr[i, j] / 100)
            {

            }
        }
    }
}
