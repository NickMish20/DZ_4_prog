/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */
Console.Clear();
 double step (double x, int y)
  { 
    double res=x;
    if(y>0)
      {
        for (int i=2; i<=y; i++)
        { 
          res*=x;
        }
      }
    else if (y<0)
      {
        res=1/x;
        for (int i=2; i<=Math.Abs(y); i++)
        { 
          res/=x;
        }
      }
   else
    {res=1;}
    return res;
  }
Console.Write("Введите число, которое нужно возвести в степень: ");
if (!double.TryParse(Console.ReadLine(), out double A))
  {
    Console.Write("Вы ввели не число!");
  }
else
  {
    Console.Write("Введите целое значение степени, в которую нужно возвести число: ");
    if (!int.TryParse(Console.ReadLine(), out int B))
      {
        Console.Write("Вы ввели не корректное значение степени!");
      }
    else
      {
        Console.WriteLine("{0} в степерни {1} равно {2}", A, B, step(A,B));
      }
  }