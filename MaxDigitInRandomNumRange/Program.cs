Console.WriteLine("Дано число из отрезка [10, 99]. Показать наибольшую цифру числа");

int    randomValue  = new Random().Next(10,100);
string sRandomValue = randomValue.ToString();
Console.WriteLine("Рандом число равно " + sRandomValue);
char[] array        = sRandomValue.ToCharArray();
int    counter      = 0;
int    maxDigit     = int.MinValue;

while(counter < array.Length) // Можно через for но сделал через While
{
    int tmp = int.Parse(array[counter].ToString());
    if(tmp > maxDigit) maxDigit = tmp;
    counter++;
}

Console.WriteLine("Наибольшая цифра рандом числа из отрезка равна " + maxDigit);