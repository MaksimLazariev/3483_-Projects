// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

PrintData("Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N" , "");

int number = ReadData("Введите число N: ");

// Находим длину куба данного числа ( оно имеет максимальную длину из всех чисел)
int maxCubeLength = (int)Math.Log10(Math.Pow(number, 3)) + 1;

// Рисуем черту
PrintData( SymbolBuilder( (maxCubeLength+1)*number +1, '-') , "");

// Выводим список чисел по порядку
string outLine = LineBuilder(number, 1, maxCubeLength );
PrintData("", outLine);

// Рисуем черту 
PrintData( SymbolBuilder( (maxCubeLength+1)*number +1, '-') , "");

// Выводим список кубов по порядку
outLine = LineBuilder(number, 3, maxCubeLength );
PrintData("", outLine);

// Рисуем черту
PrintData( SymbolBuilder( (maxCubeLength+1)*number +1, '-') , "");




// Метод наполнения строки повторяющимся заданным символом (пробелом или горизонтальной чертой)

string SymbolBuilder(int counter, char symbol)
{
    string line = string.Empty;
    for (int i = 0; i < counter; i++)
    {
       line = line + symbol; 
    }
    return line;
}

// Метод вывода данных

void PrintData( string msg, string res)
{
    Console.WriteLine(msg + res);
}

// Метод сборки строки

string LineBuilder(int n, int pow, int countOfSpace)
{
    string line = string.Empty;
    for (int i=1; i<n; i++)
    {
        // наполняем строку: черта + пробелы + число
        line = line + '|'+ SymbolBuilder(countOfSpace - (int)Math.Log10(Math.Pow(i, pow))-1, ' ') + Math.Pow (i, pow) ;
    }

    // дописываем последнее число
    line = line + '|'+ SymbolBuilder(countOfSpace - (int)Math.Log10(Math.Pow(n, pow))-1, ' ') + Math.Pow (n, pow) + '|';
    return line;
}

// Метод читает данные от пользователя

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
