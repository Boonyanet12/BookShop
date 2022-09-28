Public Class fr_main
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        fr_login.Show()
        Me.Hide()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        fr_customer.MdiParent = fr_main.ActiveForm
        fr_customer.Dock = DockStyle.Fill
        fr_customer.Show()

    End Sub

    Private Sub BookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem.Click
        fr_book.MdiParent = fr_main.ActiveForm
        fr_book.Dock = DockStyle.Fill
        fr_book.Show()
    End Sub

    Private Sub SaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaleToolStripMenuItem.Click
        fr_sale.MdiParent = fr_main.ActiveForm
        fr_sale.Dock = DockStyle.Fill
        fr_sale.Show()
    End Sub
End Class
