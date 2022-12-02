/*
* Задача №16
* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
*/
void validate(bool isNumber){
    if (!isNumber){
        Console.WriteLine("Вы ввели не число, выход");
        Environment.Exit(0);
    }
}

bool isSqrt(int a, int b){
    return (a*a == b) || (b*b == a) ;
}


Console.WriteLine("является ли одно число квадратом другого ?");
Console.Write("Введите первое число: ");
int firstNumber;
bool isNumber = int.TryParse(Console.ReadLine(), out firstNumber);
validate(isNumber);

Console.Write("Введите второе число: ");
int secondNumber;
isNumber = int.TryParse(Console.ReadLine(), out secondNumber);
validate(isNumber);

Console.WriteLine(isSqrt(firstNumber,secondNumber)? "Да" : "Нет");

