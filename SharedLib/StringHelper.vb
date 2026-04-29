Public Class StringHelper
    Public Shared Function Reverse(input As String) As String
        Return New String(input.ToCharArray().Reverse().ToArray())
    End Function
End Class
