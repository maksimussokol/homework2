﻿Console.Clear();
Console.WriteLine("enter the number");
int f = Convert.ToInt32(Console.ReadLine());
if (f < 100)
{
    Console.WriteLine("error");

}
else
{
    string a = f.ToString();



    Console.WriteLine(a[2]);
}