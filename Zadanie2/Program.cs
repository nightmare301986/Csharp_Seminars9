/*Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int m = Prompt("Введите начальное число m: ");
int n = Prompt("Введите начальное число n: ");
int sum = 0;

void PrintNumbers(int numberStart, int numberFinish)//Вывод и подсчет суммы чисел от m до n
{
    sum = sum + (numberStart);
    if (numberStart == numberFinish)
    {
        return;
    }
    PrintNumbers(numberStart + 1, numberFinish);
}

int numberStart = m;
int numberFinish = n;
PrintNumbers(numberStart, numberFinish);
System.Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {sum}");