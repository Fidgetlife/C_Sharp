int GetRandomNumber(int max)
{
    Random number = new Random();
    return number.Next(max);
}

int GetMinElementArr(int[] arr)
{
    int min = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}

int GetMaxElementArr(int[] arr)
{
    int max = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
} 

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный размер числа наполнения массива: ");
int elMax = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];

void FillArrayRandomNumber(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = GetRandomNumber(elMax);
    }
}

FillArrayRandomNumber(array);
int diffNumber = GetMaxElementArr(array) - GetMinElementArr(array);

Console.Write(string.Join(" ", array));
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальных элементом массива = "+ diffNumber);
