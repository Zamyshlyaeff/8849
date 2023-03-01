/* Задайте две матрицы. Напишите программу с подпрограммой MultiMatrix,
 которая будет находить произведение двух матриц. 
а) простым поэлементным перемножением*/
int[,] INITA(int N, int C)
{   int [,] a=new int[N,C];
    Random random=new Random();
for (int i=0;i<a.GetLength(0);i++)
 { for (int j=0;j<a.GetLength(1);j++)
   { a[i,j]=random.Next(5,10);
   Console.Write(a[i,j]);
   }
   Console.WriteLine();
 }
 return a;
}
int[,] INITB(int N, int C)
{   int [,] b=new int[N,C];
    Random random=new Random();
for (int i=0;i<b.GetLength(0);i++)
 { for (int j=0;j<b.GetLength(1);j++)
   { b[i,j]=random.Next(5,10);
   Console.Write(b[i,j]);
   }
   Console.WriteLine();
 }
 return b;
}
int[,] MULTIMATRIX(int[,]a, int[,] b)
{   int [,] c=new int[a.GetLength(0), a.GetLength(1)];
for (int i=0;i<c.GetLength(0);i++)
 { for (int j=0;j<c.GetLength(1);j++)
   { c[i,j]=a[i,j]*b[i,j];
   Console.Write(c[i,j]);
   }
   Console.WriteLine();
 }
 return c;
}
int[,] a=INITA(3,3);
Console.WriteLine();
int[,] b=INITB(3,3);
Console.WriteLine();
int[,] c=MULTIMATRIX(a,b);
