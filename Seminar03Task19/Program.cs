// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


int number = ReadData("Введите пятизначное число ");


// Проверка что число пятизначное
if ((number > 9999) && (number < 100000)) 
{
    if (ItsPalindrome(number)) PrintData( "Это Палиндром ", "");
    else PrintData( "Это не Палиндром ", "");
}
else PrintData( "Это не пятизначное число ","");


// Метод проверки на палиндром

bool ItsPalindrome(int num)
{
    // Создаем и заполняем словарь
    Dictionary<int, int> palindromeDict = new Dictionary<int, int>();
    for (int  number01 = 1; number01 < 10; number01++)
    {
        for (int number02 = 0; number02 < 10; number02++)
        {
            palindromeDict[number01*10+number02] = number01*1000 + number02*100 + number02*10 + number01;
        }
    }
    // Делаем проверку на палиндром
    bool result = false; 
    result = (((number/1000)*100 + number%100) == palindromeDict[num/1000]);    
    return result;
}

// Метод вывода данных

void PrintData( string msg, string res)
{
    Console.WriteLine(msg + res);
}

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
