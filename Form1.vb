Imports System.Drawing.Text

Public Class Form1
    Dim numero1 As Double
    Dim numero2 As Double
    Dim resultado As Double
    Dim [operador] As String

    Private Sub ButtonNum_Click(sender As Object, e As EventArgs) Handles Button0.Click, Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        Dim button As Button = sender
        txtDisplay.Text &= button.Text
    End Sub

    Private Sub buttonDecimal_Click(sender As Object, e As EventArgs) Handles ButtonDecimal.Click
        If Not txtDisplay.Text.Contains(".") Then
            txtDisplay.Text &= "."
        End If
    End Sub

    Private Sub buttonSumar_Click(sender As Object, e As EventArgs) Handles ButtonSumar.Click, ButtonRestar.Click, ButtonMultiplicar.Click, ButtonDividir.Click, ButtonPorcentaje.Click
        Dim button As Button = sender
        If button.Text = "%" Then
            numero1 = Val(txtDisplay.Text) / 100
            txtDisplay.Text = numero1.ToString()
        Else
            numero1 = Val(txtDisplay.Text)
            [operador] = button.Text
            txtDisplay.Text = ""
        End If
    End Sub

    Private Sub buttonIgual_Click(sender As Object, e As EventArgs) Handles ButtonIgual.Click
        numero2 = Val(txtDisplay.Text)
        Select Case [operador]
            Case "+"
                resultado = numero1 + numero2
            Case "-"
                resultado = numero1 - numero2
            Case "x"
                resultado = numero1 * numero2
            Case "/"
                resultado = numero1 / numero2
            Case "%"
                resultado = numero1 / 100
        End Select
        txtDisplay.Text = resultado.ToString
    End Sub

    Private Sub buttonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        txtDisplay.Text = ""
        numero2 = 0
    End Sub

    Private Sub buttonCE_Click(sender As Object, e As EventArgs) Handles ButtonCE.Click
        txtDisplay.Text = ""
        numero1 = 0
        numero2 = 0
        [operador] = ""
    End Sub
End Class
