<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetailPriceCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblWholesaleCost = New System.Windows.Forms.Label()
        Me.tbxWholesaleCost = New System.Windows.Forms.TextBox()
        Me.tbxMarkup = New System.Windows.Forms.TextBox()
        Me.lblMarkup = New System.Windows.Forms.Label()
        Me.tbxRetail = New System.Windows.Forms.TextBox()
        Me.lblRetail = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWholesaleCost
        '
        Me.lblWholesaleCost.AutoSize = True
        Me.lblWholesaleCost.Location = New System.Drawing.Point(17, 60)
        Me.lblWholesaleCost.Name = "lblWholesaleCost"
        Me.lblWholesaleCost.Size = New System.Drawing.Size(165, 25)
        Me.lblWholesaleCost.TabIndex = 0
        Me.lblWholesaleCost.Text = "&Wholesale cost:"
        Me.lblWholesaleCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbxWholesaleCost
        '
        Me.tbxWholesaleCost.Location = New System.Drawing.Point(188, 57)
        Me.tbxWholesaleCost.Name = "tbxWholesaleCost"
        Me.tbxWholesaleCost.Size = New System.Drawing.Size(167, 31)
        Me.tbxWholesaleCost.TabIndex = 1
        '
        'tbxMarkup
        '
        Me.tbxMarkup.Location = New System.Drawing.Point(188, 105)
        Me.tbxMarkup.Name = "tbxMarkup"
        Me.tbxMarkup.Size = New System.Drawing.Size(167, 31)
        Me.tbxMarkup.TabIndex = 3
        '
        'lblMarkup
        '
        Me.lblMarkup.AutoSize = True
        Me.lblMarkup.Location = New System.Drawing.Point(67, 108)
        Me.lblMarkup.Name = "lblMarkup"
        Me.lblMarkup.Size = New System.Drawing.Size(115, 25)
        Me.lblMarkup.TabIndex = 2
        Me.lblMarkup.Text = "&Markup %:"
        Me.lblMarkup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbxRetail
        '
        Me.tbxRetail.Location = New System.Drawing.Point(188, 154)
        Me.tbxRetail.Name = "tbxRetail"
        Me.tbxRetail.ReadOnly = True
        Me.tbxRetail.Size = New System.Drawing.Size(167, 31)
        Me.tbxRetail.TabIndex = 5
        '
        'lblRetail
        '
        Me.lblRetail.AutoSize = True
        Me.lblRetail.Location = New System.Drawing.Point(56, 157)
        Me.lblRetail.Name = "lblRetail"
        Me.lblRetail.Size = New System.Drawing.Size(126, 25)
        Me.lblRetail.TabIndex = 4
        Me.lblRetail.Text = "Retail price:"
        Me.lblRetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(220, 214)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(135, 62)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(61, 214)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(135, 62)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(82, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(225, 25)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Retail Price Calculator"
        '
        'RetailPriceCalculator
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(385, 304)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.tbxRetail)
        Me.Controls.Add(Me.lblRetail)
        Me.Controls.Add(Me.tbxMarkup)
        Me.Controls.Add(Me.lblMarkup)
        Me.Controls.Add(Me.tbxWholesaleCost)
        Me.Controls.Add(Me.lblWholesaleCost)
        Me.Name = "RetailPriceCalculator"
        Me.Text = "Retail Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWholesaleCost As Label
    Friend WithEvents tbxWholesaleCost As TextBox
    Friend WithEvents tbxMarkup As TextBox
    Friend WithEvents lblMarkup As Label
    Friend WithEvents tbxRetail As TextBox
    Friend WithEvents lblRetail As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblTitle As Label
End Class
