Imports System.Linq
Imports Newtonsoft.Json

Public Class StringHelper
    Public Shared Function Reverse(input As String) As String
        Return New String(input.ToCharArray().Reverse().ToArray())
    End Function

    Public Shared Function ToJson(value As Object) As String
        Return JsonConvert.SerializeObject(value)
    End Function
End Class
