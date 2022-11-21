Imports System.Net.Sockets

Public Class Form1
    Dim Alimentos() As Integer = {10, 110, 1, 2, 7, 24, 88, 99, 12, 51}
    Dim precio() As Integer = {66, 255, 40, 99, 1999, 23, 72, 31, 84, 23}
    Dim cont As Integer = 0
    Dim contali(10) As Integer
    Dim acumali(10) As Integer

    Structure Estructura
        Dim Alimento As Integer
        Dim Comedor As String
        Dim Cant As Integer
    End Structure
    Dim Comida(25) As Estructura
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Dim sino As Boolean = False
        For i As Integer = 0 To 9
            If NumericUpDown1.Value = Alimentos(i) Then
                sino = True
            End If
        Next

        If sino = False Then
            Label4.Visible = True
            Button1.Enabled = False
        Else
            Label4.Visible = False
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReDim Preserve Comida(cont + 1)
        cont += 1
        Comida(cont).Alimento = NumericUpDown1.Value
        Comida(cont).Comedor = TextBox1.Text
        Comida(cont).Cant = NumericUpDown2.Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = False
        Button2.Enabled = False
        For i As Integer = 0 To cont
            Select Case Comida(i).Alimento
                Case 10
                    contali(0) += 1
                    acumali(0) += Comida(i).Cant
                Case 110
                    contali(1) += 1
                    acumali(1) += Comida(i).Cant
                Case 1
                    contali(2) += 1
                    acumali(2) += Comida(i).Cant
                Case 2
                    contali(3) += 1
                    acumali(3) += Comida(i).Cant
                Case 7
                    contali(4) += 1
                    acumali(4) += Comida(i).Cant
                Case 24
                    contali(5) += 1
                    acumali(5) += Comida(i).Cant
                Case 88
                    contali(6) += 1
                    acumali(6) += Comida(i).Cant
                Case 99
                    contali(7) += 1
                    acumali(7) += Comida(i).Cant
                Case 12
                    contali(8) += 1
                    acumali(8) += Comida(i).Cant
                Case 51
                    contali(9) += 1
                    acumali(9) += Comida(i).Cant
            End Select

        Next
        ListView1.Items.Add("Alimentos totales: ")
        For i As Integer = 0 To 9
            Dim preciototal As Integer = acumali(i) * precio(i)
            ListView1.Items.Add("Cantidad del alimento " & Alimentos(i) & " " & acumali(i) & " Precio: " & preciototal)
        Next
        ListView1.Items.Add("Alimentos individuales: ")

        For i As Integer = 0 To cont
            ListView1.Items.Add(Comida(i).Comedor + ": " & Comida(i).Cant)
        Next

    End Sub

End Class
