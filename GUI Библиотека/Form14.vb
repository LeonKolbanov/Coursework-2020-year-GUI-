Public Class Form14
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet2.Отдел_кадров". При необходимости она может быть перемещена или удалена.
        Me.Отдел_кадровTableAdapter.Fill(Me.DataSet2.Отдел_кадров)

    End Sub
End Class