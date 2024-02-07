int MyFunction(int a, int b, int c)
{
    int res = a * b * c;
    return res;
}

int Add(int a, int b, int c)
{
    int res = a + b + c;
    return res;
}
int res = MyFunction(5, 6, 7);

System.Console.WriteLine(MyFunction(5, 6, 7));
System.Console.WriteLine(res);

System.Console.WriteLine(Add(1, 2, 3));