/* Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

void Polidrom_num(int user_num)
{
    string user_string = Convert.ToString(user_num);
    if (user_string[0] == user_string[4] | user_string[1] == user_string[3])
        Console.WriteLine("YES");
    else 
        Console.WriteLine("NO");
}

Console.WriteLine("Input your number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number < 100000 & user_number > 9999)
    Polidrom_num(user_number);
else
    Console.WriteLine("Your number is out of range.");
