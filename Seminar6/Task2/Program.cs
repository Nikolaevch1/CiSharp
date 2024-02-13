// Задание 2. Работа в сессионных залах
// Семинар 6. Массивы и строки
// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

string str = "Hello!";

char[] MakeCharsArray(string str)
{   
    int size = str.Length;
    char[] word = new char[size];
    for (int i = 0; i < str.Length; i++)
    {
        word[i] = str[i];
    }
    return word;
}
char[] word = MakeCharsArray(str);
foreach (char e in word)
{
    System.Console.Write($"{e} ");
}