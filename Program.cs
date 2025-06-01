/* using System.Text.RegularExpressions;

int eleccion;
double resultado = 0;

do
{
    Console.WriteLine("Ingrese el primer número:");
    string? entrada1 = Console.ReadLine();
    if (!double.TryParse(entrada1, out double a))
    {
        Console.WriteLine("Entrada no válida. Intente de nuevo.");
        continue;
    }

    Console.WriteLine("Ingrese el segundo número:");
    string? entrada2 = Console.ReadLine();
    if (!double.TryParse(entrada2, out double b))
    {
        Console.WriteLine("Entrada no válida. Intente de nuevo.");
        continue;
    }

    Console.WriteLine(
        "-1 Sumar\n" +
        "-2 Restar\n" +
        "-3 Multiplicar\n" +
        "-4 Dividir\n" +
        "-5 Valor Absoluto\n" +
        "-6 Cuadrado\n" +
        "-7 Raíz Cuadrada\n" +
        "-8 Seno\n" +
        "-9 Coseno\n" +
        "-10 Parte Entera de Tipo Float\n" +
        "-11 Máximo\n" +
        "-12 Mínimo\n" +
        "-13 Buscar ocurrencia de una palabra\n" +
        "-0 Salir"
    );

    string? decision = Console.ReadLine();
    if (!int.TryParse(decision, out eleccion))
    {
        Console.WriteLine("Entrada no válida. Intente de nuevo.");
        continue;
    }

    resultado = 0;

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
        case 5:
            resultado = valorAbsoluto(a);
            break;
        case 6:
            resultado = cuadrado(a);
            break;
        case 7:
            resultado = raizCuadrada(a);
            break;
        case 8:
            resultado = seno(a);
            break;
        case 9:
            resultado = coseno(a);
            break;
        case 10:
            resultado = parteEnteraDeTipoFloat(a);
            break;
        case 11:
            resultado = maximo((int)a, (int)b);
            break;
        case 12:
            resultado = minimo((int)a, (int)b);
            break;
        case 13:
            BuscarOcurrenciaDePalabra();
            break;
        case 0:
            Console.WriteLine("Saliendo...");
            return;
        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            continue;
    }

    if (eleccion >= 1 && eleccion <= 12)
        Console.WriteLine($"Resultado: {resultado}");

    Console.WriteLine("Presione cualquier tecla para continuar o '0' para salir.");
    string? salir = Console.ReadLine();
    if (salir == "0")
        break;

} while (true);

Console.Write("Ponga su texto: ");
string? texto = Console.ReadLine();
Console.WriteLine($"La longitud de su texto: {texto.Length}");

string sub_cadena = texto.Substring(0, Math.Min(5, texto.Length));
Console.WriteLine($"Una subcadena de su texto es: {sub_cadena}");

Console.Write("Ponga su segundo texto: ");
string? segundo_texto = Console.ReadLine();
Console.WriteLine($"Sus textos concatenados son: {texto}{segundo_texto}");

Console.WriteLine($"La suma de num1 y num2 es: {resultado}");

foreach (var item in segundo_texto)
{
    Console.Write(item + " ");
}
Console.WriteLine();

Console.WriteLine($"El segundo texto en minuscula:" + segundo_texto.ToLower());
Console.WriteLine($"El segundo texto en Mayuscula:" + segundo_texto.ToUpper());

Console.WriteLine("Ingrese una cadena con valores separados por un carácter (por ejemplo: 'uno,dos,tres'):");

string? cadena = Console.ReadLine();

Console.WriteLine("Ingrese el carácter separador (por ejemplo: ','):");
string? separadorInput = Console.ReadLine();

if (string.IsNullOrEmpty(cadena) || string.IsNullOrEmpty(separadorInput) || separadorInput.Length != 1)
{
    Console.WriteLine("Cadena o separador no válidos.");
}
else
{
    char separador = separadorInput[0];
    string[] partes = cadena.Split(separador);

    Console.WriteLine("\nResultado de la separación:");
    foreach (string parte in partes)
    {
        Console.WriteLine(parte.Trim());
    }
}

Console.WriteLine("Ingrese una ecuación simple (por ejemplo: 582+2):");
string? ecuacion = Console.ReadLine();

if (string.IsNullOrEmpty(ecuacion))
{
    Console.WriteLine("No ingresó nada.");
    return;
}


char[] operadores = { '+', '-', '*', '/' };
char operador = ' ';
int pos = -1;

foreach (char op in operadores)
{
    pos = ecuacion.IndexOf(op);
    if (pos != -1)
    {
        operador = op;
        break;
    }
}

if (pos == -1)
{
    Console.WriteLine("No se encontró un operador válido (+, -, *, /).");
    return;
}

string parte1 = ecuacion.Substring(0, pos).Trim();
string parte2 = ecuacion.Substring(pos + 1).Trim();

if (double.TryParse(parte1, out double num1) && double.TryParse(parte2, out double num2))
{
    resultado = 0;

    switch (operador)
    {
        case '+':
            resultado = num1 + num2;
            break;
        case '-':
            resultado = num1 - num2;
            break;
        case '*':
            resultado = num1 * num2;
            break;
        case '/':
            if (num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                return;
            }
            resultado = num1 / num2;
            break;
    }

    Console.WriteLine($"Resultado: {resultado}");
}
else
    {
        Console.WriteLine("No se pudieron convertir los números.");
    }

static double Sumar(double a, double b) => a + b;
static double Restar(double a, double b) => a - b;
static double Multiplicar(double a, double b) => a * b;
static double Dividir(double a, double b) => b != 0 ? a / b : 0;
static double valorAbsoluto(double n) => Math.Abs(n);
static double cuadrado(double n) => n * n;
static double raizCuadrada(double n) => Math.Sqrt(n);
static double seno(double n) => Math.Sin(n);
static double coseno(double n) => Math.Cos(n);
static double parteEnteraDeTipoFloat(double n) => Math.Floor(n);
static int maximo(int a, int b) => a > b ? a : b;
static int minimo(int a, int b) => a < b ? a : b;
static void BuscarOcurrenciaDePalabra()
    {
        Console.Write("Ingrese el texto donde buscar: ");
        string? texto = Console.ReadLine();

        Console.Write("Ingrese la palabra a buscar: ");
        string? palabra = Console.ReadLine();

        if (string.IsNullOrEmpty(texto) || string.IsNullOrEmpty(palabra))
        {
            Console.WriteLine("Texto o palabra inválida.");
            return;
        }

        int ocurrencias = Regex.Matches(texto, $@"\b{Regex.Escape(palabra)}\b", RegexOptions.IgnoreCase).Count;
        Console.WriteLine($"La palabra '{palabra}' aparece {ocurrencias} veces.");
    }
*/

//Ejercicio 5 

using System;
using System.Text.RegularExpressions;

Console.WriteLine("VALIDADOR SIMPLE DE URL Y EMAIL");
Console.WriteLine("-------------------------------");

while (true)
{
    Console.WriteLine("\n¿Qué deseas validar?");
    Console.WriteLine("1. Dirección web (URL)");
    Console.WriteLine("2. Email");
    Console.WriteLine("3. Salir");
    Console.Write("Elige una opción (1-3): ");
    
    string opcion = Console.ReadLine();
    
    if (opcion == "1")
    {
        ValidarURL();
    }
    else if (opcion == "2")
    {
        ValidarEmail();
    }
    else if (opcion == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("Opción no válida. Intente de nuevo.");
    }
}

static void ValidarURL()
{
Console.Write("\nIngresa una URL: ");
string url = Console.ReadLine();

// Patrón para URLs (http/https opcional)
bool esValida = Regex.IsMatch(url, 
    @"^(https?:\/\/)?([\w-]+\.)+[\w-]+(\/[\w- .\/?%&=]*)?$", 
    RegexOptions.IgnoreCase);

MostrarResultado(url, esValida, "dirección web");
}
static void ValidarEmail()
{
Console.Write("\nIngresa un email: ");
string email = Console.ReadLine();

// Patrón básico para emails
bool esValido = Regex.IsMatch(email, 
    @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

MostrarResultado(email, esValido, "email");
}
static void MostrarResultado(string entrada, bool esValido, string tipo)
{
Console.WriteLine(esValido
    ? $"✔ '{entrada}' es un {tipo} válido."
    : $"✖ '{entrada}' NO es un {tipo} válido.");
}