void PrintFromNumberToOne(int a)
{
    for (int i = a; i > 0; i--)
    {
        Console.Write(i + " ");
    }
}

PrintFromNumberToOne(20);

Console.WriteLine();
Console.WriteLine();

void sum(int a, int b, int c, int d)
{
    Console.WriteLine(a + b + c + d);
}

sum(5,5,5,5);
Console.WriteLine();
Console.WriteLine();

void PrintStars(int a)
{
    for (int i = a; i > 0; i--)
    {
        Console.Write("*");
    }
}

PrintStars(20);
Console.WriteLine();
Console.WriteLine();
void PrintSquare(int a)
{
    for (int i = a; i > 0; i--)
    {
        Console.WriteLine();
        PrintStars(a);
    }
}

PrintSquare(20);
Console.WriteLine();
Console.WriteLine();

void PrintRectangle(int a, int b)
{
    for (int i = 1; i <= b; i++)
    {
        Console.WriteLine();

        for (int j = 1; j <= a; j++)
        {
            Console.Write(" * ");
        }

    }
}

PrintRectangle(5, 5);
Console.WriteLine();
Console.WriteLine();
void PrintTriangle(int b)
{
    for (int i = 1; i <= b; i++)
    {
        Console.WriteLine();

        for (int j = 1; j <= i; j++)
        {
            Console.Write(" * ");
        }

    }
}

PrintTriangle(5);
Console.WriteLine();
Console.WriteLine();


void PrintSpaces(int a) 
{
    for(int i = 1;i <= a; i++) 
    {
        Console.Write(" ");
    }
}

PrintSpaces(5);
Console.WriteLine();
Console.WriteLine();

void PrintRightTriangle(int b) 
{
    for (int i = 0; i<b; i++) 
    {
        PrintSpaces(b-i);
        PrintStars(i);
        Console.WriteLine();
    }    
    
}

PrintRightTriangle(5);
Console.WriteLine();
Console.WriteLine();

void Tree(int b) 
{
    for (int i = 1; i <= b; i+=2)
    {
        PrintSpaces((b-i)/2);
        PrintStars(i);
        Console.WriteLine();
    }
    PrintSpaces((b-3)/2);
    PrintStars(3);
    Console.WriteLine();
    PrintSpaces((b - 3) / 2);
    PrintStars(3);

}

Tree(20);
Console.WriteLine();
Console.WriteLine();

void Reverse(int b) 
{
    int cnt=0;
    for (int i = b; i > 0; i/=10)
    {
        cnt = cnt * 10 + i % 10;
    }
    Console.WriteLine(cnt);
}
Reverse(198237465);
Console.WriteLine();
Console.WriteLine();