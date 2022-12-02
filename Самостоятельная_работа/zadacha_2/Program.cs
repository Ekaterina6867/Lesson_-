// 1. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("введите два числа");
//Var-это неявный тип, который означает, что система сама определит тип данных.
//Split () - это строковый класс метод. Метод Split () возвращает массив строк, сгенерированных разбиением исходной строки,
// разделенной разделителями, переданными в качестве параметра в методе Split ()

//Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray(); считывает из консоли строку, 
//разделяет её по пробелам, для каждой подстроки вызывает int.Parse и приводит полученную коллекцию к типу массива.
var integers = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
int first = integers[0];
int second = integers[1];
if (first==second*second)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("fals");
}