Console.Clear();
Console.WriteLine("Выяснить, кратно ли число заданному, если нет, вывести остаток.");

Console.Write("Задайте число: ");
int  firstNum           = int.Parse(Console.ReadLine()?? "0");
bool firstNumIsNegative = firstNum > 0 ? false:true;

Console.Write("Введите проверяемое число: ");
int  secondNum          = int.Parse(Console.ReadLine()?? "0");
bool secondNumIsNegative = secondNum > 0 ? false:true;

if(Math.Abs(firstNum) > Math.Abs(secondNum)) // Проверка имеет смысл. только если проверяемое число больше либо равно заданному
{
    Console.WriteLine("Проверяемое число должно быть больше заданного!!!");
    return;
}
string singAndRemainder = getRemainder(firstNumIsNegative,secondNumIsNegative);
if(secondNum % firstNum == 0) Console.WriteLine($"Число {secondNum} кратно числу {firstNum}");
else                          Console.WriteLine($"Число {secondNum} не кратно числу {firstNum}. Величина остатка равна {singAndRemainder}.");

//--------------------------------Функция получения знака и остатка в зависимости от знаков входящих чисел-------------------------------+
// +/- и -/+ дают -
// -/- b +/+ дают +
string getRemainder(bool first, bool second)
{
    string signAndValue = (Math.Abs(secondNum % firstNum)).ToString();
    if     (first && !second) signAndValue = "-" + signAndValue;
    else if(!first && second) signAndValue = "-" + signAndValue;
    return(signAndValue);
}
//---------------------------------------------------------------------------------------------------------------------------------------+