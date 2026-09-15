Public Class Form1

    Private Sub cmdFIN_Click(sender As Object, e As EventArgs) Handles cmdFIN.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'USANDO EL METODO ADD
        cboMENESTRAS.Items.Add("POROTOS: 1.15")
        cboMENESTRAS.Items.Add("LENTEJAS: 0.90")
        cboMENESTRAS.Items.Add("FRIJOLES: 1.00")
        cboMENESTRAS.Items.Add("ARVEJAS: 0.95")
        cboMENESTRAS.Items.Add("GARBANZOS: 0.85")

        'USANDO EL METODO DE VECTORES ADDRANGE
        Dim LASCARNES(6) As String

        LASCARNES(0) = "CARNES DE RES: 1.55"
        LASCARNES(1) = "VENADO: 2.50"
        LASCARNES(2) = "POLLO: 1.15"
        LASCARNES(3) = "PAVO: 2.15"
        LASCARNES(4) = "PESCADO: 2.50"
        LASCARNES(5) = "CAMARONES: 2.90"
        LASCARNES(6) = "LANGOSTA: 3.50"

        'ASIGNANDO LOS VECTORES AL COMBOBOX
        cboCARNES.Items.AddRange(LASCARNES)

        ' ASIGNANDO LOS ARROCES
        cboARROCES.Items.Add("ARROZ BLANCO: 1.00")
        cboARROCES.Items.Add("ARROZ CON VEGETALES: 1.15")
        cboARROCES.Items.Add("ARROZ CON MAÍZ: 1.10")
        cboARROCES.Items.Add("ARROZ CON FRIJOLES: 1.20")
        cboARROCES.Items.Add("ARROZ FRITO: 1.50")


    End Sub

    Private Sub cboARROCES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboARROCES.SelectedIndexChanged

        Dim PRECIOARROZ, TOTAL As Single
        Dim POSICION As Integer

        'AGREGAMOS EL ARROZ SELECCIONADO
        'EN CBOARROZ AL LISTMENU
        lstMENU.Items.Add(cboARROCES.Text)

        'LEEMOS Y FIJAMOS LA POSICION DE LOS (:)
        POSICION = InStr(cboARROCES.Text, ":")

        'LEEMOS Y TRANSFORMAMOS Y CAPTURAMOS TODOS LOS CARACTERES DESPUES DE (:)
        PRECIOARROZ = Val(Mid(cboARROCES.Text, POSICION + 1))

        'SUMAMOS AL TOTAL EL PRECIO DEL ARROZ Y LE DAMOS FORMATO
        TOTAL = Val(txtTOTAL.Text) + PRECIOARROZ - PRECIOARROZ * 0.07
        txtTOTAL.Text = Format(TOTAL, "##0.00")

    End Sub

    Private Sub cboMENESTRAS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMENESTRAS.SelectedIndexChanged

        Dim PRECIOMENESTRA, TOTAL As Single
        Dim POSICION As Integer

        'AGREGAMOS EL MENESTRA SELECCIONADO
        'EN CBOMENESTRAS AL LISTMENU
        lstMENU.Items.Add(cboMENESTRAS.Text)

        'LEEMOS Y FIJAMOS LA POSICION DE LOS (:)
        POSICION = InStr(cboMENESTRAS.Text, ":")

        'LEEMOS Y TRANSFORMAMOS Y CAPTURAMOS TODOS LOS CARACTERES DESPUES DE (:)
        PRECIOMENESTRA = Val(Mid(cboMENESTRAS.Text, POSICION + 1))

        'SUMAMOS AL TOTAL EL PRECIO DEL MENESTRA Y LE DAMOS FORMATO
        TOTAL = Val(txtTOTAL.Text) + PRECIOMENESTRA - PRECIOMENESTRA * 0.07
        txtTOTAL.Text = Format(TOTAL, "##0.00")

    End Sub

    Private Sub cboCARNES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCARNES.SelectedIndexChanged

        Dim PRECIOCARNES, TOTAL As Single
        Dim POSICION As Integer

        'AGREGAMOS EL CARNES SELECCIONADO
        'EN CBOCARNES AL LISTMENU
        lstMENU.Items.Add(cboCARNES.Text)

        'LEEMOS Y FIJAMOS LA POSICION DE LOS (:)
        POSICION = InStr(cboCARNES.Text, ":")

        'LEEMOS Y TRANSFORMAMOS Y CAPTURAMOS TODOS LOS CARACTERES DESPUES DE (:)
        PRECIOCARNES = Val(Mid(cboCARNES.Text, POSICION + 1))

        'SUMAMOS AL TOTAL EL PRECIO DEL CARNES Y LE DAMOS FORMATO
        TOTAL = Val(txtTOTAL.Text) + PRECIOCARNES - PRECIOCARNES * 0.07
        txtTOTAL.Text = Format(TOTAL, "##0.00")

    End Sub

    Private Sub lstMENU_DoubleClick(sender As Object, e As EventArgs) Handles lstMENU.DoubleClick
        Dim PRECIOELIMINAR, TOTAL As Single
        Dim POSICION As Integer

        'POSICION DE LOS (:)
        POSICION = InStr(lstMENU.Text, ":")

        'LEEMOS Y TRANSFORMAMOS Y CAPTURAMOS TODOS LOS CARACTERES DESPUES DE (:)
        PRECIOELIMINAR = Val(Mid(lstMENU.Text, POSICION + 1))

        'VERIFICAMOS VALORES EN LA LISTA Y LUEGO RESTAMOS
        If lstMENU.Items.Count > 1 Then
            TOTAL = Val(txtTOTAL.Text) - PRECIOELIMINAR
            txtTOTAL.Text = Format(TOTAL, "##0.00")
        ElseIf lstMENU.Items.Count = 1 Then
            txtTOTAL.Text = ""
        Else
            Exit Sub
        End If

        'REMOVEMOS EL ELEMENTO AL QUE LE DIMOS DOBLE CLIC
        lstMENU.Items.Remove(lstMENU.Text)
    End Sub

    Private Sub cmdBORRARMENU_Click(sender As Object, e As EventArgs) Handles cmdBORRARMENU.Click
        'BORRANDO COMBOS
        cboARROCES.Text = ""
        cboMENESTRAS.Text = ""
        cboCARNES.Text = ""

        'BORRANDO LISTA
        lstMENU.Items.Clear()

        'BORRANDO TOTAL
        txtTOTAL.Clear()
    End Sub



End Class

