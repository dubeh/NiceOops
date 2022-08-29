Imports System

Module Program
    Sub Main(args As String())
        NewMethod()
        print(Names())

        Dim obj As New SubClass With {.Num1 = 100, .Num2 = 200}
        obj.Add()
        obj.Normal()
    End Sub

    Private Sub NewMethod()
        Console.WriteLine("Write comma seperated inputs")
        Dim input As String = Console.ReadLine()
        Dim arr As String() = input.Split(",")
        For Each item As String In arr
            If item.Contains("zzz") Then
                Exit For
            End If
            Console.WriteLine(item)
        Next
    End Sub

    Public Function Names() As List(Of String)
        Dim lst As New List(Of String)
        lst.Add("enna")
        lst.Add("meena")
        Return lst
    End Function

    Public Sub print(lst As List(Of String))
        For Each item As String In lst
            Console.WriteLine(item)
        Next
    End Sub


End Module
