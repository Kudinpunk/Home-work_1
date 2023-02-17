/* Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 
*/

Console.WriteLine("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

if (user_num > 100 & user_num < 1000)
{
    int second_num = user_num % 100 / 10;
    Console.WriteLine($"Second digit in {user_num} is {second_num}.");
}
else
    Console.Write("Your number is not right.");