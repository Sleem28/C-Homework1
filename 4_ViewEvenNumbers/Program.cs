Console.Clear();
Console.WriteLine("Показать четные числа от 1 до num"); // Ноль будет четным числом, т.к. он делится на все степени двойки

Console.Write("Введите число: ");
int num     = int.Parse(Console.ReadLine()?? "0");
int counter = 1;

if(num > 1) 
{
    while(counter <= num)
    {
        if(counter%2 == 0) Console.Write(counter + " ");
        counter++;
    }
}
else if(num < 1)
{
    while(counter >= num)
    {
        if(counter%2 == 0) Console.Write(counter + " ");
        counter--;
    }
}

