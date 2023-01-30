//  Напишите программу, которая выводит на экран числа от 1 до 100.
//  При этом вместо чисел, кратных трем, программа должна выводить слово «Fizz»,
//  а вместо чисел, кратных пяти — слово «Buzz».
// Если число кратно и 3, и 5, то программа должна выводить слово «FizzBuzz».

Console.Clear();
int count = 1;
while (count <= 100)
{
    if ((count % 3 == 0) & count % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("FizzBuzz");
    }
    else if (count % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write("Fizz");
    }
    else if (count % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write("Buzz");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write(count);
    }
    if (count == 100)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write(".");
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write(", ");
    }
    count++;
}