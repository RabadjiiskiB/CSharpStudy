Console.WriteLine("Welcome");
Console.WriteLine("Type 1 for multiplication");
int nav = int.Parse(Console.ReadLine());
while (nav == 0)
{
    nav = int.Parse(Console.ReadLine());
}

if(nav == 1)
{
    Console.WriteLine("Type a number to multiply by 2");
int x = int.Parse(Console.ReadLine());
while (x < 0)
{
    Console.WriteLine("Don't use negative numbers");
    x = int.Parse(Console.ReadLine());
}
int y = 2;
Console.WriteLine(x *= y);
}

if(nav == 2)
{
    bool equal = Math.Abs(n12 - n10 ) < 0.000001;
    Console.WriteLine(equal);
}

if(nav == 3)
{
    int test = 0x256;
    Console.WriteLine(test);
}

