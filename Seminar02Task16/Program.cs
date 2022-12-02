void isSqrt (int num01, int num02)
{
    bool result = (num01/num02 == num02);
    
    if (result==true) Console.WriteLine("Число "+ num01 + " является квадратом числа " + num02);
    else Console.WriteLine("Число "+ num01 + " является не квадратом числа " + num02);
}

Console.WriteLine("является ли одно число квадратом другого ?");

Console.Write("Введите первое число: ");
int number01 = int.Parse(Console.ReadLine()??"0");

Console.Write("Введите второе число: ");
int number02 = int.Parse(Console.ReadLine()??"0");

isSqrt (number01, number02);
isSqrt (number02, number01);


// int result = number02%number01;

//if ((number02==number01*number01)||(number01==number02*number02))
//{
//    Console.WriteLine("Число ЯВЛЯЕТСЯ квадратом другого");
//}
//else
//{
//    Console.WriteLine("Число НЕ является квадратом другого");
//}