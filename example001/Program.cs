Console.Write("Введите трехзначное число: ");
int inNum = Convert.ToInt32(Console.ReadLine());
int a = inNum%100;
int ostDel = a%10;
Console.Write("Последняя цифра введенного числа это: " + ostDel);

