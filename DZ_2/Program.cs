//Напишите программу, 
//которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberThird = Convert.ToInt32(Console.ReadLine());
if (numberFirst > numberSecond)
{
    if (numberFirst > numberThird)
    {
        Console.WriteLine("Number First=max");
    }
Console.WriteLine("Number First=max");
}
else if (numberFirst < numberSecond)
{
    if ( numberSecond > numberThird)
    {
        Console.WriteLine("Number Second=max");
    }
Console.WriteLine("Number Second=max");
}
else if (numberThird > numberSecond)
{
    if (numberThird > numberFirst)
    {
        Console.WriteLine("Number Third=max");
    }
}
