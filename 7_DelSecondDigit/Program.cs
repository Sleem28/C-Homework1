﻿Console.Clear();
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
    int    value    = int.Parse(sNum[0].ToString() + sNum[2].ToString());
    if(numIsNegative) value = - value;
    Console.WriteLine("Число после удаления второй цифры равно " + value + ".");
}
else
    Console.WriteLine("Введенное число не 3х значное!!!");
