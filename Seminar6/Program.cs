// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

/*
int[] CreateRandomArray(int size, int minValue, int maxValue) {
  int[] array = new int[size];

  for (int i = 0; i < size; i++) {
    array[i] = new Random().Next(minValue, maxValue + 1);
  }
  return array;
}

void ShowArray(int[] array) {
  for (int i = 0; i < array.Length; i++) {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

void ReverseArray(int[] array)
{
  for (int i = 0, j = array.Length - 1; i < j; i++, j--)
  {
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
  }
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);
ReverseArray(newArray);
ShowArray(newArray);
*/

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

/*
bool Triangle (int a, int b, int c)
{
  if (a + b > c && b + c > a && c + a > b ) 
  return true;
  else return false;
}

Console.WriteLine("Введите значение стороны 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение стороны 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение стороны 3: ");
int c = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(a, b, c);
Console.WriteLine(result);
*/

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

/*
int[] CreateFibonacciArray(int size, int a, int b)
{
  int[] array = new int[size];
  array[0] = a;
  array[1] = b;
  for (int i = 2; i < size; i++) 
    array[i] = array[i - 2] + array[i - 1];
  return array;
}

void ShowArray(int[] array)
{
  for (int i = 0; i < array.Length; i++) {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

Console.WriteLine("Введите размер ряда Фибоначчи: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение f(a): ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение f(b): ");
int b = Convert.ToInt32(Console.ReadLine());

int[] result = CreateFibonacciArray(size, a, b);
ShowArray(result);
*/

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CreateRandomArray(int size, int minValue, int maxValue) {
  int[] array = new int[size];

  for (int i = 0; i < size; i++) {
    array[i] = new Random().Next(minValue, maxValue + 1);
  }
  return array;
}

void ShowArray(int[] array) {
  for (int i = 0; i < array.Length; i++) {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int[] CopyArray (int[] array, int size)
{
  int[] newArray = new int[size];
  for (int i = 0; i < array.Length; i++)
    newArray[i] = array[i];
  return newArray;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);
ShowArray(CopyArray(newArray, length));