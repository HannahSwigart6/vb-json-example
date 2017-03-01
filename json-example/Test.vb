Public Class Test
    Public Property Name As String
    Public Property Points As Integer
    Public Property Description As String
    Public Property SomethingElse As Decimal

    ' This constructor gets called when you create a new instance of Test.
    ' It requires 4 arguments, and uses each argument to set the properties above.
    Public Sub New(_name As String, _points As Integer, _description As String, _somethingElse As Decimal)
        Name = _name
        Points = _points
        Description = _description
        SomethingElse = _somethingElse
    End Sub
End Class
