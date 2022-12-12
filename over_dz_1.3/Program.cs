int GetNumber()
{
    int number = new Random().Next(0, 1000);
    return number;
}

Console.Write("Введите длину массива:");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] newArray = new int[sizeArray];
for(int addressEl = 0; addressEl < sizeArray; addressEl++ )
{
    newArray[addressEl] = GetNumber();
}


int[] countArray = new int[sizeArray];

for(int i = 0; i < sizeArray - 1; i++)
{
    if(newArray[i] < newArray[i+1]) 
    {
        countArray[i] = 1; 
    }
    else
    {
         countArray[i] = 0; 
    }  
}

int count = 0;
for(int y = 0; y < sizeArray-1; y++)
{
    if(newArray[y] > newArray[y + 1]) count++;
}

int el = 0;
while(el < sizeArray)
{
    Console.Write($"{newArray[el]} ");
    el++;
}

Console.WriteLine($"Число подъемов в массиве равно: {count}");

// Нужно доработать. Есть нюансы.
