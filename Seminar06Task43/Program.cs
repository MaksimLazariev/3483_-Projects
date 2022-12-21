// Задача 43*: Напишите программу, которая найдёт три точки пересечения трех прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 и y = k3 * x + b3;
// Три точки образуют треугольник Найти площадь треугольника . Значения b1, k1, b2, k2, b3, k3 задаются пользователем.

//--------------Тело программы --------------

PrintData("\nПрограмма считает площадь треугольника, образованный точками пересечения трех прямых, заданных уравнениями y=Kx+B ");

// Вводим коэфициенты уравнений трех прямых
int k01 = ReadData("Введите коэфициент K01: ");
int b01 = ReadData("Введите коэфициент B01: ");
int k02 = ReadData("Введите коэфициент K02: ");
int b02 = ReadData("Введите коэфициент B02: ");
int k03 = ReadData("Введите коэфициент K03: ");
int b03 = ReadData("Введите коэфициент B03: ");

// Находим точки пересечения трех прямых
// Проверяем, чтоб коэфециенты k01, k02, k03 не были попарно равны ,иначе прямые параллельны, тогда нет решения задачи 
if ((k01 != k02) && (k01 != k03) && (k02 != k03))
{
    // A: пересечение 1й и 2й прямых, округляем до сотых
    double x12 = CrossXPoint(k01, b01, k02, b02);
    double y12 = CrossYPoint(k01, b01, x12);
    PrintData($"\nТочка пересечения 1й и 2й прямых A: ({x12.ToString()}, {y12.ToString()})");

    // В: пересечение 1й и 3й прямых, округляем до сотых
    double x13 = CrossXPoint(k01, b01, k03, b03);
    double y13 = CrossYPoint(k01, b01, x13);
    PrintData($"Точка пересечения 1й и 3й прямых B: ({x13.ToString()}, {y13.ToString()})");

    // С: пересечение 2й и 3й прямых, округляем до сотых
    double x23 = CrossXPoint(k02, b02, k03, b03);
    double y23 = CrossYPoint(k02, b02, x23);
    PrintData($"Точка пересечения 2й и 3й прямых C: ({x23.ToString()}, {y23.ToString()})");

    // Находим длины сторон треугольника, округляем до сотых
    double AB = CalculateLength(x12, y12, x13, y13);
    double BC = CalculateLength(x13, y13, x23, y23);
    double AC = CalculateLength(x12, y12, x23, y23);
    PrintData($"\nСтороны треугольника равны: AB={AB.ToString()}, BC={BC.ToString()}, AC={AC.ToString()}");

    // Находим площадь треугольника
    double square = TriangleSquare( AB, BC, AC);
    PrintData($"\nПлощадь треугольника равна {square}");

}
// Прерываемим программу, если есть пара равных коэфициентов k01, k02, k03
else
{
    PrintData("\nПрямые не пересекаются, нет решения задачи, программа завершена");
    return;
}

//-------------- Методы ---------------------

// Метод нахождения площади треугольника по трем стронам
double TriangleSquare(double a, double b, double c)
{
    double semiPerim = ( a+b+c )/2;
    return Math.Round( Math.Sqrt( semiPerim * ( semiPerim-a) * ( semiPerim-b ) * (semiPerim-c )), 2);
}

// Метод нахождения расстояния L= Sqrt((x01-x02)*(x01-x02)+ (y01-y02)*(y01-y02))
double CalculateLength(double X01, double Y01, double X02, double Y02)
{
    return Math.Round(Math.Sqrt(Math.Pow((X01 - X02), 2) + Math.Pow((Y01 - Y02), 2)), 2);
}

// Метод нахождения X точки пересечения двух прямых // x = b2-b1 / k1 - k2
double CrossXPoint(double k1, double b1, double k2, double b2)
{
    return Math.Round((b2 - b1) / (k1 - k2), 2);
}

// Метод нахождения Y точки пересечения двух прямых // подставляем найденый Х точки пересечения и коэфециенты в любое уравнение, например первое
double CrossYPoint(double k, double b, double x)
{
    return Math.Round(k * x + b, 2);
}

// Метод ввода
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода
void PrintData(string res)
{
    Console.WriteLine(res);
}