const int DISTANCIA_AL_ESPACIO_KM = 10;
const int COMBUSTIBLE_INICIAL = 5;
const int ESCUDO_MAXIMO = 50;
const int ESCUDO_POR_TURNO = 8;
const float ZONA_CALMA_BONO_ESCUDO = 1.5f;
const int PERDIDA_KM_POR_ESPERAR = 2;
const int   COMBUSTIBLE_POR_TURNO  = 5;
const int   ASCENSO_POR_TURNO      = 4;
const int DMG_ESCOMBROS = 2;
const int COMBUSTIBLE_PARA ESQUIVAR = 2;

var kmRecorridos      = 0;
var combustibleActual = COMBUSTIBLE_INICIAL;
var escudoActual      = ESCUDO_MAXIMO;

Console.WriteLine ("Bienvenido a la simulación de viaje espacial");
Console.WriteLine ($"Distancia: {kmRecorridos} ");
Console.WriteLine ($"Combustible: {combustibleActual}");
Console.WriteLine($"Escudo : {escudoActual} ");


kmRecorridos      += ASCENSO_POR_TURNO;
combustibleActual -= COMBUSTIBLE_POR_TURNO;

Console.WriteLine ($"Distancia: {kmRecorridos} ");
Console.WriteLine ($"Combustible: {combustibleActual}");
Console.WriteLine($"Escudo : {escudoActual} ");

while (kmRecorridos < DISTANCIA_AL_ESPACIO_KM && combustibleActual > 0)
{
    var esZonaDeEscombros = true;
    var  esZonaDeCalma = false;
    var  esZonaNeutral = !esZonaDeEscombros && ! esZonaDeCalma;
}

string opcion;
bool seleccionValida;

    do
    {
        if (esZonaDeEscombros)
        {
            Console.WriteLine("Estas en zona de escombros");
            Console.WriteLine("Que acción deseas realizar : ");
            Console.WriteLine("1. Acender ");
            Console.WriteLine("2. Esperar ");
            if (combustibleActual >= COMBUSTIBLE_PARA ESQUIVAR)
            {
                Console.WriteLine("3. Esquivar");
            }
            else
            {
                Console.WriteLine("No tienes suficiente combustible");
            }


        }
        else if (esZonaDeCalma)
        {
            Console.WriteLine("Estas zona de calma");
                    Console.WriteLine("Que acción deseas realizar : ");
                    Console.WriteLine("1. Acender ");
                    Console.WriteLine("2. Esperar (Bono de recuperación)");
        }
        else if (esZonaNeutral)
        {
            Console.WriteLine("Estas zona neutral");
                    Console.WriteLine("Que acción deseas realizar : ");
                    Console.WriteLine("1. Acender ");
                    Console.WriteLine("2. Esperar ");
        }

        Console.WriteLine("Que acción deseas realizar : ");
        Console.WriteLine("1. Acender ");
        Console.WriteLine("2. Esperar ");
        opcion = Console.ReadLine() ?? "";


        if (opcion != "1" && opcion !="2" && (opcion == "3" && !esZonaDeEscombros ))
        {
            Console.WriteLine("Opcion no valida, intenta de nuevo");
        }
    }
        while (opcion != "1" && opcion !="2" && (opcion == "3" && !esZonaDeEscombros ));

    if (opcion == "1")
    {
        if (esZonaDeEscombros)
        {
            escudoActual = Math.Max (0, escudoActual - DMG_ESCOMBROS);

            if (escudoActual == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine ("Recibiste daño de los escombros");
            }
        }
        Console.WriteLine("Ascendiendo...");
        kmRecorridos      += ASCENSO_POR_TURNO;
        combustibleActual -= COMBUSTIBLE_POR_TURNO;
    }
    else if (opcion == "2")
    {
        Console.WriteLine ("Esperando...");
        var bonoTurno = esZonaDeCalma ? ZONA_CALMA_BONO_ESCUDO : 1f;
        var escudoTurno = escudoActual + ESCUDO_POR_TURNO + bonoTurno;


        escudoActual = Math.Min (ESCUDO_MAXIMO, escudoActual);

        if (esZonaDeEscombros)
        {
            escudoActual = Math.Max(0, escudoActual - DMG_ESCOMBROS);

            if (escudoActual == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Recibiste daño de los escombros");
            }
        }

        kmRecorridos = Math.Min(0, kmRecorridos - PERDIDA_KM_POR_ESPERAR);
        else if (opcion == "3");

        if (combustibleActual <= COMBUSTIBLE_PARA_ESQUIVAR)
        {
            console.WriteLine("Haz esquivado los escombros");
            combustibleActual -= COMBUSTIBLE_PARA_ESQUIVAR
        }
        else
        {
            escudoActual = Math.Max (0, escudoActual - DMG_ESCOMBROS);
            if (esZonaDeEscombros)
            {
                escudoActual = Math.Max(0, escudoActual - DMG_ESCOMBROS);

                if (escudoActual == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Recibiste daño de los escombros");
                }
            }
        }
Console.WriteLine ($"Distancia: {kmRecorridos} ");
Console.WriteLine ($"Combustible: {combustibleActual}");
Console.WriteLine($"Escudo : {escudoActual} ");




if (kmRecorridos >= DISTANCIA_AL_ESPACIO_KM)
{
    Console.WriteLine("Llegaste a la meta :)");
}
else
{
    Console.WriteLine("No llegaste al espacio :(");
}



