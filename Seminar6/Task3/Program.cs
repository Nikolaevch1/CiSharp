// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

bool IsVowes(char chr) // функция выбирает гласные 
{
    return  chr == 'a' || chr == 'e' ||
            chr == 'i' || chr == 'o' ||
            chr == 'u' || chr == 'y';
}
int CountVolwels(string str) // Функция считает количестов гласных
{
    int vowels = 0;
    foreach (char e in str)
    {
        if (IsVowes(e))
        {
            vowels++;
        }
    }
    return vowels;
}
System.Console.WriteLine("Введите произвольную строку: ");
string str2 = Console.ReadLine()!;
int res = CountVolwels(str2);
System.Console.WriteLine($"Количество гласных: {res}");