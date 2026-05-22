CLASIFICADOR INTELIGENTE DE PEDIDOS (ENTREGA 3)
Integrantes:
-Miguel Ángel Berrio Agudelo
-Jhoser Ramírez Loaiza

Descripción

Este programa simula un sistema de gestión de pedidos para una tienda online.
Permite registrar varios pedidos durante la ejecución, clasificarlos automáticamente según ciertas condiciones y mostrar reportes estadísticos con la información guardada.
En esta entrega se refactorizó el código para organizarlo en funciones separadas, haciendo que el programa sea más claro, ordenado y fácil de mantener.
Arquitectura del programa

El sistema quedó dividido en varias funciones:

Funciones principales

-`Main()` → controla el flujo general
-`MenuPrincipal()` → muestra el menú
-`NuevoPedido()` → registra pedidos
-`ReporteGeneral()` → muestra estadísticas

Funciones de entrada y validación

-`PedirMonto()`
-`PedirCantidad()`
-`PedirZona()`
-`PedirCliente()`

Estas validan que los datos ingresados sean correctos.

Funciones de lógica

- `DefinirCategoria()`
- `ValorEnvio()`

Se encargan de calcular la categoría y el costo del envío.

Función de almacenamiento

- `Guardar()`

Guarda la información en listas.

Función auxiliar

- `Esperar()`

Pausa la consola para continuar.

Tabla de funciones

| Función | Retorno | Uso |
|---------|---------|-----|
| MenuPrincipal | string | Leer opción |
| NuevoPedido | void | Registrar pedido |
| PedirMonto | decimal | Validar monto |
| PedirCantidad | int | Validar cantidad |
| PedirZona | string | Validar zona |
| PedirCliente | string | Validar cliente |
| DefinirCategoria | string | Clasificar pedido |
| ValorEnvio | decimal | Calcular envío |
| Guardar | void | Guardar datos |
| ReporteGeneral | void | Mostrar reporte |
| Esperar | void | Pausa |

Entradas

El usuario debe ingresar:

- Monto del pedido
- Cantidad de productos
- Zona (Interior o Exterior)
- Tipo de cliente (Nuevo o Recurrente)

Procesos

El sistema realiza:

- Validación de datos
- Clasificación del pedido
- Cálculo del envío
- Guardado en memoria
- Generación de estadísticas

Salidas

El programa muestra:

- Categoría del pedido
- Costo de envío
- Reporte estadístico general

Casos de prueba

Caso 1

Entrada:

- Monto: 250000
- Cantidad: 5
- Zona: I
- Cliente: R

Salida esperada:

- Envío Gratis
- Costo: $0

Caso 2

Entrada:

- Monto: 150000
- Cantidad: 3
- Zona: E
- Cliente: N

Salida esperada:

- Envío Express
- Costo: $15000

Caso 3

Entrada:

- Monto: 50000
- Cantidad: 2
- Zona: I
- Cliente: N

Salida esperada:

- Envío Estándar
- Costo: $5000

Validaciones implementadas

El sistema controla:

- Valores negativos
- Cantidades inválidas
- Letras en valores numéricos
- Opciones incorrectas para zona
- Opciones incorrectas para cliente
- Reportes sin registros

Cómo ejecutar

Compilar:

```bash
dotnet build
```

Ejecutar:

```bash
dotnet run
```
Cambios realizados en esta entrega

Se hicieron mejoras como:

- Separar el código en funciones
- Mejor organización general
- Documentación XML
- Código más claro y mantenible
- Mejor validación de entradas
