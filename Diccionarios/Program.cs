Dictionary<string, int> items = new()
                                {
                                    { "Espada", 25 },
                                    { "Arco", 15 },
                                    { "Hacha", 35 },
                                };

Console.WriteLine(items["Espada"]);
Console.WriteLine(items["Hacha"]);

items["Arco"] = 20;

Console.WriteLine(items["Arco"]);

if(items.ContainsKey("Hoz")) {
    Console.WriteLine("DMG Hoz: " + items["Hoz"]);
}

if(items.TryGetValue("Hacha", out int dmg))
{
    Console.WriteLine($"DMG hacha: {dmg}");
}

Console.WriteLine(items.Count);

//En el diccionario no existen los indices sino claves que deben tener un valor
//Conteo-cuantos elementos hay, clave-identificador de un valor dentro de el diccionario, capacidad-capacidad del diccionario antes de crecer
