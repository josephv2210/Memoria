<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_Facil = New System.Windows.Forms.Button()
        Me.Btn_Medio = New System.Windows.Forms.Button()
        Me.Btn_Dificil = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Facil
        '
        Me.Btn_Facil.Location = New System.Drawing.Point(65, 134)
        Me.Btn_Facil.Name = "Btn_Facil"
        Me.Btn_Facil.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Facil.TabIndex = 0
        Me.Btn_Facil.Text = "Facil"
        Me.Btn_Facil.UseVisualStyleBackColor = True
        '
        'Btn_Medio
        '
        Me.Btn_Medio.Location = New System.Drawing.Point(295, 134)
        Me.Btn_Medio.Name = "Btn_Medio"
        Me.Btn_Medio.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Medio.TabIndex = 1
        Me.Btn_Medio.Text = "Medio"
        Me.Btn_Medio.UseVisualStyleBackColor = True
        '
        'Btn_Dificil
        '
        Me.Btn_Dificil.Location = New System.Drawing.Point(510, 134)
        Me.Btn_Dificil.Name = "Btn_Dificil"
        Me.Btn_Dificil.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Dificil.TabIndex = 2
        Me.Btn_Dificil.Text = "Dificil"
        Me.Btn_Dificil.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Por favor escoge el nivel"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 328)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Dificil)
        Me.Controls.Add(Me.Btn_Medio)
        Me.Controls.Add(Me.Btn_Facil)
        Me.Name = "MenuPrincipal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Facil As Button
    Friend WithEvents Btn_Medio As Button
    Friend WithEvents Btn_Dificil As Button
    Friend WithEvents Label1 As Label
End Class
