/* Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
int result = 1;
int Method(int number, int degree)
{
    for (int i = 0; i < degree; i++)
    {
        result = result * number;
        //Console.WriteLine(result);
    }
    return result;
}
Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int res = Method(A, B);
Console.WriteLine(res);