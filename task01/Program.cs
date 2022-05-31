// 02. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов

void FillMatrix (int [,] m1)
{
    for (int i=0; i<m1.GetLength(0); i++)
    {
        for (int j=0; j<m1.GetLength(1); j++)
        {
            m1[i,j]=new Random().Next(0,10);
        }
    }
}

void PrintMatrix (int [,] m2)
{
    for (int i=0; i<m2.GetLength(0); i++)
    {
        for (int j=0; j<m2.GetLength(1); j++)
        {
            Console.Write ($"{m2[i,j]}  ");
        }
    Console.WriteLine ();
    }
}

Console.Write ($"введите кол-во строк ");
int rows = int.Parse(Console.ReadLine () ?? "0");
Console.Write ($"введите кол-во столбцов ");
int columns = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix = new int [rows,columns];
double sum=0;
double medium_ar=0;

FillMatrix (matrix);
PrintMatrix (matrix);

for (int j=0; j<matrix.GetLength(1);j++)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        sum= sum+matrix[i,j];  
        medium_ar = sum/matrix.GetLength(1);
        medium_ar = Math.Round(medium_ar,2);
    }
Console.WriteLine($"среднее арифметическое столбца {j} = {medium_ar}");
sum=0;
}
