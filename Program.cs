﻿int GetNumSize(int num)
{
    int size = 0;
    while (num > 0)
    {
        size++;
        num /= 10;
    }
    return size;
}

int MthPow(int num, int exp)
{
    int z = num;
    for(int i = 1; i < exp; i++)
    {
        num = num * z;
    }
    return num;
}

bool CeckSimple(int num)
{
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
            return false;
    }
    return true;
}

Console.Write("Введите число ");
int num = 0; // без объявления с Read некорректное значение
num = Convert.ToInt32(Console.ReadLine());
int print = 0;
Console.Write("Выводить подчисла на кослоь (1 - да, 2 - нет) ");
print = Convert.ToInt32(Console.ReadLine());
int size = GetNumSize(num);
int simple = 0;
int count = 0;
for (int i = 1; i < size; i++)
{
    for(int j = 1; j < MthPow(10, (size+1-i)); j *= 10)
    {
        int n = (num / j) % (MthPow(10, i));
            count++;
        if (CeckSimple(n) == true)
        {
            simple++;
        }
        if (print == 1)
        {
            Console.Write($"{n}, ");
        }
    }
}
Console.WriteLine();
Console.Write($"В введенном числе {count} подчисел из них {simple} простых");
