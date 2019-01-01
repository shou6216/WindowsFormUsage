Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ListViewのItemを取得
        ListView1.View = View.Details
        ListView1.Columns.Add("item", -2, HorizontalAlignment.Left)
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.HeaderStyle = ColumnHeaderStyle.None
        ListView1.MultiSelect = False

        Dim items As List(Of String) = findItems()
        For Each item As String In items
            Dim lvItem As New ListViewItem
            lvItem.Text = item
            ListView1.Items.Add(lvItem)
        Next
    End Sub

    Private Function findItems() As List(Of String)
        Dim listItems As List(Of String) = New List(Of String)
        listItems.Add("item1")
        listItems.Add("item2")
        listItems.Add("item3")
        listItems.Add("item4")
        listItems.Add("item5")
        listItems.Add("item6")
        listItems.Add("item7")
        listItems.Add("item8")
        listItems.Add("item9")
        listItems.Add("item10")
        listItems.Add("item11")
        listItems.Add("item12")
        Return listItems
    End Function

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        ' SelectedIndexChangedの仕様上イベント検知時に負数になるため
        If ListView1.SelectedItems.Count <= 0 Then
            Exit Sub
        End If

        Dim lvItem = ListView1.SelectedItems(0)
        Console.WriteLine(lvItem.Text)
    End Sub
End Class