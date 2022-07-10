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

while (intCantidadNumeros != 6){
    if (boolFunctionValidarValor(intValoresUsuarios))
    {
        Console.Write("Ingrese el digito {0}: ", intCantidadNumeros);
        int.TryParse(Console.ReadLine(), out intValoresUsuarios);
        if (!boolFunctionValidarNumeroRepetido(intValoresUsuarios, intArrayValoresUsuarios)){
            intCantidadNumeros++;
            intArrayValoresUsuarios[intCantidadNumeros - 1] = intValoresUsuarios;           
        }
        else{
            voidCapturaDatos("El numero ya fue ingresado.",intCantidadNumeros);
            int.TryParse(Console.ReadLine(), out intValoresUsuarios);
        }
    }
    else{
        voidCapturaDatos("Favor de ingresar un valor entre el 1-40",intCantidadNumeros);
        int.TryParse(Console.ReadLine(), out intValoresUsuarios);
    }
}

//Genera los numeros de la loterias
voidGenerarNumeroLoteria(intArrayValoresLoterias);

//Imprime los numeros jugados
Console.Write("Numeros Jugados: ");
voidImprimirValores(intArrayValoresUsuarios);

//Imprime los numeros de la loterias
Console.Write("Numeros ganadores: ");
voidImprimirValores(intArrayValoresLoterias);

//Verifica si el ticket es ganodor o perdedor
voidVerificarGanador(intArrayValoresUsuarios,intArrayValoresLoterias);

Console.ReadKey();
Console.Clear();

#region Captura de datos del usuario
/// <summary>
/// Captura los introducido por el usuario
/// </summary>
/// <param name="paramStringTexto">Texto gerico tipo string</param>
/// <param name="paramIntCantidadNumeros">Cantidad de digito</param>
void voidCapturaDatos(string paramStringTexto,int paramIntCantidadNumeros)
{
        Console.WriteLine(paramStringTexto);
        Console.Write("Ingrese el digito {0}: ", paramIntCantidadNumeros);
}
#endregion Captura de datos del usuario 

#region  Validacion de numeros entre el 1 y 40
/// <summary>
/// Valida los valores comprendido entre 1 y 40 introducido por el usuario.
/// </summary>
/// <param name="paramIntValor">Recive el valor de validacion</param>
/// <returns>Valor tipo bool</returns>
bool boolFunctionValidarValor(int paramIntValor)
{
    return (paramIntValor >= 1 && paramIntValor <= 40) ? true : false;
}
#endregion Validacion de numeros entre el 1 y 40

#region Comprueba si un valor esta repetido en un array
/// <summary>
/// Valida los numeros duplicado de un arreglo
/// </summary>
/// <param name="paramIntValor">Valor a verificar tipo intenger</param>
/// <param name="paramIntArray">Lista de valor a comprobar tipo arreglo</param>
/// <returns>Valor encontro o no encontrado tipo bool</returns>
bool boolFunctionValidarNumeroRepetido(int paramIntValor, int[] paramIntArray)
{
    bool boolEcontrado = false;
    foreach (var item in paramIntArray)
        if (item == paramIntValor)
            boolEcontrado = true;
    return (boolEcontrado) ? true : false;
}
#endregion Comprueba si un valor esta repetido en un array

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

#region Genera los numeros de la loteria
/// <summary>
/// Inicializa un array con numeros aleatoreos del 1 al 100
/// </summary>
/// <param name="paramArray">Array de tipo intenger</param>
/// <returns>Objeto tipo array<returns>
void voidGenerarNumeroLoteria(int[] paramArray)
{
    for (int i = 0; i < paramArray.Length; i++)
        if (!boolFunctionValidarNumeroRepetido(intFuctionNumerosAleatores(), paramArray)){
            paramArray[i] = intFuctionNumerosAleatores();
        }
        else{
            paramArray[i] = intFuctionNumerosAleatores() + 1;
        }    
}
#endregion Genera los numeros de la loteria

#region Imprime los valores ordenado de un array
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
#endregion Imprime los valores ordenado de un array

#region Verifica si existe un ticket ganador o pelao!
/// <summary>
/// Verificacion de los numeros ganadores
/// </summary>
/// <param name="paramIntArrayJugada">Valores jugados del usuario tipo array</param>
/// <param name="paramIntArrayLoto">Valores generados de la loteria tipo array</param>
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
#endregion Verifica si existe un ticket ganador o pelao!

#endregion Ejercicio 01