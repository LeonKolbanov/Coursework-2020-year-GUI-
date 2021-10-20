Public Class Form13
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet2.Книги_на_руках". При необходимости она может быть перемещена или удалена.
        Me.Книги_на_рукахTableAdapter.Fill(Me.DataSet2.Книги_на_руках)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class