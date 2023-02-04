// Показать двумерный массив размером m×n заполненный вещественными числами
double [,] CreateMatrix(int m, int n)
{
    var matrix = new double[m,n];
    var random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.NextDouble();
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Введите кол-во столбцов: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во строк: ");
int n = int.Parse(Console.ReadLine()!);
PrintMatrix(CreateMatrix(m,n));





