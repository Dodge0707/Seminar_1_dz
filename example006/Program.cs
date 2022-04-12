Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA < 0)
{
    Console.Write(-numberA);
}
else
{
    Console.Write(numberA);
}