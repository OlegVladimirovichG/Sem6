/*int rows = 3;
int columns = 4;

double[,] GetArray(int m, int n){
    var result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            result[i, j] = new Random().NextDouble();
        }
    }
    return result;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

PrintArray(GetArray(rows, columns));


int rows = 3;
int columns = 4;

int[,] GetArray(int m, int n){
    var result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            result[i, j] = new Random().Next(110);
        }
    }
    return result;
}

bool Contains(int[,] arr, int element)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == element)
            {
                return true;
            }
        }
    }
    return false;
}

var arr = GetArray(rows, columns);
foreach (var item in arr)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine(Contains(arr, 12));



int rows = 3;
int columns = 4;

int[,] GetArray(int m, int n){
    var result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            result[i, j] = new Random().Next(110);
        }
    }
    return result;
}


double[] GetAverge(int[,] arr)
{
    var result = new double[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        result[1] = Math.Round(sum / arr.GetLength(0), 2);
    }
    return result;
}



foreach (var item in GetAverge(GetArray(rows, columns)))
{
    System.Console.WriteLine(item);
}

*/