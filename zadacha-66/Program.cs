/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


Console.Write("Введите значение M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int PrintSumNumber(int numberM, int numberN)
{
    if (numberN > numberM)
        return numberN + PrintSumNumber(numberM, numberN-1);
    
    return numberM;
   
}
int result = PrintSumNumber(numberM, numberN);
Console.Write($"M = {numberM}; N = {numberN} -> {result}");
