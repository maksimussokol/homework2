Console.Clear();
Console.WriteLine("enter the day");
int f = Convert.ToInt32(Console.ReadLine());
if (f > 7 || f < 1)
{
    Console.WriteLine("error");
}
else
{
    if (f == 6 || f == 7)
    {
        Console.WriteLine("its weekend. go party");
    }
    else
    {
        Console.WriteLine("go to work");
    }
}
