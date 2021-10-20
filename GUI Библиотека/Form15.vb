Public Class Form15
    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet3.Фильтр_для_отображения_отдельных_должностей". При необходимости она может быть перемещена или удалена.
        Me.Фильтр_для_отображения_отдельных_должностейTableAdapter.Fill(Me.DataSet3.Фильтр_для_отображения_отдельных_должностей)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class