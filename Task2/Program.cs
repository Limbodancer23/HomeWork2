// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5 
// 78 -> третьей цифры нет 
// 32679 -> 6
System.Console.WriteLine("Task№2");
System.Console.WriteLine("Enter your three digit number");
string strnumber = Console.ReadLine();
int num = Convert.ToInt32(strnumber);

int div1 = num % 10;
if (num > 99)
    System.Console.WriteLine(div1);
else
    System.Console.WriteLine("There is no third digit in your number!");