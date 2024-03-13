void GetListNums(int left, int right)
{
     if(left == right) 
     {
        Console.WriteLine($"{left}");
        return;
     }
    Console.Write($"{left} ");
    GetListNums(left + 1, right); 
   

}
Console.Write("Введите натуральное число число M: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число число N: ");
int num1 = Convert.ToInt32(Console.ReadLine());
GetListNums(num, num1);
