Imports System
Imports System.IO.Ports
Imports System.Threading

Public Class Form1

    'Chargement des taches de fond
    Private Sub Form1_Chargement(sender As Object, e As EventArgs) Handles MyBase.Load
        'Remplissage du combobox "ComboBox_PortCOM"
        For Each port As String In My.Computer.Ports.SerialPortNames
            ComboBox_PortCOM.Items.Add(port)
        Next

        'Remplissage du combobox "ComboBox_Baud"
        Dim baud = New Integer() {110, 220, 300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200}
        For i As Integer = 0 To baud.Length - 1 Step 1
            ComboBox_Baud.Items.Add(baud(i))
        Next
        'Remplissage du combobox "ComboBox_Parité"
        Dim parité = New Integer() {0, 1, 2}
        For i As Integer = 0 To parité.Length - 1 Step 1
            ComboBox_Parite.Items.Add(parité(i))
        Next

        'Remplissage du combobox "ComboBox_NombreBitsDonnée"
        Dim bitsDonnee = New Integer() {4, 5, 6, 7, 8}
        For i As Integer = 0 To bitsDonnee.Length - 1 Step 1
            ComboBox_NombreBitsDonnee.Items.Add(bitsDonnee(i))
        Next

        'Remplissage du combobox "ComboBox_NombreBitsStop"
        Dim bitsStop = New Integer() {0, 1, 2}
        For i As Integer = 0 To bitsStop.Length - 1 Step 1
            ComboBox_NombreBitsStop.Items.Add(bitsStop(i))
        Next

    End Sub

    'Private Sub ComboBox_Remplissage(sender As System.Object, e As EventArgs) Handles ComboBox_PortCOM.Click
    '    ComboBox_PortCOM.Items.Clear()
    '    ObtenirListePortCOM()

    'End Sub
    'Sub Main()
    '    '  ObtenirListePortCOM()
    '    ComboBox_PortCOM.Items.Add("1")

    '    For compteur As Integer = 1 To 5 Step 1
    '        ComboBox_PortCOM.Items.Add("1")

    '    Next
    'End Sub



    Private Sub ObtenirListePortCOM()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label_PortCOM.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label_Baud.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Baud.SelectedIndexChanged

    End Sub
End Class


