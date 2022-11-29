//Считываем данные с консоли
string? inputLine = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if (inputLine != null)
{
    //    //Создаем массив с днями недели
    //    string[] dayOfWeek = new string[7];
    //    dayOfWeek[0] = "понедельник";
    //    dayOfWeek[1] = "вторник";
    //    dayOfWeek[2] = "среда";
    //    dayOfWeek[3] = "четверг";
    //    dayOfWeek[4] = "пятница";
    //    dayOfWeek[5] = "суббота";
    //    dayOfWeek[6] = "воскресенье";
    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);
    //     case 7: outDayOfWeek = "воскресенье"; break;
    //     default: outDayOfWeek = "это не день недели!"; break;
    // }

    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber));


    // Выводим данные в консоль 
    Console.WriteLine(outDayOfWeek);
}
