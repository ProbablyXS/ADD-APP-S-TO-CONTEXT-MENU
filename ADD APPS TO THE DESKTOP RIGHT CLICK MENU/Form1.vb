Imports System.IO
Imports Microsoft.Win32

Public Class Form1


    Private Sub ButtonApply_Click(sender As Object, e As EventArgs) Handles ButtonApply.Click

        If (NameBoxText1.Text = "") Then

            Exit Sub

        ElseIf (DestinationFolderBoxText1.Text = "C:\\\.exe") Then

            Exit Sub

        End If

        Try

            'NameBox'
            My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\Directory\background\shell\" & NameBoxText1.Text, "Name", NameBoxText1.Text)

            'Destinationfolderbox'
            My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\Directory\background\shell\" & NameBoxText1.Text & "\command", "", DestinationFolderBoxText1.Text)

        Catch ex As Exception



        End Try

        Try

            ListBox1.Items.Clear()

            Dim Key As RegistryKey = Registry.ClassesRoot.OpenSubKey("Directory\background\shell", False)
            Dim SubKeyNames() As String = Key.GetSubKeyNames()

            Dim Index As Integer
            Dim SubKey As RegistryKey

            For Index = 0 To Key.SubKeyCount - 1

                SubKey = Registry.ClassesRoot.OpenSubKey("Directory\background\shell" + "\" + SubKeyNames(Index), False)

                ListBox1.Items.Add(SubKeyNames(Index).ToString)

            Next

        Catch ex As Exception



        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DeleteButton1.Click

        If (NameDeleteBoxText1.Text = "") Then

            MsgBox("Aucun nom spécifié")
            Exit Sub

        Else



        End If

        Try

            My.Computer.Registry.ClassesRoot.DeleteSubKeyTree("\Directory\background\shell\" & NameDeleteBoxText1.Text)

        Catch ex As Exception

            MsgBox(ex.Message & "! LE NOM DE FICHIER N'EXISTE PAS !")
            Exit Sub

        End Try

        ListBox1.Items.Clear()

        Dim Key As RegistryKey = Registry.ClassesRoot.OpenSubKey("Directory\background\shell", False)
        Dim SubKeyNames() As String = Key.GetSubKeyNames()

        Dim Index As Integer
        Dim SubKey As RegistryKey

        For Index = 0 To Key.SubKeyCount - 1

            SubKey = Registry.ClassesRoot.OpenSubKey("Directory\background\shell" + "\" + SubKeyNames(Index), False)

            ListBox1.Items.Add(SubKeyNames(Index).ToString)

        Next

        NameDeleteBoxText1.Clear()

    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click

        Try

            OpenFileDialog1.ShowDialog()
            DestinationFolderBoxText1.Text = OpenFileDialog1.FileName
            NameBoxText1.Text = Path.GetFileNameWithoutExtension(OpenFileDialog1.SafeFileName.ToString)

        Catch ex As Exception



        End Try

        If (OpenFileDialog1.FileName = "OpenFileDialog1") Then

            DestinationFolderBoxText1.Clear()
            NameBoxText1.Clear()

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim Key As RegistryKey = Registry.ClassesRoot.OpenSubKey("Directory\background\shell", False)
            Dim SubKeyNames() As String = Key.GetSubKeyNames()

            Dim Index As Integer
            Dim SubKey As RegistryKey

            For Index = 0 To Key.SubKeyCount - 1

                SubKey = Registry.ClassesRoot.OpenSubKey("Directory\background\shell" + "\" + SubKeyNames(Index), False)

                ListBox1.Items.Add(SubKeyNames(Index).ToString)

            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Try

            NameDeleteBoxText1.Text = ListBox1.SelectedItem.ToString

        Catch ex As Exception



        End Try

    End Sub
End Class