// я НЕ понимаю почему не складывает последний элемент!

Console.Clear();
Console.WriteLine("vvedi skolko kustov");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1 || n > 1000)
{
    Console.WriteLine("error");
}
Console.WriteLine("vvedi massiv kolichestva yagod na kustah");

int[] a = new int[n];
int i = 0;
while (i < n)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
    i = i + 1;
}

int max = a[1] + a[2] + a[3];
while (i < n)
{
    if ((a[i] + a[i + 1] + a[i + 2] > max))
    {
        max = a[i] + a[i + 1] + a[i + 2];
        i++;

    }
}
Console.Write("maksimalno za odin prohod ");
Console.WriteLine(max);


