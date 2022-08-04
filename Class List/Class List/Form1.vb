Public Class frmClassList


    Public Counter As Integer
    Public Counter2 As Integer
    Public AmountArray() As String

    Private Sub frmClassList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Prevent Erro if arrays empty
        GroupBox1.Enabled = False
    End Sub
  
    Private Sub btnAmount_Click(sender As Object, e As EventArgs) Handles btnAmount.Click
        'Setup the Amount of student in the class
        Counter = CInt(txtAmount.Text) - 1

        ReDim AmountArray(Counter)

        If txtAmount.Text > 0 Then
            GroupBox1.Enabled = True
        End If

        txtAmount.Clear()

    End Sub

    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles Enter.Click
        'Enter Student into Array
        Dim K As Integer


        AmountArray(Counter2) = txtName.Text & "  " & txtSurname.Text

        lstClassList.Sorted = True
        txtName.Focus()
        txtName.Clear()
        txtSurname.Clear()

        If Counter2 = Counter Then
            MessageBox.Show("Limit was reached")
            For K = 0 To Counter
                lstClassList.Items.Add(AmountArray(K))
            Next
            Exit Sub
        End If

        Counter2 = Counter2 + 1

    End Sub

    Sub ClearTextBox()
        'Procedure to clear textbox
        txtName.Clear()
        txtSurname.Clear()
        txtAmount.Clear()
        GroupBox1.Enabled = False
        lstClassList.Items.Clear()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the textbox and listbox using an procedure
        ClearTextBox()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the program
        Me.Close()
    End Sub
End Class
