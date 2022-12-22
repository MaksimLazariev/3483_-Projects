// Задача 42 Программа преобразовывает 10ные числа в 2ные

// Вводим число
int inputNumber = ReadData("Enter number: ");

PrintData("Result: " + DegToBin(inputNumber));              
PrintData("Result: " + DecToBinNativ(inputNumber));            // Переводим в 2ную систему
PrintData("Result: " + Convert.ToString(inputNumber, 8));      // Переводим в 8ную систему 
PrintData("Result: " + Convert.ToString(inputNumber, 16));     // Переводим в 16ную систему

// Метод ввода
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод перевода из 10ного числа в 2ное число  
string DegToBin(int num)
{
    string outBin = String.Empty;
    while (num > 0)
    {
        outBin = (num % 2) + outBin;
        num = num / 2;
    }
    return outBin;
}
// Системный метод конвертации
string DecToBinNativ(int num)
{
    return Convert.ToString(num, 2);
}
