// Task_2

int SearchDivisible(int num1)
{
    if(num1 / 100 != 0){
        int md = num1 % 10;
        return md;
    }
    else
        return 0;
}

Console.Write("Введите трехзначное число: ");
int ed = SearchDivisible(Convert.ToInt32(Console.ReadLine()));

if(ed != 0)
    Console.WriteLine($"Число с конца: {ed}");
else
    Console.WriteLine("Третьего числа нет!");

