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
                IngresarProducto1();
                IngresarPrecio1();
                MensajeParaContinuar();
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
    Console.Write("Ingresa el nombre del primer producto: ");
    string nombreProducto1 = Console.ReadLine();
    return nombreProducto1;
}

static double IngresarPrecio1()
{
    bool validarFormato = false;
    double precioProducto1 = 0;
    do
    {
        Console.WriteLine();
        Console.Write("Ingresa el precio del primer producto: Q");
        try
        {
            precioProducto1 = Convert.ToDouble(Console.ReadLine());
            if(precioProducto1 <= 0)
            {
                Console.WriteLine("El precio no puede ser igual ni menor a Q0.00. Intenta de nuevo.");
                Console.WriteLine();
            }
            else
            {
                validarFormato = true;
            }
        }catch(FormatException)
        {
            MensajeDeError();
        }
    } while (validarFormato==false);
    return precioProducto1;
}

static string IngresarProducto2()
{
    Console.Write("Ingresa el nombre del primer producto: ");
    string nombreProducto2 = Console.ReadLine();
    return nombreProducto2;
}

static double IngresarPrecio2()
{
    bool validarFormato = false;
    double precioProducto2 = 0;
    do
    {
        Console.WriteLine();
        Console.Write("Ingresa el precio del primer producto: Q");
        try
        {
            precioProducto2 = Convert.ToDouble(Console.ReadLine());
            if (precioProducto2 <= 0)
            {
                Console.WriteLine("El precio no puede ser igual ni menor a Q0.00. Intenta de nuevo.");
                Console.WriteLine();
            }
            else
            {
                validarFormato = true;
            }
        }
        catch (FormatException)
        {
            MensajeDeError();
        }
    } while (validarFormato == false);
    return precioProducto2;
}

static double PrecioTotal(double precioProducto2, double precioProducto1)
{
    double total;
    total  
    return total;
}




