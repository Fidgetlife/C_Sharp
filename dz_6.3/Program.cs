// Задача 3*. Найдите сумму произведений пар чисел в одномерном целочисленном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Если кол-во элементов нечетное, то элемент посередине не учитывать.
// Результат сложения вывести на экран.
// 1, 3, 8, 3, 2 -> 11
// 8, 3, 4, 2 -> 28

Console.Write("Введите размер массива:\t");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int sumParNumber = 0;

int[] array = new int[sizeArray];

Random newNumber = new Random();

void FillArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = newNumber.Next(1,10);
    }    
}

int GetSumParNumber(int[] arr)
{
    int sum = 0;
    int endElement = arr.Length - 1;
    for(int i = 0; i < arr.Length / 2; i++)
    {
        sum += arr[i] * arr[endElement - i];
    }

    return sum;    
}

FillArray(array);
sumParNumber = GetSumParNumber(array);

for(int i= 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}  ");
}
Console.Write(array);

Console.Write($"\nСумма произведений пар чисел массива размером '{sizeArray}', сгенерированного рандомно = " + sumParNumber);
