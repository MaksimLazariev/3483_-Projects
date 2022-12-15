// Задача №33  Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// генерируем массив
int[] array = GenArray(20, -9, 9);
// Печатаем массив
Print1DArr(array);
// Ввод искомого числа
int num = ReadData("Введите число");
// Поиск числа
int result = SearchElem(array, num);

if (result >= 0) PrintData("Элемент найден в позиции: " + result);
else PrintData("В массиве элемент не найден!");

// Метод ввода данных
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

// Метод генерации массива
int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

// Метод печати одномерного массива
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// Метод поиска элемента
int SearchElem(int[] arr, int elem)
{
    int res = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elem)
        {
            res = i;
            break;
        }
    }
    return res;
}

