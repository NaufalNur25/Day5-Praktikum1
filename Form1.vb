Public Class Form1
    ' Procedure
    Sub clearForm()
        txtProductName.Text = ""
        txtProductCode.Text = ""
        cmbUnit.Text = ""
        txtPrice.Text = ""
        txtQty.Text = ""
        txtTotals.Text = ""

        ' Enable Form Input
        txtProductCode.Focus()
        txtTotals.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call Sub
        Call clearForm()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Call Sub
        Call clearForm()
    End Sub

    ' Procedure
    Sub formValidation()
        If txtProductCode.Text = "" Then
            MessageBox.Show("Kode Barang harus diisi.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductCode.Focus()
        ElseIf txtProductName.Text = "" Then
            MessageBox.Show("Nama Barang harus diisi.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductName.Focus()
        ElseIf cmbUnit.Text = "" Then
            MessageBox.Show("Satuan Barang harus diisi.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbUnit.Focus()
        ElseIf txtPrice.Text = "" Then
            MessageBox.Show("Harga Satuan harus diisi.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.Focus()
        ElseIf txtQty.Text = "" Then
            MessageBox.Show("Jumlah Barang harus diisi.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQty.Focus()
        Else
            ' Call Function
            Call calculate()
        End If
    End Sub

    Private Function calculate()
        ' Initialize
        Dim valQty, valPrice, valTotals As Integer

        valQty = Integer.Parse(txtQty.Text)
        valPrice = Integer.Parse(txtPrice.Text)
        valTotals = (valQty * valPrice)
        txtTotals.Text = valTotals

        Return valTotals
    End Function

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        ' Call Procedure
        Call formValidation()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Initialize
        Dim closed As String
        closed = MessageBox.Show("Yakin tutup form ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If closed = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class
