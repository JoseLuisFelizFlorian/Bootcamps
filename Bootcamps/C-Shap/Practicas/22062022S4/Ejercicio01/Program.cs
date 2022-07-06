#region Ejercicio 01
///<summary>
/// Autor: Feliz Florian Jose Luis
/// Fecha: 22/06/2022
/// Descripcion: 	
///             *Crear un arreglo de 20 posiciones.
///         	*Llenar el arreglo con valores aleatorios.
///	            *Organizar de manera ascendente con el metodo de ordenacion burbuja.
///	            *Imprimir el arreglo antes y despues de ordenado.
///<summary>

Console.WriteLine("Favor de ingresar el tamano del arreglo");
int.TryParse(Console.ReadLine(), out int intPosiciones);

int [] intArray = new int[intPosiciones];

voidInicializarValores(intArray);

voidBubbleSort(intArray);

void voidInicializarValores(int [] paramArrey)
{
    for(int i=0; i < paramArrey.Length ; i++)
    {
        
        Console.Write(paramArrey[i]=intNumerosAleatores());
    }
}

int intNumerosAleatores()
{
    Random intNumeroAleatoreos = new Random();
    
    return intNumeroAleatoreos.Next(1,100);
}

void voidBubbleSort(int []paramArray)
{
    int intContenedor;

    for(int i=1; i <= paramArray.Length -1; i++)
    {
        for(int j = 0;j< paramArray.Length -1;  j++ )
        {
            if (paramArray[j + 1] < paramArray[j])
            {
                intContenedor = paramArray[j];
                paramArray[j] = paramArray[j+1];
                paramArray[j+1]=intContenedor;
            }
        }
    }
                //Sorted array  
            foreach (int num in paramArray)  
            {  
                Console.Write("\t {0}",num);  
            }  
            Console.Read();
}


#endregion Ejercicio 01