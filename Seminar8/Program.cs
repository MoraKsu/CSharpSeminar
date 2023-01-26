// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

/*
int[,] CreateRandom2dArray()
{
  Console.Write("Input a number of rows: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a number of columns: ");
  int columns = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a min possible value: ");
  int minValue = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a max possible value: ");
  int maxValue = Convert.ToInt32(Console.ReadLine());

  int[,] array = new int[rows, columns];

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return array;
}

void Show2dArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i, j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

void ChangeRows(int[,] array, int row1, int row2)
{
  if (row1 >= 0 && row1 < array.GetLength(0) 
      && row2 >=0 && row2 < array.GetLength(0) 
      && row1 != row2)
      {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          int temp = array[row1, j];
          array[row1, j] = array[row2, j];
          array[row2, j] = temp;
        }
      }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.WriteLine("Input a number of first row: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of second row: ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(myArray, r1, r2);
Show2dArray(myArray);
*/

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

/*
int[,] CreateRandom2dArray()
{
  Console.Write("Input a number of rows: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a number of columns: ");
  int columns = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a min possible value: ");
  int minValue = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a max possible value: ");
  int maxValue = Convert.ToInt32(Console.ReadLine());

  int[,] array = new int[rows, columns];

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return array;
}

void Show2dArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i, j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

void ChangeArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0) - 1; i++)
  {
    for (int j = i + 1; j < array.GetLength(1); j++)
    {
      int temp = array[i, j];
      array[i, j] = array[j, i];
      array[j, i] = temp;
    }
  }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
ChangeArray(myArray);
Show2dArray(myArray);
*/

// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.


int[,] CreateRandom2dArray()
{
  Console.Write("Input a number of rows: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a number of columns: ");
  int columns = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a min possible value: ");
  int minValue = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a max possible value: ");
  int maxValue = Convert.ToInt32(Console.ReadLine());

  int[,] array = new int[rows, columns];

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return array;
}

void Show2dArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i, j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}


int[] MinElement(int[,] array)
{

  int minrow = 0;
  int mincol = 0;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 1; j < array.GetLength(1); j++)
    {
      if (array[i, j] < array[minrow, mincol])
      {
        minrow = i;
        mincol = j;
      }
    }
  }
  int[] indexes = {minrow, mincol};
  return indexes;
}

int[,] NewArray(int[,] array, int[] indexes)
{
  int[,] massiv = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

  for (int i = 0, x = 0; i < array.GetLength(0); i++, x++)
  {
    if (indexes[0] == i) 
    {
      x--;
      continue;
    }
    else 
      for (int j = 0, y = 0; j < array.GetLength(1); j++, y++)
      {
        if (indexes[1] == j)
        {
          y--;
          continue;
        }
        else {
          massiv[x, y] = array[i, j];
        }
      }
  }
  return massiv;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Show2dArray(NewArray(myArray, MinElement(myArray)));

