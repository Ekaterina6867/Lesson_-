//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("введите число");
int n = int.Parse(Console.ReadLine());
int k = (int)Math.Log10(n)-2;
if (n>100)
{
Console.WriteLine(k < 0 ? "No such digit" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
Console.ReadLine(); 
}
else 
{
Console.WriteLine(" число должно быть больше 99");
}  