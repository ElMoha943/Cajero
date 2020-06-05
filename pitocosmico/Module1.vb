Imports MySql.Data.MySqlClient
Module Module1
    Public total = 0
    Public tipo As String = "efectivo"
    Public DescMastercard As String = " 7%"
    Public DescVisa As String = " 5%"
    Public connectionstring As String = "server=localhost;database=mercado;user id=mercado;password=mercado123;port=3306;" 'CONNECTION STRING
    Public conn As New MySqlConnection(connectionstring)

End Module
