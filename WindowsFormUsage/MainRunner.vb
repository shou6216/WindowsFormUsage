Module MainRunner

    Private Const ID_AAA As String = "AAA"
    Private Const ID_BBB As String = "BBB"
    Private Const ID_CCC As String = "CCC"

    <STAThread()>
    Sub Main(args As String())
        If args.Length = 0 Then
            MsgBox("IDを指定してください。")
            Exit Sub
        End If

        Dim id As String = args(0)
        Select Case id
            Case ID_AAA
                ' 画面AAA起動
                Application.Run(New Form1)
            Case ID_BBB
                ' 画面BBB起動
                Application.Run(New Class1)
            Case ID_CCC
                ' 画面CCC起動
                Application.Run(New Class2)
            Case Else
                ' 指定IDがない場合
                MsgBox("指定IDの画面はありません。")
        End Select
    End Sub
End Module
