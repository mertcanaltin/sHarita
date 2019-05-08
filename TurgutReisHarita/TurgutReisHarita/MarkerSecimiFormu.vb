Imports System.Windows.Forms

Public Class MarkerSecimiFormu
    Public MarkerResim As Image
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        For Each Secim As RadioButton In Me.Controls.OfType(Of RadioButton)
            If Secim.Checked = True Then
                MarkerResim = Secim.Image
            End If
        Next
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
