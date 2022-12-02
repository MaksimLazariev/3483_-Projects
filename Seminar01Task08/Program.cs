string? inputLine = Console.ReadLine();             // Считываем данные с консоли 


if(inputLine!=null)                                 // проверяем, чтобы данные были не пустыми     
{
    int inputNumber = int.Parse( inputLine);        // Изменяем введенную строку в целое число
    int index = 2;                                  // счетчик для цикла, стартуем с 2, так как нужны только четные числа
    
    string outLine = string.Empty;

    while ( index <= inputNumber-2)                  // цикл до (введенного числа+1), чтоб если введенное число четное, то оно попадет в строку  
    {
       outLine = outLine + index + ',';             // приписываем четные числа
       index = index+2; 
    }
    
    outLine = outLine + index;
    //outLine = outLine.TrimEnd(',');

    Console.WriteLine(outLine);
}
