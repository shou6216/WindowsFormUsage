Public Class Class2
    Inherits Form2

    Public Sub New()
        Me.Text = "画面CCC"
    End Sub

    Protected Overrides Sub updateInfo(id As String)
        Dim hoge As Hoge = hogeDao.findById(id)
        TextBox1.Text = hoge.h1
        TextBox2.Text = hoge.h2
        TextBox3.Text = hoge.h3
        TextBox4.Text = hoge.h4
        TextBox5.Text = hoge.h5
        TextBox6.Text = hoge.h6
        TextBox7.Text = hoge.h7
        TextBox8.Text = hoge.h8
        TextBox10.Text = hoge.h9
    End Sub

    Protected Overrides Function findItems() As List(Of String)
        Dim listItems As List(Of String) = New List(Of String)
        listItems.Add("CCCitem1")
        listItems.Add("CCCitem2")
        listItems.Add("CCCitem3")
        listItems.Add("CCCitem4")
        listItems.Add("CCCitem5")
        listItems.Add("CCCitem6")
        listItems.Add("CCCitem7")
        listItems.Add("CCCitem8")
        listItems.Add("CCCitem9")
        listItems.Add("CCCitem10")
        listItems.Add("CCCitem11")
        listItems.Add("CCCitem12")
        Return listItems
    End Function
End Class
