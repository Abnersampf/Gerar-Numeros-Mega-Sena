int[] numeros = new int[6];
Random random = new Random();
int aleatorio;

for (int c = 0; c < 6; c++)
{
    aleatorio = random.Next(1, 61);
    while (numeros.Contains(aleatorio))
    {
        aleatorio = random.Next(1, 61);
    }
    numeros[c] = aleatorio;
}
Array.Sort(numeros);

foreach (int n in numeros)
{
    Console.Write(n + " ");
}
Console.WriteLine();
