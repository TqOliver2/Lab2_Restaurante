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
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        ListBox1 = New ListBox()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(6, 52)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(6, 116)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 1
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(6, 171)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(121, 23)
        ComboBox3.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(ComboBox3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Location = New Point(47, 104)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(257, 215)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 4
        Label3.Text = "CARNES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 15)
        Label2.TabIndex = 3
        Label2.Text = "MENESTRAS"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 15)
        Label1.TabIndex = 2
        Label1.Text = "ARROCES"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ListBox1)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Location = New Point(426, 112)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(319, 207)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(26, 54)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(275, 139)
        ListBox1.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(16, 26)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 15)
        Label4.TabIndex = 0
        Label4.Text = "MENU SELECCIONADO"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(69, 355)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 29)
        Button1.TabIndex = 5
        Button1.Text = "BORRAR MENU"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(69, 402)
        Button2.Name = "Button2"
        Button2.Size = New Size(115, 23)
        Button2.TabIndex = 6
        Button2.Text = "FINALIZAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(537, 341)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 15)
        Label5.TabIndex = 7
        Label5.Text = "TOTAL DE CUENTA"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(519, 377)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(143, 23)
        TextBox1.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(217, 38)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 15)
        Label6.TabIndex = 9
        Label6.Text = "RESTAURANTE"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label

End Class
