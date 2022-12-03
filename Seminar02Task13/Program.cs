// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет 

// Вводим число
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()??"0");            

// делаем цикл, если в числе минимум три цифры
if(number> 99)                                         
{
// Находим количество цифр в числе ( или можно сделать циклом while, делить number/10, пока number> 10, счетчик в цикле ++  )
    int length = (int)Math.Log10(number) + 1;               
    
    int index = 0;
    int thirdDigit = number;

// Делаем деление числа на 10 (length-3) раз, чтоб осталось три цифры в числе     
    while( index < length-3)                                
    {
        thirdDigit = thirdDigit/ 10;                        
        index ++;
    }
// находим третью цифру остатком от деления на 10
    thirdDigit = thirdDigit % 10;   
// выводим третье число                         
    Console.WriteLine(thirdDigit + " Является третьей цифрой числа " + number);     
}
else
{
// выводим, если в числе меньше трех цифр    
    Console.WriteLine("Число меньше 99, нет третьей цифры");                          
}
