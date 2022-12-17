// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//* Добавить сортировки: 1. Методом пузырька; 2. Методом вставки; 3. Методом подсчета; Оценить их быстродействие

//------------  Тело программы ------------------

// Console.Clear();
// Генерируем массив
int[] array = GenArray(30,0,10);
// Печатаем заданный массив
PrintData("Рандомный массив");
Print1DArr(array);

// Ради интереса замерил скорость стандартного метода
DateTime d0 = DateTime.Now;
// Стандартный метод поиска разницы
PrintData("Разница между минимальным и максимальным элементами равна " + (MaxNumber(array)-MinNumber(array)));

Console.Write("Время работы метода: ");
Console.WriteLine(DateTime.Now - d0);   

//----------- Метод Пузырька ----------------

// Сначала копируем основной массив во второстепенный. Иначе будет осортирован основной массив, и дальнейшие методы будут бесполезны
int[] bubbleArray = new int[array.Length];
array.CopyTo(bubbleArray, 0);

// Засекаем время работы 1го метода
DateTime d1 = DateTime.Now;

// Печатаем отсортированный методом пузырька массив
PrintData("\nМассив отсортирован методом пузырька");
bubbleArray = BubbleSort(bubbleArray);
Print1DArr(bubbleArray);

// Находим разницу между минимальным и максимальным значением (последний элемент минус первый элемент)
PrintData("Разница между минимальным и максимальным элементами равна " + (bubbleArray[bubbleArray.Length-1] - bubbleArray[0]));

Console.Write("Время работы метода: ");
Console.WriteLine(DateTime.Now - d1);   

// --------- Метод Вставки ---------

// Сначала копируем основной массив во второстепенный. Иначе будет осортирован основной массив, и дальнейшие методы будут бесполезны
int[] insertArray = new int[array.Length];
array.CopyTo(insertArray, 0);

// Засекаем время работы 2го метода
DateTime d2 = DateTime.Now;

// Печатаем отсортированный методом вставки массив
PrintData("\nМассив отсортирован методом вставки");
insertArray = InsertionSort(insertArray);
Print1DArr(insertArray);
// Находим разницу между минимальным и максимальным значением (последний элемент минус первый элемент)
PrintData("Разница между минимальным и максимальным элементами равна " + (insertArray[insertArray.Length-1] - insertArray[0]));

Console.Write("Время работы метода: ");
Console.WriteLine(DateTime.Now - d2);

//---------  Метод подсчета -----------------------

// Сначала копируем основной массив во второстепенный. Иначе будет осортирован основной массив, и дальнейшие методы будут бесполезны
int[] countArray = new int[array.Length];
array.CopyTo(countArray, 0);

// Засекаем время работы 3го метода
DateTime d3 = DateTime.Now;

// Печатаем отсортированный методом подсчета массив
PrintData("\nМассив отсортирован методом подсчета");
countArray = CountingSort(countArray, 0, 10);                  
Print1DArr(countArray);
// Находим разницу между минимальным и максимальным значением (последний элемент минус первый элемент)
PrintData("Разница между минимальным и максимальным элементами равна " + (countArray[countArray.Length-1] - countArray[0]));

Console.Write("Время работы метода: ");
Console.WriteLine(DateTime.Now - d3);

PrintData("");

// ------------------   Методы -----------------------------

// Метод поиска максимального элемента
int MaxNumber(int[] arr)
{
    int maxNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > maxNum) maxNum = arr[i];
    }
    return maxNum; 
}

// Метод поиска минимального элемента
int MinNumber(int[] arr)
{
    int minNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < minNum) minNum = arr[i];
    }
    return minNum; 
}


// Метод сортировки пузырьком. Самый максимальный отодвигаем вправо, затем уменьшаем ряд на один, начинаем сначала.
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

// Метод сортировки вставкой. Каждому последующему элементу находим свое место в ряде. Постепенно ряд увеличиваем на один.
int[] InsertionSort(int[] arr)
{
    int temp=0;
    int j=0;
    for (int i = 1; i < arr.Length; i++)
    {
        j=i-1;
        while((j>=0)&&(arr[j]>arr[j+1]))
        {
            temp = arr[j];                      // обмен
            arr[j] = arr[j+1];
            arr[j+1]=temp;
            j--;
        }

    }
    return arr;
}

// Метод сортировки подсчетом. Нужно знать границы значений массива. Считаем для каждого значения количество вхождений в массив, записываем количество во вспомогательный массив (индекс вспог массива = знчение основного массива )
int[] CountingSort(int[] arr, int minNum, int maxNum)
{
    int j = 0;
    int[] countArr = new int[maxNum+1];         // Заводим вспомогательный массив длиной равной максимальному значению заданного массива. По умолчанию элементы int массива равны 0, как и требуется в условиях сортировки. 

    for (int i = 0; i < arr.Length; i++)        // Заполняем вспомогательный массив
    {
        countArr[arr[i]] += 1;                  // Увеличиваем на 1 ячейки под тем же номером в массиве с результатом подсчёта
    }
    
    for (int i = minNum; i < maxNum + 1; i++)   // Заполняем основной массив при помощи второстепенного
    {
        while (countArr[i] > 0) 
        {
            arr[j] = i;                         // добавляем номер ячейки в исходный массив
            j++;                                // переходим к следующему элементу в исходном массиве
            countArr[i]--;                      // уменьшаем на единицу содержимое ячейки в массиве с подсчётом
        }

    }
    return arr;
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