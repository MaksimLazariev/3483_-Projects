// Программа,  которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Вводим число
Console.Write("Введите день недели: ");
int number = int.Parse(Console.ReadLine()??"0");

// делаем цикл, если выполняется условие 0<number<8
if((number> 0)&&(number< 8))                                         
{

// Вариант 1
    if(number> 5)
    {
        Console.WriteLine("Это выходной");    
    }
    else
    {
        Console.WriteLine("Это рабочий день");
    }

// Вариант 2

// Заводим массив под все значения дней недели
string[] daysOfWeek = new string [7];
daysOfWeek[0] = "рабочий"; daysOfWeek[1] = "рабочий"; daysOfWeek[2] = "рабочий"; daysOfWeek[3] = "рабочий"; daysOfWeek[4] = "рабочий";
daysOfWeek[5] = "выходной"; daysOfWeek[6] = "выходной";

// Выводим значение массива по дню
Console.WriteLine("Этот день " + daysOfWeek[number-1]);

// Вариант 3

// Заполняем словарь
Dictionary<int, string> dict = new Dictionary<int, string>
{
    { 1, "рабочий день" },
    { 2, "рабочий день" },
    { 3, "рабочий день" },
    { 4, "рабочий день" },
    { 5, "рабочий день" },
    { 6, "выходной день" },
    { 7, "выходной день" },
};

// Выводим значение словаря по дню
Console.WriteLine(dict[number]);

}
else
{
// выводим, если не выполняется условие    
    Console.WriteLine("Это не день недели");                          
}
