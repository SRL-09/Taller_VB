<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdRegresar = New System.Windows.Forms.Button()
        Me.cmdFin = New System.Windows.Forms.Button()
        Me.txtInfUltima = New System.Windows.Forms.TextBox()
        Me.txtInfoOut = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ultima Captura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Informacion Registrada"
        '
        'cmdRegresar
        '
        Me.cmdRegresar.Location = New System.Drawing.Point(74, 193)
        Me.cmdRegresar.Name = "cmdRegresar"
        Me.cmdRegresar.Size = New System.Drawing.Size(107, 56)
        Me.cmdRegresar.TabIndex = 2
        Me.cmdRegresar.Text = "Regresar"
        Me.cmdRegresar.UseVisualStyleBackColor = True
        '
        'cmdFin
        '
        Me.cmdFin.Location = New System.Drawing.Point(240, 193)
        Me.cmdFin.Name = "cmdFin"
        Me.cmdFin.Size = New System.Drawing.Size(107, 56)
        Me.cmdFin.TabIndex = 3
        Me.cmdFin.Text = "Terminar"
        Me.cmdFin.UseVisualStyleBackColor = True
        '
        'txtInfUltima
        '
        Me.txtInfUltima.Location = New System.Drawing.Point(213, 128)
        Me.txtInfUltima.Name = "txtInfUltima"
        Me.txtInfUltima.ReadOnly = True
        Me.txtInfUltima.Size = New System.Drawing.Size(175, 22)
        Me.txtInfUltima.TabIndex = 4
        '
        'txtInfoOut
        '
        Me.txtInfoOut.Location = New System.Drawing.Point(213, 54)
        Me.txtInfoOut.Name = "txtInfoOut"
        Me.txtInfoOut.ReadOnly = True
        Me.txtInfoOut.Size = New System.Drawing.Size(175, 22)
        Me.txtInfoOut.TabIndex = 5
        '
        'frmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 282)
        Me.Controls.Add(Me.txtInfoOut)
        Me.Controls.Add(Me.txtInfUltima)
        Me.Controls.Add(Me.cmdFin)
        Me.Controls.Add(Me.cmdRegresar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInfo"
        Me.Text = "Visualizar Informacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdRegresar As Button
    Friend WithEvents cmdFin As Button
    Friend WithEvents txtInfUltima As TextBox
    Friend WithEvents txtInfoOut As TextBox
End Class
