//Micro-ejercicio #1
  //Genera un log de batalla de forma manual y muestra el resultado:
  //1. Player ataca por 5
  //2. Enemy ataca por 6
  //3. Player ataca por 7 (crit)
  //4. ¡Enemy aturdido!
  //5. Player ataca por 5
  //6. ¡Enemy ha muerto!
  //¿Arreglo o lista?: Arreglo
  
  string[] me1 =
  {
      "Player ataca por 5",
      "Enemy ataca por 6",
      "Player ataca por 7",
      "¡Enemy aturdido!",
      "Player ataca por 5",
      "¡Enemy ha muerto!",
  };

  foreach (string j1 in me1)
  {
      Console.WriteLine(j1);
  }
  
  Console.WriteLine("\n\n\n");
  
// Micro-ejercicio #2
  //Genera un programa que administre los enemigos activos de una zona. Muestra el estado en cada paso:
  //1. Slime, Globlin, Skeleton
  //2. Aparece Orc
  //3. Muere un Slime
  //4. Aparece Orc
  //5. Muere Orc
  //¿Arreglo o lista?:Lista

  List<string> enemigos = new List<string>()
  {
      "Slime", "Globlin", "Skeleton"
  };
  Console.WriteLine ($"Capacity: {enemigos.Capacity}");
  Console.WriteLine ($"Count: {enemigos.Count}"); 
  
    Console.WriteLine("\n");
    
  enemigos.Add ("Orc");
for (int i = 0 ; i <enemigos.Count; i++)
{
    Console.WriteLine ($"{i}: {enemigos[i]}");
}

    Console.WriteLine("\n");
    
enemigos.Remove ("Slime");
for (int i = 0 ; i <enemigos.Count; i++)
{
    Console.WriteLine ($"{i}: {enemigos[i]}");
}

    Console.WriteLine("\n");
    
  enemigos.Add ("Orc");
for (int i = 0 ; i <enemigos.Count; i++)
{
    Console.WriteLine ($"{i}: {enemigos[i]}");
}

    Console.WriteLine("\n");
    
enemigos.Remove ("Orc");
for (int i = 0 ; i <enemigos.Count; i++)
{
    Console.WriteLine ($"{i}: {enemigos[i]}");
}


  