Public Class ListadoNadadoresXClub

    Private Sub ListadoClubes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ds_nadxclub.Nadadores' Puede moverla o quitarla según sea necesario.
        Me.NadadoresTableAdapter.Fill(Me.ds_nadxclub.Nadadores)
        'TODO: esta línea de código carga datos en la tabla 'ds_nadxclub.Nadadores' Puede moverla o quitarla según sea necesario.
        Me.NadadoresTableAdapter.Fill(Me.ds_nadxclub.Nadadores)
        'TODO: esta línea de código carga datos en la tabla 'ds_nadxclub.Nadadores' Puede moverla o quitarla según sea necesario.
        Me.NadadoresTableAdapter.Fill(Me.ds_nadxclub.Nadadores)
        'TODO: esta línea de código carga datos en la tabla 'ds_nadxclub.Nadadores' Puede moverla o quitarla según sea necesario.
        Me.NadadoresTableAdapter.Fill(Me.ds_nadxclub.Nadadores)
        'TODO: esta línea de código carga datos en la tabla 'ds_nadxclub.Nadadores' Puede moverla o quitarla según sea necesario.
        Me.NadadoresTableAdapter.Fill(Me.ds_nadxclub.Nadadores)
        'TODO: esta línea de código carga datos en la tabla 'ds_nadxclub.Nadadores' Puede moverla o quitarla según sea necesario.
        Me.NadadoresTableAdapter.Fill(Me.ds_nadxclub.Nadadores)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class