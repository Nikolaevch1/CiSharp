// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

char[] chars = { 'a', 'b', 'c', 'd' };
string PrString(char[] chars)
{
    string sim = " ";
    foreach (char e in chars)
    {
        sim = sim + e;
    }
    return sim;

}
string sim = PrString(chars);
System.Console.WriteLine(sim);