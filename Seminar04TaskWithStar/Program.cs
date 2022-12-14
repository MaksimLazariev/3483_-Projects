// Ввести список имен. Из них случайным образом выбрать одно

// Тело программы

// Вводим список имен через запятую
string nameList = ReadData("Введите список имен через запятую: ");

// Переводим строку имен в строчный массив
string[] nameArray = StringToArray(nameList);

// печатаем случайное имя
PrintData("Случайное имя из списка: ", nameArray[RandomNumber(nameArray.Length)]);


// Метод генерирует случайное число
int RandomNumber(int num)
{
    return new Random().Next(0,num); 
}

// Метод перевода из строки в строчный массив
string[] StringToArray(string line)
{
    string[] stringArray = line.Split(',');
    return stringArray;
}

// Метод ввода данных
string ReadData(string msg)
{
    Console.Write(msg);
    return Console.ReadLine() ?? "0";
}

// Метод вывода данных
void PrintData( string msg, string res)
{
    Console.WriteLine(msg + res);
}