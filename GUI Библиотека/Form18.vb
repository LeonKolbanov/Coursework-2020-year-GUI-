Public Class Form18
    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet3._Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__". При необходимости она может быть перемещена или удалена.
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__TableAdapter.Fill(Me.DataSet3._Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class