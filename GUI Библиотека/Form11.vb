Public Class Form11
    Private Sub СотрудникиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles СотрудникиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.СотрудникиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
        Me.СотрудникиTableAdapter.Fill(Me.DataSet1.Сотрудники)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class