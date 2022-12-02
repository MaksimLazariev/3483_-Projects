int number = int.Parse(Console.ReadLine()??"0");

int result01 = number%7;
int result02 = number%23;

if ((result01==0)&&(result02==0))
{
    Console.WriteLine("Число " + number + " ДЕЛИТСЯ на число 7 и 23 без остатка");
}
else
{
    Console.WriteLine("Число " + number + " НЕ делится на число 7 и 23 без остатка");
}