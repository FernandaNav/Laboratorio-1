using System;
using System.ComponentModel.DataAnnotations;

int opcion = 0;
double precioProducto1, precioProducto2;

do
{
    Console.Clear();
    Console.WriteLine("___________");
    Console.WriteLine("BIENVENIDO");
    Console.WriteLine("___________");
    Console.WriteLine("Bienvenido a la papelería CHUCHITO...");
    Console.WriteLine("¿Qué deseas realizar?");
    Console.WriteLine("Opción 1: Agregar producto.");
    Console.WriteLine("Opción 2: Salir.");

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
                precioProducto1 = IngresarPrecio1();
                IngresarProducto2();
                precioProducto2 = IngresarPrecio2();
                Console.Write("El total de tu compra es de: Q"+ PrecioTotal(precioProducto1, precioProducto2));
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
} while (opcion != 2);

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
    Console.WriteLine();
    Console.Write("Ingresa el nombre del segundo producto: ");
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
        Console.Write("Ingresa el precio del segundo producto: Q");
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
    total = precioProducto1 + precioProducto2;
    if(total > 20)
    {
        Console.WriteLine("Has comprado un total de más de Q20.00, te haremos un descuento del 15%");
        total = total - (total * 0.15);
    }
    return total;
}




