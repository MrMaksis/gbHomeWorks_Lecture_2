// Task_1

int SearchDivisible(int num1)
{
    int sot = num1 / 10;
    int md = sot % 10;
    return md;
}

Console.Write("Введите трехзначное число: ");
Console.WriteLine($"Второе число: {SearchDivisible(Convert.ToInt32(Console.ReadLine()))}");