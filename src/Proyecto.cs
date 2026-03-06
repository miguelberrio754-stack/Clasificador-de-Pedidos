using System;

class SistemaDespachos
{
    static void Main()
    {
        Console.WriteLine("==================================");
        Console.WriteLine("   CLASIFICADOR INTELIGENTE");
        Console.WriteLine("==================================");

        // Variables
        decimal montoPedido = 0;
        string ciudadDestino = "";
        string tipoCliente = "";
        int cantidadItems = 0;

        string categoriaDespacho = "";
        decimal costoEnvio = 0;

        // -----------------------------
        // Entrada de datos
        // -----------------------------

// validacion de datos ingresados por el usuario


        Console.Write("Ingrese el monto del pedido: ");
        montoPedido = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese ciudad destino (interior / exterior): ");
        ciudadDestino = Console.ReadLine().ToLower();

        Console.Write("Tipo de cliente (nuevo / recurrente): ");
        tipoCliente = Console.ReadLine().ToLower();

        Console.Write("Cantidad de items: ");
        cantidadItems = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");

        // -----------------------------
        // Clasificación del despacho
        // -----------------------------

        if (montoPedido >= 150000 && tipoCliente == "recurrente")
        {
            categoriaDespacho = "Envio Gratis";
        }
        else if (cantidadItems >= 5 || montoPedido >= 300000)
        {
            categoriaDespacho = "Envio Express";
        }
        else
        {
            categoriaDespacho = "Envio Estandar";
        }

        // -----------------------------
        // Cálculo del costo de envío
        // -----------------------------

        if (categoriaDespacho == "Envio Gratis")
        {
            costoEnvio = 0;
        }
        else if (categoriaDespacho == "Envio Express")
        {
            costoEnvio = 20000;
        }
        else
        {
            costoEnvio = 10000;
        }

        // Recargo si es exterior
        if (ciudadDestino == "exterior")
        {
            costoEnvio = costoEnvio + 15000;
        }

        // -----------------------------
        // Mostrar resultados
        // -----------------------------

        Console.WriteLine("--------- RESULTADO ---------");
        Console.WriteLine("Monto del pedido: $" + montoPedido);
        Console.WriteLine("Ciudad destino: " + ciudadDestino);
        Console.WriteLine("Tipo de cliente: " + tipoCliente);
        Console.WriteLine("Cantidad de items: " + cantidadItems);

        Console.WriteLine("");

        Console.WriteLine("Categoria de despacho: " + categoriaDespacho);
        Console.WriteLine("Costo de envio: $" + costoEnvio);

        Console.WriteLine("");
        Console.WriteLine("Gracias por usar el sistema.");

        Console.ReadLine();
    }
}