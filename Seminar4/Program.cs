// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*
int GetSum(int num) {
  int sum = 0;
  for (int current = 1; current <= num; current++)
    sum+= current;
  return sum;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.WriteLine(result);
*/

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int Numbers(int n) {
  int count = 0;
  while (n != 0) {
    n = n / 10;
    count += 1; 
  }
  return count;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int res = Numbers(a);
Console.WriteLine(res);
*/
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int GetPro(int num) {
  int sum = 1;
  for (int current = 1; current <= num; current++)
    sum *= current;
  return sum;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetPro(a);
Console.WriteLine(result);
*/

// 

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

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a man possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);