// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int quarter = ReadData("Введите четверть: ");

PrintAnswer(quarter);

// Метод нхождения значений X и Y по четверти

void PrintAnswer(int num)
{
    if (( num > 0) && (num < 5))
    {
        if ( num == 1) Console.WriteLine("X > 0, Y > 0");
        if ( num == 2) Console.WriteLine("X > 0, Y < 0");
        if ( num == 3) Console.WriteLine("X < 0, Y < 0");
        if ( num == 4) Console.WriteLine("X < 0, Y > 0");
    }
    else Console.WriteLine("Вы ввели неверный номер четверти!");
}


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
