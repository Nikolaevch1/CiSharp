System.Console.WriteLine("Start");
int[] numbres = { 2, 4, 6, 7, 8, 10 };
foreach (int number in numbres)
{
    if (number % 2 == 1)
    {
        System.Console.WriteLine("There is odd number");
        break;
    }
}
System.Console.WriteLine("Stop");



int[,] table = {{1, 1, 1},
                {2, -2, 2},
                {3, 3, -3}};
for(int i = 0; i < table.GetLength(0); i++)
{
    for(int j = 0; j < table.GetLength(1); j++)
    {
        if (table[i,j]<0)
        {
            System.Console.WriteLine($"There are negative elements in line {i}");
            break;
        }
    }
}


for(int i = 1; 1 <= 5; i++)
{
    System.Console.WriteLine($"Interation {i}: ");
    if(i == 3)
    {
        System.Console.WriteLine("Skip");
        continue;
    }
    System.Console.WriteLine("Some progressing");
}