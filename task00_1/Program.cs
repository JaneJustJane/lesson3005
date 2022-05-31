// 01. В матрице чисел найти сумму элементов главной диагонали

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
int sum=0;
FillMatrix (matrix);
PrintMatrix (matrix);

if (rows==columns)
{
     for (int i=0; i<matrix.GetLength(0); i++)
    {
        sum=sum + matrix[i,i];
    }
Console.WriteLine ($"сумма элементов главной диагонали массива = {sum}"); 
}
   
else 
Console.WriteLine ($"кол-во строк и столбцов должно совпадать");