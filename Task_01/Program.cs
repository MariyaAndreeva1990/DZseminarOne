/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
Console.Write("Подставьте числа: a = ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number > number1)
    {
        Console.WriteLine("max" + " " + "=" + " " + number);
        Console.Write("min" + " " + "=" + " " + number1);
    }
else if (number < number1)
    {
        Console.Write("max" + " " + "=" + " " + number1);
        Console.Write("min" + " " + "=" + " " + number);
    }
else
    {
        Console.Write(number + " " + "=" + " " + number1);
    }