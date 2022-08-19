/* Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Введите число: ");
string num = Console.ReadLine();

int result = 0;
int lengts = num.Length;

for (int i = 0; i < lengts; i++)
{
    int temp = int.Parse(num[i] + " ");
    result = temp + result;

    // Console.Write(num[i] + " ");
    // Console.WriteLine(result);
}
Console.WriteLine(result);