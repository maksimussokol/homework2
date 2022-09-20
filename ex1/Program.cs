Console.Clear();
Console.WriteLine("enter number between 100 and 999");
int n = Convert.ToInt32(Console.ReadLine());
int f = Convert.ToInt32(n / 10);
int z = Convert.ToInt32(f % 10);

if (n < 100 || n > 999)
{
    Console.WriteLine("error");
}
else
{
    Console.Write("middle point is ");
    Console.WriteLine(z);
}


