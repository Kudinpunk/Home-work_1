/* Задача 2: Напишите программу, которая на вход принимает два 
числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7, min = 5
a = 2 b = 10 -> max = 10, min = 2 */

Console.Write($"Input first number: ") ;
int first_number = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input second number: ");
int second_number = Convert.ToInt32(Console.ReadLine());

if (first_number > second_number)
{
    Console.WriteLine($"max = {first_number} min = {second_number}");
}
else
{
    Console.WriteLine($"max = {second_number} min = {first_number}");
}