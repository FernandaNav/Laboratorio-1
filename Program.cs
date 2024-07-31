using System;
using System.ComponentModel.DataAnnotations;

int opcion = 0;

do
{
    Console.Clear();
    Console.WriteLine("___________");
    Console.WriteLine("BIENVENIDO");
    Console.WriteLine("___________");
    Console.WriteLine("Bienvenido a la papelería CHUCHITO...");
    Console.WriteLine("¿Qué deseas realizar?");
    Console.WriteLine("Opción 1: Agregar producto.");
    Console.WriteLine("Opción 3: Salir.");

    try
    {
        opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("___________");
                Console.WriteLine("OPCION 1");
                Console.WriteLine("___________");
                IngresarProductos();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Ten un buen día");
                break;
            default:
                Console.WriteLine("Esta opcion no existe. "); Console.WriteLine("");
                MensajeParaContinuar();
                break;
        }
    }
    catch (FormatException)
    {
        MensajeDeError();
        MensajeParaContinuar();
    }
} while (opcion != 3);

static void MensajeParaContinuar()
{
    Console.WriteLine("");
    Console.WriteLine("Presiona cualquier tecla para continuar...");
    Console.ReadKey();
}
static void MensajeDeError()
{
    Console.WriteLine("Error de Formato");
}
static void IngresarProductos()
{

}

static string IngresarProducto1()
{
    Console.WriteLine("Ingresa el nombre del primer producto: ");
    string nombre = Console.ReadLine();
    return nombre;
}

static double IngresarPrecio1()
{
    bool validarFormato = false;
    double precio1;
    do
    {
        Console.WriteLine();
        Console.WriteLine("Ingresa el precio del primer producto: ");
        try
        {
            precio1 = Convert.ToDouble(Console.ReadLine());
            if(precio1 <= 0)
            {

            }
        }catch(FormatException)
        {
            MensajeDeError();
        }
        return precio1;
    } while (validarFormato==false);
}




