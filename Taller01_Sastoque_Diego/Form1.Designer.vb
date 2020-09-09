<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntrada
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdVisual = New System.Windows.Forms.Button()
        Me.cmdTerminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserin = New System.Windows.Forms.TextBox()
        Me.txtContrin = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(26, 217)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(95, 60)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdVisual
        '
        Me.cmdVisual.Location = New System.Drawing.Point(175, 217)
        Me.cmdVisual.Name = "cmdVisual"
        Me.cmdVisual.Size = New System.Drawing.Size(93, 60)
        Me.cmdVisual.TabIndex = 1
        Me.cmdVisual.Text = "Visualizar Info"
        Me.cmdVisual.UseVisualStyleBackColor = True
        '
        'cmdTerminar
        '
        Me.cmdTerminar.Location = New System.Drawing.Point(327, 217)
        Me.cmdTerminar.Name = "cmdTerminar"
        Me.cmdTerminar.Size = New System.Drawing.Size(93, 60)
        Me.cmdTerminar.TabIndex = 2
        Me.cmdTerminar.Text = "Terminar"
        Me.cmdTerminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña"
        '
        'txtUserin
        '
        Me.txtUserin.Location = New System.Drawing.Point(175, 55)
        Me.txtUserin.Name = "txtUserin"
        Me.txtUserin.Size = New System.Drawing.Size(207, 22)
        Me.txtUserin.TabIndex = 5
        '
        'txtContrin
        '
        Me.txtContrin.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtContrin.Location = New System.Drawing.Point(175, 122)
        Me.txtContrin.Name = "txtContrin"
        Me.txtContrin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrin.Size = New System.Drawing.Size(207, 22)
        Me.txtContrin.TabIndex = 6
        '
        'frmEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 308)
        Me.Controls.Add(Me.txtContrin)
        Me.Controls.Add(Me.txtUserin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdTerminar)
        Me.Controls.Add(Me.cmdVisual)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Name = "frmEntrada"
        Me.Text = "Introduccion a VB.Net"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdGuardar As Button
    Friend WithEvents cmdVisual As Button
    Friend WithEvents cmdTerminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserin As TextBox
    Friend WithEvents txtContrin As TextBox
End Class
