Public Class frmStatus
    Private Sub frmStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatus.Visible = False
    End Sub

    Private Sub btnIncome_Click(sender As Object, e As EventArgs) Handles btnIncome.Click
        Dim income As Decimal = Val(txtIncomeRange.Text)
        checkRange(income)
    End Sub

    Sub checkRange(ByVal income As Decimal)
        lblStatus.Visible = True
        If income >= 4200 Then
            lblStatus.Text = "T20"
        ElseIf income > 1400 Then
            lblStatus.Text = "M40"
        Else
            lblStatus.Text = "B40"
        End If
    End Sub
End Class