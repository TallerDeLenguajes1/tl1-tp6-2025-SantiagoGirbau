// See https://aka.ms/new-console-template for more information
float a;
float b;


string input;
do
{
    Console.WriteLine("Escriba la operación a realizar s=Suma e=Exit \n");
    input = Console.ReadLine();
    switch (input)
    {
        case "s":
        a=LeerNumero();
        b=LeerNumero();
        Console.WriteLine("Resultado de la Suma= "+ suma(a,b));
            break;
        case "e":
            break;
        default:
         Console.WriteLine("No es una opción válida");
            break;
    }
} while (input!="e");



float LeerNumero(){
    float a;
    bool Resultado;
        do{
            Console.WriteLine("Escriba un numero: ");
            Resultado=float.TryParse(Console.ReadLine(), out a);
                if(!Resultado){
                    Console.WriteLine("No es un número válido");
                }
        }while(!Resultado);
    return a;
}

float suma(float a, float b){
    return a+b;
}
