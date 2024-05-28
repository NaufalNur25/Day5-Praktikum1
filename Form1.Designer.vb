<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        txtProductCode = New TextBox()
        txtProductName = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtPrice = New TextBox()
        Label5 = New Label()
        txtQty = New TextBox()
        Label6 = New Label()
        txtTotals = New TextBox()
        Label7 = New Label()
        cmbUnit = New ComboBox()
        btnTotal = New Button()
        btnClear = New Button()
        btnExit = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(411, 84)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(159, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 15)
        Label1.TabIndex = 0
        Label1.Text = "Point Of Sales"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 15)
        Label2.TabIndex = 1
        Label2.Text = "Kode Barang"
        ' 
        ' txtProductCode
        ' 
        txtProductCode.Location = New Point(160, 114)
        txtProductCode.Name = "txtProductCode"
        txtProductCode.Size = New Size(80, 23)
        txtProductCode.TabIndex = 2
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(160, 156)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(168, 23)
        txtProductName.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(59, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 15)
        Label3.TabIndex = 3
        Label3.Text = "Nama Barang"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(63, 207)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 15)
        Label4.TabIndex = 5
        Label4.Text = "Satuan"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(160, 240)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(168, 23)
        txtPrice.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(59, 248)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 15)
        Label5.TabIndex = 7
        Label5.Text = "Harga Satuan"
        ' 
        ' txtQty
        ' 
        txtQty.Location = New Point(160, 281)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(168, 23)
        txtQty.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(59, 289)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 15)
        Label6.TabIndex = 9
        Label6.Text = "Jumlah (QTY)"
        ' 
        ' txtTotals
        ' 
        txtTotals.Location = New Point(160, 321)
        txtTotals.Name = "txtTotals"
        txtTotals.Size = New Size(168, 23)
        txtTotals.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(59, 329)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 15)
        Label7.TabIndex = 11
        Label7.Text = "Total Harga"
        ' 
        ' cmbUnit
        ' 
        cmbUnit.FormattingEnabled = True
        cmbUnit.Items.AddRange(New Object() {"PCS", "LUSIN", "KODI", "KG"})
        cmbUnit.Location = New Point(160, 199)
        cmbUnit.Name = "cmbUnit"
        cmbUnit.Size = New Size(168, 23)
        cmbUnit.TabIndex = 13
        ' 
        ' btnTotal
        ' 
        btnTotal.BackColor = Color.Black
        btnTotal.FlatStyle = FlatStyle.Flat
        btnTotal.ForeColor = SystemColors.ControlLightLight
        btnTotal.Location = New Point(58, 394)
        btnTotal.Name = "btnTotal"
        btnTotal.Size = New Size(80, 32)
        btnTotal.TabIndex = 14
        btnTotal.Text = "Hitung"
        btnTotal.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Black
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.ForeColor = SystemColors.ControlLightLight
        btnClear.Location = New Point(163, 394)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(80, 32)
        btnClear.TabIndex = 15
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Black
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = SystemColors.ControlLightLight
        btnExit.Location = New Point(266, 394)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(80, 32)
        btnExit.TabIndex = 16
        btnExit.Text = "Keluar"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(410, 457)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnTotal)
        Controls.Add(cmbUnit)
        Controls.Add(txtTotals)
        Controls.Add(Label7)
        Controls.Add(txtQty)
        Controls.Add(Label6)
        Controls.Add(txtPrice)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtProductName)
        Controls.Add(Label3)
        Controls.Add(txtProductCode)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Procedure And Function"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotals As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button

End Class
