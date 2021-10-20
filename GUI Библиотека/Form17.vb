Public Class Form17
    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet3.Фильтры_для_отображения_книг_отдельных_авторов". При необходимости она может быть перемещена или удалена.
        Me.Фильтры_для_отображения_книг_отдельных_авторовTableAdapter.Fill(Me.DataSet3.Фильтры_для_отображения_книг_отдельных_авторов)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class