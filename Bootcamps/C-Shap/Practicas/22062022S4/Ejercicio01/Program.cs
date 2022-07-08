#region Ejercicio 01
///<summary>
/// Autor: Feliz Florian Jose Luis
/// Fecha: 22/06/2022
/// Codgio: 22062022S4
/// Descripcion: 	
///             *Crear un arreglo de 20 posiciones.
///         	*Llenar el arreglo con valores aleatorios.
///	            *Organizar de manera ascendente con el metodo de ordenacion burbuja.
///	            *Imprimir el arreglo antes y despues de ordenado.
///<summary>

Console.Write("Favor de ingresar el tamaño del arreglo: ");
int.TryParse(Console.ReadLine(), out int intPosiciones);

//Declaracion y asignacion del tamaño del arreglo
int [] intArray = new int[intPosiciones];

//Inicializa un arreglo con valores aleatorios
voidInicializarArreglo(intArray);

Console.WriteLine("\nPresione las siguientes teclas para ordenar: \n[A] Ascendente \n[D] Descendente");
string stringTipoOrdenamiento = Console.ReadLine();

//Ordena el arreglo de forma ascendente o desendente
//segun el tipo de ordenamiento ingresedo por el usuario
voidBubbleSort(intArray, stringTipoOrdenamiento);

//Salida del arreglo segun el tipo de ordenamiento seleccionado
voidImprimirValores(intArray);

#region Genera numeros aleatorios
/// <summary>
/// Genera numeros aleatoreos comprendidos del 1 al 100.
/// Algunos numeros pueden repetirse.
/// </summary>
/// <returns>Valor intenger de 2 digitos</returns>
int intFuctionNumerosAleatores()
{
    Random intNumeroAleatoreos = new Random();
    
    return intNumeroAleatoreos.Next(1,100);
}

#endregion Genera numeros aleatorios

#region Inicializar Array
/// <summary>
/// Inicializa un array con numeros aleatoreos del 1 al 100
/// </summary>
/// <param name="paramArray">Array de tipo intenger</param>
/// <returns>Objeto tipo array<returns>
void voidInicializarArreglo(int [] paramArray)
{
    Console.Write("Valores Generado: ");
    for(int i=0; i < paramArray.Length ; i++)
    {      
        Console.Write($"{paramArray[i]=intFuctionNumerosAleatores()}\t  ");
    }
}
#endregion Inicializar Array

#region Metodo de ordenamiento
/// <summary>
/// Metodo de ordenamiento burbuja.
/// Ordena los valores de forma ascendente y descendente.
/// </summary>
/// <param name="paramArray">Recibe un arreglo de tipo intenger</param>
/// <param name="paramStringOrden">Opcional: [A] Ascendente [D] Descendente</param>  
void voidBubbleSort(int []paramArray, string  paramStringOrden ="A")
{
    int intContenedor;

    for(int i=1; i <= paramArray.Length -1; i++)
    {
        for(int j = 0;j< paramArray.Length -1;  j++ )
        {
            if (paramArray[j + 1] < paramArray[j] && paramStringOrden =="A")
            {
                intContenedor = paramArray[j];
                paramArray[j] = paramArray[j+1];
                paramArray[j+1]=intContenedor;
            }
            else
            {
                if (paramArray[j + 1] > paramArray[j])
                {
                    intContenedor = paramArray[j];
                    paramArray[j] = paramArray[j+1];
                    paramArray[j+1]=intContenedor;
                }
            }
        }
    }
}
#endregion Metodo de ordenamiento

#region Imprime los valores ordenado
/// <summary>
/// Imprime los valores almecenado en un arreglo de tipo intenger
/// </summary>
/// <param name="paramArray">Recibe un arreglo de tipo intenger</param>
void voidImprimirValores(int []paramArray)
{   
    Console.Write("\nValores Ordenado: ");
    foreach (int intArray in paramArray)  
    {  
        Console.Write("{0:00}\t  ",intArray);  
    }  
    Console.Read();
    Console.Clear();
}
#endregion Imprime los valores ordenado

#endregion Ejercicio 01