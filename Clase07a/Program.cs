int opcion = 0;
int numero = 0;
do
{
    Console.WriteLine("----------------------");
    Console.WriteLine("Seleccione una opcion:");
    Console.WriteLine("----------------------");
    Console.WriteLine("1) Suma n Numeros pares");
    Console.WriteLine("2) suma n Numeros impares");
    Console.WriteLine("3) promedio de notas");
    Console.WriteLine("4) promedio de notas");
    Console.WriteLine("5) promedio de notas");
    Console.WriteLine("6) promedio de notas");
    Console.WriteLine("7) promedio de notas");
    Console.WriteLine("S) Salir");
    Console.WriteLine();

    opcion = Convert.ToInt32(Console.ReadLine());


    switch (opcion)
    {
        case 1:
            numero = ingreseNumero();
            mostrarMensajeNumeros(numero);
            break;
        case 2:
         
            break;
        case 3:
       
            break;
        case 4:
         
            break;
    }

} while (opcion != 8);

int ingreseNumero()
{
    Console.WriteLine("Ingrese una cantidad: ");
    Console.WriteLine("----------------------");

    numero = int.Parse(Console.ReadLine());
    return numero;
}


void mostrarMensajeNumeros(int numero)
{
    if(numero > 0) Console.WriteLine($"El Número {numero} es positivo") ;
    if(numero == 0) Console.WriteLine($"El Número {numero} es cero");
    if (numero < 0) Console.WriteLine($"El Número {numero} es negativo");

}