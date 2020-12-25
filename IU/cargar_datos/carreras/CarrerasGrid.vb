﻿Imports System.Data
Imports System.Data.OleDb
Public Class CarrerasGrid
    Dim carr As New carreras
    Private Sub CarrerasGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carr.Listar(DataGridView1)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cargar_carrera As New Cargar_Carrera()
        cargar_carrera.ShowDialog()
        carr.Listar(DataGridView1)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(2).Value Is Nothing Then
                    MsgBox("No existen datos para borrar")
                    Exit For
                Else
                    carr.carrid = DataGridView1.CurrentRow.Cells("ID").Value
                    carr.Borrar(carr.carrid)
                    carr.Listar(DataGridView1)
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Modificar()
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(2).Value Is Nothing Then
                    MsgBox("No existen datos para modificar")
                    Exit For
                Else
                    carr.nombre = DataGridView1.CurrentRow.Cells("Nombre").Value
                    carr.idPreceptor = DataGridView1.CurrentRow.Cells("idPreceptor").Value
                    carr.anio = DataGridView1.CurrentRow.Cells("Año").Value
                    carr.carrid = DataGridView1.CurrentRow.Cells("ID").Value

                    Dim cargar_carrera As New Cargar_Carrera(carr)
                    cargar_carrera.ShowDialog()
                    carr.Listar(DataGridView1)
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Modificar()
    End Sub
    Private Sub DataGridView2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Modificar()
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")

        If conn.State = ConnectionState.Closed Then
            conn.Open()

        End If


        Dim cmd1 As New OleDbCommand("select * from carreras where nombre like '%" + TextBox1.Text + "%' or plan like '%" + TextBox1.Text + "%' or año like '%" + TextBox1.Text + "%' or idpreceptor like '%" + TextBox1.Text + "%'", conn)

        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd1
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt



        conn.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\Access\asistencias.accdb;Persist Security Info=False;")

        If conn.State = ConnectionState.Closed Then
            conn.Open()

        End If


        Dim cmd1 As New OleDbCommand("select * from carreras where nombre like '%" + TextBox1.Text + "%' or plan like '%" + TextBox1.Text + "%' or año like '%" + TextBox1.Text + "%' or idpreceptor like '%" + TextBox1.Text + "%'", conn)

        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd1
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt



        conn.Close()
    End Sub

End Class


