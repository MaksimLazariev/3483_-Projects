// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int coordX01 = ReadData("Введите координату X первой точки: ");
int coordY01 = ReadData("Введите координату Y первой точки: ");
int coordZ01 = ReadData("Введите координату Z первой точки: ");

// Делаем разрыв между вводом точек
Console.WriteLine("");

int coordX02 = ReadData("Введите координату X второй точки: ");
int coordY02 = ReadData("Введите координату Y второй точки: ");
int coordZ02 = ReadData("Введите координату Z второй точки: ");

double length = CalculateLength( coordX01, coordX02, coordY01, coordY02, coordZ01, coordZ02);
PrintData("Расстояние между точками 1й и 2й точками равна ", Math.Round(length,2));  // Округление до сотых

// Метод вывода данных

void PrintData( string msg, double res)
{
    Console.WriteLine(msg + res);
}

// Метод нахождения расстояния L= Sqrt((x01-x02)*(x01-x02)+ (y01-y02)*(y01-y02)+ (z01-z02)*(z01-z02))

double CalculateLength( int X01, int X02, int Y01, int Y02, int Z01, int Z02)
{
    double leng = Math.Sqrt(Math.Pow((X01-X02),2)+ Math.Pow((Y01-Y02),2) + Math.Pow((Z01-Z02),2));
    return leng;
}


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}