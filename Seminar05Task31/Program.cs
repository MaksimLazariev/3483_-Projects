// Задача №31 Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int positivSum=0;
int negativSum=0;

int[] testArray = GenArr(12, -9, 9);
NegotPositSum(testArray);
Print1DArr(testArray);

PrintData("Сумма положительных чисел ", positivSum);
PrintData("Сумма отрицательных чисел ", negativSum);

// Метод генератора массива
int[] GenArr(int length, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue);
    }
    return arr;
}

// Метод вывода данных

void PrintData( string msg, int res)
{
    Console.WriteLine(msg + res);
}

void NegotPositSum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {   
        if(arr[i]>0)    positivSum+=arr[i];
        else            negativSum+= arr[i];
    }
}

// Печатаем одномерный массив
    void Print1DArr(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)    Console.Write(arr[i] + ", ");
        Console.WriteLine(arr[arr.Length - 1]);
    }

