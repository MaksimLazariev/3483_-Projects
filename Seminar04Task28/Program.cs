// Задача 28 найти произведение чисел от 1 до N

using System.Numerics;

// Ввод данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Вывод данных
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Простой метод
BigInteger CalcFactor(int num)
{    
    BigInteger count = 1;
    for(int i=1;i<=num;i++)
    {
       count *= i;
    }
    return count;
}

int number = ReadData("Введите число А:");

BigInteger length1 = CalcFactor(number);

PrintData("Факториал равно^ " + length1);
