

Console.Write("Введите размер матрици: ");
int matrixSize;
int.TryParse(Console.ReadLine(), out matrixSize);

int[,] matrix = new int[matrixSize, matrixSize];
        
for(int i = 0; i < matrixSize;++i)
{
    for(int j = 0; j < matrixSize; ++j)
    {
        matrix[i, j] = Random.Shared.Next(0, 10);
    }
}


void RenderMatrix(in int[,] matrix, int matrixSize)
{
    for(int i = 0; i < matrixSize; ++i)
    {
        for(int j = 0; j < matrixSize; ++j)
        {
            if(i == j)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(matrix[i,j]);
                Console.ResetColor();
                Console.Write(" ");
            }else
            {
                Console.Write($"{matrix[i,j]} ");
            }

        }
        Console.WriteLine();
    }
}


int[,] MatrixTransform(int[,] matrix, int matrixSize)
{
    int[,] newMatrix = new int[matrixSize, matrixSize];

    for(int i = 0; i < matrixSize; ++i)
    {
        for(int j = 0; j < matrixSize; ++j)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }

    return newMatrix;
}


int[,] ColMenatMesta(int[,] matrix, int matrixSize , int numColOne, int numColTwo)
{

    for(int i = 0; i < matrixSize; ++i)
    {
        int temp = matrix[i, numColOne];
        matrix[i, numColOne] = matrix[i, numColTwo];
        matrix[i, numColTwo] = temp;
    }

    return matrix;
}

int[,] RowMenatMesta(int[,] matrix, int matrixSize , int numRowOne, int numRowTwo)
{
    for(int i = 0; i < matrixSize; ++i)
    {
        int temp = matrix[numRowOne, i];
        matrix[numRowOne, i] = matrix[numRowTwo, i];
        matrix[numRowTwo, i] = temp; 
    }

    return matrix;
}



RenderMatrix(matrix, matrixSize);

System.Console.WriteLine();

RenderMatrix(MatrixTransform(matrix, matrixSize), matrixSize);

System.Console.WriteLine();

RenderMatrix(ColMenatMesta(matrix, matrixSize, 1, 2), matrixSize);

System.Console.WriteLine();

RenderMatrix(RowMenatMesta(matrix, matrixSize, 1, 2), matrixSize);