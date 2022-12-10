int Exponentiation(int num, int pow)
{
    int result = num;
    for(int i = 1; i < pow; i++)
    {
        result = result * num;
    }
    
    return result;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень числа, в которую нужно возвести: ");
int powNumber = Convert.ToInt32(Console.ReadLine());


int example = Exponentiation(number, powNumber);
Console.Write($"Число '{number}' в степени '{powNumber}' равно: " + example);
