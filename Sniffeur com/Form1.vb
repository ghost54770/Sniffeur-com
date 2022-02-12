Imports System.IO.Ports
Imports System.Threading

Public Class Form1
    Dim WithEvents PortCOM As SerialPort
    Dim inputCOM As String

    'Chargement des taches de fond
    Private Sub Form1_Chargement(sender As Object, e As EventArgs) Handles MyBase.Load


        'Remplissage du combobox "ComboBox_Baud"
        Dim baud = New Integer() {110, 220, 300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200}
        For i As Integer = 0 To baud.Length - 1 Step 1
            ComboBox_Baud.Items.Add(baud(i))
        Next
        'Remplissage du combobox "ComboBox_Parité"
        Dim parité = New String() {"aucun", "valeur a 0", "valeur à 1", "impair", "pair"}
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

    Private Sub ListeLesPortsCOM(sender As System.Object, e As EventArgs) Handles ComboBox_PortCOM.Click
        'Remplissage du combobox "ComboBox_PortCOM"
        ComboBox_PortCOM.Items.Clear()
        For Each port As String In My.Computer.Ports.SerialPortNames
            ComboBox_PortCOM.Items.Add(port)
        Next
    End Sub



    Private Sub EnvoieCOM(sender As System.Object, e As EventArgs) Handles Button_EnvoieCOM.Click
        PortCOM.Write(TextBox_EnvoieCOM.Text)
    End Sub


    Private Sub OuvreFermePortCOM(sender As Object, e As EventArgs) Handles Button_OuvreFermeCOM.Click
        Dim numeroPortCOM As String = ComboBox_PortCOM.Text
        Dim baude As Integer = CType(ComboBox_Baud.Text, Integer)
        Dim parite As String
        If ComboBox_Parite.Text = "aucun" Then
            parite = Parity.None
        ElseIf ComboBox_Parite.Text = "valeur a 0" Then
            parite = Parity.Space
        ElseIf ComboBox_Parite.Text = "valeur à 1" Then
            parite = Parity.Mark
        ElseIf ComboBox_Parite.Text = "impair" Then
            parite = Parity.Odd
        ElseIf ComboBox_Parite.Text = "pair" Then
            parite = Parity.Even

        End If

        Try
            If Button_OuvreFermeCOM.Text = "Ouvrir" Then
                PortCOM = New SerialPort(numeroPortCOM, baude, parite, 8)
                PortCOM.Open()

                Dim threadLectureCOM As Thread = New Thread(New ThreadStart(AddressOf LectureCOM))
                threadLectureCOM.Start()

                Button_OuvreFermeCOM.Text = "Fermer"
            ElseIf Button_OuvreFermeCOM.Text = "Fermer" Then
                PortCOM.Close()
                Button_OuvreFermeCOM.Text = "Ouvrir"
            End If
            Exit Try
        Catch
            MsgBox("Erreur com")
        End Try
    End Sub


    Private Sub ObtenirListePortCOM()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label_PortCOM.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label_Baud.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Baud.SelectedIndexChanged

    End Sub

    Private Sub LectureCOM()
        Try
            Do
                Dim inputMessage As String = PortCOM.ReadLine()
                If inputMessage Is Nothing Then
                    Exit Do
                Else

                    TextBox_FenetrePrincipale.Text &= PortCOM.ReadLine() & vbCr

                End If


            Loop
        Catch ex As Exception
        End Try


    End Sub
End Class



