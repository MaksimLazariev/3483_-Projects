// Создаем экземпляр класса Рандомайзер
System.Random numberSintezator = new System.Random();

// Получаем новое случайное число
int number = numberSintezator.Next(10,100);

// выводим данные в консоль
Console.WriteLine(number);

//Получаем первое и второе число по отдельности

int firstNumber = number/10;
int secondNumber = number%10;

// Сравниваем числа
if (firstNumber > secondNumber)
{
    // Выводим данные в консоль
    Console.WriteLine(firstNumber);
}
else
{
    // Выводим данные в консоль
    Console.WriteLine(secondNumber);
}

// Вариант 2

char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);

firstNumber = ((int)digits[0])-48;
secondNumber = ((int)digits[1])-48;

int resultNumber = firstNumber > secondNumber?resultNumber = firstNumber:resultNumber = secondNumber;
Console.WriteLine(resultNumber);
 
