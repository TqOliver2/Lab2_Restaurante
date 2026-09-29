Imports System.Globalization

''' <summary>
''' Formulario principal para la gestion de pedidos y cobro del restaurante.
''' Cumple con los requisitos de entrega del Prof. Jorge Marin:
''' - Nombres descriptivos en controles y variables.
''' - Separacion logica de responsabilidades en metodos especificos.
''' - Validacion estricta de tipos de datos, campos obligatorios y rangos permitidos.
''' - Manejo estructurado de errores con Try...Catch para evitar cierres inesperados.
''' - Retroalimentacion constante en pantalla para el usuario.
''' </summary>
Public Class Form1

    ' Variable booleana de control para prevenir llamadas recursivas o eventos no deseados al limpiar selecciones
    Private estaReiniciandoCombos As Boolean = False

    ''' <summary>
    ''' Inicializa los datos del menu del restaurante al cargar el formulario.
    ''' Mantiene las tecnicas originales solicitadas: metodo Add y vectores con AddRange.
    ''' </summary>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' CARGA DE ARROCES UTILIZANDO EL METODO ADD
            cboArroces.Items.Add("ARROZ BLANCO: 1.00")
            cboArroces.Items.Add("ARROZ CON VEGETALES: 1.15")
            cboArroces.Items.Add("ARROZ CON MAIZ: 1.10")
            cboArroces.Items.Add("ARROZ CON FRIJOLES: 1.20")
            cboArroces.Items.Add("ARROZ FRITO: 1.50")

            ' CARGA DE MENESTRAS UTILIZANDO EL METODO ADD
            cboMenestras.Items.Add("POROTOS: 1.15")
            cboMenestras.Items.Add("LENTEJAS: 0.90")
            cboMenestras.Items.Add("FRIJOLES: 1.00")
            cboMenestras.Items.Add("ARVEJAS: 0.95")
            cboMenestras.Items.Add("GARBANZOS: 0.85")

            ' CARGA DE CARNES UTILIZANDO VECTORES Y EL METODO ADDRANGE
            Dim carnesDisponibles(6) As String
            carnesDisponibles(0) = "CARNES DE RES: 1.55"
            carnesDisponibles(1) = "VENADO: 2.50"
            carnesDisponibles(2) = "POLLO: 1.15"
            carnesDisponibles(3) = "PAVO: 2.15"
            carnesDisponibles(4) = "PESCADO: 2.50"
            carnesDisponibles(5) = "CAMARONES: 2.90"
            carnesDisponibles(6) = "LANGOSTA: 3.50"

            cboCarnes.Items.AddRange(carnesDisponibles)

            ' Asignar valores iniciales y fecha actual en pantalla
            txtCantidad.Text = "1"
            txtTotal.Text = "0.00"
            txtCambio.Text = "0.00"
            lblFechaOrden.Text = "Fecha: " & DateTime.Now.ToString("dd/MM/yyyy")
            lblEstadoOperacion.Text = "Sistema listo. Ingrese la cantidad y elija un plato para iniciar el pedido."

            ' Posicionar el cursor inicialmente en el primer campo de seleccion
            Me.ActiveControl = cboArroces

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al inicializar las listas del menu: " & ex.Message,
                            "Error de Inicializacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Extrae de forma segura el precio numerico ubicado despues del delimitador de dos puntos (:).
    ''' Emplea Decimal y cultura invariante para garantizar exactitud financiera.
    ''' </summary>
    Private Function ExtraerPrecioDeTexto(descripcionPlato As String) As Decimal
        If String.IsNullOrWhiteSpace(descripcionPlato) Then Return 0D

        Dim posicionDosPuntos As Integer = descripcionPlato.IndexOf(":"c)
        If posicionDosPuntos < 0 Then Return 0D

        Dim textoPrecio As String = descripcionPlato.Substring(posicionDosPuntos + 1).Trim().Replace(",", ".")
        Dim precioDecimal As Decimal = 0D

        If Decimal.TryParse(textoPrecio, NumberStyles.Any, CultureInfo.InvariantCulture, precioDecimal) Then
            Return precioDecimal
        End If

        Return 0D
    End Function

    ''' <summary>
    ''' Recalcula el importe total acumulado sumando todos los platos presentes en la lista del pedido.
    ''' </summary>
    Private Sub RecalcularTotalPedido()
        Try
            Dim totalCalculado As Decimal = 0D

            For Each elemento In lstPedidoMenu.Items
                totalCalculado += ExtraerPrecioDeTexto(elemento.ToString())
            Next

            txtTotal.Text = totalCalculado.ToString("0.00", CultureInfo.InvariantCulture)

        Catch ex As Exception
            lblEstadoOperacion.Text = "Error al recalcular el total de la orden: " & ex.Message
        End Try
    End Sub

    ''' <summary>
    ''' Valida los datos y agrega el plato seleccionado a la lista del pedido.
    ''' Verifica campo no vacio, tipo de dato numerico y rango permitido (1 a 99 porciones).
    ''' </summary>
    Private Sub AgregarPlatoAlPedido(comboSeleccionado As ComboBox)
        If estaReiniciandoCombos OrElse comboSeleccionado.SelectedIndex = -1 Then Return

        Try
            ' 1. VALIDACION: Campo de cantidad no vacio
            Dim textoCantidad As String = txtCantidad.Text.Trim()
            If String.IsNullOrWhiteSpace(textoCantidad) Then
                MessageBox.Show("El campo de cantidad es obligatorio. Por favor ingrese un valor numerico.",
                                "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                RestablecerSeleccionCombo(comboSeleccionado)
                txtCantidad.Focus()
                Return
            End If

            ' 2. VALIDACION: Tipo de dato numerico entero
            Dim cantidadPorciones As Integer
            If Not Integer.TryParse(textoCantidad, cantidadPorciones) Then
                MessageBox.Show("El valor de la cantidad debe ser un numero entero valido (sin letras ni simbolos).",
                                "Tipo de Dato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                RestablecerSeleccionCombo(comboSeleccionado)
                txtCantidad.SelectAll()
                txtCantidad.Focus()
                Return
            End If

            ' 3. VALIDACION: Rango permitido (1 a 99 porciones)
            If cantidadPorciones < 1 OrElse cantidadPorciones > 99 Then
                MessageBox.Show("La cantidad de porciones permitida debe estar en el rango de 1 a 99.",
                                "Rango Fuera de Limite", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                RestablecerSeleccionCombo(comboSeleccionado)
                txtCantidad.SelectAll()
                txtCantidad.Focus()
                Return
            End If

            ' 4. VALIDACION: Extraccion de precio valida
            Dim precioUnitario As Decimal = ExtraerPrecioDeTexto(comboSeleccionado.Text)
            If precioUnitario <= 0D Then
                MessageBox.Show("No se pudo obtener el precio del plato seleccionado. Verifique la seleccion.",
                                "Precio No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                RestablecerSeleccionCombo(comboSeleccionado)
                Return
            End If

            ' 5. PROCESAMIENTO Y ADICION
            Dim subtotal As Decimal = precioUnitario * cantidadPorciones
            Dim lineaDetalle As String

            If cantidadPorciones = 1 Then
                lineaDetalle = comboSeleccionado.Text
            Else
                Dim nombrePlato As String = comboSeleccionado.Text.Substring(0, comboSeleccionado.Text.IndexOf(":"c)).Trim()
                lineaDetalle = nombrePlato & " (x" & cantidadPorciones.ToString() & "): " & subtotal.ToString("0.00", CultureInfo.InvariantCulture)
            End If

            lstPedidoMenu.Items.Add(lineaDetalle)
            RecalcularTotalPedido()

            ' Retroalimentacion clara al usuario
            lblEstadoOperacion.Text = "Agregado: " & lineaDetalle & " • Total acumulado: $" & txtTotal.Text

            ' Deseleccionar el combo de forma segura
            RestablecerSeleccionCombo(comboSeleccionado)

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error inesperado al agregar el plato: " & ex.Message,
                            "Error en Operacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RestablecerSeleccionCombo(comboSeleccionado)
        End Try
    End Sub

    ''' <summary>
    ''' Deselecciona un ComboBox protegiendo el flujo contra eventos recursivos.
    ''' </summary>
    Private Sub RestablecerSeleccionCombo(combo As ComboBox)
        estaReiniciandoCombos = True
        combo.SelectedIndex = -1
        estaReiniciandoCombos = False
    End Sub

    ' Manejadores de eventos de seleccion de platos
    Private Sub cboArroces_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArroces.SelectedIndexChanged
        AgregarPlatoAlPedido(cboArroces)
    End Sub

    Private Sub cboMenestras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMenestras.SelectedIndexChanged
        AgregarPlatoAlPedido(cboMenestras)
    End Sub

    Private Sub cboCarnes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCarnes.SelectedIndexChanged
        AgregarPlatoAlPedido(cboCarnes)
    End Sub

    ''' <summary>
    ''' Permite eliminar un plato al hacer doble clic sobre su entrada en la lista.
    ''' </summary>
    Private Sub lstPedidoMenu_DoubleClick(sender As Object, e As EventArgs) Handles lstPedidoMenu.DoubleClick
        EliminarPlatoSeleccionado()
    End Sub

    ''' <summary>
    ''' Boton visible para eliminar el plato seleccionado de la lista.
    ''' </summary>
    Private Sub btnQuitarPlato_Click(sender As Object, e As EventArgs) Handles btnQuitarPlato.Click
        EliminarPlatoSeleccionado()
    End Sub

    ''' <summary>
    ''' Procedimiento centralizado para eliminar el plato seleccionado con comprobacion previa.
    ''' </summary>
    Private Sub EliminarPlatoSeleccionado()
        Try
            ' VALIDACION: Verificar si el usuario ha seleccionado un elemento
            If lstPedidoMenu.SelectedIndex = -1 Then
                MessageBox.Show("Por favor, seleccione en la lista el plato que desea remover.",
                                "Aviso de Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim nombrePlatoEliminado As String = lstPedidoMenu.SelectedItem.ToString()
            lstPedidoMenu.Items.RemoveAt(lstPedidoMenu.SelectedIndex)

            RecalcularTotalPedido()

            ' Si no quedan elementos, reiniciar tambien los campos de liquidacion
            If lstPedidoMenu.Items.Count = 0 Then
                txtPagaCon.Clear()
                txtCambio.Text = "0.00"
                lblEstadoOperacion.Text = "Se removieron todos los platos. El pedido esta vacio."
            Else
                lblEstadoOperacion.Text = "Se elimino de la orden: " & nombrePlatoEliminado
            End If

        Catch ex As Exception
            MessageBox.Show("No se pudo remover el elemento seleccionado: " & ex.Message,
                            "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Limpia todo el pedido previa solicitud de confirmacion del usuario para proteger la informacion.
    ''' </summary>
    Private Sub btnLimpiarPedido_Click(sender As Object, e As EventArgs) Handles btnLimpiarPedido.Click
        Try
            If lstPedidoMenu.Items.Count > 0 Then
                Dim respuesta = MessageBox.Show("¿Esta seguro que desea cancelar y limpiar todo el pedido actual?",
                                                "Confirmacion de Limpieza", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If respuesta <> DialogResult.Yes Then Return
            End If

            RestablecerSeleccionCombo(cboArroces)
            RestablecerSeleccionCombo(cboMenestras)
            RestablecerSeleccionCombo(cboCarnes)

            lstPedidoMenu.Items.Clear()
            txtTotal.Text = "0.00"
            txtPagaCon.Clear()
            txtCambio.Text = "0.00"
            txtCantidad.Text = "1"

            lblEstadoOperacion.Text = "El pedido ha sido cancelado y limpiado completamente."
            cboArroces.Focus()

        Catch ex As Exception
            MessageBox.Show("Ocurrio un inconveniente al limpiar el formulario: " & ex.Message,
                            "Error al Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Valida el cobro, comprueba existencia de platos, monto recibido numerico y suficiente,
    ''' y calcula el cambio correspondiente.
    ''' </summary>
    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        Try
            ' 1. VALIDACION: Comprobar que existan platos en el pedido
            If lstPedidoMenu.Items.Count = 0 Then
                MessageBox.Show("El pedido esta vacio. Debe seleccionar al menos un plato antes de cobrar.",
                                "Pedido Vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cboArroces.Focus()
                Return
            End If

            ' 2. VALIDACION: Campo de pago no vacio
            Dim textoPago As String = txtPagaCon.Text.Trim().Replace(",", ".")
            If String.IsNullOrWhiteSpace(textoPago) Then
                MessageBox.Show("Debe ingresar el monto en efectivo con el que paga el cliente.",
                                "Monto Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPagaCon.Focus()
                Return
            End If

            ' 3. VALIDACION: Tipo numerico positivo
            Dim montoPagoCliente As Decimal
            If Not Decimal.TryParse(textoPago, NumberStyles.Any, CultureInfo.InvariantCulture, montoPagoCliente) OrElse montoPagoCliente <= 0D Then
                MessageBox.Show("El monto ingresado es invalido. Ingrese un valor numerico positivo (ejemplo: 5.00 o 10.50).",
                                "Formato de Pago Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPagaCon.SelectAll()
                txtPagaCon.Focus()
                Return
            End If

            ' 4. VALIDACION: Monto suficiente para cubrir el total
            Dim montoTotalPagar As Decimal = 0D
            Decimal.TryParse(txtTotal.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, montoTotalPagar)

            If montoPagoCliente < montoTotalPagar Then
                Dim montoFaltante As Decimal = montoTotalPagar - montoPagoCliente
                MessageBox.Show("El monto entregado ($" & montoPagoCliente.ToString("0.00", CultureInfo.InvariantCulture) & ") es insuficiente." & vbCrLf &
                                "Total de la cuenta: $" & montoTotalPagar.ToString("0.00", CultureInfo.InvariantCulture) & vbCrLf &
                                "Monto faltante:    $" & montoFaltante.ToString("0.00", CultureInfo.InvariantCulture),
                                "Pago Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPagaCon.SelectAll()
                txtPagaCon.Focus()
                Return
            End If

            ' 5. CALCULO DEL CAMBIO Y CONFIRMACION AL CLIENTE
            Dim cambioDevuelto As Decimal = montoPagoCliente - montoTotalPagar
            txtCambio.Text = cambioDevuelto.ToString("0.00", CultureInfo.InvariantCulture)

            lblEstadoOperacion.Text = "Cobro completado exitosamente. Cambio entregado: $" & cambioDevuelto.ToString("0.00", CultureInfo.InvariantCulture)

            MessageBox.Show("Transaccion registrada exitosamente!" & vbCrLf & vbCrLf &
                            "• Total facturado:   $" & montoTotalPagar.ToString("0.00", CultureInfo.InvariantCulture) & vbCrLf &
                            "• Efectivo recibido: $" & montoPagoCliente.ToString("0.00", CultureInfo.InvariantCulture) & vbCrLf &
                            "• Cambio a devolver: $" & cambioDevuelto.ToString("0.00", CultureInfo.InvariantCulture),
                            "Cobro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error inesperado al procesar el cobro: " & ex.Message,
                            "Error de Cobro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Cierre ordenado de la aplicacion previa confirmacion del usuario.
    ''' </summary>
    Private Sub btnSalirSistema_Click(sender As Object, e As EventArgs) Handles btnSalirSistema.Click
        Dim respuesta = MessageBox.Show("¿Esta seguro que desea salir del sistema de restaurante?",
                                        "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' Filtro de pulsacion de teclas para Cantidad: Solo permite numeros y teclas de control.
    ''' </summary>
    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Filtro de pulsacion de teclas para Pago: Solo permite numeros, un separador decimal y teclas de control.
    ''' </summary>
    Private Sub txtPagaCon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPagaCon.KeyPress
        Dim esControl As Boolean = Char.IsControl(e.KeyChar)
        Dim esDigito As Boolean = Char.IsDigit(e.KeyChar)
        Dim esSeparador As Boolean = (e.KeyChar = "."c OrElse e.KeyChar = ","c)

        If esSeparador Then
            If txtPagaCon.Text.Contains("."c) OrElse txtPagaCon.Text.Contains(","c) Then
                e.Handled = True
            End If
        ElseIf Not esDigito AndAlso Not esControl Then
            e.Handled = True
        End If
    End Sub

End Class
