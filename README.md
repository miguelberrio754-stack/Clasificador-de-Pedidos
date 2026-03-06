**Clasificador** Inteligente de Pedidos



**Equipo:** Miguel Ángel Berrio Agudelo, Jhoser Ramírez Loaiza



**Descripción del problema**



Este programa simula un pequeño sistema para una tienda online que clasifica los pedidos según ciertas condiciones, el usuario ingresa el monto del pedido, la ciudad de destino, el tipo de cliente y la cantidad de artículos. Con estos datos el sistema decide qué tipo de despacho se debe usar (gratis, express o estándar) y calcula el costo de envío correspondiente. Nuestro objetivo es practicar el uso de variables, condicionales y entrada de datos en C#.



**IPO (Entradas – Proceso – Salidas)**



**Entradas**



montoPedido

ciudadDestino

tipoCliente

cantidadItems



**Proceso**



Evaluar condiciones con if, else if y operadores lógicos

Verificar si la ciudad es interior o exterior

Determinar si aplica envío gratis



**Salidas**



Categoría de despacho

Costo de envío

Mensaje con resultado

Ejemplo

 

**Entrada**



montoPedido=160000

ciudadDestino=interior

tipoCliente=recurrente

cantidadItems = 3



**Salida**



Categoría:Envío Gratis

Costo de envío: $0



**Variables**



**Variable	Tipo	Propósito**



montoPedido	decimal	Guardar el valor total del pedido



ciudadDestino	string	Indicar si el envío es interior o exterior



tipoCliente	string	Saber si el cliente es nuevo o recurrente



cantidadItems	int	Número de artículos del pedido



categoriaDespacho	string	Guardar el tipo de envío asignado



costoEnvio	decimal	Guardar el valor final del envío





**Casos de prueba**



**Caso normal**



**Entrada**



montoPedido:160000

ciudadDestino: Interior

tipoCliente: recurrente

cantidadItems: 3



**Resultado esperado**

Categoría: Envío Gratis

Costo de envío: $0



**Caso borde**



**Entrada**



montoPedido: 50000

ciudadDestino: exterior

tipoCliente: nuevo

cantidadItems: 1



**Resultado esperado**

Categoría: Envío Estándar

Costo de envío: $25000

(10000 del envío estándar + 15000 por ser exterior)



**Instrucciones para compilar y ejecutar**



1.Tener instalado .NET SDK.

2.Clonar o descargar el repositorio.

3\. Abrir una terminal en la carpeta del proyecto.

4\. Compilar:

5\. dotnet build

6\. Ejecutar:

dotnet run

Ingresar los datos que el programa solicita en la consola.



Proyecto desarrollado para práctica de lógica en C#.

