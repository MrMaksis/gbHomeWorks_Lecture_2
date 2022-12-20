// Task_3

bool IsEntrance(int day)
{
    if(day > 5 || day == 7){
        return true;
    }
    else    
        return false;
}

Console.Write("Введите день недели: ");
bool en = IsEntrance(Convert.ToInt32(Console.ReadLine()));

if (en == true)
    Console.WriteLine("Сегодня выходной!");
else
    Console.WriteLine("Мы еще работаем!");