// Задача 24 ряд Гаусса, найти сумму чисел от 1 до N 

//запрос данных у пользователя
int ReadData(string line)
{
    Console.Write(line);                                    //выводим сообщение
    int numberP = int.Parse(Console.ReadLine() ?? "0");     //считываем число
    return numberP;                                         //возвращаем значение
}

// Метод вывода результата
void PrintResult(string line)
{
   Console.WriteLine(line);
}


// Метод простой суммы
int VariantSumSimple(int numA)
{
    int sumOfNumbers =0;
    for(int i=1;i<=numA;i++)
    {
        sumOfNumbers+=i;
    }
    return sumOfNumbers;
}

// Метод Гаусса 
int VariantSumGause(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + numA) * numA) / 2;
    return sumOfNumbers;
}

int numberA = ReadData("Введите число А:");


// Замеряем время работы простого метода
DateTime d1 = DateTime.Now;
int res1 = VariantSumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

// Замеряем время работы метода Гаусса
DateTime d2 = DateTime.Now;
int res2 = VariantSumGause(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до A равна(простой метод):" + res1 );
PrintResult("Сумма чисел от 1 до A равна(простой Гауса):" + res2 );