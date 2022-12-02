Console.Write("Введите трехзначное число: ");
int numberEnter = Convert.ToInt32(Console.ReadLine());

int secondDigitNumber = (numberEnter / 10) % 10;
Console.WriteLine("Вторая цифра числа: " + secondDigitNumber);