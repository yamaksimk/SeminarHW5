Console.Clear();

// void InputMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(-10, 11);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + "\t");
//         Console.WriteLine();
//     }        
// }

// void ReleaseMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//                 Console.Write(matrix[i, j] * matrix[i, j] + "\t");
//             else
//                 Console.Write(matrix[i, j] + "\t");

//         }    
//         Console.WriteLine();
//     }        
// }

// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];

// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine("Новый массив: ");
// ReleaseMatrix(matrix);

//.........................................................................................................................................

// void InputMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(-10, 11);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + "\t");
//         Console.WriteLine();
//     }        
// }

// void ReleaseMatrix(int[,] matrix)
// {
//     int sum = 0;
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//                 sum = sum + matrix[i, j];
//         }    
//     }
//     Console.WriteLine(sum);        
// }

// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];

// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine("Сумма главной диагонали матрицы: ");
// ReleaseMatrix(matrix);

//.........................................................................................................................................

// void InputMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(0, 11);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + "\t");
//         Console.WriteLine();
//     }        
// }

// int[] ReleaseMatrix(int[,] matrix)
// {
//     int[] array = new int[matrix.GetLength(0)];
//     int sum = 0;
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         sum = 0;
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum = sum + matrix[i, j];
//         }
//         array[i] = sum / matrix.GetLength(1);
//     }
//     return array;
// }

// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// int[] array = new int[size[0]]; 
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine("Среднее арефметическое строк матрицы: ");
// array = ReleaseMatrix(matrix);
// Console.WriteLine(string.Join(", ", array));