<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtAns = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnTimes = New System.Windows.Forms.Button()
        Me.btnDividedBy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAns
        '
        Me.txtAns.Location = New System.Drawing.Point(525, 262)
        Me.txtAns.Name = "txtAns"
        Me.txtAns.Size = New System.Drawing.Size(100, 26)
        Me.txtAns.TabIndex = 6
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(102, 152)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 26)
        Me.txtNum1.TabIndex = 7
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(395, 152)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 26)
        Me.txtNum2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(432, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "="
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(266, 44)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(75, 53)
        Me.btnPlus.TabIndex = 10
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(266, 103)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(75, 54)
        Me.btnMinus.TabIndex = 11
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnTimes
        '
        Me.btnTimes.Location = New System.Drawing.Point(266, 163)
        Me.btnTimes.Name = "btnTimes"
        Me.btnTimes.Size = New System.Drawing.Size(75, 55)
        Me.btnTimes.TabIndex = 12
        Me.btnTimes.Text = "*"
        Me.btnTimes.UseVisualStyleBackColor = True
        '
        'btnDividedBy
        '
        Me.btnDividedBy.Location = New System.Drawing.Point(266, 224)
        Me.btnDividedBy.Name = "btnDividedBy"
        Me.btnDividedBy.Size = New System.Drawing.Size(75, 58)
        Me.btnDividedBy.TabIndex = 13
        Me.btnDividedBy.Text = "/"
        Me.btnDividedBy.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDividedBy)
        Me.Controls.Add(Me.btnTimes)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.txtAns)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAns As TextBox
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnTimes As Button
    Friend WithEvents btnDividedBy As Button
End Class
