Public Class Form7
    Private Sub ЖанрыBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ЖанрыBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ЖанрыBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet1.Жанры". При необходимости она может быть перемещена или удалена.
        Me.ЖанрыTableAdapter.Fill(Me.DataSet1.Жанры)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub
End Class