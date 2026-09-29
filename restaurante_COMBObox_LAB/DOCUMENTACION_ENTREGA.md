# DOCUMENTACIÓN DE ENTREGA Y MANUAL DE SUSTENTACIÓN
## Laboratorio N° 2: Sistema de Restaurante y Gestión de Pedidos
**Asignatura:** Desarrollo de Software VIII  
**Docente:** Prof. Jorge Marín  
**Entorno de Desarrollo:** Visual Studio 2022 / .NET 9.0 Windows Forms  
**Lenguaje:** Visual Basic (.NET)  

---

## 1. DESCRIPCIÓN DEL SISTEMA

El sistema corresponde a una aplicación de escritorio diseñada para la toma de pedidos y facturación rápida en un restaurante criollo gourmet. Permite al cajero o despachador seleccionar platos de diferentes categorías (**Arroces**, **Menestras del Día** y **Carnes y Proteínas**), definir la cantidad de porciones deseadas, acumular los pedidos en una comanda en tiempo real, remover ítems por doble clic o botón asistido, y realizar la liquidación y cobro calculando el cambio correspondiente.

La aplicación incorpora una paleta de colores moderna inspirada en gastronomía:
- **Rojo Principal (`#CD0508`)**: Encabezado principal, botón destacado de cobro y total a pagar.
- **Marrón / Naranja (`#B05328`)**: Títulos de secciones, detalles de bordes y botón de salida.
- **Amarillo / Dorado (`#FEAE0D`)**: Acento decorativo superior, botones de limpieza y remoción de platos.
- **Fondo Claro (`#F5F5F5`)**: Fondo general con tarjetas blancas (`#FFFFFF`) para organización visual.

---

## 2. CUMPLIMIENTO DE LOS REQUISITOS DE ENTREGA

### 2.1. Interfaz y Diseño de la Aplicación
- **Distribución ordenada:** Se diseñó una estructura en 3 secciones lógicas numeradas: *1. Selección del Menú*, *2. Detalle del Pedido*, y *3. Liquidación y Pago*.
- **Nombres descriptivos en controles:** Se eliminaron nombres genéricos (`Label1`, `GroupBox1`, etc.). Cada control cuenta con un prefijo estándar y nombre claro (`cboArroces`, `cboMenestras`, `cboCarnes`, `txtCantidad`, `lstPedidoMenu`, `btnQuitarPlato`, `btnLimpiarPedido`, `txtTotal`, `txtPagaCon`, `txtCambio`, `btnCobrar`, `btnSalirSistema`, `lblEstadoOperacion`, `lblFechaOrden`).
- **Coherencia visual:** Tipografía estandarizada en `Segoe UI`, tamaños jerarquizados y bordes planos `Flat` en botones.
- **Tamaño de ventana adecuado:** Tamaño fijo (940 x 608 px) centrado en pantalla (`StartPosition = CenterScreen`), impidiendo deformaciones.

### 2.2. Código Fuente y Buenas Prácticas
- **Nombres descriptivos de variables:** Se sustituyeron nombres abreviados o genéricos por identificadores claros como `cantidadPorciones`, `precioUnitario`, `subtotal`, `lineaDetalle`, `montoPagoCliente`, `montoTotalPagar`, `cambioDevuelto`, `carnesDisponibles`.
- **Tipos de datos exactos:** Se implementó `Decimal` para todos los cálculos monetarios en sustitución de `Single`/`Double` para evitar discrepancias de redondeo y punto flotante.
- **Modularidad y DRY (Don't Repeat Yourself):** La lógica de adición se centralizó en `AgregarPlatoAlPedido()`, el recálculo en `RecalcularTotalPedido()`, y la extracción en `ExtraerPrecioDeTexto()`.
- **Cero código muerto:** No existen bloques comentados innecesarios ni variables en desuso.

### 2.3. Validación de Datos
- **Campos obligatorios:** La cantidad y el monto de pago no permiten valores en blanco.
- **Tipo de dato correcto:** `txtCantidad` valida números enteros y `txtPagaCon` valida números decimales, bloqueando pulsaciones no válidas mediante `KeyPress` y comprobando con `Integer.TryParse` / `Decimal.TryParse`.
- **Comprobación de rangos:**
  - Cantidad restringida al rango de **1 a 99 porciones**.
  - Monto de pago validado para que sea mayor o igual al total facturado.
- **Corrección sin cierre:** Ante un dato erróneo, la aplicación emite una alerta comprensible, resalta el campo (`SelectAll()`) y coloca el foco en él sin interrumpir la ejecución.

### 2.4. Manejo de Errores y Excepciones
- Todos los métodos críticos están encapsulados en bloques `Try...Catch Exception`.
- Ante cualquier anomalía, el usuario recibe un mensaje comprensible con recomendaciones sobre qué corregir, evitando caídas inesperadas de la aplicación.

### 2.5. Usabilidad y Navegación
- **Orden de tabulación lógico (`TabIndex`):** `cboArroces (0)` -> `cboMenestras (1)` -> `cboCarnes (2)` -> `txtCantidad (3)` -> `lstPedidoMenu (4)` -> `btnQuitarPlato (5)` -> `txtPagaCon (6)` -> `btnCobrar (7)` -> `btnLimpiarPedido (8)` -> `btnSalirSistema (9)`.
- **Foco inicial:** Al iniciar el sistema, el cursor se posiciona automáticamente en `cboArroces`.
- **Retroalimentación en tiempo real:** La barra inferior `lblEstadoOperacion` reporta cada acción ejecutada (ítem agregado con su total acumulado, ítem removido, comanda limpiada o cobro exitoso).
- **Confirmación de operaciones críticas:** Tanto limpiar la orden como salir del sistema solicitan confirmación previa mediante cuadro de diálogo.

---

## 3. MATRIZ DE PRUEBAS Y RESULTADOS

| N° | Escenario de Prueba | Entrada Ingresada | Resultado Esperado | Resultado Obtenido | Estado |
|---|---|---|---|---|:---:|
| 1 | Campo Cantidad vacío | `""` al seleccionar plato | Bloquear adición y solicitar cantidad | Muestra advertencia "El campo de cantidad es obligatorio" y enfoca campo | **APROBADO** |
| 2 | Cantidad no numérica | Letras o símbolos en `txtCantidad` | Teclas bloqueadas | El evento `KeyPress` impide teclear caracteres no numéricos | **APROBADO** |
| 3 | Cantidad fuera de rango | `0` o `120` | Alerta de límite 1 a 99 | Muestra "La cantidad de porciones permitida debe estar en el rango de 1 a 99" | **APROBADO** |
| 4 | Adición válida múltiple | Cantidad: `2`, Plato: "POLLO: 1.15" | Agregar "POLLO (x2): 2.30" y sumar $2.30 | Se agrega a la lista y el Total sube a $2.30 | **APROBADO** |
| 5 | Eliminación por doble clic | Doble clic sobre ítem | Remover plato y descontar su importe | Remueve el elemento exacto y recalcula el Total | **APROBADO** |
| 6 | Cobro con pedido vacío | Clic en Cobrar sin platos | Alerta de pedido vacío | Alerta "El pedido está vacío. Debe seleccionar al menos un plato" | **APROBADO** |
| 7 | Pago insuficiente | Total: $5.00, Paga con: $3.00 | Alerta con monto faltante exacto | Muestra "Monto insuficiente. Faltan: $2.00" y no procesa cobro | **APROBADO** |
| 8 | Pago exacto o con cambio | Total: $3.45, Paga con: $5.00 | Cambio: $1.55 y confirmación | Muestra cambio $1.55 en verde y cuadro de transacción exitosa | **APROBADO** |
| 9 | Limpieza con confirmación | Clic en "Limpiar Pedido" | Preguntar confirmación Yes/No | Si responde Sí, reinicia lista, total y combos a -1 limpiamente | **APROBADO** |
| 10| Salida del sistema | Clic en "Salir" | Diálogo de confirmación | Si confirma, ejecuta `Me.Close()` liberando recursos | **APROBADO** |

---

## 4. GUÍA PARA LA SUSTENTACIÓN CON EL PROFESOR

Si el docente Jorge Marín solicita explicar el código o realizar modificaciones en vivo, tome en cuenta los siguientes puntos clave:

### ¿Dónde se cargan los productos?
En el evento `Form1_Load`:
- Las **Menestras** y **Arroces** se cargan mediante el método `.Items.Add("NOMBRE: PRECIO")`.
- Las **Carnes** se cargan creando un vector (`Dim carnesDisponibles(6) As String`) y asignándolo al ComboBox mediante `.Items.AddRange(carnesDisponibles)`.

### ¿Cómo se extrae el precio de la cadena de texto?
En la función privada `ExtraerPrecioDeTexto(descripcionPlato As String) As Decimal`:
1. Busca la posición del caracter dos puntos `:` con `IndexOf(":"c)`.
2. Corta la subcadena posterior con `Substring(posicion + 1)`.
3. Convierte el texto numérico a `Decimal` usando `Decimal.TryParse` con `CultureInfo.InvariantCulture` para que funcione igual sin importar si la computadora usa coma o punto decimal.

### ¿Por qué se utiliza `Decimal` en lugar de `Single` o `Double`?
`Single` y `Double` son tipos de coma flotante binaria basados en el estándar IEEE 754, lo que provoca pequeñas imprecisiones acumulativas en operaciones monetarias (por ejemplo, `1.15 + 1.15` podría dar `2.29999995`). `Decimal` utiliza base 10 con 128 bits de precisión exacta, siendo el estándar profesional para finanzas y contabilidad.

### ¿Cómo evitar que `SelectedIndexChanged` se dispare al limpiar?
Se utiliza la bandera booleana privada `estaReiniciandoCombos`. Antes de cambiar `cbo.SelectedIndex = -1`, se coloca en `True` y luego en `False`. En el manejador de eventos se valida:
```vb
If estaReiniciandoCombos OrElse comboSeleccionado.SelectedIndex = -1 Then Return
```
Esto evita que se añadan líneas vacías o se generen errores al limpiar el formulario.

### Posibles Modificaciones Menores en la Evaluación:
1. **Agregar un nuevo plato:** Basta con añadir una línea en `Form1_Load`:
   ```vb
   cboArroces.Items.Add("ARROZ CON POLLO: 2.25")
   ```
2. **Modificar el límite máximo de porciones:** En `AgregarPlatoAlPedido`:
   Cambiar `If cantidadPorciones < 1 OrElse cantidadPorciones > 99 Then` al nuevo rango deseado.
3. **Calcular impuesto (ITBMS 7%):** Si se solicita desglosar subtotal e impuesto antes del total:
   ```vb
   Dim subtotalNeto As Decimal = totalCalculado / 1.07D
   Dim itbms As Decimal = totalCalculado - subtotalNeto
   ```

---

## 5. INSTRUCCIONES DE EJECUCIÓN

1. **Desde Visual Studio 2022:**
   - Abrir el archivo de solución `restaurante_COMBObox_LAB.sln`.
   - Presionar `F5` o el botón verde **Iniciar Depuración** (`Debug` -> `net9.0-windows`).
2. **Desde la Consola de Comandos (CLI .NET):**
   ```bash
   cd "restaurante_COMBObox_LAB"
   dotnet run
   ```
