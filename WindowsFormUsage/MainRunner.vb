Module MainRunner
    <STAThread()>
    Sub Main(args As String())
        If args.Length = 0 Then
            MsgBox("画面IDを指定してください。")
            Exit Sub
        End If

        Dim screenId As String = args(0)

        MsgBox(screenId)

        Application.Run(New Form1)
    End Sub
End Module
