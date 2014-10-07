Public Class frm_Menu


    Private Sub frm_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbl_hora.Text = DateTime.Now.ToShortTimeString()

    End Sub

   
    Private Sub NadadoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NadadoresToolStripMenuItem.Click
        frm_ABMnadadores.Show()
    End Sub

    Private Sub ClubesAfiliadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClubesAfiliadosToolStripMenuItem.Click
        frm_ABMclubes.Show()
    End Sub

   
    Private Sub frm_Menu_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            e.Cancel() = True
        End If
    End Sub

    Private Sub CodigosPostalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigosPostalesToolStripMenuItem.Click
        frm_ABMCodPos.Show()
    End Sub

    Private Sub ProfesoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProfesoresToolStripMenuItem1.Click
        frm_ABMProfesores.Show()
    End Sub

    Private Sub EspecialidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EspecialidadesToolStripMenuItem.Click
        frm_ABMEspecialidades.Show()
    End Sub

    Private Sub TiposDeDocumentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeDocumentoToolStripMenuItem.Click
        frm_ABMTipoDocumento.Show()
    End Sub

    Private Sub TorneosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TorneosToolStripMenuItem.Click
        frm_ABMTorneo.Show()
    End Sub

    Private Sub RealizacionDeTorneoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealizacionDeTorneoToolStripMenuItem.Click
        proc_realizacionTorneo.Show()
    End Sub
End Class
