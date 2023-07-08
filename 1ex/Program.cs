// Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"
int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int N = Prompt("Введите первое число");
int M = Prompt("Введите второе число");

Console.WriteLine($"{Sum(N,M)}");
string Sum(int N, int M)
{
    if ( M == N)
    {
    return M + ", ";
    }
    else if ( M > N)
    {
         return Sum(N, M - 1) + M + ", ";
    }
    else
    {
        return Sum(M, N - 1) + N + ", ";
    }
}