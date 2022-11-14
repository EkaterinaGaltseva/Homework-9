/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29  */

Console.Write("Введите значение M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int Akkerman(int numberM, int numberN)
{
	if(numberM == 0)
	{
		return numberN + 1;
	}
	else if(numberM > 0 && numberN == 0)
	{
		return Akkerman(numberM - 1, 1);
	}
	else
    {	
        return Akkerman(numberM - 1, Akkerman(numberM, numberN - 1));
    }
}
		
Console.WriteLine($"M = {numberM}, N = {numberN} -> A(M,N) = {Akkerman(numberM, numberN)}");