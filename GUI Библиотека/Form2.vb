Public Class Form2
    Private Sub Выданные_книгиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Выданные_книгиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Выданные_книгиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet1.Выданные_книги". При необходимости она может быть перемещена или удалена.
        Me.Выданные_книгиTableAdapter.Fill(Me.DataSet1.Выданные_книги)

    End Sub

    Private Sub Отметка_о_возвратеCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Отметка_о_возвратеCheckBox.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class