// ---------------------------------------------------------------------
//                                 Задача 66
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// ---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int prefix)
{
    Console.WriteLine(prefix.ToString());
}

// Нахождение суммы от M до N рекурентно 
int RecSumMN(int M, int N)
{
    int sum=0;
    if (M >= N) return sum +=N;             // точка остановки
     sum += M +  RecSumMN(M + 1, N);        // изменение при вызове
    return sum;
}

// ---------------- Тело программы --------------------------

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
int sumMN= number1<number2? RecSumMN(number1, number2):RecSumMN(number2, number1);
PrintResult(sumMN);