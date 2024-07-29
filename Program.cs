int opcion=0;

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
                break;
            case 2:
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
    }
} while (opcion != 3);


static void MensajeDeError()
{
    Console.WriteLine("Error de Formato");
}




