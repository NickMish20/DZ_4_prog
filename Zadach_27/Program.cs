/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12 */
Console.Write("Введите целое число: ");
if (!int.TryParse(Console.ReadLine(), out int x))
  {
    Console.Write("Вы ввели не целое число!");
  }
else
  {
    int y=x;
    int sum=0;
    while (y>0)
      {
        sum+=y%10;
        y/=10;
      }
    Console.Write("Сумма цифр в числе {0} равняется {1}", x, sum);
  }