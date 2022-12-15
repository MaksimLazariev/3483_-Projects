// Задача 35 Задайте одномерный массив из 123 элементов. Найдите количество элементов массива, которые 10<<99

// Генерируем массив
int[] array = GenArray(123,-100,100);
// Печатаем заданный массив
Print1DArr(array);
// печатаем результат
PrintData("Количество элементов 10<<99 равно ", CountElem(array, 10, 99));


// Метод подсчета элементов min << max
int CountElem(int[] arr, int minNum, int maxNum)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] > minNum)&&(arr[i] < maxNum)) 
        {
            res++;
        }
    }
    return res;
}    

// Метод генерации массива
 int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
//Метод  печати одномерного массива
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// Метод вывода данных
void PrintData( string msg, int res)
{
    Console.WriteLine(msg + res);
}


