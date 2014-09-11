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
End Class
