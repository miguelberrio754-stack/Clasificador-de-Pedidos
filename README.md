CLASIFICADOR INTELIGENTE DE PEDIDOS (ENTREGA 2)

Miguel Ángel Berrio Agudelo
Jhoser Ramírez Loaiza

DESCRIPCIÓN DEL PROBLEMA
Este programa simula un sistema de gestión de pedidos para una tienda online. A diferencia de la versión anterior (Entrega 1), ahora el sistema permite registrar múltiples pedidos en una misma ejecución y generar reportes estadísticos sobre todos los datos ingresados.
El usuario puede ingresar información como el monto del pedido, ubicación del envío, tipo de cliente y cantidad de artículos. El sistema clasifica automáticamente el tipo de despacho (Gratis, Express o Estándar), calcula el costo de envío y almacena cada registro en memoria.
Además, el sistema incluye un menú interactivo que permite registrar nuevos pedidos o visualizar estadísticas generales.
Evolución del sistema

 IPO 
-Entradas
montoPedido
ubicacion (Interior / Exterior)
tipoCliente (Nuevo / Recurrente)
cantidadItems
-Proceso
Validación de datos con TryParse
Evaluación de condiciones con if y operadores lógicos
Clasificación del tipo de envío
Cálculo del costo de envío
Almacenamiento en listas
Generación de estadísticas mediante ciclos
-Salidas
Categoría de despacho
Costo de envío
Reporte estadístico:
Total de pedidos
Promedio
Máximo
Mínimo
Cantidad por tipo de envío

 Estructura del sistema
 Capa de control
Menú interactivo con do-while
Uso de switch para gestionar opciones
Capa de datos
List<decimal> para montos
List<string> para categorías

 Capa de lógica
Validación de entradas
Clasificación de pedidos
Cálculo de métricas

 Ejemplo de uso
Registro de pedido
Entrada:
montoPedido = 160000
ubicación = Interior
tipoCliente = Recurrente
cantidadItems = 3
Salida:
Categoría: Envío Gratis
Costo de envío: $0

Reporte estadístico (ejemplo)
Total pedidos: 3
Promedio: 120000
Máximo: 200000
Mínimo: 50000
Tipos de envío:
Gratis: 1
Express: 1
Estándar: 1

Variables principales
Variable	Tipo	Propósito
montos	List	Almacenar montos de pedidos
categorias	List	Guardar tipo de envío
montoPedido	decimal	Valor del pedido
cantidadItems	int	Cantidad de artículos
ubicacion	string	Interior o exterior
tipoCliente	string	Nuevo o recurrente

 Validaciones implementadas
Uso de TryParse para evitar errores de entrada
Restricción de valores negativos
Validación de opciones (I/E, N/R)
Prevención de división por cero en reportes

 Casos de prueba
 Caso normal
Entrada:
montoPedido: 160000
ubicación: Interior
tipoCliente: Recurrente
cantidadItems: 3
Resultado esperado:
Categoría: Envío Gratis
Costo: $0

 Caso borde
Entrada:
montoPedido: 50000
ubicación: Exterior
tipoCliente: Nuevo
cantidadItems: 1
Resultado esperado:
Categoría: Envío Estándar
Costo: $10000 (5000 base + 5000 exterior)

 Instrucciones para compilar y ejecutar
Tener instalado .NET SDK
Clonar o descargar el repositorio
Abrir una terminal en la carpeta del proyecto
Compilar:
dotnet build
Ejecutar:
dotnet run
Seguir las instrucciones en consola

