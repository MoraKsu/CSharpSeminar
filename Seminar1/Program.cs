// Семинар 1.

// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)
{
  Console.WriteLine("Yes!");
}
else
{
  Console.WriteLine("No!");
}
*/

// Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current <= number)
{
  Console.Write(current + " ");
  current++; // current += 1, current = current + 1;
}
*/

/*
37145 / 10 = 3714
37145 / 100 = 371
37145 / 1000 = 37
37145 / 10000 = 3
37145 / 100000 = 0

37145 % 10 = 5
37145 % 100 = 45
37145 % 1000 = 145
37145 % 10000 = 7145
37145 % 100000 = 37145

56473 -> 64
/100 %100

14359 -> 35
/10 %100
*/