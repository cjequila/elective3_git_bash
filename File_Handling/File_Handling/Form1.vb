Imports System.IO
Public Class Form1

    Dim name As String
    Dim age As Byte
    Dim address As String
    Dim file As String

    Private Sub name_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles name_textbox.KeyPress
        e.Handled = True

        If e.KeyChar Like "[A-z]" Or e.KeyChar = "." Or e.KeyChar = Chr(8) Or e.KeyChar = Chr(32) Then
            e.Handled = False
        End If
    End Sub

    Private Sub age_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles age_textbox.KeyPress
        e.Handled = True
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub address_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles address_textbox.KeyPress
        If e.KeyChar Like "[A-z]" Or e.KeyChar = "." Or e.KeyChar = Chr(8) Or e.KeyChar = Chr(32) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_button_Click(sender As Object, e As EventArgs) Handles txt_button.Click
        If age_textbox.Text.Length >= 255 Then
            MessageBox.Show("You have exceed the maximum value 255")
        End If

        name = name_textbox.Text
        age = age_textbox.Text
        address = address_textbox.Text

        file = name + ".txt"
        Try
            Using file_write As StreamWriter = New StreamWriter(file)
                file_write.WriteLine(name)
                file_write.WriteLine(age)
                file_write.WriteLine(address)
            End Using
        Catch ex As Exception
            Dim error_key As String = ex.ToString
            MessageBox.Show("The file can't be processed " + error_key)
        End Try

    End Sub

    Private Sub xml_button_Click(sender As Object, e As EventArgs) Handles xml_button.Click
        If age_textbox.Text.Length >= 255 Then
            MessageBox.Show("You have exceed the maximum value 255")
        End If


        name = name_textbox.Text
        age = age_textbox.Text
        address = address_textbox.Text

        file = name + ".xml"
        Try
            Using file_write As StreamWriter = New StreamWriter(file)
                file_write.WriteLine(name)
                file_write.WriteLine(age)
                file_write.WriteLine(address)
            End Using
        Catch ex As Exception
            Dim error_key As String = ex.ToString
            MessageBox.Show("The file can't be processed " + error_key)
        End Try
    End Sub

    Private Sub json_button_Click(sender As Object, e As EventArgs) Handles json_button.Click
        If age_textbox.Text.Length >= 255 Then
            MessageBox.Show("You have exceed the maximum value 255")
        End If


        name = name_textbox.Text
        age = age_textbox.Text
        address = address_textbox.Text

        file = name + ".json"
        Try
            Using file_write As StreamWriter = New StreamWriter(file)
                file_write.WriteLine(name)
                file_write.WriteLine(age)
                file_write.WriteLine(address)
            End Using
        Catch ex As Exception
            Dim error_key As String = ex.ToString
            MessageBox.Show("The file can't be processed " + error_key)
        End Try
    End Sub

    Private Sub name_textbox_TextChanged(sender As Object, e As EventArgs) Handles name_textbox.TextChanged

    End Sub
End Class
