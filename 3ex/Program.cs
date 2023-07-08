// Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int N = Prompt("Введите первое число");
int M = Prompt("Введите второе число");
Console.WriteLine($"{Akk(M,N)}");

int Akk(int m, int n)
{
    if ( m == 0)
    {
        return n +1;
    }
    else if (n == 0)
    {
        return Akk(m - 1,1);
    }
    else
    {
        return Akk(m - 1, Akk(m,n - 1));
    }
}
