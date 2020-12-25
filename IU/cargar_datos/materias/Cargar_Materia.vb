Imports System.Data.OleDb
Public Class Cargar_Materia
    Private mat_ As New Materias
    Private matnueva_ As Boolean
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")

    Public Property mat() As Materias
        Get
            Return mat_
        End Get
        Set(ByVal value As Materias)
            mat_ = value
        End Set
    End Property
    Private Property matnueva() As Boolean
        Get
            Return matnueva_
        End Get
        Set(ByVal value As Boolean)
            matnueva_ = value
        End Set

    End Property
    Private Function ObtenerAutonumerico() As Integer

        Try
            Using conexion_auto As New OleDbConnection( _
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")
                Dim comando As OleDbCommand = conexion_auto.CreateCommand()
                comando.CommandText = "SELECT MAX(id) AS MAXIMO FROM Materias"
                conexion_auto.Open()
                Dim maximo As Object = comando.ExecuteScalar()
                If (maximo Is DBNull.Value) Then
                    Return 1
                Else
                    Return CInt(maximo) + 1
                End If
            End Using
        Catch ex As Exception
            Throw
        End Try

    End Function
    Private Sub agregando(ByVal sender As Object, ByVal e As EventArgs)

        Try
            Dim n As Integer = ObtenerAutonumerico()
            txt_matid.Text = CStr(n)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub New(ByVal mat As Materias) 'Constructor para Modificar
        InitializeComponent()
        txt_canthor.Text = mat.CantHoras
        txt_nom_mat.Text = mat.nombre
        txt_matid.Text = mat.id
        txt_matid.Enabled = False

        Dim tabla As New DataTable
        Dim sql As String = "SELECT DISTINCT Legajo FROM Profesor"
        Dim adp As New OleDbDataAdapter(sql, con)
        adp.Fill(tabla)

        cmb_prof.DataSource = tabla

        Dim tabla2 As New DataTable
        Dim sql2 As String = "SELECT DISTINCT Id FROM Carreras"
        Dim adp2 As New OleDbDataAdapter(sql2, con)
        adp2.Fill(tabla2)

        cmb_carr.DataSource = tabla2

        'combobox1.DisplayMember = "Nombre"
        'combobox1.ValueMember = "Documento"

        cmb_prof.DisplayMember = "Legajo"
        cmb_prof.Text = Convert.ToString(mat.idProfe)

        cmb_carr.DisplayMember = "Id"
        cmb_carr.Text = Convert.ToString(mat.idCarrera)

        Me.Text = "Modificar Materia"
        matnueva = False
    End Sub
    Public Sub New() 'Constructor para Agregar
        InitializeComponent()
        txt_canthor.Text = ""
        txt_nom_mat.Text = ""
        AddHandler Me.Load, AddressOf agregando

        Dim tabla As New DataTable
        Dim sql As String = "SELECT DISTINCT Legajo FROM Profesor"
        Dim adp As New OleDbDataAdapter(sql, con)
        adp.Fill(tabla)

        cmb_prof.DataSource = tabla

        Dim tabla2 As New DataTable
        Dim sql2 As String = "SELECT DISTINCT Id FROM Carreras"
        Dim adp2 As New OleDbDataAdapter(sql2, con)
        adp2.Fill(tabla2)

        cmb_carr.DataSource = tabla2

        'combobox1.DisplayMember = "Nombre"
        'combobox1.ValueMember = "Documento"

        cmb_prof.DisplayMember = "Legajo"
        cmb_prof.Text = Convert.ToString(mat.idProfe)

        cmb_carr.DisplayMember = "Id"
        cmb_carr.Text = Convert.ToString(mat.idCarrera)

        Me.Text = "Cargar Materia"
        matnueva = True
    End Sub
    Function cambia(ByVal cambiatext As String) As String
        Dim a As String = StrConv(cambiatext, VbStrConv.ProperCase)
        Return a
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_canthor.Text = "" Or txt_nom_mat.Text = "" Then
            MsgBox("Debes rellenar todos los campos para continuar")
            Return
        End If


        Me.txt_nom_mat.Text = cambia(Me.txt_nom_mat.Text)


        mat.nombre = txt_nom_mat.Text
        mat.idCarrera = cmb_carr.Text
        mat.idProfe = cmb_prof.Text
        mat.id = txt_matid.Text
        mat.CantHoras = txt_canthor.Text


        If matnueva = False Then
            mat.id = txt_matid.Text
            mat.Modificar(mat)
            Close()
        Else
            mat.Agregar(mat)
            Close()
        End If
    End Sub

    Private Sub txt_canthor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_canthor.KeyPress
        txt_canthor.MaxLength = 12

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_nom_mat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nom_mat.KeyPress
        txt_nom_mat.MaxLength = 60

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class