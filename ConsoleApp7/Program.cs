int[] mas = new int[30];
Random rand = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = rand.Next(1, 100);
    Console.Write(mas[i] + " ");
}
Console.WriteLine();
int tempL, tempR;
int max = 0;
for (int i = 0; i < mas.Length; i++)
{
    if (i == 0) tempL = 0;
    else tempL = mas[i - 1];
    if (i == 29) tempR = 0;
    else tempR = mas[i + 1];
    if (mas[i] > tempL && mas[i] > tempR) max = mas[i];
    if (mas[i] > tempL && mas[i] > tempR) Console.Write(max + " ");
}