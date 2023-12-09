Console.Clear();

//..........................................................................................................................

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(0, 11);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + "\t");
//         Console.WriteLine();
//     }
// }

// void Element (int[,] matrix)
// {
//     Console.WriteLine("Введите номер строки");
//     int pos1 = int.Parse(Console.ReadLine()!);
//     Console.WriteLine("Введите номер столбца");
//     int pos2 = int.Parse(Console.ReadLine()!);
//     if (pos1 - 1 > matrix.GetLength(0) || pos2 - 1 > matrix.GetLength(1)) 
//         Console.WriteLine("Такого элемента нет");
//     else 
//     {
//         Console.WriteLine("Элемент матрицы: ");
//         Console.Write(matrix[pos1 - 1, pos2 - 1]);
//     }
// }

// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// int[] array = new int[size[0]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Element(matrix);

//..........................................................................................................................

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(0, 11);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + "\t");
//         Console.WriteLine();
//     }
// }

// void NewMatrix(int[,] matrix)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[0, j] = matrix[0, j] + matrix[matrix.GetLength(0)-1, j];
//         matrix[matrix.GetLength(0)-1, j] = matrix[0, j] - matrix[matrix.GetLength(0)-1, j];
//         matrix[0, j] = matrix[0, j] - matrix[matrix.GetLength(0)-1, j];
//     }
// }

// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine("Новая матрица: ");
// NewMatrix(matrix);
// PrintMatrix(matrix);

//..........................................................................................................................

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(0, 11);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + "\t");
//         Console.WriteLine();
//     }
// }

// int MinString(int[,] matrix)
// {
//     int sum = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++) sum +=matrix[0,j];
//     int min = sum;
//     int a = 0;
//     Console.WriteLine("Сумма всех строк в матрице: ");
//     Console.WriteLine(sum);

//     for (int i = 1; i < matrix.GetLength(0); i++)
//     {
//         sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum +=matrix[i,j];
//         }
//         Console.WriteLine(sum);
//         if (min > sum)
//         {
//             min = sum;
//             a = i;
//         }
//     }
//     return (a);
// }

// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// int minSum = MinString(matrix);
// Console.Write ("Строка с минимальной суммой: "+(minSum + 1));