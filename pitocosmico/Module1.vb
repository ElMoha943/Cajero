Imports MySql.Data.MySqlClient
Module Module1
    Public total = 0
    Public tipo As String = "efectivo"
    Public DescMastercard As String = " 7%"
    Public DescVisa As String = " 5%"
    Public connectionstring As String = "server=localhost;database=mercado;user id=mercado;password=mercado123;port=3306;"
    Public conn As New MySqlConnection(connectionstring)
    Public lista As New List(Of Producto)

End Module

Public Class Producto
    Public Sub New(nombre As String, precio As Integer)
        Me.nombre = nombre
        Me.precio = precio
        'Me.stock = stock
    End Sub

    Public Property nombre As String
    Public Property precio As Integer
    'Public Property stock As Integer

End Class