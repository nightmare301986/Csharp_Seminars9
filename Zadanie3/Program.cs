/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Prompt("Введите начальное число m:");
int n = Prompt("Введите начальное число n:");

///Метод вычисления функции Аккермана:
int AkkermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AkkermanFunc(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    return AkkermanFunc(m, n);
}

Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AkkermanFunc(m, n)}");