
int[] Random_mas(int num)
{
    int[] mas = new int[num];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(0, 11);
    }
    return mas;
}

void Print_mas(int[] mas)
{
    foreach (var i in mas)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

void GetListNums(int[] mas, int index = 0)
{
     if(index == mas.Length) return;
    GetListNums(mas, index + 1);
    Console.Write($"{mas[index]} "); 
}

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = Random_mas(n);
Print_mas(array);
GetListNums(array);