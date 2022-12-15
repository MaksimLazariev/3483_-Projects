// Задача 32 Программа заменяет положительные элементы на отрицательные, и наоборот.

    // Генерируем массив
    int[] array = GenArray(10,-9,9);
    // Печатаем заданный массив
    Print1DArr(array);
    // Инвертируем массив
    int[] newArray = InverseArr(array);
    // Печатаем измененный массив
    Print1DArr(newArray);

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

    // Метод инверсии (*(-1)) массива
    int[] InverseArr(int[] arr)
    {
        int[] outArr = new int[arr.Length];
        for(int i=0;i<arr.Length;i++) outArr[i]=arr[i]*(-1);
        return outArr;
    }
