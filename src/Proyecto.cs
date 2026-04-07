using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<decimal> montos = new List<decimal>();
        List<string> categorias = new List<string>();

        bool sistemaActivo = true;

        do
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE GESTIÓN DE PEDIDOS ===");
            Console.WriteLine("1. Registrar nuevo pedido");
            Console.WriteLine("2. Ver reporte estadístico");
            Console.WriteLine("0. Salir");
            Console.Write("\nOpción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    // REGISTRO (FASE DE CARGA) 

                    decimal montoPedido;
                    while (true)
                    {
                        Console.Write("Ingrese el monto del pedido: ");
                        string entradaMonto = Console.ReadLine();

                        if (decimal.TryParse(entradaMonto, out montoPedido))
                        {
                            if (montoPedido < 0)
                            {
                                Console.WriteLine("El monto no puede ser negativo.");
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Solo números.");
                        }
                    }

                    int cantidadItems;
                    while (true)
                    {
                        Console.Write("Ingrese la cantidad de ítems: ");
                        string entradaItems = Console.ReadLine();

                        if (int.TryParse(entradaItems, out cantidadItems))
                        {
                            if (cantidadItems <= 0)
                            {
                                Console.WriteLine("Debe ser mayor a 0.");
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                    }

                    string ubicacion;
                    while (true)
                    {
                        Console.Write("¿Es envío interior o exterior? (I/E): ");
                        ubicacion = Console.ReadLine().ToUpper();

                        if (ubicacion == "I" || ubicacion == "E")
                            break;

                        Console.WriteLine("Ingrese solo I o E.");
                    }

                    string tipoCliente;
                    while (true)
                    {
                        Console.Write("Tipo de cliente (N = Nuevo / R = Recurrente): ");
                        tipoCliente = Console.ReadLine().ToUpper();

                        if (tipoCliente == "N" || tipoCliente == "R")
                            break;

                        Console.WriteLine("Ingrese solo N o R.");
                    }

                    string categoria;
                    decimal costoEnvio = 0;

                    if (montoPedido > 200000 && tipoCliente == "R")
                    {
                        categoria = "Envío Gratis";
                        costoEnvio = 0;
                    }
                    else if (montoPedido > 100000 || cantidadItems > 10)
                    {
                        categoria = "Envío Express";
                        costoEnvio = 10000;
                    }
                    else
                    {
                        categoria = "Envío Estándar";
                        costoEnvio = 5000;
                    }

                    if (ubicacion == "E")
                    {
                        costoEnvio += 5000;
                    }

                    //  GUARDADO 
                    montos.Add(montoPedido);
                    categorias.Add(categoria);

                    Console.WriteLine("\n--- RESULTADO ---");
                    Console.WriteLine($"Categoría: {categoria}");
                    Console.WriteLine($"Costo de envío: ${costoEnvio}");
                    Console.WriteLine($"Registro guardado #{montos.Count}");

                    Console.WriteLine("\nPresione Enter para continuar...");
                    Console.ReadLine();
                    break;

                case "2":
                    // REPORTES (FASE DE PROCESAMIENTO) 

                    if (montos.Count == 0)
                    {
                        Console.WriteLine("No hay registros.");
                    }
                    else
                    {
                        decimal suma = 0;
                        decimal maximo = decimal.MinValue;
                        decimal minimo = decimal.MaxValue;

                        int gratis = 0;
                        int express = 0;
                        int estandar = 0;

                        for (int i = 0; i < montos.Count; i++)
                        {
                            decimal val = montos[i];
                            suma += val;

                            if (val > maximo) maximo = val;
                            if (val < minimo) minimo = val;

                            if (categorias[i] == "Envío Gratis") gratis++;
                            if (categorias[i] == "Envío Express") express++;
                            if (categorias[i] == "Envío Estándar") estandar++;
                        }

                        decimal promedio = suma / montos.Count;

                        Console.WriteLine("\n=== REPORTE ===");
                        Console.WriteLine($"Total pedidos: {montos.Count}");
                        Console.WriteLine($"Promedio monto: {promedio:F2}");
                        Console.WriteLine($"Máximo: {maximo}");
                        Console.WriteLine($"Mínimo: {minimo}");

                        Console.WriteLine("\n--- Tipos de envío ---");
                        Console.WriteLine($"Gratis: {gratis}");
                        Console.WriteLine($"Express: {express}");
                        Console.WriteLine($"Estándar: {estandar}");
                    }

                    Console.WriteLine("\nPresione Enter para continuar...");
                    Console.ReadLine();
                    break;

                case "0":
                    sistemaActivo = false;
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    Console.ReadLine();
                    break;
            }

        } while (sistemaActivo);
    }
}
