string? al = Console.ReadLine();     // Считываем данные с консоли 
string? bl = Console.ReadLine();

if(al!=null && bl!=null)      // проверяем, чтобы данные были не пустыми     
{
    int a = int.Parse( al);      // Парсим введенные числа
    int b = int.Parse( bl);

    if ( a == b*b )
    {
        Console.WriteLine("Первое число квадрат второго");
    }
    else
    {
        Console.WriteLine("Первое число квадрат второго");
    }  
}

