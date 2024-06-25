Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        Me.Size = New Size(700, 500)
        Me.ControlBox = False
        Me.FormBorderStyle = FormBorderStyle.Sizable ' o Fixed3D, FixedDialog, FixedSingle
        Me.MaximizeBox = False ' Desactiva el botón de maximizar
        Me.MinimizeBox = False ' Desactiva el botón de minimizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Desactiva la capacidad de redimensionar verticalmente
    End Sub


    Private Sub txtusuario_keydown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyData = Keys.Enter Then
            login_us()

        End If
    End Sub

    Private Sub txtPsw_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPsw.KeyDown
        If e.KeyData = Keys.Enter Then
            login_psw()
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        login_psw()
    End Sub
    Private Sub login_us()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "select id, usuario, contrasena from usuarios
                            where usuario = '" & Me.txtUsuario.Text & "'"
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()

        Try
            If dr.HasRows Then
                While dr.Read
                    Me.lbApellidoNombre.Visible = True
                    wid_usuario = dr(0).ToString
                    wusuario = dr(1).ToString
                    Me.lbApellidoNombre.Visible = True
                    Me.lbApellidoNombre.Text = dr(1).ToString
                    Me.lbPsw.Text = dr(2).ToString
                    Me.txtPsw.Focus()
                    Me.btnIngresar.Visible = True
                End While
            Else
                MsgBox("Usuario Inexistente", Title:="Super")
                Me.txtUsuario.Clear()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub login_psw()
        If (Me.txtPsw.Text = Me.lbPsw.Text) Then
            ' MsgBox("Hola")
            frmMain.Show()
            Me.Close()
        Else
            MsgBox("Los datos ingresados no son correctos.", MsgBoxStyle.Critical, "Error de acceso")
            Me.txtUsuario.Clear()
            Me.txtUsuario.Focus()
            Me.txtPsw.Clear()
            Me.btnIngresar.Visible = False
            Me.lbApellidoNombre.Visible = False

        End If


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub txtIdcaja_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            txtUsuario.Focus()


        End If
    End Sub


End Class