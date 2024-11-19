
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Public Class UnitTest
    'Test Add
    Public Sub TestAdd()
        Dim opt As New Operations
        Dim a As Integer = 5
        Dim b As Integer = 5
        Dim expected As Integer = 10
        Dim actual As Integer = opt.Adds(a, b)
        Assert.AreEqual(expected, actual)
    End Sub

    'Test Subtract
    Public Sub TestSubtract()
        Dim opt As New Operations
        Dim a As Integer = 5
        Dim b As Integer = 5
        Dim expected As Integer = 0
        Dim actual As Integer = opt.Subtracts(a, b)
        Assert.AreEqual(expected, actual)
    End Sub

    'Test Multiply
    Public Sub TestMultiply()
        Dim opt As New Operations
        Dim a As Integer = 5
        Dim b As Integer = 5
        Dim expected As Integer = 25
        Dim actual As Integer = opt.Multiplies(a, b)
        Assert.AreEqual(expected, actual)
    End Sub

    'Test Divide
    Public Sub TestDivide()
        Dim opt As New Operations
        Dim a As Integer = 5
        Dim b As Integer = 5
        Dim expected As Integer = 1
        Dim actual As Integer = opt.Divides(a, b)
        Assert.AreEqual(expected, actual)
    End Sub

    'Test Modulus
    Public Sub TestModulus()
        Dim opt As New Operations
        Dim a As Integer = 5
        Dim b As Integer = 5
        Dim expected As Integer = 0
        Dim actual As Integer = opt.Modulus(a, b)
        Assert.AreEqual(expected, actual)
    End Sub

    'Test All
    Public Sub TestAll()
        TestAdd()
        TestSubtract()
        TestMultiply()
        TestDivide()
        TestModulus()
    End Sub
End Class
