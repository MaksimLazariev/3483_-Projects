// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// * Написать метод сортировки пузырьком

Console.Clear();
// Генерируем массив
int[] array = GenArray(10,-10,10);
// Печатаем заданный массив
PrintData("Рандомный массив");
Print1DArr(array);
// Выводим количество элементов, удовлетворяющих условию
PrintData("количетво четных элементов в массиве равно " + ElementsCount(array));

// Печатаем осортированный методом пузырька массив
PrintData("\nМассив отсортирован методом пузырька");
Print1DArr(BubbleSort(array));



// Метод сортировки пузырьком. 
int[] BubbleSort(int[] arr)
{
    int temp=0;
    for (int i = 0; i < arr.Length; i++)
    {
        bool checker = false;          // Переменная для проверки, был ли обмен значениями при проходе второго цикла
        for (int j = 0; j < arr.Length-i-1; j++)
        {
            if(arr[j]>arr[j+1])         // Если элемент больше следующего, делаем обмен значениями  
            {
                temp = arr[j];          // обмен
                arr[j] = arr[j+1];
                arr[j+1]=temp;
                checker = true;         // ставим значение, что был обмен
            }            
        }
        if(!checker) break;             // если не было обменов, то выходим из цикла For, сортировка окончена. 
    }
    return arr;
}

// Метод подсчета элементов в массиве, удовлетворяющих условию
int ElementsCount(int[] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(EvenTest(arr[i])) count++;
    }
    return count;
}

// Метод проверки четного числа
bool EvenTest(int num)
{
    return (num%2 == 0);
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
void PrintData( string msg)
{
    Console.WriteLine(msg);
}