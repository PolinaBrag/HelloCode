// Показать числа от -N до N

int numP = new Random().Next(1,10);
Console.WriteLine(numP);

int numN = -numP;


while (numN <= numP)
{
   Console.WriteLine(numN);
numN = numN + 1;
}
