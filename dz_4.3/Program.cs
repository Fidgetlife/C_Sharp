// Метод для генерирования случайного числа;
int GetNumber()
{
    int number = new Random().Next(10, 1000);
    return number;
}

// Метод для нахождения произведения состовных цифр числа;
int GetProd(int number)
{
    int product = 1;
    int num = 0;
    
    while(number > 0)
    {
        num = number % 10;
        if(num != 0)
        {
            product *= num;
        }
        
        number /= 10;
    }

    return product;
}

// Метод для подсчета суммы состовных цифр числа;
int GetSum(int number)
{
    int sum = 0;
    int num = 0;
    
    while(number > 0)
    {
        num = number % 10;
        sum += num;
        number /= 10;
    }

    return sum;
}
//Инициализация массива для заполнения интересными числами;

int[] array = new int[10]; 

// Цикл по перебору и заполнению массива интересными числами;
for(int i = 0; i < array.Length; i++)
{
    int numberGetForArray = 1;
    do
    {
        numberGetForArray = GetNumber();
        if(GetProd(numberGetForArray) % GetSum(numberGetForArray) == 0)
        {
            array[i] = numberGetForArray;           
        }
    }  
    while(GetProd(numberGetForArray) % GetSum(numberGetForArray) != 0);
}

string str = string.Join(" ", array);
Console.Write(str);

