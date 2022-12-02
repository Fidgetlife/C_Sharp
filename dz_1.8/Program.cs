Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int start = 2;

while(start <= num)
{
    Console.Write(start + ",");
    start = start +2;
}