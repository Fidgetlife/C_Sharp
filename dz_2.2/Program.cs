int randomNumber = new Random().Next(0, 99999);
if(randomNumber / 100 >0)
{
    int thirdDigit = (randomNumber / 100) % 10;
    Console.WriteLine(randomNumber);
    Console.WriteLine("Третья цифра числа: " + thirdDigit);
}
else
{
    Console.WriteLine(randomNumber);
    Console.WriteLine("У числа нет треьей цифры!");
}