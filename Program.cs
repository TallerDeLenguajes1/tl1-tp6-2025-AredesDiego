Console.WriteLine("Ingrese valor del número:");
string? entrada = Console.ReadLine();

if (!string.IsNullOrEmpty(entrada))
{
    int numero = int.Parse(entrada);

    if (numero > 0)
    {
        int invertido = 0;
        while (numero > 0)
        {
            int digito = numero % 10;
            invertido = (invertido * 10) + digito;
            numero /= 10;
        }
         Console.WriteLine($"Número invertido: {invertido}");
    }
}
else
{
    Console.WriteLine("No ingresaste ningún número.");
}
