//Решение первой задачи. Напишите программу которая на вход принимает два числа и 
//выдает, какое больше и какое меньше 
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA < numberB)
{
Console.WriteLine ("numberSecond=max,numberFirst=min");
}
else
{
    Console.WriteLine("numberFirst=max,numberSecond=min");
}