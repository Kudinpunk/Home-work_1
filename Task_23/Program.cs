/* 
Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void Cub_n(int n)
{
    int current = 1;
    while (current <= n)
    {
        int result = current * current * current;
        Console.Write($"{result}, ");
        current++;
    }
    Console.WriteLine("\b\b ");

}

Console.Write("Input your number: ");
int user_n = Convert.ToInt32(Console.ReadLine());

if (user_n >= 1)
    Cub_n(user_n);
else
    Console.WriteLine("Calculation not possible.");
