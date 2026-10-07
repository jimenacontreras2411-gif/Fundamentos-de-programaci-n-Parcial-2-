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

if (items.ContainsKey ("Arco")== false )
{
    items.Add ("Arco",30);
}

if (items.ContainsKey("Cuchillo", 70)==false)
{
    items.Add ("Cuchillo",70);
}



if(items.TryGetValue("Hoz", out int dmgHoz)==true)
{
    Console.WriteLine($"DMG Hoz: {dmgHoz}");
}

if(items.ContainsKey("Hacha", out int dmg))
{
    Console.WriteLine($"DMG hacha: {dmg}");
}

items.Clear ();
items.Add("Espada", 4);



Console.WriteLine(items.Count);

//En el diccionario no existen los indices sino claves que deben tener un valor
//Conteo-cuantos elementos hay, clave-identificador de un valor dentro de el diccionario, capacidad-capacidad del diccionario antes de crecer
