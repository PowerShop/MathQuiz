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
        timeLabel = New Label()
        Label1 = New Label()
        plusLeftLabel = New Label()
        plusRightLabel = New Label()
        Label3 = New Label()
        Label4 = New Label()
        minusRightLabel = New Label()
        minusLeftLabel = New Label()
        Label7 = New Label()
        timesRightLabel = New Label()
        timesLeftLabel = New Label()
        Label10 = New Label()
        dividedRightLabel = New Label()
        dividedLeftLabel = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        sum = New NumericUpDown()
        quotient = New NumericUpDown()
        product = New NumericUpDown()
        difference = New NumericUpDown()
        startButton = New Button()
        Label2 = New Label()
        CType(sum, ComponentModel.ISupportInitialize).BeginInit()
        CType(quotient, ComponentModel.ISupportInitialize).BeginInit()
        CType(product, ComponentModel.ISupportInitialize).BeginInit()
        CType(difference, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' timeLabel
        ' 
        timeLabel.BorderStyle = BorderStyle.FixedSingle
        timeLabel.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        timeLabel.Location = New Point(588, 11)
        timeLabel.Name = "timeLabel"
        timeLabel.Size = New Size(200, 37)
        timeLabel.TabIndex = 0
        timeLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        Label1.Location = New Point(463, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 29)
        Label1.TabIndex = 1
        Label1.Text = "Time Left"
        ' 
        ' plusLeftLabel
        ' 
        plusLeftLabel.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        plusLeftLabel.Location = New Point(175, 74)
        plusLeftLabel.Name = "plusLeftLabel"
        plusLeftLabel.Size = New Size(60, 62)
        plusLeftLabel.TabIndex = 2
        plusLeftLabel.Text = "?"
        plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' plusRightLabel
        ' 
        plusRightLabel.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        plusRightLabel.Location = New Point(366, 74)
        plusRightLabel.Name = "plusRightLabel"
        plusRightLabel.Size = New Size(60, 62)
        plusRightLabel.TabIndex = 3
        plusRightLabel.Text = "?"
        plusRightLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        Label3.Location = New Point(265, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 62)
        Label3.TabIndex = 4
        Label3.Text = "+"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        Label4.Location = New Point(265, 180)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 62)
        Label4.TabIndex = 7
        Label4.Text = "-"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' minusRightLabel
        ' 
        minusRightLabel.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        minusRightLabel.Location = New Point(366, 180)
        minusRightLabel.Name = "minusRightLabel"
        minusRightLabel.Size = New Size(60, 62)
        minusRightLabel.TabIndex = 6
        minusRightLabel.Text = "?"
        minusRightLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' minusLeftLabel
        ' 
        minusLeftLabel.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        minusLeftLabel.Location = New Point(175, 180)
        minusLeftLabel.Name = "minusLeftLabel"
        minusLeftLabel.Size = New Size(60, 62)
        minusLeftLabel.TabIndex = 5
        minusLeftLabel.Text = "?"
        minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        Label7.Location = New Point(265, 282)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 62)
        Label7.TabIndex = 10
        Label7.Text = "x"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' timesRightLabel
        ' 
        timesRightLabel.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        timesRightLabel.Location = New Point(366, 282)
        timesRightLabel.Name = "timesRightLabel"
        timesRightLabel.Size = New Size(60, 62)
        timesRightLabel.TabIndex = 9
        timesRightLabel.Text = "?"
        timesRightLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' timesLeftLabel
        ' 
        timesLeftLabel.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        timesLeftLabel.Location = New Point(175, 282)
        timesLeftLabel.Name = "timesLeftLabel"
        timesLeftLabel.Size = New Size(60, 62)
        timesLeftLabel.TabIndex = 8
        timesLeftLabel.Text = "?"
        timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        Label10.Location = New Point(265, 380)
        Label10.Name = "Label10"
        Label10.Size = New Size(60, 62)
        Label10.TabIndex = 13
        Label10.Text = "/"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dividedRightLabel
        ' 
        dividedRightLabel.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        dividedRightLabel.Location = New Point(366, 380)
        dividedRightLabel.Name = "dividedRightLabel"
        dividedRightLabel.Size = New Size(60, 62)
        dividedRightLabel.TabIndex = 12
        dividedRightLabel.Text = "?"
        dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dividedLeftLabel
        ' 
        dividedLeftLabel.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        dividedLeftLabel.Location = New Point(175, 380)
        dividedLeftLabel.Name = "dividedLeftLabel"
        dividedLeftLabel.Size = New Size(60, 62)
        dividedLeftLabel.TabIndex = 11
        dividedLeftLabel.Text = "?"
        dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label13
        ' 
        Label13.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        Label13.Location = New Point(451, 74)
        Label13.Name = "Label13"
        Label13.Size = New Size(60, 62)
        Label13.TabIndex = 14
        Label13.Text = "="
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label14
        ' 
        Label14.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        Label14.Location = New Point(451, 380)
        Label14.Name = "Label14"
        Label14.Size = New Size(60, 62)
        Label14.TabIndex = 15
        Label14.Text = "="
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label15
        ' 
        Label15.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        Label15.Location = New Point(451, 282)
        Label15.Name = "Label15"
        Label15.Size = New Size(60, 62)
        Label15.TabIndex = 16
        Label15.Text = "="
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label16
        ' 
        Label16.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        Label16.Location = New Point(451, 180)
        Label16.Name = "Label16"
        Label16.Size = New Size(60, 62)
        Label16.TabIndex = 17
        Label16.Text = "="
        Label16.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' sum
        ' 
        sum.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        sum.Location = New Point(546, 80)
        sum.Margin = New Padding(3, 4, 3, 4)
        sum.MaximumSize = New Size(100, 0)
        sum.Name = "sum"
        sum.Size = New Size(100, 41)
        sum.TabIndex = 1
        ' 
        ' quotient
        ' 
        quotient.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        quotient.Location = New Point(546, 386)
        quotient.Margin = New Padding(3, 4, 3, 4)
        quotient.MaximumSize = New Size(100, 0)
        quotient.Name = "quotient"
        quotient.Size = New Size(100, 41)
        quotient.TabIndex = 4
        ' 
        ' product
        ' 
        product.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        product.Location = New Point(546, 289)
        product.Margin = New Padding(3, 4, 3, 4)
        product.MaximumSize = New Size(100, 0)
        product.Name = "product"
        product.Size = New Size(100, 41)
        product.TabIndex = 3
        ' 
        ' difference
        ' 
        difference.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        difference.Location = New Point(546, 186)
        difference.Margin = New Padding(3, 4, 3, 4)
        difference.MaximumSize = New Size(100, 0)
        difference.Name = "difference"
        difference.Size = New Size(100, 41)
        difference.TabIndex = 2
        ' 
        ' startButton
        ' 
        startButton.AutoSize = True
        startButton.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(254))
        startButton.Location = New Point(332, 472)
        startButton.Margin = New Padding(3, 4, 3, 4)
        startButton.Name = "startButton"
        startButton.Size = New Size(169, 58)
        startButton.TabIndex = 0
        startButton.Text = "Start the quiz"
        startButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(55, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 18
        Label2.Text = "Label2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 562)
        Controls.Add(Label2)
        Controls.Add(startButton)
        Controls.Add(difference)
        Controls.Add(product)
        Controls.Add(quotient)
        Controls.Add(sum)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label10)
        Controls.Add(dividedRightLabel)
        Controls.Add(dividedLeftLabel)
        Controls.Add(Label7)
        Controls.Add(timesRightLabel)
        Controls.Add(timesLeftLabel)
        Controls.Add(Label4)
        Controls.Add(minusRightLabel)
        Controls.Add(minusLeftLabel)
        Controls.Add(Label3)
        Controls.Add(plusRightLabel)
        Controls.Add(plusLeftLabel)
        Controls.Add(Label1)
        Controls.Add(timeLabel)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Math Quiz"
        CType(sum, ComponentModel.ISupportInitialize).EndInit()
        CType(quotient, ComponentModel.ISupportInitialize).EndInit()
        CType(product, ComponentModel.ISupportInitialize).EndInit()
        CType(difference, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents timeLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents plusLeftLabel As Label
    Friend WithEvents plusRightLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents minusRightLabel As Label
    Friend WithEvents minusLeftLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents timesRightLabel As Label
    Friend WithEvents timesLeftLabel As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dividedRightLabel As Label
    Friend WithEvents dividedLeftLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents sum As NumericUpDown
    Friend WithEvents quotient As NumericUpDown
    Friend WithEvents product As NumericUpDown
    Friend WithEvents difference As NumericUpDown
    Friend WithEvents startButton As Button
    Friend WithEvents Label2 As Label
End Class
