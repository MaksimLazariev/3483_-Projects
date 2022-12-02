// Создаем экземпляр класса Рандомайзер
System.Random numberSintezator = new System.Random();

// Получаем новое случайное число
int number = numberSintezator.Next(100,1000);

// выводим данные в консоль
Console.WriteLine(number);

//Получаем первое и второе число по отдельности

//int firstNumber = number/100;
//int secondNumber = number%10;

//int result = firstNumber*10 + secondNumber;

// Вариант 2

int result = (number/100)*10 + number%10;
Console.WriteLine(result);


// Вариант 3
System.Random random = new System.Random();

int randomNumber = random.Next(100,1000);
Console.WriteLine("число: " + randomNumber);

string value = randomNumber.ToString();
char[] numberArray = value.ToCharArray();

Console.WriteLine(numberArray[0] +"" + numberArray[2]);

