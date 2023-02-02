int InputInt(string massage)
{
    System.Console.WriteLine($"{massage} > ");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int a = InputInt("Введите любое число");
int SumCh (int a)
{
    int sum =0;
    int advance =0;
    while (a>0)
    {
        advance=a%10;
        sum = sum + advance;
        a=a/10;
    }
    return sum;
}
System.Console.WriteLine($"сумма чисел введенного числа равна {SumCh(a)}");
