Option Strict On

Public Class Server
    Public Property Name As String
    Public Property Location As String
    Public Property Connection As String

    Public Sub New(ByVal name As String, ByVal location As String, ByVal connection As String)
        Me.Name = name
        Me.Location = location
        Me.Connection = connection
    End Sub

    Public Function StatusReport(ByVal mode As String) As String
        If String.Equals(mode, "ONLINE", StringComparison.OrdinalIgnoreCase) Then
            Return "🟢 Server is ONLINE"
        Else
            Return "🔴 Server is OFFLINE"
        End If
    End Function
End Class
