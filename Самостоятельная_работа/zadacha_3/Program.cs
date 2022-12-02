// Даны два числа. Показать большее и меньшее число


Console.WriteLine("введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение", a, b);
}
else
{
 Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение", b, a);
}
