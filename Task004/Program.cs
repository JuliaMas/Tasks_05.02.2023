// В матрице чисел найти сумму элементов главной диагонали
int [,] CreateMatrix(int m, int n)
{
    var matrix = new int[m,n];
    var random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(10,100);
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
Console.Write("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine()!);
var matrix = CreateMatrix(m,n);
int sum = 0;
PrintMatrix(matrix);

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        if(i == j)
        {
            sum = sum + matrix[i,j]; 
            
        }
    }
 }
 Console.WriteLine("Сумма элементов главной диагонали равна " + sum);


