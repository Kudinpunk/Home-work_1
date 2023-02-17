/* Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */ 

Console.WriteLine("Inpunt the day of the week...");
int user_day = Convert.ToInt32(Console.ReadLine());

if (user_day > 0 & user_day < 8)
{
    if (user_day == 6 || user_day == 7)
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");
}
else
    Console.WriteLine("Input the day of the week between 1 and 7.");