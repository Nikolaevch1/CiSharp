string GetLettersFromStr(string s) // Функция считывающая от пользователя и извлекающая толко строки
{
    string letters = "";
    foreach (char element in s)
    {
        if(char.IsAsciiLetter(element) == true)
        {
            letters = letters + element;
        }
    }
    return letters;
}

string str = Console.ReadLine()!;
string letters = GetLettersFromStr(str);
System.Console.WriteLine(letters);