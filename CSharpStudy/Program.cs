//Декларирайте няколко променливи, като изберете за всяка една най-
//подходящия от типовете sbyte, byte, short, ushort, int, uint, long и
//ulong, за да им присвоите следните стойности: 52130, -115, 4825932,
//97, -10000, 20000; 224; 970700000; 112; -44; -1000000; 1990;
//123456789123456789.
ushort n1 = 52130;
sbyte n2 = -115;
int n3 = 4825932;
sbyte n4 = 97;
short n5 = -10000;
short n6 = 20000;
byte n7 = 224;
int n8 = 970700000;
sbyte n9 = 112;
sbyte n10 = -44;
int n11 = -1000000;
short n12 = 1990;
long n13 = 123456789123456789;

Console.WriteLine("Ohayo");
sbyte nav = sbyte.Parse(Console.ReadLine());
while (nav == 0)
{
    nav = sbyte.Parse(Console.ReadLine());
}


Console.WriteLine("Type a number to multiply by 2");
int x = int.Parse(Console.ReadLine());
while (x < 0)
{
    Console.WriteLine("Don't use negative numbers");
    x = int.Parse(Console.ReadLine());
}
int y = 2;
Console.WriteLine(x *= y);