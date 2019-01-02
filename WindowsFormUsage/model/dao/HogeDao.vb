Public Class HogeDao

    Public Function findById(ByVal id As String) As Hoge
        Dim hoge As New Hoge()
        hoge.h1 = "aaaa" & id
        hoge.h2 = "bbbb" & id
        hoge.h3 = "cccc" & id
        hoge.h4 = "dddd" & id
        hoge.h5 = "eeee" & id
        hoge.h6 = "ffff" & id
        hoge.h7 = "gggg" & id
        hoge.h8 = "hhhh" & id
        hoge.h9 = "iiii" & id
        Return hoge
    End Function

End Class
