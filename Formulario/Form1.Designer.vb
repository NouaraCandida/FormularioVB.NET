<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnsSalvar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Telefone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(99, 35)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(301, 22)
        Me.txtNome.TabIndex = 3
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(99, 87)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(301, 22)
        Me.txtTelefone.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(99, 134)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(301, 22)
        Me.txtEmail.TabIndex = 5
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(351, 189)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(94, 31)
        Me.btnFechar.TabIndex = 6
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(182, 189)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(94, 31)
        Me.btnLimpar.TabIndex = 7
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnsSalvar
        '
        Me.btnsSalvar.Location = New System.Drawing.Point(33, 189)
        Me.btnsSalvar.Name = "btnsSalvar"
        Me.btnsSalvar.Size = New System.Drawing.Size(94, 31)
        Me.btnsSalvar.TabIndex = 8
        Me.btnsSalvar.Text = "Salvar"
        Me.btnsSalvar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 246)
        Me.Controls.Add(Me.btnsSalvar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnsSalvar As Button
End Class
