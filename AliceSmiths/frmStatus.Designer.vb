<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatus
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtIncomeRange = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIncome = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AliceSmiths.My.Resources.Resources.income
        Me.PictureBox1.Location = New System.Drawing.Point(31, 156)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 231)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtIncomeRange
        '
        Me.txtIncomeRange.Location = New System.Drawing.Point(162, 51)
        Me.txtIncomeRange.Name = "txtIncomeRange"
        Me.txtIncomeRange.Size = New System.Drawing.Size(191, 26)
        Me.txtIncomeRange.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Income Range"
        '
        'btnIncome
        '
        Me.btnIncome.Location = New System.Drawing.Point(252, 94)
        Me.btnIncome.Name = "btnIncome"
        Me.btnIncome.Size = New System.Drawing.Size(101, 56)
        Me.btnIncome.TabIndex = 3
        Me.btnIncome.Text = "Income Range"
        Me.btnIncome.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Red
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.GreenYellow
        Me.lblStatus.Location = New System.Drawing.Point(35, 409)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(210, 53)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "lblStatus"
        '
        'frmStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 489)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnIncome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIncomeRange)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmStatus"
        Me.Text = "frmStatus"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtIncomeRange As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnIncome As Button
    Friend WithEvents lblStatus As Label
End Class
