Public Class Form19
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet3.Фильтры_для_отображения_книг_отдельных_издательств". При необходимости она может быть перемещена или удалена.
        Me.Фильтры_для_отображения_книг_отдельных_издательствTableAdapter.Fill(Me.DataSet3.Фильтры_для_отображения_книг_отдельных_издательств)

    End Sub
End Class