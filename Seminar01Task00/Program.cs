string? Num01Line = Console.ReadLine();     // Считываем данные с консоли 
string? Num02Line = Console.ReadLine();

if(Num01Line!=null && Num02Line!=null)      // проверяем, чтобы данные были не пустыми     
{
    int num01 = int.Parse( Num01Line);      // Парсим введенные числа
    int num02 = int.Parse( Num02Line);

    int outResult = num01 * num02;
    Console.WriteLine(outResult);           // выводим данные на консоль

    //Console.writeLine(Math.Pow(int.Parthe(inputLine),2))
}
