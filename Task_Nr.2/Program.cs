int a = 2;
int b = 8;

int max = a;

if(a > max) max = a;
if(b > max) max = b;

Console.Write("max = ");
Console.WriteLine(max);