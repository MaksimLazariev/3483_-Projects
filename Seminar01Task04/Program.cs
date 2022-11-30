string? inputLine01 = Console.ReadLine();           // Считываем данные с консоли 
string? inputLine02 = Console.ReadLine();
string? inputLine03 = Console.ReadLine();

if(inputLine01!=null && inputLine02!=null && inputLine03!=null) // проверяем, чтобы данные были не пустыми     
{
    int inputNumber01 = int.Parse( inputLine01);    // Изменяем введенные строки в целые числа
    int inputNumber02 = int.Parse( inputLine02);
    int inputNumber03 = int.Parse( inputLine03);

    if (inputNumber01>inputNumber02)            // Сравниваем 1е и 2е число
    {
        if (inputNumber01>inputNumber03)        // Если 1е число больше, сравниваем его с 3м
        {
            Console.WriteLine("1е число максимальное и равно "+ inputNumber01);  // 1е число максимально
        }
        else
        {
            Console.WriteLine("3е число максимальное и равно "+ inputNumber03);   // 3е число максимально
        }
    }
    else
    {  
        if (inputNumber02>inputNumber03)        // Если 2е число больше, сравниваем его с 3м
        {
            Console.WriteLine("2е число максимальное и равно "+ inputNumber02);  // 2е число максимально
        }
        else
        {
            Console.WriteLine("3е число максимальное и равно "+ inputNumber03);   // 3е число максимально
        }
    }
}
