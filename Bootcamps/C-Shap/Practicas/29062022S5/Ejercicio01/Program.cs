#region  Ejercicio 01

///<summary>
/// Autor: Feliz Florian Jose Luis
/// Fecha: 29/06/2022
/// Codgio: 29062022S4
/// Descripcion: 	
////            *Programa que pida al usuario 6 valores entre 1-40.
////            *Luego que genere de forma aleatoria 6 numeros entre el 1-40.
////            *Debe asegurarse de que no se repitan estos numeros.
////            *Los 6 numeros deben almacenarse en un array.
////            *Estos seran los numeros ganadores.
////            *Al final debe mostrar los 6 numeros introducidos por el usuario y
////            *Moatrar los 6 numeros ganadores.
////            *Debe imprimir si el usuario es ganador o se fue pelao!
///<summary>

int intCantidadNumeros = 0;
int intValoresUsuarios = 1;
int[] intArrayValoresUsuarios = new int[6];
int[] intArrayValoresLoterias = new int[6];

Console.WriteLine("LOTERIA NACIONAL DE LA REPUBLICA DOMINICANA\n");

while (intCantidadNumeros != 6)
{
    if (boolFunctionValidarValor(intValoresUsuarios))
    {
        Console.Write("Ingrese el digito {0}: ", intCantidadNumeros);
        int.TryParse(Console.ReadLine(), out intValoresUsuarios);
        if (!boolFunctionValidarNumeroRepetido(intValoresUsuarios, intArrayValoresUsuarios))
        {
            intCantidadNumeros++;
            intArrayValoresUsuarios[intCantidadNumeros - 1] = intValoresUsuarios;           
        }
        else
        {
            voidCapturaDatos("El numero ya fue ingresado.",intCantidadNumeros);
            int.TryParse(Console.ReadLine(), out intValoresUsuarios);
        }
    }
    else
    {
        voidCapturaDatos("Favor de ingresar un valor entre el 1-40",intCantidadNumeros);
        int.TryParse(Console.ReadLine(), out intValoresUsuarios);
    }
}

voidInicializarArreglo(intArrayValoresLoterias);

Console.Write("Numero Jugados: ");
voidImprimirValores(intArrayValoresUsuarios);

Console.Write("Numeros ganadores: ");
voidImprimirValores(intArrayValoresLoterias);

voidVerificarGanador(intArrayValoresUsuarios,intArrayValoresLoterias);

void voidCapturaDatos(string paramStringTexto,int paramIntCantidadNumeros)
{
        Console.WriteLine(paramStringTexto);
        Console.Write("Ingrese el digito {0}: ", paramIntCantidadNumeros);
        //int.TryParse(Console.ReadLine(), out paramIntValoresUsuarios);
}

void voidVerificarGanador(int[] paramIntArrayJugada, int[] paramIntArrayLoto)
{
    int intNumeroAcertados = 0;
    for (int i = 0; i < paramIntArrayLoto.Length; i++)
        if(paramIntArrayLoto[i] == paramIntArrayJugada[i])
            intNumeroAcertados += 1;
    if(intNumeroAcertados == 6)
    {
        Console.WriteLine("TICKER GANADOR");
    }
    else
    {
        Console.WriteLine($"TICKET PELAO!. Solo obtuviste {intNumeroAcertados}.");
    }
}

bool boolFunctionValidarNumeroRepetido(int paramIntValor, int[] paramIntArray)
{
    bool boolEcontrado = false;
    foreach (var item in paramIntArray)
        if (item == paramIntValor)
            boolEcontrado = true;
    return (boolEcontrado) ? true : false;
}

bool boolFunctionValidarValor(int paramIntValor)
{
    return (paramIntValor >= 1 && paramIntValor <= 40) ? true : false;
}

#region Genera numeros aleatorios
/// <summary>
/// Genera numeros aleatoreos comprendidos del 1 al 40.
/// Algunos numeros pueden repetirse.
/// </summary>
/// <returns>Valor intenger de 2 digitos</returns>
int intFuctionNumerosAleatores()
{
    Random intNumeroAleatoreos = new Random();
    return intNumeroAleatoreos.Next(1, 40);
}

#endregion Genera numeros aleatorios

#region Inicializar Array
/// <summary>
/// Inicializa un array con numeros aleatoreos del 1 al 100
/// </summary>
/// <param name="paramArray">Array de tipo intenger</param>
/// <returns>Objeto tipo array<returns>
void voidInicializarArreglo(int[] paramArray)
{
    for (int i = 0; i < paramArray.Length; i++)
        if (!boolFunctionValidarNumeroRepetido(intFuctionNumerosAleatores(), paramArray)){
            paramArray[i] = intFuctionNumerosAleatores();
        }
        else{
            paramArray[i] = intFuctionNumerosAleatores() + 1;
        }    
}
#endregion Inicializar Array

#region Imprime los valores ordenado
/// <summary>
/// Imprime los valores almecenado en un arreglo de tipo intenger
/// </summary>
/// <param name="paramArray">Recibe un arreglo de tipo intenger</param>
void voidImprimirValores(int[] paramArray)
{
    Array.Sort(paramArray);
    foreach (int intArray in paramArray)
    {
        Console.Write("{0:00} ", intArray);
    }
    Console.WriteLine();
}
#endregion Imprime los valores ordenado

#endregion Ejercicio 01