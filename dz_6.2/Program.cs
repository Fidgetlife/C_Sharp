Console.Write("Введите значение B1:\t");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение K1:\t");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение B2:\t");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Введите значение K2:\t");
double k2 = double.Parse(Console.ReadLine());

double x = 0;
double y = 0;

void MathMetod(double arg1, double arg2, double arg3, double arg4)
{
    x = -((arg1 - arg3) / (arg2 - arg4));
    y = x * arg2 + arg1;
}

MathMetod(b1, k1, b2, k2);
Console.Write($"\n Координаты точки пересечения двух прямых ({x}; {y})");