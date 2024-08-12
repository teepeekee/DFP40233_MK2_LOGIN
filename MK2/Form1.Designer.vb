<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblLogmasuk = New Label()
        txtId = New TextBox()
        lblIdpengguna = New Label()
        lblKatalaluan = New Label()
        txtKatalaluan = New TextBox()
        BtnLogin = New Button()
        SuspendLayout()
        ' 
        ' lblLogmasuk
        ' 
        lblLogmasuk.AutoSize = True
        lblLogmasuk.Location = New Point(142, 37)
        lblLogmasuk.Name = "lblLogmasuk"
        lblLogmasuk.Size = New Size(90, 20)
        lblLogmasuk.TabIndex = 0
        lblLogmasuk.Text = "LOG MASUK"
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(153, 72)
        txtId.Name = "txtId"
        txtId.Size = New Size(189, 27)
        txtId.TabIndex = 1
        ' 
        ' lblIdpengguna
        ' 
        lblIdpengguna.AutoSize = True
        lblIdpengguna.Location = New Point(41, 79)
        lblIdpengguna.Name = "lblIdpengguna"
        lblIdpengguna.Size = New Size(106, 20)
        lblIdpengguna.TabIndex = 2
        lblIdpengguna.Text = "ID PENGGUNA"
        ' 
        ' lblKatalaluan
        ' 
        lblKatalaluan.AutoSize = True
        lblKatalaluan.Location = New Point(41, 143)
        lblKatalaluan.Name = "lblKatalaluan"
        lblKatalaluan.Size = New Size(103, 20)
        lblKatalaluan.TabIndex = 3
        lblKatalaluan.Text = "KATA LALUAN"
        ' 
        ' txtKatalaluan
        ' 
        txtKatalaluan.Location = New Point(153, 136)
        txtKatalaluan.Name = "txtKatalaluan"
        txtKatalaluan.Size = New Size(189, 27)
        txtKatalaluan.TabIndex = 4
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(150, 194)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(94, 29)
        BtnLogin.TabIndex = 5
        BtnLogin.Text = "LOGIN"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(394, 256)
        Controls.Add(BtnLogin)
        Controls.Add(txtKatalaluan)
        Controls.Add(lblKatalaluan)
        Controls.Add(lblIdpengguna)
        Controls.Add(txtId)
        Controls.Add(lblLogmasuk)
        Name = "Form1"
        Text = "Login Page"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLogmasuk As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblIdpengguna As Label
    Friend WithEvents lblKatalaluan As Label
    Friend WithEvents txtKatalaluan As TextBox
    Friend WithEvents BtnLogin As Button

End Class
