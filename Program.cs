﻿int opcion=0;
string productos;

do
{
    Console.WriteLine("___________");
    Console.WriteLine("BIENVENIDO");
    Console.WriteLine("___________");
    Console.WriteLine("Bienvenido a la papelería CHUCHITO...");
    Console.WriteLine("¿Qué deseas realizar?");
    Console.WriteLine("Opción 1: Agregar producto.");
    Console.WriteLine("Opción 2: Comprar productos.");
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
                Console.WriteLine("___________");
                Console.WriteLine("OPCION 2");
                Console.WriteLine("___________");
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Ten un buen día");
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
    do
    {
        Console.WriteLine("");
        Console.Write("Ingresa el nombre del primer producto: ");
        string producto1 = Console.ReadLine();
        Console.Write("Ingresa el precio del primer producto: Q");
        try
        {
            double precioProducto1 = Convert.ToDouble(Console.ReadLine());
            if (precioProducto1 == 0)
            {
                Console.WriteLine("El precio no puede ser 0, intenta de nuevo");
                Console.WriteLine();
            }
        }
        catch (FormatException)
        {
            Console.Write("Ingresa el segundo producto: ");
        }
    } while (true);
}




