Console.WriteLine("Проведем проверку, является ли первое введенное число квадратом второго введенного числа.");

Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine()?? "0");

Console.Write("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine()?? "0");

if(firstNum == secondNum * secondNum)
{
    Console.Write($"Число {firstNum} является квадратом числа {secondNum}. ");
}
else
{
    Console.Write($"Число {firstNum} не является квадратом числа {secondNum}. ");
}