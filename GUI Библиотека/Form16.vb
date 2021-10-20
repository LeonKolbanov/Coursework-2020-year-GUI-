Public Class Form16
    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet3.Фильтры_для_отображения_книг_на_руках_отдельных_читателей". При необходимости она может быть перемещена или удалена.
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейTableAdapter.Fill(Me.DataSet3.Фильтры_для_отображения_книг_на_руках_отдельных_читателей)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class