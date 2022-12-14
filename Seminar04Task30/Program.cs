// Задача 30 Программа, которая выводит массив из 8 элементов, заполненных 0 и 1 в случайном порядке


// Метод ввода данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных (связан с методом вывода массива) 
void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArr(arr);
}

// Метод генератора массива
int[] GenArr(int num)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

// Метод вывода массива
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

// Тело программы
int arrLen = ReadData("Введите длину массива.");
int[] arr = GenArr(arrLen);
PrintData("Сгененрированный массив:",arr);