// See https://aka.ms/new-console-template for more information
float a;
float b;

string input1;
string input2;

Console.WriteLine("Escriba un string: \n");
    input1 = Console.ReadLine();

    Console.WriteLine(input1.Length);

    Console.WriteLine("Escriba otro string: \n");
    input2 = Console.ReadLine();

string concat = input1 + input2;

    Console.WriteLine("Resultado: "+ concat);

Console.WriteLine("Escriba un numero para obtener un substring: \n");
int pillar = LeerNumero();
string resultado = concat.Substring(pillar);
Console.WriteLine("Se obtuvo: " + resultado);

string input;
do
{
    Console.WriteLine("Escriba la operación a realizar suma, resta, mult, div, abs, cuad, raiz, V2 para funciones extra o exit para salir \n");
    input = Console.ReadLine();
    switch (input)
    {
        case "suma":
            a = LeerNumero();
            b = LeerNumero();
            Console.WriteLine($"Resultado de la suma entre {a} y {b} es " + suma(a, b).ToString());
            break;
        case "resta":
            a = LeerNumero();
            b = LeerNumero();
            Console.WriteLine($"Resultado de la resta entre {a} y {b} es " + resta(a, b));
            break;
        case "mult":
            a = LeerNumero();
            b = LeerNumero();
            Console.WriteLine($"Resultado del producto entre {a} y {b} es " + multiplicacion(a, b));
            break;
        case "div":
            a = LeerNumero();
            b = LeerNumero();
            if (b == 0)
            {
                Console.WriteLine("NO EXISTE LA DIVISIÓN EN CERO");
            }
            else
            {
                Console.WriteLine($"Resultado del cociente entre {a} y {b} es " + division(a, b));
            }
            break;
        case "V2":
            Console.WriteLine("Escriba un numero para calcular el ABS, CUADRADO, RAÍZ, SENO COSENO y PARTE REAL:\n");
            a = LeerNumero();

            Console.WriteLine("Valor Absoluto = " + abs(a));

            Console.WriteLine("Cuadrado = " + cuadrado(a));

            Console.WriteLine("Raríz cuadrada = " + raizCuadrada(a));

            Console.WriteLine("Seno = " + seno(a));

            Console.WriteLine("Coseno = " + coseno(a));

            Console.WriteLine("Parte real = " + parteEntera(a));

            Console.WriteLine("Escriba dos numeros para calcular el mayor y el menor:\n");

            a = LeerNumero();
            b = LeerNumero();

            if (a != b)
            {
                Console.WriteLine("El mayor es: " + Mayor(a, b));
                Console.WriteLine("El menor es: " + Menor(a, b));
            }
            else
            {
                Console.WriteLine("Los números son iguales\n");
            }
            break;
        case "exit":
            break;
        default:
            Console.WriteLine("No es una opción válida");
            break;
    }
} while (input != "exit");

foreach (var letra in resultado)
{
    Console.WriteLine(letra);
}

resultado = resultado.ToUpper();
Console.WriteLine("Mayusculas: " + resultado);
resultado = resultado.ToLower();
Console.WriteLine("Minusculas: " + resultado);

Console.WriteLine("Escriba una cadena para separar en los espacios:");

input1 = Console.ReadLine();

string[] separado = input1.Split(' ');

foreach (var palabra in separado)
{
    Console.WriteLine(palabra);
}


int LeerNumero()
{
    int a;
    bool Resultado;
    do
    {
        Console.WriteLine("Escriba un numero: ");
        Resultado = int.TryParse(Console.ReadLine(), out a);
        if (!Resultado)
        {
            Console.WriteLine("No es un número válido");
        }
    } while (!Resultado);
    return a;
}

float suma(float a, float b)
{
    return a + b;
}

float resta(float a, float b)
{
    return a - b;
}

float multiplicacion(float a, float b)
{
    return a * b;
}

float division(float a, float b)
{

    return a / b;
}

float cuadrado(float a)
{
    return a * a;
}

float abs(float a)
{
    if (a >= 0)
    {
        return a;
    }
    else
    {
        return (-a);
    }
}

double raizCuadrada(float a)
{
    if (a < 0)
    {
        Console.WriteLine("Es raíz compleja\n");
        return 0;
    }
    else
    {
        return Math.Sqrt(a);
    }

}
double seno(float a)
{
    return Math.Sin(a);
}

double coseno(float a)
{
    return Math.Cos(a);
}

int parteEntera(float a)
{
    int x = (int)a;
    return x;
}

float Mayor(float a, float b)
{

    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

float Menor(float a, float b)
{
    if (a < b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
