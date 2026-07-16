using System;

class Program
{
    static void Main()
    {
    
        int fila, columna, x, yy, mayo;
        int[,] tabla = new int[4, 4];

      
        for (fila = 0; fila < 4; fila++)
        {
            for (columna = 0; columna < 4; columna++)
            {
                Console.Write("Ingrese un número: ");
               
                tabla[fila, columna] = int.Parse(Console.ReadLine());
            }
        }

     
        mayo = tabla[0, 0];
        x = 0;
        yy = 0;

        for (fila = 0; fila < 4; fila++)
        {
            for (columna = 0; columna < 4; columna++)
            {
                if (tabla[fila, columna] > mayorr)
                {
                   
                    mayo = tabla[fila, columna];
                    
                    x = fila;
                    yy = columna;
                }
            }
        }

        Console.WriteLine("El número mayor es: " + mayorr);
        Console.WriteLine("Está en la fila " + (x + 1));
        Console.WriteLine("Y en la columna " + (yy + 1));
    }
