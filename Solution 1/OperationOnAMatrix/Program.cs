
Console.Write("Ingrese orden de la matriz: ");
int n = int.Parse(Console.ReadLine());

int[,] mat = new int[n, n];
int sum = 0;
int may = -999999;
int men = 999999;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        mat[i, j] = (i + 1) - j;

        Console.Write(mat[i, j] + "\t");

        sum += mat[i, j];

        if (mat[i, j] > may)
        {
            may = mat[i, j];
        }

        if (mat[i, j] < men)
        {
            men = mat[i, j];
        }
    }
    Console.WriteLine();
}

Console.WriteLine("\nSuma total: " + sum);
Console.WriteLine("Valor máximo: " + may);
Console.WriteLine("Valor mínimo: " + men);

Console.ReadKey();