Public MustInherit Class Form2

    Protected hogeDao As New HogeDao()

    Protected MustOverride Function findItems() As List(Of String)
    Protected MustOverride Sub updateInfo(id As String)


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ListViewの初期化
        ListView1.View = View.Details
        ListView1.Columns.Add("item", -2, HorizontalAlignment.Left)
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.HeaderStyle = ColumnHeaderStyle.None
        ListView1.MultiSelect = False
        ' ComboBoxの初期化
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList

        ' ListViewのItemを取得
        Dim items As List(Of String) = findItems()
        For Each item As String In items
            Dim lvItem As New ListViewItem
            lvItem.Text = item
            ListView1.Items.Add(lvItem)
        Next
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        ' SelectedIndexChangedの仕様上イベント検知時に負数になるため
        If ListView1.SelectedItems.Count <= 0 Then
            Exit Sub
        End If

        Dim lvItem = ListView1.SelectedItems(0)
        Dim id = lvItem.Text

        ' 取得情報更新
        updateInfo(id)

        ' 選択項目更新
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        ComboBox1.Items.Add("input1" & id)
        ComboBox1.Items.Add("input2" & id)
        ComboBox1.Items.Add("input3" & id)
        ComboBox1.Items.Add("input4" & id)
    End Sub

    ' 入力1の選択項目変更イベント
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        ' 入力1の選択項目名設定
        Dim cbItem = ComboBox1.SelectedItem
        TextBox11.Text = cbItem & "Name"

        ' 選択項目更新
        ComboBox2.Items.Clear()
        TextBox12.Clear()
        ComboBox2.Items.Add("input1" & cbItem)
        ComboBox2.Items.Add("input2" & cbItem)
        ComboBox2.Items.Add("input3" & cbItem)
        ComboBox2.Items.Add("input4" & cbItem)
    End Sub

    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        ' 入力2の選択項目名設定
        Dim cbItem = ComboBox2.SelectedItem
        TextBox12.Text = cbItem & "Name"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (String.IsNullOrEmpty(TextBox11.Text) _
                And String.IsNullOrEmpty(TextBox12.Text) _
                And String.IsNullOrEmpty(TextBox9.Text)
                ) Then
            Me.Close()
        End If

        Dim closeResult As DialogResult = MessageBox.Show("閉じてもいい?",
                                                     "確認",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Information,
                                                     MessageBoxDefaultButton.Button2)

        If closeResult = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class