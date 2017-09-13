Imports System
Imports System.Math
Imports System.Windows.Forms


Public Class Calculator
    Private operand1 As Double
    Private op As Char
    Private Sub clearTextbox()
        txtOutput.Clear()
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtOutput.Text += "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtOutput.Text += "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtOutput.Text += "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtOutput.Text += "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtOutput.Text += "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtOutput.Text += "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtOutput.Text += "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtOutput.Text += "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtOutput.Text += "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtOutput.Text += "0"
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        txtOutput.Text += "."
    End Sub

    Private Sub btnPluss_Click(sender As Object, e As EventArgs) Handles btnPluss.Click
        op = "+"
        operand1 = txtOutput.Text
        clearTextbox()
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        op = "-"
        operand1 = txtOutput.Text
        clearTextbox()
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        op = "*"
        operand1 = txtOutput.Text
        clearTextbox()
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        op = "/"
        operand1 = txtOutput.Text
        clearTextbox()
    End Sub

    Private Sub btnPow_Click(sender As Object, e As EventArgs) Handles btnPow.Click
        op = "^"
        operand1 = txtOutput.Text
        clearTextbox()
    End Sub

    Private Sub btnPowTwo_Click(sender As Object, e As EventArgs) Handles btnPowTwo.Click
        Dim str As String
        str = txtOutput.Text + " ^ 2"
        txtOutput.Text = Pow(txtOutput.Text, 2)
        listCalculations.Items.Add(str + " = " + txtOutput.Text)
    End Sub

    Private Sub btnSin_Click(sender As Object, e As EventArgs) Handles btnSin.Click
        Dim str As String
        str = "sin(" + txtOutput.Text + ")"
        txtOutput.Text = Sin(txtOutput.Text)
        listCalculations.Items.Add(str + " = " + txtOutput.Text)
    End Sub

    Private Sub btnCos_Click(sender As Object, e As EventArgs) Handles btnCos.Click
        Dim str As String
        str = "cos(" + txtOutput.Text + ")"
        txtOutput.Text = Cos(txtOutput.Text)
        listCalculations.Items.Add(str + " = " + txtOutput.Text)
    End Sub

    Private Sub btnTan_Click(sender As Object, e As EventArgs) Handles btnTan.Click
        Dim str As String
        str = "tan(" + txtOutput.Text + ")"
        txtOutput.Text = Tan(txtOutput.Text)
        listCalculations.Items.Add(str + " = " + txtOutput.Text)
    End Sub

    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        Dim str As String
        str = "v" + txtOutput.Text
        txtOutput.Text = Sqrt(txtOutput.Text)
        listCalculations.Items.Add(str + " = " + txtOutput.Text)
    End Sub

    'Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
    '
    '    Select Case KeyCode
    '        Case vbKeyE : Command1_Click()
    '        Case vbKeyF : Command2_Click()
    '        Case Else
    '            Exit Sub 'let the keycode pass to the form
    '    End Select
    '
    '    KeyCode = 0 'discard the key
    'End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.NumPad0
                btn0_Click(sender, e)
            Case Keys.NumPad1
                btn1_Click(sender, e)
            Case Keys.NumPad2
                btn2_Click(sender, e)
            Case Keys.NumPad3
                btn3_Click(sender, e)
            Case Keys.NumPad4
                btn4_Click(sender, e)
            Case Keys.NumPad5
                btn5_Click(sender, e)
            Case Keys.NumPad6
                btn6_Click(sender, e)
            Case Keys.NumPad7
                btn7_Click(sender, e)
            Case Keys.NumPad8
                btn8_Click(sender, e)
            Case Keys.NumPad9
                btn9_Click(sender, e)
            Case Keys.Enter
                btnEqual_Click(sender, e)
            Case Keys.Add
                btnPluss_Click(sender, e)
            Case Keys.Subtract
                btnMinus_Click(sender, e)
            Case Keys.Multiply
                btnMult_Click(sender, e)
            Case Keys.Divide
                btnDiv_Click(sender, e)
            Case Keys.Delete
                txtOutput.Clear()
            Case Keys.Decimal
                btnDecimal_Click(sender, e)
            Case Keys.V
                btnSqrt_Click(sender, e)


        End Select
        If e.KeyCode = Keys.NumPad0 Then
            btn0_Click(sender, e)
        End If
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim str As String
        str = CStr(operand1) + " " + op + " " + txtOutput.Text
        Select Case op
            Case "+"
                txtOutput.Text = operand1 + txtOutput.Text
            Case "-"
                txtOutput.Text = operand1 - txtOutput.Text
            Case "*"
                txtOutput.Text = operand1 * txtOutput.Text
            Case "/"
                txtOutput.Text = operand1 / txtOutput.Text
            Case "^"
                txtOutput.Text = Pow(operand1, txtOutput.Text)

        End Select
        listCalculations.Items.Add(str + " = " + txtOutput.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOutput.Clear()
    End Sub

    Private Sub btnPi_Click(sender As Object, e As EventArgs) Handles btnPi.Click
        txtOutput.Text = PI
    End Sub
End Class
