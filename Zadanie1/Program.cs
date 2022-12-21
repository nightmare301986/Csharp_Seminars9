/* Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"*/
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int m = Prompt("Введите начальное число m:");
if (m%2==1){m++;}
int n = Prompt("Введите начальное число n:");

void Podschet(int m, int n)//Метод (функция) подсчета четных чисел
{
    if(m > n)
        return ;
    Console.Write(" {0}  ", m);
    if (m%2==0 )
    {Podschet(m+2, n);}//Вызов функции(рекурсия)
    if (m%2==1 )
    {Podschet(m+1, n); }//Вызов функции(рекурсия)
}

Podschet(m, n);
return ;