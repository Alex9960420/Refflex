int Akkerman(int m, int n)
{
    if(m == 0) 
    {
        return n + 1;
    }
    else if(n == 0) 
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Console.Write("Введите натуральное число число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число число N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат вычисления функции Аккермана для {num} и {num1}: {Akkerman(num, num1)}");