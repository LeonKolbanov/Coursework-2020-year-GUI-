Public Class Form10
    Private Sub ИздательстваBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ИздательстваBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ИздательстваBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet1.Издательства". При необходимости она может быть перемещена или удалена.
        Me.ИздательстваTableAdapter.Fill(Me.DataSet1.Издательства)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class