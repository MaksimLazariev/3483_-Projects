// ---------------------------------------------------------------------
//                                 Задача 68
//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// ---------------------------------------------------------------------
//  m = 2, n = 3 -> A(m,n) = 9
//  m = 3, n = 2 -> A(m,n) = 29
//
// ---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

// Нахождение суммы от M до N рекурентно 
int AccermanFunc(int N, int M)
{
    if (N==0) return M+1;                                  // точка остановки
    if (M==0 && N!=0) return AccermanFunc(N-1, 1);          
    return AccermanFunc(N-1, AccermanFunc(N , M-1) ) ;     // изменение при вызове
}

// ---------------- Тело программы --------------------------

int numberN = ReadData("Введите число n: ");
int numberM = ReadData("Введите число m: ");
// проверяем, что введены положительные числа 
if(numberN>=0 && numberM>=0)
{   
    int accerman = AccermanFunc( numberN, numberM);
    PrintResult($"Функция Аккермана A({numberN},{numberM}) равна {accerman}");
}
else PrintResult("Ошибка! Введите числа n и m больше или равные 0"); 