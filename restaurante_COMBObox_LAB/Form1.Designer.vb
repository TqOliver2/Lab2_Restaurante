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
        cboARROCES = New ComboBox()
        cboMENESTRAS = New ComboBox()
        cboCARNES = New ComboBox()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        lstMENU = New ListBox()
        Label4 = New Label()
        cmdBORRARMENU = New Button()
        cmdFIN = New Button()
        Label5 = New Label()
        txtTOTAL = New TextBox()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' cboARROCES
        ' 
        cboARROCES.FormattingEnabled = True
        cboARROCES.Location = New Point(7, 69)
        cboARROCES.Margin = New Padding(3, 4, 3, 4)
        cboARROCES.Name = "cboARROCES"
        cboARROCES.Size = New Size(138, 28)
        cboARROCES.TabIndex = 0
        ' 
        ' cboMENESTRAS
        ' 
        cboMENESTRAS.FormattingEnabled = True
        cboMENESTRAS.Location = New Point(7, 155)
        cboMENESTRAS.Margin = New Padding(3, 4, 3, 4)
        cboMENESTRAS.Name = "cboMENESTRAS"
        cboMENESTRAS.Size = New Size(138, 28)
        cboMENESTRAS.TabIndex = 1
        ' 
        ' cboCARNES
        ' 
        cboCARNES.FormattingEnabled = True
        cboCARNES.Location = New Point(7, 228)
        cboCARNES.Margin = New Padding(3, 4, 3, 4)
        cboCARNES.Name = "cboCARNES"
        cboCARNES.Size = New Size(138, 28)
        cboCARNES.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(cboCARNES)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(cboARROCES)
        GroupBox1.Controls.Add(cboMENESTRAS)
        GroupBox1.Location = New Point(54, 139)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(294, 287)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 4
        Label3.Text = "CARNES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 20)
        Label2.TabIndex = 3
        Label2.Text = "MENESTRAS"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(7, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 20)
        Label1.TabIndex = 2
        Label1.Text = "ARROCES"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lstMENU)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Location = New Point(487, 149)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(365, 276)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' lstMENU
        ' 
        lstMENU.FormattingEnabled = True
        lstMENU.Location = New Point(30, 72)
        lstMENU.Margin = New Padding(3, 4, 3, 4)
        lstMENU.Name = "lstMENU"
        lstMENU.Size = New Size(314, 184)
        lstMENU.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(18, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(162, 20)
        Label4.TabIndex = 0
        Label4.Text = "MENU SELECCIONADO"
        ' 
        ' cmdBORRARMENU
        ' 
        cmdBORRARMENU.Location = New Point(79, 473)
        cmdBORRARMENU.Margin = New Padding(3, 4, 3, 4)
        cmdBORRARMENU.Name = "cmdBORRARMENU"
        cmdBORRARMENU.Size = New Size(131, 39)
        cmdBORRARMENU.TabIndex = 5
        cmdBORRARMENU.Text = "BORRAR MENU"
        cmdBORRARMENU.UseVisualStyleBackColor = True
        ' 
        ' cmdFIN
        ' 
        cmdFIN.Location = New Point(79, 536)
        cmdFIN.Margin = New Padding(3, 4, 3, 4)
        cmdFIN.Name = "cmdFIN"
        cmdFIN.Size = New Size(131, 31)
        cmdFIN.TabIndex = 6
        cmdFIN.Text = "FINALIZAR"
        cmdFIN.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(614, 455)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 20)
        Label5.TabIndex = 7
        Label5.Text = "TOTAL DE CUENTA"
        ' 
        ' txtTOTAL
        ' 
        txtTOTAL.Location = New Point(593, 503)
        txtTOTAL.Margin = New Padding(3, 4, 3, 4)
        txtTOTAL.Name = "txtTOTAL"
        txtTOTAL.ReadOnly = True
        txtTOTAL.Size = New Size(163, 27)
        txtTOTAL.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(248, 51)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 20)
        Label6.TabIndex = 9
        Label6.Text = "RESTAURANTE"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(Label6)
        Controls.Add(txtTOTAL)
        Controls.Add(Label5)
        Controls.Add(cmdFIN)
        Controls.Add(cmdBORRARMENU)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboARROCES As ComboBox
    Friend WithEvents cboMENESTRAS As ComboBox
    Friend WithEvents cboCARNES As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lstMENU As ListBox
    Friend WithEvents cmdBORRARMENU As Button
    Friend WithEvents cmdFIN As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTOTAL As TextBox
    Friend WithEvents Label6 As Label

End Class
