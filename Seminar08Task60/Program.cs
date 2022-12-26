// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// просто доработать двумерные

//-------------- Тело программы--------------
PrintData("Программа заполняет трехмерную матрицу уникальными двузначными числами\n");

int height = ReadData("Введите высоту массива: ");
int length = ReadData("Введите  длину массива: ");
int width  = ReadData("Введите ширину массива: ");

// Проверяем, что количество элементов меньше или равно 90, иначе не хватит уникальных элементов
if (height * length * width <= 90)
{
    // Создаем список с уникальными 90 числами от 10 до 99 
    List<int> numbersList = ListAdd();
    // Генерируем массив
    int[,,] array = Fill3Array(height, length, width, numbersList);
    // Печатаем заданный массив
    PrintData($"\nИсходный массив {height}x{length}x{width}\n");
    Print3DArray(array);
}
else
{
    PrintData("\nКоличество элементов массива больше 90, задайте меньше количество элементов.");
}

//---------------Методы-----------------------

// Метод генерации списка двухзначных чисел от 10 до 99
List<int> ListAdd()
{
    List<int> num = new List<int>(90);
    for (int i = 0; i < 90; i++)
    {
        num.Add(10 + i);
    }
    return num;
}

// Метод генерации уникального числа из списка
int GetUniqueNumber(List<int> num)
{
    // Выбираем случайный индекс из списка, передаем значение в переменную
    int index = new Random().Next(0, num.Count);
    int outNum = num[index];
    // Удаляем переданный элемент для сохранения уникальности
    num.RemoveAt(index);
    return outNum;
}

// Метод генерации  3D массива уникальными двузначными числами
int[,,] Fill3Array(int countHeight, int countLength, int countWidth, List<int> num)
{
    int[,,] array3D = new int[countHeight, countLength, countWidth];
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = GetUniqueNumber(num);
            }
        }
    }
    return array3D;
}

//Метод  печати трехмерного массива
void Print3DArray(int[,,] matr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.ForegroundColor = col[matr[i, j, k] % 16];
                Console.Write($"{matr[i, j, k]} ({i},{j},{k})");
                Console.Write("     ".Substring(matr[i, j, k].ToString().Length));
                Console.ResetColor();

            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных
void PrintData(string msg)
{
    Console.WriteLine(msg);
}