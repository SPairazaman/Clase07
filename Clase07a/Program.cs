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
    Console.WriteLine("4) impresión Números ingresado por usuario");
    Console.WriteLine("5) ");
    Console.WriteLine("6)");
    Console.WriteLine("7) ");
    Console.WriteLine("8) Salir");
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
            numero = ingreseNumero();
            mostrarNumeros(numero);
            break;
        case 5:
            numero = ingreseNumero();
            mostrarAreaCirculo(numero);
            break;
    }

} while (opcion != 8);

void mostrarAreaCirculo(int radio){
    double area = areaCirculo(radio);
    Console.WriteLine($"El área del círculo es: {area}");
}

double areaCirculo(int radio)
{
    double area = (Math.PI) * Math.Pow(radio,2);
    return area;
}

void mostrarNumeros(int cantidad)
{
    Console.WriteLine("Los números son:");
    Console.WriteLine("");
    for (int i = 0; i <= cantidad; i++)
    {
        Console.WriteLine($"Número {i}");
    }
}

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