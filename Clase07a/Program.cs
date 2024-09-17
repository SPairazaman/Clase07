int opcion = 0;
int numero = 0;
do
{
    Console.WriteLine("----------------------");
    Console.WriteLine("Seleccione una opcion:");
    Console.WriteLine("----------------------");
    Console.WriteLine("1) Numero + - 0");
    Console.WriteLine("2) Dia de la semana");
    Console.WriteLine("3) Suma de primeros 100 números");
    Console.WriteLine("4) ");
    Console.WriteLine("5) ");
    Console.WriteLine("6)");
    Console.WriteLine("7) ");
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
            int dia = ingreseNumero();
            diaDelasemana(dia);
            break;
        case 3:
            muestraSumaPrimerosCien();
            break;
        case 4:
         
            break;
    }

} while (opcion != 8);

int sumaPrimerosCienNumeros()
{
    int suma = 0;
    for (int i = 1; i < 100; i++)
    {
        suma = suma + i;
    }
    return suma;
}

void muestraSumaPrimerosCien()
{
    int suma = sumaPrimerosCienNumeros();
    Console.WriteLine($"La suma de los primeros 100 números es : {suma}");
}

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

void diaDelasemana(int dia)
{
    switch (dia)
    {
        case 1:
            Console.WriteLine("El día es Lunes");
            break;
        case 2:
            Console.WriteLine("El día es martes");
            break;
        case 3:
            Console.WriteLine("El día es Miércoles");
            break;
        case 4:
            Console.WriteLine("El día es Jueves");
            break;
        case 5:
            Console.WriteLine("El día es Viernes");
            break;
        case 6:
            Console.WriteLine("El día es Sábado");
            break;
        case 7:
            Console.WriteLine("El día es Domingo");
            break;
        default:
            break;
    }


}