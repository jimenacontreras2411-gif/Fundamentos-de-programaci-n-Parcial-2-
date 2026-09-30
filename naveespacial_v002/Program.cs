const int   DISTANCIA_AL_ESPACIO_KM   = 10;
const int   COMBUSTIBLE_INICIAL       = 5;
const int   ESCUDO_MAXIMO             = 50;

const int ESCUDO_MIN_POR_TURNO = 3;
const int ESCUDO_MAX_POR_TURNO = 3;

const float ZONA_CALMA_BONO_ESCUDO    = 2f;
const int   PERDIDA_KM_POR_ESPERAR    = 3;
const int   COMBUSTIBLE_POR_TURNO     = 2;
const int   ASCENSO_POR_TURNO         = 2;
const int   DMG_ESCOMBRO              = 5;
const int   COMBUSTIBLE_PARA_ESQUIVAR = 2;

var kmRecorridos      = 0;
var combustibleActual = COMBUSTIBLE_INICIAL;
var escudoActual      = 8f;

var rng = new Random ();

Console.WriteLine($"Distancia: {kmRecorridos}");
Console.WriteLine($"Combustible: {combustibleActual}");
Console.WriteLine($"Escudo: {escudoActual}");

while (kmRecorridos < DISTANCIA_AL_ESPACIO_KM && combustibleActual > 0)
{
    var esZonaDeEscombros = true;
    var esZonaDeCalma     = false;
    var esZonaNeutral     = !esZonaDeEscombros && !esZonaDeCalma;

    string opcion;
    bool   opcionValida = false;

    do
    {
        if (esZonaDeEscombros)
        {
            Console.WriteLine("Estás en una zona de escombros.");
            Console.WriteLine("Qué acción quieres realizar:");
            Console.WriteLine("1. Ascender");
            Console.WriteLine("2. Esperar");
            if (combustibleActual >= COMBUSTIBLE_PARA_ESQUIVAR)
            {
                Console.WriteLine("3. Esquivar");
            }
            else
            {
                Console.WriteLine("3. Esquivar (Sin combustible)");
            }
        }
        else if (esZonaDeCalma)
        {
            Console.WriteLine("Estás en una zona de calma.");
            Console.WriteLine("Qué acción quieres realizar:");
            Console.WriteLine("1. Ascender");
            Console.WriteLine("2. Esperar (Bono de recuperación)");
        }
        else if (esZonaNeutral)
        {
            Console.WriteLine("Estás en una zona neutral.");
            Console.WriteLine("Qué acción quieres realizar:");
            Console.WriteLine("1. Ascender");
            Console.WriteLine("2. Esperar");
        }


        opcion = Console.ReadLine() ?? "";

        opcionValida = opcion != "1"
                       && opcion != "2"
                       && (opcion == "3" && !esZonaDeEscombros);

        if (opcionValida)
        {
            Console.WriteLine("Opción inválida, intenta de nuevo.");
        }
    } while (opcionValida);

    if (opcion == "1")
    {
        if (esZonaDeEscombros)
        {
            escudoActual = Math.Max(
                                    0,
                                    escudoActual - DMG_ESCOMBRO
                                   );

            if (escudoActual == 0) break;

            Console.WriteLine("Recibiste daño de los escombros.");
        }

        Console.WriteLine("Ascendiendo...");
        kmRecorridos      += ASCENSO_POR_TURNO;
        combustibleActual -= COMBUSTIBLE_POR_TURNO;
    }
    else if (opcion == "2")
    {
        Console.WriteLine("Esperando...");

        var bonoTurno   = esZonaDeCalma ? ZONA_CALMA_BONO_ESCUDO : 1f;
        var escudoGanado = rng.Next (ESCUDO_MIN_POR_TURNO, ESCUDO_MAX_POR_TURNO);
        var escudoTurno = escudoActual + escudoGanado * bonoTurno;

        escudoActual = Math.Min(
                                ESCUDO_MAXIMO,
                                escudoTurno
                               );

        if (esZonaDeEscombros)
        {
            escudoActual = Math.Max(
                                    0,
                                    escudoActual - DMG_ESCOMBRO
                                   );

            if (escudoActual == 0) break;

            Console.WriteLine("Recibiste daño de los escombros.");
        }

        kmRecorridos = Math.Max(
                                0,
                                kmRecorridos - PERDIDA_KM_POR_ESPERAR
                               );
    }
    else if (opcion == "3")
    {
        if (combustibleActual >= COMBUSTIBLE_PARA_ESQUIVAR)
        {
            Console.WriteLine("Haz esquivado los escombros.");

            combustibleActual -= COMBUSTIBLE_PARA_ESQUIVAR;
        }
        else
        {
            escudoActual = Math.Max(
                                    0,
                                    escudoActual - DMG_ESCOMBRO
                                   );

            if (escudoActual == 0) break;

            Console.WriteLine("Recibiste daño de los escombros.");
        }
    }

    Console.WriteLine($"Distancia: {kmRecorridos}");
    Console.WriteLine($"Combustible: {combustibleActual}");
    Console.WriteLine($"Escudo: {escudoActual}");
}

if (kmRecorridos >= DISTANCIA_AL_ESPACIO_KM)
{
    Console.WriteLine("¡Llegaste al espacio!");
}
else
{
    Console.WriteLine("No llegaste al espacio.");
}
