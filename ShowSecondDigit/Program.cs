Console.Clear();
Console.WriteLine("Показать вторую цифру трёхзначного числа");

Console.Write("Введите 3х значное число: ");

string sNum = Console.ReadLine()?? "0";
int iNum = int.Parse(sNum);

if(iNum < 0) // Проверка на отрицательное значение введенного числа
{
    iNum = Math.Abs(iNum);
    sNum = iNum.ToString();
}

if(sNum.Length != 3)
{
    Console.WriteLine("Введеное число не 3х значное!!!");
    return;
}

int result = ((iNum - iNum%10)/10)%10;
Console.WriteLine("Вторая цифра введенного числа " + result); 