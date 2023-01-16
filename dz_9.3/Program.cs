/* Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 (?)
m = 3, n = 2 -> A(m,n) = 29 (?) */


int FunctionAkkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return FunctionAkkerman(n - 1, 1);
    else
      return FunctionAkkerman(n - 1, FunctionAkkerman(n, m - 1));
}

Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.Write(FunctionAkkerman(numberM, numberN));