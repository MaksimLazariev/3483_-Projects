// Задача 40  Вводим 3 числа. Нужно определить, может ли существовать тругольник с такими стронами

// int a = ReadData("Введите первое число: ");
// int b = ReadData("Введите второе число: ");
// int c = ReadData("Введите третье число: ");

// if (TriangleTest(a, b, c)) PrintData("Может существовать треугольник сo сторонами такой длины.");
// else PrintData("Треугольник сo сторонами такой длины не существует.");
// //Метод, считывающий данные, введенные пользователем
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// //Метод, выводящий на печать данные пользователю
// void PrintData(string res)
// {
//     Console.WriteLine(res);
// }

// bool TriangleTest(int a, int b, int c)
// {
//     return ((a + b > c) && (a + c > b) && (b + c > a));
// }
int A = ReadData("Enter first number: ");//1c
int B = ReadData("Enter second number: ");//1c
int C = ReadData("Enter third number: ");//1c
//TriangleTest(A,B,C);//50c
PrintData ("Result: "  + TriangleTest(A,B,C));//1

//103c

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

// Тест на треугольник
bool TriangleTest (int a, int b, int c)
{
    return ((a+b>c)&& (a+c>b)&& (b+c>a));
}