Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
//int ostDel = numberA%2;
int b = 2;

while (b <= numberA)
{
    Console.Write(b);
    b= b +2;
    if (b <= numberA)
    {
        Console.Write(", ");
    }
}


/* Денис, у меня есть вопрос по этой задаче. Вот такое решение мне подсказал одногруппник. Конеретно то, что надо прибавлять +2. Изнчально мой цикл выглядел так:
int ostDel = numberA%2;
while (b <= numberA && ostDel == 0)
{
    Console.Write(b);
    b++;
    if (b <= numberA)
    {
        Console.Write(", ");
    }
}
Но почему-то не работало. Можете подсказать, где ошибка?
*/