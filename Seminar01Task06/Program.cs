string? inputLine = Console.ReadLine();             // Считываем данные с консоли 


if(inputLine!=null)                                 // проверяем, чтобы данные были не пустыми     
{
    int inputNumber = int.Parse( inputLine);        // Изменяем введенную строку в целое число
    
    if ((inputNumber%2) == 0)                       // Проверяем остаок от деления на 2
    {
        Console.WriteLine("Число "+ inputNumber+" четное");  // число четное
    }
    else
    {
        Console.WriteLine("Число "+ inputNumber+" нечетное");   // число нечетное
    }    
}
