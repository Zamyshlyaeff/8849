/* Показать треугольник Паскаля
 *Сделать вывод в виде равнобедренного треугольника*/
int [,] a=new int[6,6];
int PASK(int x, int y)
{ if (x<2 & y<2) return 1; 
 else 
return PASK(x-1,y)+PASK(x,y-1);
}
for (int x=0;x<6;x++)
{
    for (int y=0;y<6;y++)
    {
        Console.Write(PASK(x,y));
    }

}
