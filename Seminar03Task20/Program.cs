// Задача №20 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int coordX01 = ReadData("Введите координату X первой точки: ");
int coordY01 = ReadData("Введите координату Y первой точки: ");

int coordX02 = ReadData("Введите координату X второй точки: ");
int coordY02 = ReadData("Введите координату Y второй точки: ");

double length = CalculateLength( coordX01, coordY01, coordX02, coordY02);
PrintData("Расстояние между точками X и Y равна ", length);

// Метод вывода данных

void PrintData( string msg, double res)
{
    Console.WriteLine(msg + res);
}

// Метод нахождения расстояния L= Sqrt((x01-x02)*(x01-x02)+ (y01-y02)*(y01-y02))

double CalculateLength( double X01, double Y01, double X02, double Y02)
{
    double leng = Math.Sqrt(Math.Pow((X01-X02),2)+ Math.Pow((Y01-Y02),2));
    return leng;
}


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

