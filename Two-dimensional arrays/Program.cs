//Двухмерные массивы. Плотников Кирилл Андреевич 22-ИСП-2/2
//№варианта:16
//Дана квадратная матрица 10 × 10.Реализуйте программу для транспонирования матрицы по главной и побочной диагоналям.

int[,] a = new int[10, 10];
int[,] at1 = new int[10, 10];
int[,] at2 = new int[10, 10];
Random rand = new Random();

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("Исходная матрица:");
for (int j = 0; j < 10; j++)
{
    for (int i = 0; i < 10; i++)
    {
        a[i, j] = rand.Next(10, 100);
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("Транспонированная матрица (по главной диагонали):");
for (int j = 0; j < 10; j++)
{
    for (int i = 0; i < 10; i++)
    {
        at1[i, j] = a[j, i];
        Console.Write(at1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("Транспонированная матрица (по побочной диагонали):");
for (int j = 0; j < 10; j++)
{
    for (int i = 0; i < 10; i++)
    {
        at2[i, j] = a[9 - j, 9 - i];
        Console.Write(at2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;