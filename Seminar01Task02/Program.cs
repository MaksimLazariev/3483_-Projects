string? inputLine01 = Console.ReadLine();           // Считываем данные с консоли 
string? inputLine02 = Console.ReadLine();

if(inputLine01!=null && inputLine02!=null)          // проверяем, чтобы данные были не пустыми     
{
    int inputNumber01 = int.Parse( inputLine01);    // Изменяем введенные строки в целые числа
    int inputNumber02 = int.Parse( inputLine02);

    if (inputNumber01==inputNumber02)
    {
        Console.WriteLine("Числа равны");           // Проверяем, если числа равны
    }
    else
    {
        if (inputNumber01 > inputNumber02)         // Проверка условия, что 1е число больше 2го
        {
            Console.WriteLine(inputNumber01 + " больше "+ inputNumber02); 
        }
        else
        {
            Console.WriteLine(inputNumber01 + " меньше " + inputNumber02); 
        }
    }
}
