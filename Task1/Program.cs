// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5 
// 782 -> 8 
// 918 -> 1

System.Console.WriteLine("Task№1");
System.Console.WriteLine("Enter three digit number");
string strnumber = Console.ReadLine();
int num = Convert.ToInt32(strnumber);
int div1 = (num % 100) / 10;
System.Console.WriteLine(div1);