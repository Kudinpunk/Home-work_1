/* Напишите программу, которая на вход принимает число (N), а
 на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8  */

Console.Write($"Input your number: ") ;
int number = Convert.ToInt32(Console.ReadLine());

int current_number = 2;

while (current_number <= number)
{
    Console.Write(current_number + " ");
    current_number += 2;
}