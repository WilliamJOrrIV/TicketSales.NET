Public Class From1
    Dim TicketPrices() As Integer = {65, 60, 20, 10}
    Dim Sections() As Char = {"Orchestra", "Balconey", "Mezzanine", "General Admission"}
    Dim PriceOfTicket As Integer
    Dim SectionSelected As String
    Dim TotalSale As Integer
    Dim Orchestra, Mezzanine, Balconey, General, i As Integer

    Private Sub PurchaseButton_Click(sender As Object, e As EventArgs) Handles PurchaseButton.Click

        Dim NumberOfTickets As Integer
        Dim Total As Integer

        Try

            NumberOfTickets = Integer.Parse(TicketNumberTextBox.Text)
            Total = NumberOfTickets * PriceOfTicket
            TotalTextBox.Text = Total.ToString("C")
            TotalSale = TotalSale + Total
            TotalSaleTextBox.Text = TotalSale.ToString("C")

            Summary.Items.Add(NumberOfTickets.ToString + " " + "Tickets " + "for " + SectionSelected + " Cost:  " + Total.ToString("C"))

            For i = 1 To NumberOfTickets
                If SectionSelected = Sections(0) Then
                    Orchestra = Orchestra + 1
                ElseIf SectionSelected = Sections(1) Then
                    Balconey = Balconey + 1
                ElseIf SectionSelected = Sections(2) Then
                    Mezzanine = Mezzanine + 1
                ElseIf SectionSelected = Sections(3) Then
                    General = General + 1
                End If
            Next

            TotalSales.Items.Clear()
            TotalSales.Items.Add("Orchestra Total Ticket Sales: " + Orchestra.ToString())
            TotalSales.Items.Add("Balconey Total Ticket Sales: " + Balconey.ToString())
            TotalSales.Items.Add("Mezzanine Total Ticket Sales: " + Mezzanine.ToString())
            TotalSales.Items.Add("General Admission Total Ticket Sales: " + General.ToString())


        Catch ex As FormatException
            MessageBox.Show("Can not be empty",
                                   "Data Entry Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Asterisk)
            TicketNumberTextBox.Focus()
            TicketNumberTextBox.SelectAll()
        End Try

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub OrchestraRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles OrchestraRadioButton.Click
        PriceOfTicket = TicketPrices(0)
        SectionSelected = Sections(0)
    End Sub

    Private Sub From1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MezzanineRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MezzanineRadioButton.Click
        PriceOfTicket = TicketPrices(1)
        SectionSelected = Sections(2)
    End Sub

    Private Sub GeneralRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GeneralRadioButton.Click
        PriceOfTicket = TicketPrices(2)
        SectionSelected = Sections(3)
    End Sub
    Private Sub BalconeyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BalconeyRadioButton.Click
        PriceOfTicket = TicketPrices(3)
        SectionSelected = Sections(1)
    End Sub

    Private Sub NewSaleButton_Click(sender As Object, e As EventArgs) Handles NewSaleButton.Click
        TicketNumberTextBox.Clear()
        TotalTextBox.Clear()
        BalconeyRadioButton.Checked = False
        MezzanineRadioButton.Checked = False
        GeneralRadioButton.Checked = False
        OrchestraRadioButton.Checked = False
    End Sub
End Class
