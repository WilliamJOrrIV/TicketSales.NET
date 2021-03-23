<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class From1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OrchestraRadioButton = New System.Windows.Forms.RadioButton()
        Me.MezzanineRadioButton = New System.Windows.Forms.RadioButton()
        Me.GeneralRadioButton = New System.Windows.Forms.RadioButton()
        Me.BalconeyRadioButton = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TicketNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PurchaseButton = New System.Windows.Forms.Button()
        Me.Summary = New System.Windows.Forms.ListBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.NewSaleButton = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TotalSaleTextBox = New System.Windows.Forms.TextBox()
        Me.TotalSales = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Select Ticket"
        '
        'OrchestraRadioButton
        '
        Me.OrchestraRadioButton.AutoSize = True
        Me.OrchestraRadioButton.Location = New System.Drawing.Point(13, 80)
        Me.OrchestraRadioButton.Name = "OrchestraRadioButton"
        Me.OrchestraRadioButton.Size = New System.Drawing.Size(113, 21)
        Me.OrchestraRadioButton.TabIndex = 1
        Me.OrchestraRadioButton.TabStop = True
        Me.OrchestraRadioButton.Text = "Orchetra $65"
        Me.OrchestraRadioButton.UseVisualStyleBackColor = True
        '
        'MezzanineRadioButton
        '
        Me.MezzanineRadioButton.AutoSize = True
        Me.MezzanineRadioButton.Location = New System.Drawing.Point(13, 107)
        Me.MezzanineRadioButton.Name = "MezzanineRadioButton"
        Me.MezzanineRadioButton.Size = New System.Drawing.Size(129, 21)
        Me.MezzanineRadioButton.TabIndex = 2
        Me.MezzanineRadioButton.TabStop = True
        Me.MezzanineRadioButton.Text = "Mezzanine  $60"
        Me.MezzanineRadioButton.UseVisualStyleBackColor = True
        '
        'GeneralRadioButton
        '
        Me.GeneralRadioButton.AutoSize = True
        Me.GeneralRadioButton.Location = New System.Drawing.Point(12, 134)
        Me.GeneralRadioButton.Name = "GeneralRadioButton"
        Me.GeneralRadioButton.Size = New System.Drawing.Size(108, 21)
        Me.GeneralRadioButton.TabIndex = 3
        Me.GeneralRadioButton.TabStop = True
        Me.GeneralRadioButton.Text = "General $20"
        Me.GeneralRadioButton.UseVisualStyleBackColor = True
        '
        'BalconeyRadioButton
        '
        Me.BalconeyRadioButton.AutoSize = True
        Me.BalconeyRadioButton.Location = New System.Drawing.Point(13, 161)
        Me.BalconeyRadioButton.Name = "BalconeyRadioButton"
        Me.BalconeyRadioButton.Size = New System.Drawing.Size(115, 21)
        Me.BalconeyRadioButton.TabIndex = 4
        Me.BalconeyRadioButton.TabStop = True
        Me.BalconeyRadioButton.Text = "Balconey $10"
        Me.BalconeyRadioButton.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(13, 199)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(123, 22)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "Number of Tickets"
        '
        'TicketNumberTextBox
        '
        Me.TicketNumberTextBox.Location = New System.Drawing.Point(142, 199)
        Me.TicketNumberTextBox.Name = "TicketNumberTextBox"
        Me.TicketNumberTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TicketNumberTextBox.TabIndex = 6
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(29, 511)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(61, 23)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PurchaseButton
        '
        Me.PurchaseButton.Location = New System.Drawing.Point(385, 511)
        Me.PurchaseButton.Name = "PurchaseButton"
        Me.PurchaseButton.Size = New System.Drawing.Size(100, 23)
        Me.PurchaseButton.TabIndex = 8
        Me.PurchaseButton.Text = "Purchase"
        Me.PurchaseButton.UseVisualStyleBackColor = True
        '
        'Summary
        '
        Me.Summary.FormattingEnabled = True
        Me.Summary.ItemHeight = 16
        Me.Summary.Location = New System.Drawing.Point(12, 260)
        Me.Summary.Name = "Summary"
        Me.Summary.Size = New System.Drawing.Size(230, 148)
        Me.Summary.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 427)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(78, 22)
        Me.TextBox3.TabIndex = 10
        Me.TextBox3.Text = "Final Price:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(102, 427)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TotalTextBox.TabIndex = 11
        '
        'NewSaleButton
        '
        Me.NewSaleButton.Location = New System.Drawing.Point(188, 511)
        Me.NewSaleButton.Name = "NewSaleButton"
        Me.NewSaleButton.Size = New System.Drawing.Size(89, 23)
        Me.NewSaleButton.TabIndex = 12
        Me.NewSaleButton.Text = "New Sale"
        Me.NewSaleButton.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(6, 469)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(84, 22)
        Me.TextBox4.TabIndex = 13
        Me.TextBox4.Text = "Total Sales"
        '
        'TotalSaleTextBox
        '
        Me.TotalSaleTextBox.Location = New System.Drawing.Point(102, 468)
        Me.TotalSaleTextBox.Name = "TotalSaleTextBox"
        Me.TotalSaleTextBox.ReadOnly = True
        Me.TotalSaleTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TotalSaleTextBox.TabIndex = 14
        '
        'TotalSales
        '
        Me.TotalSales.FormattingEnabled = True
        Me.TotalSales.ItemHeight = 16
        Me.TotalSales.Location = New System.Drawing.Point(248, 260)
        Me.TotalSales.Name = "TotalSales"
        Me.TotalSales.Size = New System.Drawing.Size(269, 148)
        Me.TotalSales.TabIndex = 15
        '
        'From1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 546)
        Me.Controls.Add(Me.TotalSales)
        Me.Controls.Add(Me.TotalSaleTextBox)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.NewSaleButton)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Summary)
        Me.Controls.Add(Me.PurchaseButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.TicketNumberTextBox)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.BalconeyRadioButton)
        Me.Controls.Add(Me.GeneralRadioButton)
        Me.Controls.Add(Me.MezzanineRadioButton)
        Me.Controls.Add(Me.OrchestraRadioButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "From1"
        Me.Text = "Ticket Sales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents OrchestraRadioButton As RadioButton
    Friend WithEvents MezzanineRadioButton As RadioButton
    Friend WithEvents GeneralRadioButton As RadioButton
    Friend WithEvents BalconeyRadioButton As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TicketNumberTextBox As TextBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents PurchaseButton As Button
    Friend WithEvents Summary As ListBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents NewSaleButton As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TotalSaleTextBox As TextBox
    Friend WithEvents TotalSales As ListBox
End Class
