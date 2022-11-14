/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Write("Введите значение N: ");
int number = Convert.ToInt32(Console.ReadLine());

string CountNumber( int number)
{
    if (number <= 0)
        return number.ToString();
    else
    {
        Console.Write($" {number} ");
       return CountNumber(number-1)+ "," + number;

        
    }
}
CountNumber(number);

