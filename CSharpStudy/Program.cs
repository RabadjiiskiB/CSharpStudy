Console.WriteLine("Ohayo");
Console.WriteLine("Type a number to multiply by 2");
int x = int.Parse(Console.ReadLine());
while (x < 0)
{
    Console.WriteLine("Don't use negative numbers");
    x = int.Parse(Console.ReadLine());
}
int y = 2;
Console.WriteLine(x *= y);