Public MustInherit Class Sample
    Public Overridable Sub VeEthod()
        Console.WriteLine("Sample")
    End Sub

    Public MustOverride Function Add() As Integer

    Public Sub Normal()
        Console.WriteLine("Normal")
    End Sub
End Class

Public Class SubClass
    Inherits Sample
    Private n1 As Integer
    Public Property Num1() As Integer
        Get
            Return n1
        End Get
        Set(ByVal value As Integer)
            n1 = value
        End Set
    End Property

    Private n2 As Integer
    Public Property Num2() As Integer
        Get
            Return n2
        End Get
        Set(ByVal value As Integer)
            n2 = value
        End Set
    End Property
    Public Overrides Sub VeEthod()
        Console.WriteLine("SubClass")
        MyBase.VeEthod()

    End Sub

    Public Overrides Function Add() As Integer
        Console.WriteLine($"{Num2 + Num1}")
    End Function

    Public Shadows Sub Normal()
        Console.WriteLine("majedaar zindagi")
    End Sub
End Class
