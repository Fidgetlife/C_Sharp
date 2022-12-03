Console.Write("Введите число: ");
int numberEnter = Convert.ToInt32(Console.ReadLine());
if(numberEnter % 7 == 0 && numberEnter % 23 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}