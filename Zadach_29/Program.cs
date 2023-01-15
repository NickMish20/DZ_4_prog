/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */
int [] mass (int n, int x1, int x2)
  {
    int [] arr= new int[n];
    int x;
    if (x1>x2)
      {
        x=x2; x2=x1; x1=x;
      }
    for (int i=0; i<n; i++)
      {
        arr[i]= new Random().Next(x1, x2+1);
      }
    return arr;
  }
    
Console.Write("Введите длинну масива целых чисел, которого Вы хотите получить: ");
if(!int.TryParse(Console.ReadLine(), out int n))
  {
    Console.Write("Вы ввели не корректную длинну массива!");
  }
else
  {
    Console.Write("Введите начало диапазона Вашего масива: ");
    if(!int.TryParse(Console.ReadLine(), out int A))
      {
        Console.Write("Вы ввели не корректное значение начала диапазона!");
      }
    else
      {
        Console.Write("Введите окончание диапазона Вашего масива: ");
        if(!int.TryParse(Console.ReadLine(), out int B))
          {
            Console.Write("Вы ввели не корректное значение окончания диапазона!");
          }
        else
          {
            Console.Write("Ваш массив: [{0}]", String.Join (", ", mass(n, A, B)));
          }
      }
  }