/* Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/ 

Console.WriteLine("Input your number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
string third_symbol = Convert.ToString(user_number);

if (third_symbol.Length > 2)
    Console.WriteLine($"Second symbol is {third_symbol[2]}");
else
    Console.WriteLine("Your number is not right.");
