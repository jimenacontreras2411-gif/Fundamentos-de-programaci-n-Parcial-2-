
using System.Numerics;



int vidaenemigo = 5;
Console.WriteLine ("Vida Del EnemigoOO: " + vidaenemigo);
Console.WriteLine ("Marca enter para atacar al enemigo");
while (vidaenemigo > 0)
{Console.ReadLine ();

    vidaenemigo = vidaenemigo - 5;
                  Console.WriteLine("Has atacado al enemigo, le queda " + vidaenemigo + " de vida");
}
Console.WriteLine ("El enemigo ha sido derrotado");

Console.WriteLine ("\n\n\n");

//Ejercicio 2
//programa que pida num entero, mensaje de error si no es asi
Console.WriteLine ("Dame un número entero");
string yapapa;
int    num;
do

{
        Console.WriteLine("Porfavor escriba un número entero");
        yapapa = Console.ReadLine ();
} while (!int.TryParse (yapapa ,out num));

Console.WriteLine("Muchas gracias");
Console.WriteLine ("\n\n\n");

//Ejercicio 3
//Tabla del 7 del 0 al 100 en forma ordenada
Console.WriteLine("Presiona enter para mostrar la tabla del 7");
Console.ReadLine ();
for (int i = 0; i <= 100;i++)
{
    Console.WriteLine($"{i} * 7 = {i*7}");
}

