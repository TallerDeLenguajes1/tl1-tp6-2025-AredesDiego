int eleccion;

do
{
    Console.WriteLine("Ingrese el primer número:");
    string? entrada1 = Console.ReadLine();
    if (!int.TryParse(entrada1, out int a))
    {
        Console.WriteLine("Entrada no válida. Intente de nuevo.");
        continue;
    }

    Console.WriteLine("Ingrese el segundo número:");
    string? entrada2 = Console.ReadLine();
    if (!int.TryParse(entrada2, out int b))
    {
        Console.WriteLine("Entrada no válida. Intente de nuevo.");
        continue;
    }

    Console.WriteLine("-1 Sumar \n-2 Restar \n-3 Multiplicar \n-4 Dividir \n-0 Salir");
    string? decision = Console.ReadLine();
    if (!int.TryParse(decision, out eleccion))
    {
        Console.WriteLine("Entrada no válida. Intente de nuevo.");
        continue;
    }

    int resultado = 0;

    switch (eleccion)
    {
        case 1:
            resultado = Sumar(a, b);
            break;
        case 2:
            resultado = Restar(a, b);
            break;
        case 3:
            resultado = Multiplicar(a, b);
            break;
        case 4:
            resultado = Dividir(a, b);
            break;
        case 0:
            Console.WriteLine("Saliendo...");
            return;
        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            continue;
    }

    Console.WriteLine($"Resultado: {resultado}");
    Console.WriteLine("Presione cualquier tecla para continuar o '0' para salir.");
    string? salir = Console.ReadLine();
    if (salir == "0")
        break;

} while (true);


int Sumar(int a , int b)
{
    return a + b;
}
int Restar(int a , int b)
{
    return a - b;
}
int Multiplicar(int a , int b)
{
    return a * b;
}
int Dividir(int a , int b)
{
    return a / b;
}


Console.WriteLine("-1 Sumar \n-2 Restar \n-3 Multiplicar \n-4 Dividir \n-0 Salir \n Ponga su respuesta:");
string? entrada = Console.ReadLine();

if (!int.TryParse(entrada, out int numero))
{
    Console.WriteLine("\nEntrada no válida. Intente de nuevo.\n");
}
    
Console.WriteLine("Ingrese el número:");
string? entrada2 = Console.ReadLine();

if (!int.TryParse(entrada2, out int b))
{
    Console.WriteLine("Entrada no válida. Intente de nuevo.\n");
}

Console.WriteLine("Ingrese el Primer número:");
string? entrada3 = Console.ReadLine();

if (!int.TryParse(entrada3, out int c))
{
    Console.WriteLine("Entrada no válida. Intente de nuevo.\n");
}

Console.WriteLine("Ingrese el segundo número:");
string? entrada4 = Console.ReadLine();

if (!int.TryParse(entrada4, out int d))
{
    Console.WriteLine("Entrada no válida. Intente de nuevo.\n");
}

Console.WriteLine("Su numero maximo es:" + maximo(c,d));
Console.WriteLine("Su numero maximo es:" + minimo(c,d));

double valorAbsoluto(double numero)
{
    return Math.Abs(numero);
}
double cuadrado(double numero)
{
    return numero * numero;
}
double raizCuadrada(double numero)
{
    return Math.Sqrt(numero);
}
double seno(double numero)
{
    return Math.Sin(numero);
}
double coseno(double numero)
{
    return Math.Cos(numero);
}
int parteEnteraDeTipoFloat(double numero)
{
    return (int)Math.Floor(numero);
}
int maximo(int a, int b)
{
    if (a > b)
        return a;
    return b;
}
int minimo(int a, int b)
{
    if (a > b)
        return a;
    return b;
}