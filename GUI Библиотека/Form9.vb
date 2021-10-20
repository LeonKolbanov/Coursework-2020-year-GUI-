Public Class Form9
    Private Sub ЧитателиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ЧитателиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ЧитателиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet1.Читатели". При необходимости она может быть перемещена или удалена.
        Me.ЧитателиTableAdapter.Fill(Me.DataSet1.Читатели)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class