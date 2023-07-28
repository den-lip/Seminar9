//Задайте значение N. Напишите программу, которая выведет все ЧЕТНЫЕ 
//натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
NaturalToLow(number, count);


void NaturalToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, count + 2);
        Console.Write(count + " ");
    }
}