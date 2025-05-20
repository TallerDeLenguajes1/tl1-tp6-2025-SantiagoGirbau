// See https://aka.ms/new-console-template for more information
float a;
float b;


string input;
do
{
    Console.WriteLine("Escriba la operación a realizar suma, resta, mult, div o exit para salir \n");
    input = Console.ReadLine();
    switch (input)
    {
        case "suma":
            a=LeerNumero();
            b=LeerNumero();
            Console.WriteLine("Resultado = "+ suma(a,b));
            break;
        case "resta":
            a=LeerNumero();
            b=LeerNumero();
            Console.WriteLine("Resultado = "+ resta(a,b));
            break;
        case "mult":
            a=LeerNumero();
            b=LeerNumero();
            Console.WriteLine("Resultado = "+ multiplicacion(a,b));
            break;
        case "div":
            a=LeerNumero();
            b=LeerNumero();
            if(b==0){
            Console.WriteLine("NO EXISTE LA DIVISIÓN EN CERO");
            }else{
            Console.WriteLine("Resultado = "+ division(a,b));
            }
            break;
        case "exit":
            break;
        default:
         Console.WriteLine("No es una opción válida");
            break;
    }
} while (input!="exit");



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

float resta(float a, float b){
    return a-b;
}

float multiplicacion(float a, float b){
    return a*b;
}

float division(float a, float b){
    
    return a/b;
}