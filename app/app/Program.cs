// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Mars!");
Console.WriteLine("Hello, Jupiter!");
Console.WriteLine("Hello, Venus!");
Console.WriteLine("Hello, Mercury!");


static int CalculateAverage(int[] numbers)
{
    return numbers.Sum() / numbers.Length;
}

static int CalculateMax(int[] numbers)
{
    return numbers.Max();
}

static int CalculateMin(int[] numbers)
{
    return numbers.Min();
}