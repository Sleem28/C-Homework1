Console.Clear();
Console.WriteLine("Найти третью цифру числа или сообщить, что её нет.");

Console.Write("Введите число: ");
char[] charNum = (Console.ReadLine() ?? "0").ToCharArray();

if(!TextIsNumber(ref charNum))
{
    Console.WriteLine("В введенном тексте содержатся недопустимые символы!!!");
    return;
}

if     (charNum[0] == '-' && charNum.Length == 4) Console.WriteLine($"Третья цифра числа равна {charNum[3]}");
else if(charNum[0] != '-' && charNum.Length >= 3) Console.WriteLine($"Третья цифра числа равна {charNum[2]}");
else                                              Console.WriteLine($"Третьей цифры числа НЕТ");

//----------------------------------------Функция проверки введеного текста на наличие любых символов кроме цифр---------------------------------------+
bool TextIsNumber(ref char[] array)
{
    bool isNumber = false;
    bool found    = false;
    for(int i = 0; i < array.Length; i++)
    {
        switch(array[i])
        {
            case '0': 
                isNumber = true;
                break;
            
            case '1': 
                isNumber = true;
                break;
            case '2': 
                isNumber = true;
                break;
            case '3': 
                isNumber = true;
                break;
            case '4': 
                isNumber = true;
                break;
            case '5': 
                isNumber = true;
                break;
            case '6': 
                isNumber = true;
                break;
            case '7': 
                isNumber = true;
                break;
            case '8': 
                isNumber = true;
                break;
            case '9': 
                isNumber = true;
                break;
            case '-': 
                if(i == 0) isNumber = true; // Проверка первого чара на отрицательное значение т.к. число может быть отрицательным
                else      {isNumber = false; found = true;}
                break;
            default:
                isNumber = false;
                found     = true;
                break;
        }
        if(found) break;
    }
    return(isNumber);
}

//-----------------------------------------------------------------------------------------------------------------------------------------------------+