Public Class Form1
    ' Create a Random object called randomizer 
    ' to generate random numbers.
    Private randomizer As New Random

    ' These integer variables store the numbers 
    ' for the addition problem. 
    Private addend1 As Integer
    Private addend2 As Integer

    ' These integer variables store the numbers 
    ' for the subtraction problem. 
    Private minuend As Integer
    Private subtrahend As Integer

    ' These integer variables store the numbers 
    ' for the multiplication problem. 
    Private multiplicand As Integer
    Private multiplier As Integer

    ' These integer variables store the numbers 
    ' for the division problem. 
    Private dividend As Integer
    Private divisor As Integer

    ' This integer variable keeps track of the 
    ' remaining time.
    Private timeLeft As Integer

    ' Declare the Timer object
    Private WithEvents Timer1 As New Timer With {.Interval = 1000}

    ''' <summary>
    ''' Start the quiz by filling in all of the problems
    ''' and starting the timer.
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Public Function CheckTheAnswer() As Boolean
        If addend1 + addend2 = sum.Value AndAlso
            minuend - subtrahend = difference.Value AndAlso
            multiplicand * multiplier = product.Value AndAlso
            dividend / divisor = quotient.Value Then

            Return True
        Else
            Return False
        End If

    End Function
    ''' <summary>
    ''' Start the quiz by filling in all of the problem 
    ''' values and starting the timer. 
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If CheckTheAnswer() Then
            Timer1.Stop()
            MessageBox.Show("You got all of the answers right!", "Congratulations!")
            startButton.Enabled = True
        ElseIf timeLeft > 0 Then
            ' ลดเวลาที่เหลือ และอัปเดตข้อความใน Label
            ' Reduce the remaining time and update the label text
            timeLeft -= 1
            timeLabel.Text = timeLeft & " seconds" ' ใช้ Label แสดงเวลาที่เหลือ
            timeLabel.Refresh()
        Else
            ' เมื่อหมดเวลา
            Timer1.Stop()
            timeLabel.Text = "Time's up!"
            MessageBox.Show("You didn't finish in time.", "Sorry!")
            sum.Value = addend1 + addend2
            difference.Value = minuend - subtrahend
            product.Value = multiplicand * multiplier
            quotient.Value = dividend / divisor
            startButton.Enabled = True
        End If

    End Sub



    Public Sub StartTheQuiz()

        ' Fill in the addition problem.
        ' Generate two random numbers to add.
        ' Store the values in the variables 'addend1' and 'addend2'.
        addend1 = randomizer.Next(51)
        addend2 = randomizer.Next(51)

        ' Convert the two randomly generated numbers
        ' into strings so that they can be displayed
        ' in the label controls.
        plusLeftLabel.Text = addend1.ToString()
        plusRightLabel.Text = addend2.ToString()

        ' 'sum' is the name of the NumericUpDown control.
        ' This step makes sure its value is zero before
        ' adding any values to it.
        sum.Value = 0

        ' Fill in the subtraction problem.
        minuend = randomizer.Next(1, 101)
        subtrahend = randomizer.Next(1, minuend)
        minusLeftLabel.Text = minuend.ToString()
        minusRightLabel.Text = subtrahend.ToString()
        difference.Value = 0

        ' Fill in the multiplication problem.
        multiplicand = randomizer.Next(2, 11)
        multiplier = randomizer.Next(2, 11)
        timesLeftLabel.Text = multiplicand.ToString()
        timesRightLabel.Text = multiplier.ToString()
        product.Value = 0

        ' Fill in the division problem.
        divisor = randomizer.Next(2, 11)
        Dim temporaryQuotient As Integer = randomizer.Next(2, 11)
        dividend = divisor * temporaryQuotient
        dividedLeftLabel.Text = dividend.ToString()
        dividedRightLabel.Text = divisor.ToString()
        quotient.Value = 0

        ' ตั้งค่าเวลาที่เริ่มต้น และอัปเดตข้อความใน Label
        timeLeft = 30
        timeLabel.Text = "30 seconds" ' ใช้ Label แสดงเวลาที่เริ่มต้น
        Timer1.Start()

    End Sub

    ' Call the StartTheQuiz() method and enable
    ' the Start button. 
    Private Sub startButton_Click() Handles startButton.Click
        StartTheQuiz()
        startButton.Enabled = False
    End Sub

End Class
