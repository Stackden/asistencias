Imports System.Data
Imports System.Data.OleDb
Public Class Cargar_Datos

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_alumnos.Click
        AlumnoGrid.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_carreras.Click
        CarrerasGrid.Show()

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_materias.Click
        MateriasGrid.Show()

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_profesores.Click
        ProfesoresGrid.Show()

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_preceptores.Click
        PreceptoresGrid.Show()
    End Sub

End Class
