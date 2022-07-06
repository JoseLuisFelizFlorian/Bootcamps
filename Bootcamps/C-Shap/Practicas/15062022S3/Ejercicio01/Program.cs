#region Ejercicio 02
///<summary>
/// Autor: Feliz Florian Jose Luis
/// Fecha: 11/06/2022
/// Descripcion: Hacer un programa que imprima la tabla de multiplicar del 2 al 9
///<summary>

//Recore las tabla de multiplicar 1 al 9
for (int i= 2; i<=9; i++)
{
    //Imprimime +++++   Tabla 1,2,3...9 ++++
    Console.WriteLine("+++++++++++++++++\n*    Tabla {0}   *\n+++++++++++++++++",i);

    //Recorre los valores de multiplicar de cada una de las tablas
    for (int j = 1; j < 13; j++)
    {
        //Imprimime los valores 2 X 01 = 02, 2 x 02 = 04...9 X N = N
        Console.WriteLine("|| {0} X {1:00} = {2:00} ||" ,i,j,i*j);
    }
    
}

#endregion Ejercicio 02
