// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

 internal class Program 
    { 
        static void Main(string[] args) 
        { 
            Console.Write(" Является ли этот день выходным ?  "); 
            while (true) 
            { 
                Console.Write(" Введите номер дня недели  "); 
                int num = int.Parse(Console.ReadLine()); 
                if (num >= 1 && num <= 5) 
                { 
                    Console.Write(" Нет, это не выходной"); 
                } 
 
                else if (num >= 6 && num <= 7) 
                { 
                    Console.Write(" Да, это выходной"); 
                } 
                else Console.Write(" Не существует такого дня недели"); 
            } 
        } 
    } 