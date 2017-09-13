<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnPluss = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.btnPow = New System.Windows.Forms.Button()
        Me.btnPowTwo = New System.Windows.Forms.Button()
        Me.btnSqrt = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDecimal = New System.Windows.Forms.Button()
        Me.listCalculations = New System.Windows.Forms.ListBox()
        Me.btnSin = New System.Windows.Forms.Button()
        Me.btnCos = New System.Windows.Forms.Button()
        Me.btnTan = New System.Windows.Forms.Button()
        Me.btnPi = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(12, 12)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(230, 20)
        Me.txtOutput.TabIndex = 0
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(12, 38)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(30, 30)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(48, 38)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(30, 30)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(84, 38)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(30, 30)
        Me.btn3.TabIndex = 3
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(12, 74)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(30, 30)
        Me.btn4.TabIndex = 4
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(48, 74)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(30, 30)
        Me.btn5.TabIndex = 5
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(84, 74)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(30, 30)
        Me.btn6.TabIndex = 6
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(12, 110)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(30, 30)
        Me.btn7.TabIndex = 7
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(48, 110)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(30, 30)
        Me.btn8.TabIndex = 8
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(84, 110)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(30, 30)
        Me.btn9.TabIndex = 9
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(48, 146)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(30, 30)
        Me.btn0.TabIndex = 10
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnPluss
        '
        Me.btnPluss.Location = New System.Drawing.Point(167, 38)
        Me.btnPluss.Name = "btnPluss"
        Me.btnPluss.Size = New System.Drawing.Size(30, 30)
        Me.btnPluss.TabIndex = 11
        Me.btnPluss.Text = "+"
        Me.btnPluss.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(203, 38)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(30, 30)
        Me.btnMinus.TabIndex = 12
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnMult
        '
        Me.btnMult.Location = New System.Drawing.Point(167, 74)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(30, 30)
        Me.btnMult.TabIndex = 13
        Me.btnMult.Text = "*"
        Me.btnMult.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(203, 74)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(30, 30)
        Me.btnDiv.TabIndex = 14
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnEqual
        '
        Me.btnEqual.Location = New System.Drawing.Point(268, 38)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(30, 30)
        Me.btnEqual.TabIndex = 15
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = True
        '
        'btnPow
        '
        Me.btnPow.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPow.Location = New System.Drawing.Point(167, 110)
        Me.btnPow.Name = "btnPow"
        Me.btnPow.Size = New System.Drawing.Size(30, 30)
        Me.btnPow.TabIndex = 16
        Me.btnPow.Text = "X^Y"
        Me.btnPow.UseVisualStyleBackColor = True
        '
        'btnPowTwo
        '
        Me.btnPowTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPowTwo.Location = New System.Drawing.Point(203, 110)
        Me.btnPowTwo.Name = "btnPowTwo"
        Me.btnPowTwo.Size = New System.Drawing.Size(30, 30)
        Me.btnPowTwo.TabIndex = 17
        Me.btnPowTwo.Text = "X^2"
        Me.btnPowTwo.UseVisualStyleBackColor = True
        '
        'btnSqrt
        '
        Me.btnSqrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSqrt.Location = New System.Drawing.Point(167, 146)
        Me.btnSqrt.Name = "btnSqrt"
        Me.btnSqrt.Size = New System.Drawing.Size(30, 30)
        Me.btnSqrt.TabIndex = 18
        Me.btnSqrt.Text = "√"
        Me.btnSqrt.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(268, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(30, 30)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDecimal
        '
        Me.btnDecimal.Location = New System.Drawing.Point(84, 146)
        Me.btnDecimal.Name = "btnDecimal"
        Me.btnDecimal.Size = New System.Drawing.Size(30, 30)
        Me.btnDecimal.TabIndex = 20
        Me.btnDecimal.Text = "."
        Me.btnDecimal.UseVisualStyleBackColor = True
        '
        'listCalculations
        '
        Me.listCalculations.FormattingEnabled = True
        Me.listCalculations.Location = New System.Drawing.Point(12, 182)
        Me.listCalculations.Name = "listCalculations"
        Me.listCalculations.Size = New System.Drawing.Size(286, 173)
        Me.listCalculations.TabIndex = 21
        '
        'btnSin
        '
        Me.btnSin.Location = New System.Drawing.Point(131, 74)
        Me.btnSin.Name = "btnSin"
        Me.btnSin.Size = New System.Drawing.Size(30, 30)
        Me.btnSin.TabIndex = 22
        Me.btnSin.Text = "Sin"
        Me.btnSin.UseVisualStyleBackColor = True
        '
        'btnCos
        '
        Me.btnCos.Location = New System.Drawing.Point(131, 110)
        Me.btnCos.Name = "btnCos"
        Me.btnCos.Size = New System.Drawing.Size(30, 30)
        Me.btnCos.TabIndex = 23
        Me.btnCos.Text = "Cos"
        Me.btnCos.UseVisualStyleBackColor = True
        '
        'btnTan
        '
        Me.btnTan.Location = New System.Drawing.Point(131, 146)
        Me.btnTan.Name = "btnTan"
        Me.btnTan.Size = New System.Drawing.Size(30, 30)
        Me.btnTan.TabIndex = 24
        Me.btnTan.Text = "Tan"
        Me.btnTan.UseVisualStyleBackColor = True
        '
        'btnPi
        '
        Me.btnPi.Location = New System.Drawing.Point(12, 146)
        Me.btnPi.Name = "btnPi"
        Me.btnPi.Size = New System.Drawing.Size(30, 30)
        Me.btnPi.TabIndex = 25
        Me.btnPi.Text = "Π"
        Me.btnPi.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnE.Location = New System.Drawing.Point(203, 146)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(30, 30)
        Me.btnE.TabIndex = 26
        Me.btnE.Text = "e"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 360)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.btnPi)
        Me.Controls.Add(Me.btnTan)
        Me.Controls.Add(Me.btnCos)
        Me.Controls.Add(Me.btnSin)
        Me.Controls.Add(Me.listCalculations)
        Me.Controls.Add(Me.btnDecimal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSqrt)
        Me.Controls.Add(Me.btnPowTwo)
        Me.Controls.Add(Me.btnPow)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMult)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPluss)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txtOutput)
        Me.KeyPreview = True
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btnPluss As System.Windows.Forms.Button
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btnMult As System.Windows.Forms.Button
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents btnEqual As System.Windows.Forms.Button
    Friend WithEvents btnPow As System.Windows.Forms.Button
    Friend WithEvents btnPowTwo As System.Windows.Forms.Button
    Friend WithEvents btnSqrt As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDecimal As System.Windows.Forms.Button
    Friend WithEvents listCalculations As System.Windows.Forms.ListBox
    Friend WithEvents btnSin As System.Windows.Forms.Button
    Friend WithEvents btnCos As System.Windows.Forms.Button
    Friend WithEvents btnTan As System.Windows.Forms.Button
    Friend WithEvents btnPi As System.Windows.Forms.Button
    Friend WithEvents btnE As Button
End Class
