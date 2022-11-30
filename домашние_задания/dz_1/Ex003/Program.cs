Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());
int i=2;
while (i<n-1)
{
    Console.WriteLine(i);
    i = i+2;
}
Console.WriteLine(i);