using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] tabla = new int[4, 3];
        int num, suma;

        for (int fila = 0; fila < 4; fila++)
        {
            suma = 0;

            for (int columna = 0; columna < 3; columna++)
            {
                Console.Write("Ingrese un número: ");
                num = Convert.ToInt32(Console.ReadLine());

                tabla[fila, columna] = num;
                suma += num;
            }

            Console.WriteLine("La suma de la fila {0} es: {1}", fila + 1, suma);
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
