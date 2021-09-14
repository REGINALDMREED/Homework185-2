Public Class MainForm
    Private lblInfoDetail As Object

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnView.Click
        'To visualize information detail of marathon
        lblInfoDetail.Visible = True
        'to disabled View button
        btnView.Enabled = False

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'To terminate window application
        Me.Close()
    End Sub

    Private Sub lblInfo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
