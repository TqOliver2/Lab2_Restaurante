<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlEncabezado = New Panel()
        lblFechaOrden = New Label()
        lblSubtituloRestaurante = New Label()
        lblTituloRestaurante = New Label()
        pnlBordeDorado = New Panel()
        grpSeleccionMenu = New GroupBox()
        lblInstruccionesCantidad = New Label()
        txtCantidad = New TextBox()
        lblCantidadPorciones = New Label()
        lblCarnes = New Label()
        lblMenestras = New Label()
        cboCarnes = New ComboBox()
        lblArroces = New Label()
        cboArroces = New ComboBox()
        cboMenestras = New ComboBox()
        grpDetallePedido = New GroupBox()
        btnQuitarPlato = New Button()
        lblInstruccionesLista = New Label()
        lstPedidoMenu = New ListBox()
        lblPlatosAgregados = New Label()
        btnLimpiarPedido = New Button()
        btnSalirSistema = New Button()
        grpLiquidacionPago = New GroupBox()
        btnCobrar = New Button()
        txtCambio = New TextBox()
        lblMontoCambio = New Label()
        txtPagaCon = New TextBox()
        lblMontoPago = New Label()
        txtTotal = New TextBox()
        lblTotalPagar = New Label()
        lblPiePagina = New Label()
        lblEstadoOperacion = New Label()
        pnlEncabezado.SuspendLayout()
        grpSeleccionMenu.SuspendLayout()
        grpDetallePedido.SuspendLayout()
        grpLiquidacionPago.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlEncabezado
        ' 
        pnlEncabezado.BackColor = Color.FromArgb(CByte(205), CByte(5), CByte(8))
        pnlEncabezado.Controls.Add(lblFechaOrden)
        pnlEncabezado.Controls.Add(lblSubtituloRestaurante)
        pnlEncabezado.Controls.Add(lblTituloRestaurante)
        pnlEncabezado.Dock = DockStyle.Top
        pnlEncabezado.Location = New Point(0, 0)
        pnlEncabezado.Name = "pnlEncabezado"
        pnlEncabezado.Size = New Size(940, 75)
        pnlEncabezado.TabIndex = 10
        ' 
        ' lblFechaOrden
        ' 
        lblFechaOrden.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFechaOrden.ForeColor = Color.White
        lblFechaOrden.Location = New Point(730, 43)
        lblFechaOrden.Name = "lblFechaOrden"
        lblFechaOrden.Size = New Size(185, 20)
        lblFechaOrden.TabIndex = 2
        lblFechaOrden.Text = "Fecha: 29/09/2026"
        lblFechaOrden.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblSubtituloRestaurante
        ' 
        lblSubtituloRestaurante.AutoSize = True
        lblSubtituloRestaurante.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubtituloRestaurante.ForeColor = Color.FromArgb(CByte(254), CByte(174), CByte(13))
        lblSubtituloRestaurante.Location = New Point(25, 45)
        lblSubtituloRestaurante.Name = "lblSubtituloRestaurante"
        lblSubtituloRestaurante.Size = New Size(305, 17)
        lblSubtituloRestaurante.TabIndex = 1
        lblSubtituloRestaurante.Text = "Sistema de Gestion de Pedidos y Menu del Restaurante"
        ' 
        ' lblTituloRestaurante
        ' 
        lblTituloRestaurante.AutoSize = True
        lblTituloRestaurante.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTituloRestaurante.ForeColor = Color.White
        lblTituloRestaurante.Location = New Point(22, 11)
        lblTituloRestaurante.Name = "lblTituloRestaurante"
        lblTituloRestaurante.Size = New Size(405, 32)
        lblTituloRestaurante.TabIndex = 0
        lblTituloRestaurante.Text = "RESTAURANTE EL BUEN SABOR"
        ' 
        ' pnlBordeDorado
        ' 
        pnlBordeDorado.BackColor = Color.FromArgb(CByte(254), CByte(174), CByte(13))
        pnlBordeDorado.Dock = DockStyle.Top
        pnlBordeDorado.Location = New Point(0, 75)
        pnlBordeDorado.Name = "pnlBordeDorado"
        pnlBordeDorado.Size = New Size(940, 5)
        pnlBordeDorado.TabIndex = 11
        ' 
        ' grpSeleccionMenu
        ' 
        grpSeleccionMenu.BackColor = Color.White
        grpSeleccionMenu.Controls.Add(lblInstruccionesCantidad)
        grpSeleccionMenu.Controls.Add(txtCantidad)
        grpSeleccionMenu.Controls.Add(lblCantidadPorciones)
        grpSeleccionMenu.Controls.Add(lblCarnes)
        grpSeleccionMenu.Controls.Add(lblMenestras)
        grpSeleccionMenu.Controls.Add(cboCarnes)
        grpSeleccionMenu.Controls.Add(lblArroces)
        grpSeleccionMenu.Controls.Add(cboArroces)
        grpSeleccionMenu.Controls.Add(cboMenestras)
        grpSeleccionMenu.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpSeleccionMenu.ForeColor = Color.FromArgb(CByte(176), CByte(83), CByte(40))
        grpSeleccionMenu.Location = New Point(25, 96)
        grpSeleccionMenu.Name = "grpSeleccionMenu"
        grpSeleccionMenu.Size = New Size(390, 430)
        grpSeleccionMenu.TabIndex = 0
        grpSeleccionMenu.TabStop = False
        grpSeleccionMenu.Text = "  1. SELECCION DEL MENU  "
        ' 
        ' lblInstruccionesCantidad
        ' 
        lblInstruccionesCantidad.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblInstruccionesCantidad.ForeColor = Color.FromArgb(CByte(115), CByte(115), CByte(115))
        lblInstruccionesCantidad.Location = New Point(20, 345)
        lblInstruccionesCantidad.Name = "lblInstruccionesCantidad"
        lblInstruccionesCantidad.Size = New Size(348, 55)
        lblInstruccionesCantidad.TabIndex = 8
        lblInstruccionesCantidad.Text = "Instruccion: Defina la cantidad (entre 1 y 99) y luego seleccione el plato en la lista superior para agregarlo al pedido."
        ' 
        ' txtCantidad
        ' 
        txtCantidad.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        txtCantidad.BorderStyle = BorderStyle.FixedSingle
        txtCantidad.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCantidad.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        txtCantidad.Location = New Point(220, 290)
        txtCantidad.MaxLength = 2
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(75, 27)
        txtCantidad.TabIndex = 3
        txtCantidad.Text = "1"
        txtCantidad.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblCantidadPorciones
        ' 
        lblCantidadPorciones.AutoSize = True
        lblCantidadPorciones.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCantidadPorciones.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        lblCantidadPorciones.Location = New Point(20, 295)
        lblCantidadPorciones.Name = "lblCantidadPorciones"
        lblCantidadPorciones.Size = New Size(174, 17)
        lblCantidadPorciones.TabIndex = 6
        lblCantidadPorciones.Text = "CANTIDAD DE PORCIONES:"
        ' 
        ' lblCarnes
        ' 
        lblCarnes.AutoSize = True
        lblCarnes.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCarnes.ForeColor = Color.FromArgb(CByte(176), CByte(83), CByte(40))
        lblCarnes.Location = New Point(20, 200)
        lblCarnes.Name = "lblCarnes"
        lblCarnes.Size = New Size(137, 15)
        lblCarnes.TabIndex = 4
        lblCarnes.Text = "CARNES Y PROTEINAS:"
        ' 
        ' lblMenestras
        ' 
        lblMenestras.AutoSize = True
        lblMenestras.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMenestras.ForeColor = Color.FromArgb(CByte(176), CByte(83), CByte(40))
        lblMenestras.Location = New Point(20, 118)
        lblMenestras.Name = "lblMenestras"
        lblMenestras.Size = New Size(129, 15)
        lblMenestras.TabIndex = 2
        lblMenestras.Text = "MENESTRAS DEL DIA:"
        ' 
        ' cboCarnes
        ' 
        cboCarnes.BackColor = Color.White
        cboCarnes.DropDownStyle = ComboBoxStyle.DropDownList
        cboCarnes.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboCarnes.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        cboCarnes.FormattingEnabled = True
        cboCarnes.Location = New Point(20, 222)
        cboCarnes.Name = "cboCarnes"
        cboCarnes.Size = New Size(348, 25)
        cboCarnes.TabIndex = 2
        ' 
        ' lblArroces
        ' 
        lblArroces.AutoSize = True
        lblArroces.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblArroces.ForeColor = Color.FromArgb(CByte(176), CByte(83), CByte(40))
        lblArroces.Location = New Point(20, 36)
        lblArroces.Name = "lblArroces"
        lblArroces.Size = New Size(140, 15)
        lblArroces.TabIndex = 0
        lblArroces.Text = "ARROCES DISPONIBLES:"
        ' 
        ' cboArroces
        ' 
        cboArroces.BackColor = Color.White
        cboArroces.DropDownStyle = ComboBoxStyle.DropDownList
        cboArroces.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboArroces.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        cboArroces.FormattingEnabled = True
        cboArroces.Location = New Point(20, 58)
        cboArroces.Name = "cboArroces"
        cboArroces.Size = New Size(348, 25)
        cboArroces.TabIndex = 0
        ' 
        ' cboMenestras
        ' 
        cboMenestras.BackColor = Color.White
        cboMenestras.DropDownStyle = ComboBoxStyle.DropDownList
        cboMenestras.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboMenestras.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        cboMenestras.FormattingEnabled = True
        cboMenestras.Location = New Point(20, 140)
        cboMenestras.Name = "cboMenestras"
        cboMenestras.Size = New Size(348, 25)
        cboMenestras.TabIndex = 1
        ' 
        ' grpDetallePedido
        ' 
        grpDetallePedido.BackColor = Color.White
        grpDetallePedido.Controls.Add(btnQuitarPlato)
        grpDetallePedido.Controls.Add(lblInstruccionesLista)
        grpDetallePedido.Controls.Add(lstPedidoMenu)
        grpDetallePedido.Controls.Add(lblPlatosAgregados)
        grpDetallePedido.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpDetallePedido.ForeColor = Color.FromArgb(CByte(176), CByte(83), CByte(40))
        grpDetallePedido.Location = New Point(435, 96)
        grpDetallePedido.Name = "grpDetallePedido"
        grpDetallePedido.Size = New Size(480, 215)
        grpDetallePedido.TabIndex = 1
        grpDetallePedido.TabStop = False
        grpDetallePedido.Text = "  2. DETALLE DEL PEDIDO  "
        ' 
        ' btnQuitarPlato
        ' 
        btnQuitarPlato.BackColor = Color.FromArgb(CByte(254), CByte(174), CByte(13))
        btnQuitarPlato.Cursor = Cursors.Hand
        btnQuitarPlato.FlatAppearance.BorderSize = 0
        btnQuitarPlato.FlatStyle = FlatStyle.Flat
        btnQuitarPlato.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnQuitarPlato.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        btnQuitarPlato.Location = New Point(310, 175)
        btnQuitarPlato.Name = "btnQuitarPlato"
        btnQuitarPlato.Size = New Size(150, 28)
        btnQuitarPlato.TabIndex = 5
        btnQuitarPlato.Text = "Quitar Seleccionado"
        btnQuitarPlato.UseVisualStyleBackColor = False
        ' 
        ' lblInstruccionesLista
        ' 
        lblInstruccionesLista.AutoSize = True
        lblInstruccionesLista.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblInstruccionesLista.ForeColor = Color.FromArgb(CByte(115), CByte(115), CByte(115))
        lblInstruccionesLista.Location = New Point(20, 182)
        lblInstruccionesLista.Name = "lblInstruccionesLista"
        lblInstruccionesLista.Size = New Size(245, 13)
        lblInstruccionesLista.TabIndex = 2
        lblInstruccionesLista.Text = "Doble clic sobre un plato para eliminarlo de la lista."
        ' 
        ' lstPedidoMenu
        ' 
        lstPedidoMenu.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        lstPedidoMenu.BorderStyle = BorderStyle.FixedSingle
        lstPedidoMenu.Font = New Font("Consolas", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstPedidoMenu.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        lstPedidoMenu.FormattingEnabled = True
        lstPedidoMenu.ItemHeight = 15
        lstPedidoMenu.Location = New Point(20, 48)
        lstPedidoMenu.Name = "lstPedidoMenu"
        lstPedidoMenu.Size = New Size(440, 122)
        lstPedidoMenu.TabIndex = 4
        ' 
        ' lblPlatosAgregados
        ' 
        lblPlatosAgregados.AutoSize = True
        lblPlatosAgregados.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlatosAgregados.ForeColor = Color.FromArgb(CByte(176), CByte(83), CByte(40))
        lblPlatosAgregados.Location = New Point(20, 27)
        lblPlatosAgregados.Name = "lblPlatosAgregados"
        lblPlatosAgregados.Size = New Size(134, 15)
        lblPlatosAgregados.TabIndex = 0
        lblPlatosAgregados.Text = "PLATOS AGREGADOS:"
        ' 
        ' btnLimpiarPedido
        ' 
        btnLimpiarPedido.BackColor = Color.FromArgb(CByte(254), CByte(174), CByte(13))
        btnLimpiarPedido.Cursor = Cursors.Hand
        btnLimpiarPedido.FlatAppearance.BorderSize = 0
        btnLimpiarPedido.FlatStyle = FlatStyle.Flat
        btnLimpiarPedido.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLimpiarPedido.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        btnLimpiarPedido.Location = New Point(25, 535)
        btnLimpiarPedido.Name = "btnLimpiarPedido"
        btnLimpiarPedido.Size = New Size(160, 36)
        btnLimpiarPedido.TabIndex = 8
        btnLimpiarPedido.Text = "Limpiar Pedido"
        btnLimpiarPedido.UseVisualStyleBackColor = False
        ' 
        ' btnSalirSistema
        ' 
        btnSalirSistema.BackColor = Color.FromArgb(CByte(176), CByte(83), CByte(40))
        btnSalirSistema.Cursor = Cursors.Hand
        btnSalirSistema.FlatAppearance.BorderSize = 0
        btnSalirSistema.FlatStyle = FlatStyle.Flat
        btnSalirSistema.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalirSistema.ForeColor = Color.White
        btnSalirSistema.Location = New Point(785, 535)
        btnSalirSistema.Name = "btnSalirSistema"
        btnSalirSistema.Size = New Size(130, 36)
        btnSalirSistema.TabIndex = 9
        btnSalirSistema.Text = "Salir"
        btnSalirSistema.UseVisualStyleBackColor = False
        ' 
        ' grpLiquidacionPago
        ' 
        grpLiquidacionPago.BackColor = Color.White
        grpLiquidacionPago.Controls.Add(btnCobrar)
        grpLiquidacionPago.Controls.Add(txtCambio)
        grpLiquidacionPago.Controls.Add(lblMontoCambio)
        grpLiquidacionPago.Controls.Add(txtPagaCon)
        grpLiquidacionPago.Controls.Add(lblMontoPago)
        grpLiquidacionPago.Controls.Add(txtTotal)
        grpLiquidacionPago.Controls.Add(lblTotalPagar)
        grpLiquidacionPago.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpLiquidacionPago.ForeColor = Color.FromArgb(CByte(176), CByte(83), CByte(40))
        grpLiquidacionPago.Location = New Point(435, 321)
        grpLiquidacionPago.Name = "grpLiquidacionPago"
        grpLiquidacionPago.Size = New Size(480, 205)
        grpLiquidacionPago.TabIndex = 2
        grpLiquidacionPago.TabStop = False
        grpLiquidacionPago.Text = "  3. LIQUIDACION Y PAGO  "
        ' 
        ' btnCobrar
        ' 
        btnCobrar.BackColor = Color.FromArgb(CByte(205), CByte(5), CByte(8))
        btnCobrar.Cursor = Cursors.Hand
        btnCobrar.FlatAppearance.BorderSize = 0
        btnCobrar.FlatStyle = FlatStyle.Flat
        btnCobrar.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCobrar.ForeColor = Color.White
        btnCobrar.Location = New Point(320, 80)
        btnCobrar.Name = "btnCobrar"
        btnCobrar.Size = New Size(140, 85)
        btnCobrar.TabIndex = 7
        btnCobrar.Text = "COBRAR" & vbCrLf & "PEDIDO"
        btnCobrar.UseVisualStyleBackColor = False
        ' 
        ' txtCambio
        ' 
        txtCambio.BackColor = Color.FromArgb(CByte(240), CByte(255), CByte(240))
        txtCambio.BorderStyle = BorderStyle.FixedSingle
        txtCambio.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCambio.ForeColor = Color.FromArgb(CByte(0), CByte(128), CByte(0))
        txtCambio.Location = New Point(175, 137)
        txtCambio.Name = "txtCambio"
        txtCambio.ReadOnly = True
        txtCambio.Size = New Size(130, 27)
        txtCambio.TabIndex = 5
        txtCambio.TabStop = False
        txtCambio.Text = "0.00"
        txtCambio.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblMontoCambio
        ' 
        lblMontoCambio.AutoSize = True
        lblMontoCambio.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMontoCambio.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        lblMontoCambio.Location = New Point(20, 142)
        lblMontoCambio.Name = "lblMontoCambio"
        lblMontoCambio.Size = New Size(147, 17)
        lblMontoCambio.TabIndex = 4
        lblMontoCambio.Text = "CAMBIO / VUELTO ($):"
        ' 
        ' txtPagaCon
        ' 
        txtPagaCon.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        txtPagaCon.BorderStyle = BorderStyle.FixedSingle
        txtPagaCon.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPagaCon.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        txtPagaCon.Location = New Point(175, 85)
        txtPagaCon.Name = "txtPagaCon"
        txtPagaCon.Size = New Size(130, 27)
        txtPagaCon.TabIndex = 6
        txtPagaCon.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblMontoPago
        ' 
        lblMontoPago.AutoSize = True
        lblMontoPago.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMontoPago.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        lblMontoPago.Location = New Point(20, 90)
        lblMontoPago.Name = "lblMontoPago"
        lblMontoPago.Size = New Size(101, 17)
        lblMontoPago.TabIndex = 2
        lblMontoPago.Text = "PAGA CON ($):"
        ' 
        ' txtTotal
        ' 
        txtTotal.BackColor = Color.FromArgb(CByte(255), CByte(245), CByte(245))
        txtTotal.BorderStyle = BorderStyle.FixedSingle
        txtTotal.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTotal.ForeColor = Color.FromArgb(CByte(205), CByte(5), CByte(8))
        txtTotal.Location = New Point(175, 30)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(130, 34)
        txtTotal.TabIndex = 1
        txtTotal.TabStop = False
        txtTotal.Text = "0.00"
        txtTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblTotalPagar
        ' 
        lblTotalPagar.AutoSize = True
        lblTotalPagar.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalPagar.ForeColor = Color.FromArgb(CByte(176), CByte(83), CByte(40))
        lblTotalPagar.Location = New Point(20, 38)
        lblTotalPagar.Name = "lblTotalPagar"
        lblTotalPagar.Size = New Size(139, 19)
        lblTotalPagar.TabIndex = 0
        lblTotalPagar.Text = "TOTAL A PAGAR ($):"
        ' 
        ' lblPiePagina
        ' 
        lblPiePagina.AutoSize = True
        lblPiePagina.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPiePagina.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(140))
        lblPiePagina.Location = New Point(200, 546)
        lblPiePagina.Name = "lblPiePagina"
        lblPiePagina.Size = New Size(328, 15)
        lblPiePagina.TabIndex = 12
        lblPiePagina.Text = "Desarrollo de Software VIII • Laboratorio 2 - Gestion Restaurante"
        ' 
        ' lblEstadoOperacion
        ' 
        lblEstadoOperacion.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEstadoOperacion.ForeColor = Color.FromArgb(CByte(176), CByte(83), CByte(40))
        lblEstadoOperacion.Location = New Point(25, 578)
        lblEstadoOperacion.Name = "lblEstadoOperacion"
        lblEstadoOperacion.Size = New Size(890, 20)
        lblEstadoOperacion.TabIndex = 13
        lblEstadoOperacion.Text = "Sistema iniciado. Seleccione los platos para comenzar su orden."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        ClientSize = New Size(940, 608)
        Controls.Add(lblEstadoOperacion)
        Controls.Add(lblPiePagina)
        Controls.Add(grpLiquidacionPago)
        Controls.Add(btnSalirSistema)
        Controls.Add(btnLimpiarPedido)
        Controls.Add(grpDetallePedido)
        Controls.Add(grpSeleccionMenu)
        Controls.Add(pnlBordeDorado)
        Controls.Add(pnlEncabezado)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Restaurante - Gestion y Control de Pedidos"
        pnlEncabezado.ResumeLayout(False)
        pnlEncabezado.PerformLayout()
        grpSeleccionMenu.ResumeLayout(False)
        grpSeleccionMenu.PerformLayout()
        grpDetallePedido.ResumeLayout(False)
        grpDetallePedido.PerformLayout()
        grpLiquidacionPago.ResumeLayout(False)
        grpLiquidacionPago.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlEncabezado As Panel
    Friend WithEvents lblTituloRestaurante As Label
    Friend WithEvents lblSubtituloRestaurante As Label
    Friend WithEvents lblFechaOrden As Label
    Friend WithEvents pnlBordeDorado As Panel
    Friend WithEvents grpSeleccionMenu As GroupBox
    Friend WithEvents lblArroces As Label
    Friend WithEvents cboArroces As ComboBox
    Friend WithEvents lblMenestras As Label
    Friend WithEvents cboMenestras As ComboBox
    Friend WithEvents lblCarnes As Label
    Friend WithEvents cboCarnes As ComboBox
    Friend WithEvents lblCantidadPorciones As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lblInstruccionesCantidad As Label
    Friend WithEvents grpDetallePedido As GroupBox
    Friend WithEvents lblPlatosAgregados As Label
    Friend WithEvents lstPedidoMenu As ListBox
    Friend WithEvents lblInstruccionesLista As Label
    Friend WithEvents btnQuitarPlato As Button
    Friend WithEvents btnLimpiarPedido As Button
    Friend WithEvents btnSalirSistema As Button
    Friend WithEvents grpLiquidacionPago As GroupBox
    Friend WithEvents lblTotalPagar As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblMontoPago As Label
    Friend WithEvents txtPagaCon As TextBox
    Friend WithEvents lblMontoCambio As Label
    Friend WithEvents txtCambio As TextBox
    Friend WithEvents btnCobrar As Button
    Friend WithEvents lblPiePagina As Label
    Friend WithEvents lblEstadoOperacion As Label

End Class
