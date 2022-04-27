Console.Clear();
Console.WriteLine("Найти третью цифру числа или сообщить, что её нет.");

Console.Write("Введите число: ");
char[] charNum = (Console.ReadLine() ?? "0").ToCharArray();

if(!TextIsNumbers(ref charNum))
{
    Console.WriteLine("В введенном тексте содержатся недопустимые символы!!!");
    return;
}

if     (charNum[0] == '-' && charNum.Length == 4) Console.WriteLine($"Третья цифра числа равна {charNum[3]}");
else if(charNum[0] != '-' && charNum.Length == 3) Console.WriteLine($"Третья цифра числа равна {charNum[2]}");
else                                              Console.WriteLine($"Третьей цифры числа НЕТ");

//----------------------------------------Функция проверки введеного текста на наличие любых символов кроме цифр---------------------------------------+
bool TextIsNumbers(ref char[] array)
{
    bool isNumbers = false;
    for(int i = 0; i < array.Length; i++)
    {
        switch(array[i])
        {
            case '0': 
                isNumbers = true;
                break;
            
            case '1': 
                isNumbers = true;
                break;
            case '2': 
                isNumbers = true;
                break;
            case '3': 
                isNumbers = true;
                break;
            case '4': 
                isNumbers = true;
                break;
            case '5': 
                isNumbers = true;
                break;
            case '6': 
                isNumbers = true;
                break;
            case '7': 
                isNumbers = true;
                break;
            case '8': 
                isNumbers = true;
                break;
            case '9': 
                isNumbers = true;
                break;
            case '-': 
                if(i == 0) isNumbers = true; // Проверка первого чара на отрицательное значение
                else       isNumbers = false;
                break;
            default:
                isNumbers = false;
                break;
        }
    }
    return(isNumbers);
}

//-----------------------------------------------------------------------------------------------------------------------------------------------------+