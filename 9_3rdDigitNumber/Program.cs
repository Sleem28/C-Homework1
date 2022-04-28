Console.Clear();
Console.WriteLine("Найти третью цифру числа или сообщить, что её нет.");

Console.Write("Введите число: ");
string text = Console.ReadLine() ?? "0";

if(!TextIsNumber( text))
{
    Console.WriteLine("В введенном тексте содержатся недопустимые символы!!!");
    return;
}

if     (text[0] == '-' && text.Length == 4) Console.WriteLine($"Третья цифра числа равна {text[3]}");
else if(text[0] != '-' && text.Length >= 3) Console.WriteLine($"Третья цифра числа равна {text[2]}");
else                                              Console.WriteLine($"Третьей цифры числа НЕТ");

//----------------------------------------Функция проверки введеного текста на наличие любых символов кроме цифр---------------------------------------+
bool TextIsNumber(string text)
{
    bool isNumber = false;
    bool found    = false;
    for(int i = 0; i < text.Length; i++)
    {
        switch(text[i])
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