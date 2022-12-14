// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int number = ReadData("\nВведите число: ");

// Засекаем время работы 1го метода
DateTime d1 = DateTime.Now;
int res01 = SimpleMethod(number);

// Выводим результат по первому методу и его время работы
PrintData ("\nСумма цифр по методу деления на 10 равна ", res01);
Console.Write("Время работы метода: ");
Console.WriteLine(DateTime.Now - d1);   

// Засекаем время работы 2го метода
DateTime d2 = DateTime.Now;
int res02 = StringMethod(number); 

// Выводим результат по второму методу и его время работы
PrintData ("\nСумма цифр по строчному методу равна ", res02);
Console.Write("Время работы метода: ");
Console.WriteLine(DateTime.Now - d2);

// Метод деления
int SimpleMethod(int num)
{
    int result = 0;
    while ( num > 0)
    {
        result += num%10;     // прибавляем остаток от деления на 10
        num = num/10;         // уменьшаем число, делим на 10
    } 
    return result;
}

// Метод строки
int StringMethod(int num)
{
    string numLine = num.ToString();        // переводим число в строку
    
    int result = 0;
    for (int i = 0; i < numLine.Length; i++) // берем цикл по длине числа/строки
    {
       result +=  int.Parse(Convert.ToString(numLine[i]));  // сумммируем по одной цифре, переводя их в число
    }
    return result;
}

// Ввод данных 
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных

void PrintData( string msg, int res)
{
    Console.WriteLine(msg + res);
}