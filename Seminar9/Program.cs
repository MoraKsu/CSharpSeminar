// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// void ShowNums(int num)
// {
//   if (num > 1) ShowNums(num - 1);
//   Console.Write(num + " ");
// }

// ShowNums(5);

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

/*
int GetSumOfDigits(int num)
{
  if(num != 0) return GetSumOfDigits(num / 10) + num % 10;
  else return 0;
}

Console.WriteLine(GetSumOfDigits(1234));
*/

// f(1234) -> 4 + f(123)=6
// f(123) -> 3 + f(12)=3
// f(12) -> 2 + f(1)=1
// f(1) -> 1 + f(0)=0
// f(0) -> 0


// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

/*
void PrintNaturalNumbers(int m, int n)
  {
    if (m > n) 
    { 
      Console.Write(m + " ");
      PrintNaturalNumbers(m - 1, n); 
    }
    else if (m < n)
    { 
      Console.Write(n + " ");
      PrintNaturalNumbers(m, n - 1);
    }
    else Console.Write(n + " ");
  }

PrintNaturalNumbers(7, 3);
*/


// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

/*
int GetPow(int num1, int num2)
{
  if(num2 > 0) return num1 * GetPow(num1, (num2 - 1));
  else return 1;
}

Console.WriteLine(GetPow(2, 3));
*/