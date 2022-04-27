Console.Clear();
Console.WriteLine("Удалить вторую цифру трёхзначного числа");

Console.Write("Введите 3х значное число: ");
string tmpNum        = Console.ReadLine()?? "0";
int    iNum          = int.Parse(tmpNum);
bool   numIsNegative = false;

if(iNum < 0) 
{
    iNum          = Math.Abs(iNum);
    numIsNegative = true;
}
string sNum   = iNum.ToString();

if(sNum.Length == 3)
{
    char[] tmpArray = sNum.ToCharArray();
    int    value    = int.Parse(tmpArray[0].ToString() + tmpArray[2].ToString());
    if(numIsNegative) value = - value;
    Console.WriteLine("Число после удаления второй цифры равно " + value + ".");
}
else
    Console.WriteLine("Введенное число не 3х значное!!!");
