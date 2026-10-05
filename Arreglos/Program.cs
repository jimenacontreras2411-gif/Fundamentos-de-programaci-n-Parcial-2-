// Arreglos

using System;

// Antes de ejecutar, responde:
// - ¿Cuántos valores contiene inventory?
// - ¿Qué representa [0]?
// - ¿Qué mostrará inventory[2]?
// - ¿Qué cambia en la línea 11?
// - ¿Cuántas veces se ejecutará el for?
// - ¿Qué contiene inventory.Length?


// Después de ejecutar, realiza estos cambios:
// - Reemplaza la declaración de valores por la de longitud
// - Asigna los valores
// - Agrega un nuevo elemento  "Espada" al arreglo
// - Asigna "Linterna" a inventory[inventory.Length - 1]
// - Imprime inventory.Length
// - Imprime los 4 valores
// - Asigna "Hacha" a inventory[5]
// - Asigna "Casco" a inventory[-1]


string[] inventory =
[
  "Espada",
  "Poción",
  "Llave",
  "Linterna",
  "Hacha",
  "Casco"
];

for (var i = 0; i < inventory.Length; ++i)
{
   Console.WriteLine(inventory[i]);
}


Console.WriteLine(inventory[0]);
Console.WriteLine(inventory[2]);

inventory[1] = "Escudo";
inventory[inventory.Length - 1]= "Linterna";

Console.WriteLine(inventory.Length);

for (var i = 0; i < inventory.Length; ++i)
{
   Console.WriteLine(inventory[i]);
}

//inventory[5] = "Hacha";
// No existen los num negativos en los arreglos: inventory[-1] = "Casco"
//Empezamos del 0 hacia adelante
//El sombrero empieza en reversa 1-el num de cosas en el arreglo.

