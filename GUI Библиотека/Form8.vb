Public Class Form8
    Private Sub КнигиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles КнигиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.КнигиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet1.Книги". При необходимости она может быть перемещена или удалена.
        Me.КнигиTableAdapter.Fill(Me.DataSet1.Книги)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class