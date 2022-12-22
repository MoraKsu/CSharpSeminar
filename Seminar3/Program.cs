// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void GetDiapozone(int quadrant)
{
  if(quadrant == 1) Console.WriteLine("x > 0 and y > 0");
  else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0");
  else if(quadrant == 3) Console.WriteLine("x < 0 and y < 0");
  else if(quadrant == 4) Console.WriteLine("x > 0 and y < 0");
  else Console.WriteLine("Wrong input!");
}

Console.Write("Input a number of quadrant: ");
int quadNum = Convert.ToInt32(Console.ReadLine());

GetDiapozone(quadNum);
*/

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
int GetQuadrant(int x, int y)
{
  if(x > 0 && y > 0) return 1;
  else if(x < 0 && y > 0) return 2;
  else if(x < 0 && y < 0) return 3;
  else if(x > 0 && y < 0) return 4;
  return -1;
}
Console.Write("Input  x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input  y: ");
int y = Convert.ToInt32(Console.ReadLine());

GetQuadrant(x, y);
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N.

void Method1(int number)
{
  int n = 1;
  while(n <= number)
  {
    Console.Write(Math.Pow(n, 2) + " ");
    n++;
  }
}

Console.Write("Input number: ");
int x = Convert.ToInt32(Console.ReadLine());
Method1(x);
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*
double Method1(int x1, int x2, int y1, int y2)
{
  return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
}

Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Method1(x1, x2, y1, y2));
*/