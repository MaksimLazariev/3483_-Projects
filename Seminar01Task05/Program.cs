//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);     // Парсим строку в число
    int minusNumber = inputNumber * (-1);       // Отриц значение

    string outLine = string.Empty;

    while ( minusNumber < inputNumber)
    {
       outLine = outLine + minusNumber + ',';
       minusNumber++; 
    }

    outLine = outLine + inputNumber;
    Console.WriteLine(outLine);
}

