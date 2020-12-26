Imports System.Data.OleDb
Public Class Cargar_Preceptor
    Private prece_ As New Preceptores
    Private precenuevo_ As Boolean

    Public Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")
    Public Dst As New DataSet
    Public Cmd As OleDbCommand
    Public Dad As OleDbDataAdapter
    Public CurrentRow

    Public Property prece() As Preceptores
        Get
            Return prece_
        End Get
        Set(ByVal value As Preceptores)
            prece_ = value
        End Set
    End Property

    Private Property precenuevo() As Boolean
        Get
            Return precenuevo_
        End Get
        Set(ByVal value As Boolean)
            precenuevo_ = value
        End Set
    End Property
    Private Function IsIdExist()
        Dim Str, Str1 As String
        Dim i As Integer

        Str = txt_doc.Text
        i = 0
        While i <> Dst.Tables("Preceptor").Rows.Count

            Str1 = Dst.Tables("Preceptor").Rows(i)("Documento")

            If Str = Str1 Then
                Return True

            End If
            i += 1


        End While


        Return False
    End Function
    Public Sub New(ByVal prece As Preceptores) 'Constructor para Modificar
        InitializeComponent()
        txt_doc.Text = prece.doc
        txt_name_prece.Text = prece.nombre
        txt_doc.Enabled = False

        Me.lbl_title.Text = "MODIFICAR DATOS DEL PRECEPTOR"
        Me.Button1.Text = "Modificar"
        Me.Text = "Modificar Preceptor"
        precenuevo = False
    End Sub

    Public Sub New() 'Constructor para Agregar
        InitializeComponent()
        txt_doc.Text = ""
        txt_name_prece.Text = ""

        Me.lbl_title.Text = "AGREGAR DATOS DEL PRECEPTOR"
        Me.Text = "Agregar Preceptor"
        precenuevo = True
    End Sub

    Function cambia(ByVal cambiatext As String) As String
        Dim a As String = StrConv(cambiatext, VbStrConv.ProperCase)
        Return a
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_name_prece.Text = "" Or txt_doc.Text = "" Then
            MsgBox("Debes rellenar todos los campos para continuar")
            Return
        End If

        If Not IsNumeric(txt_doc.Text) And _
            txt_doc.Text <> "" Then
            Beep()
            MsgBox("Se debe ingresar solo números")
            txt_doc.Text = ""
            Return
        End If

        If txt_doc.Text.Length > 9 Then
            Beep()
            MsgBox("El número de documento es muy largo")
            Return
        End If



        Me.txt_name_prece.Text = cambia(Me.txt_name_prece.Text)

        prece.nombre = txt_name_prece.Text
        prece.doc = txt_doc.Text

        If precenuevo = False Then
            prece.doc = txt_doc.Text
            prece.Modificar(prece)
            Close()
        Else
            If IsIdExist() = True Then
                MsgBox("El número de documento ya existe")
                txt_doc.Text = ""
                txt_doc.Focus()
                Return
            End If
            prece.Agregar(prece)
            Close()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
    Private Sub Cargar_Preceptor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CurrentRow = 0
        Con.Open()
        Dad = New OleDbDataAdapter("SELECT * FROM Preceptor", Con)
        Dad.Fill(Dst, "Preceptor")
        Con.Close()
    End Sub

    Private Sub txt_doc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_doc.KeyPress
        txt_doc.MaxLength = 8
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_name_prece_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_name_prece.KeyPress
        txt_name_prece.MaxLength = 100

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class