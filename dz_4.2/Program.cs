Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;
int num = 0;
int numberForCycle = number;

while(numberForCycle != 0)
{
    num = numberForCycle % 10;

    if(num == 0 || number % num == 0)  
    {
        result = result + num;
    }

    numberForCycle = numberForCycle / 10;

}

Console.Write($"Сумма цифр, делителей без остатка, входящих в состав числа '{number}' = " + result);