void Akkerman(int m, int n)
{
    if(m == 0) 
    {
        return n + 1;
    }
    if(m > 0 && n == 0) 
    {
        return Akkerman(m - 1, n = 0);
    }
    if(m > 0, n > 0) 
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return;
}





Console.Write("Введите натуральное число число M: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число число N: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Akkerman(num, num1);