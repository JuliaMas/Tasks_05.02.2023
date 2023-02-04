// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int [,] CreateMatrix(int m, int n)
{
    var matrix = new int[m,n];
    var random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(3,10);
            if(i % 2 == 0 && j % 2 == 0)
            matrix[i,j] = matrix[i,j] * matrix[i,j];
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
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
