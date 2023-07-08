using System;

class Ejercicio49
{///GENERA 15 NUMERO AL AZAR CUENTA, SEGMENTA Y SUMA//
    static void Main()
    {
        Random rnd = new Random();
        int i, contador1, contador2, suma, numeroAleatorio;

        contador1 = 0;
        contador2 = 0;
        suma = 0;
        Console.WriteLine("Se generan los siguiente números aleatorios");
        for (i = 1; i <= 15; i++)
        {
            numeroAleatorio = rnd.Next(1, 21);
            
            Console.WriteLine("Número: " + numeroAleatorio);

            suma += numeroAleatorio;

            if (numeroAleatorio >= 10 && numeroAleatorio <= 15)
            {
                contador1++;
            }

            if (numeroAleatorio <= 7)
            {
                contador2++;
            }
        }

        Console.WriteLine("Cantidad de números entre 10 y 15: " + contador1);
        Console.WriteLine("Cantidad de números menores a 7: " + contador2);
        Console.WriteLine("Suma de todos los números generados: " + suma);
    }
}
