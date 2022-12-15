// Задача 37 Найди произведение пар чисел в одномерном массиве (1й и последн, 2й и предпосл)

// Генерируем массив
int[] array = GenArray(10,-10,10);
// Печатаем заданный массив
Print1DArr(array);
// Печатаем перевернутый массив
Print1DArr(Convert(array));

// Метод нахождения произведений пар чисел

int[] Convert(int[] arr)
{
    int[] outArray = new int[arr.Length/2];
    for (int i = 0; i < arr.Length/2; i++)
    {
        outArray[i] = arr[i]*arr[array.Length-i-1];
    }
    return outArray;
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