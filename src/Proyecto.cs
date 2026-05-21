using System;
using System.Collections.Generic;

class Program
{
    static List<decimal> listaMontos = new List<decimal>();
    static List<string> listaCategorias = new List<string>();

    static void Main(string[] args)
    {
        bool activo = true;

        do
        {
            string opcion = MenuPrincipal();

            switch (opcion)
            {
                case "1":
                    NuevoPedido();
                    break;

                case "2":
                    ReporteGeneral();
                    break;

                case "0":
                    activo = false;
                    break;

                default:
                    Console.WriteLine("La opción ingresada no existe.");
                    Esperar();
                    break;
            }

        } while (activo);
    }

    /// <summary>
    /// Muestra el menú y devuelve la opción.
    /// </summary>
    /// <returns>Opción digitada.</returns>
    static string MenuPrincipal()
    {
        Console.Clear();

        Console.WriteLine("===== CLASIFICADOR DE PEDIDOS =====");
        Console.WriteLine("1. Registrar pedido");
        Console.WriteLine("2. Mostrar reporte");
        Console.WriteLine("0. Salir");

        Console.Write("\nSeleccione una opción: ");

        return Console.ReadLine();
    }

    /// <summary>
    /// Registra un pedido nuevo.
    /// </summary>
    static void NuevoPedido()
    {
        decimal monto = PedirMonto();
        int cantidad = PedirCantidad();
        string zona = PedirZona();
        string cliente = PedirCliente();

        string categoria = DefinirCategoria(monto, cantidad, cliente);
        decimal envio = ValorEnvio(categoria, zona);

        Guardar(monto, categoria);

        Console.WriteLine("\n----- RESULTADO -----");
        Console.WriteLine($"Tipo de envío: {categoria}");
        Console.WriteLine($"Costo final: ${envio}");
        Console.WriteLine($"Pedido guardado #{listaMontos.Count}");

        Esperar();
    }

    /// <summary>
    /// Solicita monto válido.
    /// </summary>
    /// <returns>Monto correcto.</returns>
    static decimal PedirMonto()
    {
        decimal valor;

        while (true)
        {
            Console.Write("Ingrese monto del pedido: ");

            if (decimal.TryParse(Console.ReadLine(), out valor) && valor >= 0)
                return valor;

            Console.WriteLine("Monto inválido.");
        }
    }

    /// <summary>
    /// Solicita cantidad válida.
    /// </summary>
    /// <returns>Cantidad correcta.</returns>
    static int PedirCantidad()
    {
        int cantidad;

        while (true)
        {
            Console.Write("Ingrese cantidad de productos: ");

            if (int.TryParse(Console.ReadLine(), out cantidad) && cantidad > 0)
                return cantidad;

            Console.WriteLine("Cantidad inválida.");
        }
    }

    /// <summary>
    /// Solicita zona del pedido.
    /// </summary>
    /// <returns>I o E.</returns>
    static string PedirZona()
    {
        while (true)
        {
            Console.Write("Interior o Exterior (I/E): ");

            string dato = Console.ReadLine().ToUpper();

            if (dato == "I" || dato == "E")
                return dato;

            Console.WriteLine("Solo puede ingresar I o E.");
        }
    }

    /// <summary>
    /// Solicita tipo de cliente.
    /// </summary>
    /// <returns>N o R.</returns>
    static string PedirCliente()
    {
        while (true)
        {
            Console.Write("Cliente Nuevo o Recurrente (N/R): ");

            string dato = Console.ReadLine().ToUpper();

            if (dato == "N" || dato == "R")
                return dato;

            Console.WriteLine("Solo puede ingresar N o R.");
        }
    }

    /// <summary>
    /// Define categoría del pedido.
    /// </summary>
    /// <param name="monto">Monto total.</param>
    /// <param name="cantidad">Cantidad productos.</param>
    /// <param name="cliente">Tipo cliente.</param>
    /// <returns>Categoría asignada.</returns>
    static string DefinirCategoria(decimal monto, int cantidad, string cliente)
    {
        if (monto > 200000 && cliente == "R")
            return "Envío Gratis";

        if (monto > 100000 || cantidad > 10)
            return "Envío Express";

        return "Envío Estándar";
    }

    /// <summary>
    /// Calcula valor del envío.
    /// </summary>
    /// <param name="categoria">Tipo envío.</param>
    /// <param name="zona">Destino.</param>
    /// <returns>Valor total.</returns>
    static decimal ValorEnvio(string categoria, string zona)
    {
        decimal costo;

        if (categoria == "Envío Gratis")
            costo = 0;
        else if (categoria == "Envío Express")
            costo = 10000;
        else
            costo = 5000;

        if (zona == "E")
            costo += 5000;

        return costo;
    }

    /// <summary>
    /// Guarda pedido registrado.
    /// </summary>
    static void Guardar(decimal monto, string categoria)
    {
        listaMontos.Add(monto);
        listaCategorias.Add(categoria);
    }

    /// <summary>
    /// Muestra estadísticas.
    /// </summary>
    static void ReporteGeneral()
    {
        if (listaMontos.Count == 0)
        {
            Console.WriteLine("No hay pedidos registrados.");
            Esperar();
            return;
        }

        decimal suma = 0;
        decimal mayor = decimal.MinValue;
        decimal menor = decimal.MaxValue;

        int gratis = 0;
        int express = 0;
        int estandar = 0;

        foreach (decimal monto in listaMontos)
        {
            suma += monto;

            if (monto > mayor) mayor = monto;
            if (monto < menor) menor = monto;
        }

        foreach (string tipo in listaCategorias)
        {
            if (tipo == "Envío Gratis")
                gratis++;
            else if (tipo == "Envío Express")
                express++;
            else
                estandar++;
        }

        decimal promedio = suma / listaMontos.Count;

        Console.WriteLine("\n===== REPORTE =====");
        Console.WriteLine($"Pedidos registrados: {listaMontos.Count}");
        Console.WriteLine($"Promedio: {promedio:F2}");
        Console.WriteLine($"Mayor pedido: {mayor}");
        Console.WriteLine($"Menor pedido: {menor}");

        Console.WriteLine("\nTipos de envío");
        Console.WriteLine($"Gratis: {gratis}");
        Console.WriteLine($"Express: {express}");
        Console.WriteLine($"Estándar: {estandar}");

        Esperar();
    }

    static void Esperar()
    {
        Console.WriteLine("\nPresione ENTER para continuar...");
        Console.ReadLine();
    }
}
