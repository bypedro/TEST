Public Class Form1

    Private Sub BtnImagem1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImagem1.Click
        If BtnImagem2.zEstadoBotao = True Then
            BtnImagem2.zEstadoBotao = False
            BtnImagem2.VerificarEstadoBotao()
        End If
        If BtnImagem3.zEstadoBotao = True Then
            BtnImagem3.zEstadoBotao = False
            BtnImagem3.VerificarEstadoBotao()
        End If
    End Sub

    Private Sub BtnImagem2_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImagem2.Click
        If BtnImagem1.zEstadoBotao = True Then
            BtnImagem1.zEstadoBotao = False
            BtnImagem1.VerificarEstadoBotao()
        End If
        If BtnImagem3.zEstadoBotao = True Then
            BtnImagem3.zEstadoBotao = False
            BtnImagem3.VerificarEstadoBotao()
        End If
    End Sub

    Private Sub BtnImagem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImagem3.Click
        If BtnImagem2.zEstadoBotao = True Then
            BtnImagem2.zEstadoBotao = False
            BtnImagem2.VerificarEstadoBotao()
        End If
        If BtnImagem1.zEstadoBotao = True Then
            BtnImagem1.zEstadoBotao = False
            BtnImagem1.VerificarEstadoBotao()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnImagem1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim a As Boolean = True

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If a = True Then
            Panel1.Hide()
            a = False
        ElseIf a = False Then
            Panel1.Show()
            a = True
        End If
    End Sub

    Dim tmrstat As Boolean = True

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Panel1.Right = 236 Then
            tmr.Enabled = True
        ElseIf Panel1.Right = 50 Then
            tmr2.Enabled = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = Panel1.Right
        Label2.Text = Panel1.Left
        Label3.Text = Panel1.Top
        Label4.Text = Panel1.Bottom
        Panel1.Left = 0
        Panel1.Top = 0
    End Sub

    Private Sub tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr.Tick
        Panel1.Left = Panel1.Left - 3
        If Panel1.Right = 50 Then
            tmr.Enabled = False
            BtnImagem1.Hide()
            BtnImagem2.Hide()
            BtnImagem3.Hide()
            LblFontes1.Hide()
        End If
    End Sub

    Private Sub tmr2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr2.Tick
        Panel1.Left = Panel1.Left + 3
        If Panel1.Right = 236 Then
            tmr2.Enabled = False
            BtnImagem1.Show()
            BtnImagem2.Show()
            BtnImagem3.Show()
            LblFontes1.Show()
        End If
    End Sub

    Public Sub BtnMenu1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenu1.Click
        If BtnMenu1.zEstadoBotao = True Then
            If Panel1.Right = 236 Then
                tmr.Enabled = True
            ElseIf Panel1.Right = 50 Then
                tmr2.Enabled = True
            End If
        ElseIf BtnMenu1.zEstadoBotao = False Then
            If Panel1.Right = 236 Then
                tmr.Enabled = True
            ElseIf Panel1.Right = 50 Then
                tmr2.Enabled = True
            End If
        End If

    End Sub
End Class
