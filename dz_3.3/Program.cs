//int[] array = new int[] { 1, 2, 3 };
//var str = string.Join(" ", array);
//Console.WriteLine(str);

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

for(int i = 0; i < num; i++)
{
    array[i] = (int)Math.Pow(i+1, 3);
}

string str = string.Join(" ", array);    
Console.WriteLine(str);
