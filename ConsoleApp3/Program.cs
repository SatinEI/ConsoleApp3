int CountBits(int num) // №1
{
    int S = 0;
    string bits = Convert.ToString(num,2);
    foreach (char c in bits)
    {
        if (c == '1')
        { 
            S++; 
        } 
    }
    return S;
}

int Persistence(int num) // %2
{
    if (num < 10)
    {
        return num;
    }
    while (num >= 10)
    {
        num = MultiDigit(num);
    }
    return num;
}
static int MultiDigit(int num)
{
    int Digit = 1;
    while (num > 0)
    {
        Digit *= num % 10;
        num /= 10;
    }
    return Digit;
}
int DigitalRoot(int num) //%3
{
    if (num < 10)
    {
        return num;
    }
    while (num >= 10)
    {
        num = SumDigit(num);
    }
    return num;
}
static int SumDigit(int num)
{
    int Digit = 0;
    while (num > 0)
    {
        Digit += num % 10;
        num /= 10;
    }
    return Digit;
}
Console.WriteLine(CountBits(10));
Console.WriteLine(Persistence(39));
Console.WriteLine(DigitalRoot(16));

