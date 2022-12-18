int countNumber = 0;
int greatThanZero = 0;

string str1 = "чисел";
string str2 = "числа";

string ReplaceWord(int num)
{
    if(num == 0 || num > 4)
    {
        return str1;
    }
    else
    {
        return str2;
    }
}

void EnterNumber()
{
    Console.Write("Введите число. Если хотите прервать ввод, нажмите 'st'\n");
    string str = Console.ReadLine();
        
    if(str != "st")
    {
        int num = Convert.ToInt32(str);
        if(num > 0) 
        {
            countNumber++;
            greatThanZero++;
            EnterNumber();
            
        }
        else
        {
            countNumber++;
            EnterNumber();
        }
    }
    else
    {
        return;
    }
    
}

EnterNumber();

Console.Write($"Вы ввели '{countNumber}' {ReplaceWord(countNumber)}, из них больше '0' {greatThanZero} {ReplaceWord(greatThanZero)}");
