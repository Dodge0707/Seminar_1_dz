Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int ostDel = numberA%2;

if (ostDel == 0)
{
    Console.Write("Вы ввели четное число " + numberA + "!");
}
else 
{
    Console.Write("Вы ввели нечетное число " + numberA + "!!!");
}