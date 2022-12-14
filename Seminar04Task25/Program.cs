// Задача 25: Программа, которая принимает на вход два числа (A и B) и операцию (+, -, *, /, pow) и выводит результат операции

int number01 = int.Parse(ReadData("Введите первое число: ")); //   int.Parse(Console.ReadLine() ?? "0");
int number02 = int.Parse(ReadData("Введите второе число: "));
string actionSymbol = ReadData("Введите символ оператора ( +, -, *, /,  ^(возведение в степень)): ");

operationCheck( number01, number02, actionSymbol);

// Метод выбора оператора
void operationCheck(int x, int y, string operate)
{
    // Запускаем проверку, чтоб оператор был верный
    if((operate =="+" ) || (operate =="-" ) || (operate =="*" ) || (operate =="/" ) || (operate =="^" ))
    {
        // в зависимости от значения оператора запускаем искомый метод
        if(operate == "+")   PrintData(x, y, operate, sum(x, y) );
        if(operate == "-")   PrintData(x, y, operate, difference(x, y) );
        if(operate == "*")   PrintData(x, y, operate, multiplicate(x, y) );
        if(operate == "/")   PrintData(x, y, operate, division(x, y) );
        if(operate == "^")   PrintData(x, y, operate, pow(x, y) );
    }
    // если оператор введен неверно
    else  Console.WriteLine( "введен неверный символ оператора ");
}
// Метод сложения
int sum(int x, int y)
{
    return x+y;
}

// Метод вычитания
int difference(int x, int y)
{
    return x-y;
}

// Метод умножения
int multiplicate(int x, int y)
{
    return x*y;
}

// Метод деления
int division(int x, int y)
{
    return x/y;
}

// Метод возведения в степень
int pow(int x, int y)
{
    int result = 1;
    for (int i = 0; i < y; i++)
    {
        result = result * x;
    }
    return result;
}

// Метод ввода данных
string ReadData(string msg)
{
    Console.Write(msg);
    return Console.ReadLine() ?? "0";
}

// Метод вывода данных
void PrintData( int x, int y, string operate, int res)
{
    Console.WriteLine(x + " " + operate + " " + y + " " +"= " + res);
}
