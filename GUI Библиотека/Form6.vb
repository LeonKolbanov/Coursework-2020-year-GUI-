Public Class Form6
    Private Sub ДолжностиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ДолжностиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ДолжностиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet1.Должности". При необходимости она может быть перемещена или удалена.
        Me.ДолжностиTableAdapter.Fill(Me.DataSet1.Должности)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class