//  Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int N = Prompt("Введите первое число");
int M = Prompt("Введите второе число");
Console.WriteLine($"{Rang(N,M)}");

int Rang (int m, int n)
{
    int sum = 0;
    if (m == n)
    {
        return n;
    }
    else if ( m < n)
    {
        sum += Rang(m, n - 1 ) + n;
        return sum;
    }
    else 
    {
        sum += Rang (n, m - 1) + m;  
        return sum;
    }
}




