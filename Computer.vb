Public Class Computer
    Public Property Name As String
    Public Property Address As String

    Public Shared Function LoadComputers()
        Dim computersString As String = ""
        If System.IO.File.Exists("computers.csv") = True Then
            computersString = My.Computer.FileSystem.ReadAllText("computers.csv", System.Text.Encoding.UTF32)
        End If
        Dim computers As String() = computersString.Split(vbCrLf)
        ' Split file by row
        Dim computerObjects As New List(Of Computer)
        For Each computer As String In computers
            If computer <> "" Then
                Dim tmpComputer As New Computer With {
                    .Name = computer.Split(vbTab)(0),
                    .Address = computer.Split(vbTab)(1)
                }
                computerObjects.Add(tmpComputer)
            End If
        Next
        Return computerObjects
    End Function

End Class
