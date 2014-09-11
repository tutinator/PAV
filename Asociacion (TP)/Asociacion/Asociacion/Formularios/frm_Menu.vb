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

   
End Class
