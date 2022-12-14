int GetRandomNumber(int min, int max)
{
    Random number = new Random();
    return number.Next(min, max);
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int countSumHonestNumber = 0;

int[] array = new int[length];

void FillArrayRandomNumber(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = GetRandomNumber(100, 1000);
    }
}

FillArrayRandomNumber(array);

for(int el = 0; el < array.Length; el++)
{
    if(el % 2 != 0 && array[el] % 2 == 0) countSumHonestNumber += array[el];
}

Console.Write(string.Join(" ", array));
Console.WriteLine();
Console.WriteLine("Сумма четных элементов в массиве стоящих на нечетных позициях = "+ countSumHonestNumber);
