Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.Write("Большее число: " + numberA + " ");
    Console.Write("Меньшее число: " + numberB);
}
else 
{
    Console.Write("Большее число: " + numberB + " ");
    Console.Write("Меньшее число: " + numberA);
}
