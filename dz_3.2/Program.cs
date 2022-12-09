Console.WriteLine("Введите Х1:");
float x1 = float.Parse(Console.ReadLine());

Console.WriteLine("Введите Y1:");
float y1 = float.Parse(Console.ReadLine());

Console.WriteLine("Введите Z1:");
float z1 = float.Parse(Console.ReadLine());

Console.WriteLine("Введите Х2:");
float x2 = float.Parse(Console.ReadLine());

Console.WriteLine("Введите Y2:");
float y2 = float.Parse(Console.ReadLine());

Console.WriteLine("Введите Z2:");
float z2 = float.Parse(Console.ReadLine());

float result;

float arg(float coor1, float coor2) 
{
    float tearm =(float) Math.Pow((coor2 - coor1), 2);
    return tearm;
};

result = (float)Math.Sqrt(arg(x1, x2) + arg(y1, y2) + arg(z1, z2));

Console.WriteLine(result);