/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

/*Console.Write("Подставьте числа: a = ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("c = ");
int number2 = Convert.ToInt32(Console.ReadLine());
if  (number >= number1)
if  (number >= number2)
    {
        Console.WriteLine("max" + " " + "->" + " " + number);
    }
if (number1 >= number)
if (number1 >= number2)
    {
        Console.WriteLine("max" + " " + "->" + " " + number1);
    }
if (number2 >= number)
if (number2 >= number1)
    {
        Console.WriteLine("max" + " " + "->" + " " + number2);
    }*/
Console.Write("Подставьте числа: a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("c = ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("max -> ");
Console.Write(max);
