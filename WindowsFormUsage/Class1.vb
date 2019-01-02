Public Class Class1
    Inherits Form2

    Public Sub New()
        Me.Text = "画面BBB"
    End Sub

    Protected Overrides Sub updateInfo(id As String)
        Dim hoge As Hoge = HogeDao.findById(id)
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
        listItems.Add("BBBitem1")
        listItems.Add("BBBitem2")
        listItems.Add("BBBitem3")
        listItems.Add("BBBitem4")
        listItems.Add("BBBitem5")
        listItems.Add("BBBitem6")
        listItems.Add("BBBitem7")
        listItems.Add("BBBitem8")
        listItems.Add("BBBitem9")
        listItems.Add("BBBitem10")
        listItems.Add("BBBitem11")
        listItems.Add("BBBitem12")
        Return listItems
    End Function
End Class
