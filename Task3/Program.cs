//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("Task№3");
System.Console.WriteLine("Enter the number of the day of the week");
string strnumber = Console.ReadLine();
int num = Convert.ToInt32(strnumber);

if ((num > 7) || (num < 1))
    System.Console.WriteLine("Wrong number!");
else if (num > 5)
    System.Console.WriteLine("Chilling at home!");
else
    System.Console.WriteLine("Work hard...");