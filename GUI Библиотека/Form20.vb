Public Class Form20
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet3._Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___". При необходимости она может быть перемещена или удалена.
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___TableAdapter.Fill(Me.DataSet3._Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___)

    End Sub
End Class