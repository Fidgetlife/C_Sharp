Console.WriteLine("Введите пятизначное число : ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[5] ;


for(int i = 0; number > 0; i++)
{
    int num = number % 10;
    array[i] = num; 
    
    number = number / 10;
}

int sizeArray = array.Length;
int endIndArray = sizeArray - 1;

for(int i = 0; i <= sizeArray / 2 ; i++)
{
    
    if(array[i] != array[endIndArray])
    {
        Console.WriteLine("Нет, это число не является полиндромом!");
        break;
    }
    
    endIndArray--;

    if(i == sizeArray / 2)
    {
        Console.WriteLine("Да, это число полиндром!");
    }
    
}


