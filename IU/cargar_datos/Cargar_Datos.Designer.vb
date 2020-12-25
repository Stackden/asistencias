<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cargar_Datos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cargar_Datos))
        Me.Toolstrip = New System.Windows.Forms.ToolStrip
        Me.ts_alumnos = New System.Windows.Forms.ToolStripButton
        Me.ts_profesores = New System.Windows.Forms.ToolStripButton
        Me.ts_preceptores = New System.Windows.Forms.ToolStripButton
        Me.ts_materias = New System.Windows.Forms.ToolStripButton
        Me.ts_carreras = New System.Windows.Forms.ToolStripButton
        Me.lbl = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Toolstrip.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Toolstrip
        '
        Me.Toolstrip.BackColor = System.Drawing.Color.DimGray
        Me.Toolstrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Toolstrip.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Toolstrip.GripMargin = New System.Windows.Forms.Padding(0)
        Me.Toolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Toolstrip.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.Toolstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_alumnos, Me.ts_profesores, Me.ts_preceptores, Me.ts_materias, Me.ts_carreras})
        Me.Toolstrip.Location = New System.Drawing.Point(46, 386)
        Me.Toolstrip.Name = "Toolstrip"
        Me.Toolstrip.Padding = New System.Windows.Forms.Padding(0, 2, 10, 0)
        Me.Toolstrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.Toolstrip.ShowItemToolTips = False
        Me.Toolstrip.Size = New System.Drawing.Size(420, 77)
        Me.Toolstrip.TabIndex = 1
        Me.Toolstrip.Text = "Barra de Navegación"
        '
        'ts_alumnos
        '
        Me.ts_alumnos.Image = Global.ABMAsistencia.My.Resources.Resources.alumno
        Me.ts_alumnos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_alumnos.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ts_alumnos.Name = "ts_alumnos"
        Me.ts_alumnos.Size = New System.Drawing.Size(66, 72)
        Me.ts_alumnos.Text = "Alumnos"
        Me.ts_alumnos.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.ts_alumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_profesores
        '
        Me.ts_profesores.Image = Global.ABMAsistencia.My.Resources.Resources.profesor
        Me.ts_profesores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_profesores.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ts_profesores.Name = "ts_profesores"
        Me.ts_profesores.Size = New System.Drawing.Size(77, 72)
        Me.ts_profesores.Text = "Profesores"
        Me.ts_profesores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_preceptores
        '
        Me.ts_preceptores.Image = Global.ABMAsistencia.My.Resources.Resources.preceptor
        Me.ts_preceptores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_preceptores.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ts_preceptores.Name = "ts_preceptores"
        Me.ts_preceptores.Size = New System.Drawing.Size(84, 72)
        Me.ts_preceptores.Text = "Preceptores"
        Me.ts_preceptores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_materias
        '
        Me.ts_materias.Image = Global.ABMAsistencia.My.Resources.Resources.materia
        Me.ts_materias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_materias.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ts_materias.Name = "ts_materias"
        Me.ts_materias.Size = New System.Drawing.Size(67, 72)
        Me.ts_materias.Text = "Materias"
        Me.ts_materias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_carreras
        '
        Me.ts_carreras.Image = Global.ABMAsistencia.My.Resources.Resources.carrera
        Me.ts_carreras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_carreras.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ts_carreras.Name = "ts_carreras"
        Me.ts_carreras.Size = New System.Drawing.Size(64, 72)
        Me.ts_carreras.Text = "Carreras"
        Me.ts_carreras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'lbl
        '
        Me.lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.lbl.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.White
        Me.lbl.Location = New System.Drawing.Point(33, 9)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(434, 78)
        Me.lbl.TabIndex = 22
        Me.lbl.Text = "CARGAR DATOS"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ABMAsistencia.My.Resources.Resources.carena
        Me.PictureBox2.Location = New System.Drawing.Point(108, 107)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(282, 269)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(514, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ABMAsistencia.My.Resources.Resources.piso
        Me.PictureBox3.Location = New System.Drawing.Point(0, 386)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(514, 75)
        Me.PictureBox3.TabIndex = 26
        Me.PictureBox3.TabStop = False
        '
        'Cargar_Datos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(514, 461)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Toolstrip)
        Me.Controls.Add(Me.PictureBox3)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Cargar_Datos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Toolstrip.ResumeLayout(False)
        Me.Toolstrip.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ts_alumnos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_profesores As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_materias As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_carreras As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_preceptores As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Toolstrip As System.Windows.Forms.ToolStrip
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Private WithEvents lbl As System.Windows.Forms.Label
End Class
