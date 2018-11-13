<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.salida = New System.Windows.Forms.DataGridView()
        Me.Graf = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnRectangulos = New System.Windows.Forms.Button()
        Me.btnTrapecios = New System.Windows.Forms.Button()
        Me.btnGraficar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.tbFuncion = New System.Windows.Forms.TextBox()
        Me.tbA = New System.Windows.Forms.TextBox()
        Me.tbB = New System.Windows.Forms.TextBox()
        Me.tbCS = New System.Windows.Forms.TextBox()
        Me.tbRangoInicial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbRangoFinal = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSimpson = New System.Windows.Forms.Button()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'salida
        '
        Me.salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.salida.Location = New System.Drawing.Point(12, 266)
        Me.salida.Name = "salida"
        Me.salida.Size = New System.Drawing.Size(345, 332)
        Me.salida.TabIndex = 0
        '
        'Graf
        '
        ChartArea3.Name = "ChartArea1"
        Me.Graf.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Graf.Legends.Add(Legend3)
        Me.Graf.Location = New System.Drawing.Point(511, 266)
        Me.Graf.Name = "Graf"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Legend = "Legend1"
        Series5.Name = "Función"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series6.Color = System.Drawing.Color.Red
        Series6.Legend = "Legend1"
        Series6.Name = "Área"
        Me.Graf.Series.Add(Series5)
        Me.Graf.Series.Add(Series6)
        Me.Graf.Size = New System.Drawing.Size(468, 332)
        Me.Graf.TabIndex = 1
        Me.Graf.Text = "Chart1"
        '
        'btnRectangulos
        '
        Me.btnRectangulos.Location = New System.Drawing.Point(564, 73)
        Me.btnRectangulos.Name = "btnRectangulos"
        Me.btnRectangulos.Size = New System.Drawing.Size(130, 23)
        Me.btnRectangulos.TabIndex = 2
        Me.btnRectangulos.Text = "Calcular por rectángulos"
        Me.btnRectangulos.UseVisualStyleBackColor = True
        '
        'btnTrapecios
        '
        Me.btnTrapecios.Location = New System.Drawing.Point(718, 73)
        Me.btnTrapecios.Name = "btnTrapecios"
        Me.btnTrapecios.Size = New System.Drawing.Size(119, 23)
        Me.btnTrapecios.TabIndex = 3
        Me.btnTrapecios.Text = "Calcular por trapecios"
        Me.btnTrapecios.UseVisualStyleBackColor = True
        '
        'btnGraficar
        '
        Me.btnGraficar.Location = New System.Drawing.Point(736, 153)
        Me.btnGraficar.Name = "btnGraficar"
        Me.btnGraficar.Size = New System.Drawing.Size(75, 23)
        Me.btnGraficar.TabIndex = 4
        Me.btnGraficar.Text = "Graficar"
        Me.btnGraficar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(600, 153)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(878, 153)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'tbFuncion
        '
        Me.tbFuncion.Location = New System.Drawing.Point(34, 75)
        Me.tbFuncion.Name = "tbFuncion"
        Me.tbFuncion.Size = New System.Drawing.Size(153, 20)
        Me.tbFuncion.TabIndex = 7
        '
        'tbA
        '
        Me.tbA.Location = New System.Drawing.Point(238, 75)
        Me.tbA.Name = "tbA"
        Me.tbA.Size = New System.Drawing.Size(100, 20)
        Me.tbA.TabIndex = 8
        '
        'tbB
        '
        Me.tbB.Location = New System.Drawing.Point(384, 75)
        Me.tbB.Name = "tbB"
        Me.tbB.Size = New System.Drawing.Size(100, 20)
        Me.tbB.TabIndex = 9
        '
        'tbCS
        '
        Me.tbCS.Location = New System.Drawing.Point(64, 200)
        Me.tbCS.Name = "tbCS"
        Me.tbCS.Size = New System.Drawing.Size(100, 20)
        Me.tbCS.TabIndex = 10
        '
        'tbRangoInicial
        '
        Me.tbRangoInicial.Location = New System.Drawing.Point(238, 200)
        Me.tbRangoInicial.Name = "tbRangoInicial"
        Me.tbRangoInicial.Size = New System.Drawing.Size(34, 20)
        Me.tbRangoInicial.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Dame la función"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Dame a"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(407, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Dame b"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Dame las cifras significativas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Rango"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(299, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "a"
        '
        'tbRangoFinal
        '
        Me.tbRangoFinal.Location = New System.Drawing.Point(338, 200)
        Me.tbRangoFinal.Name = "tbRangoFinal"
        Me.tbRangoFinal.Size = New System.Drawing.Size(34, 20)
        Me.tbRangoFinal.TabIndex = 18
        '
        'Column1
        '
        Me.Column1.HeaderText = "n"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Integral"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Error"
        Me.Column3.Name = "Column3"
        '
        'btnSimpson
        '
        Me.btnSimpson.Location = New System.Drawing.Point(843, 73)
        Me.btnSimpson.Name = "btnSimpson"
        Me.btnSimpson.Size = New System.Drawing.Size(143, 23)
        Me.btnSimpson.TabIndex = 19
        Me.btnSimpson.Text = "Calcular por Simpson 1/3"
        Me.btnSimpson.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 610)
        Me.Controls.Add(Me.btnSimpson)
        Me.Controls.Add(Me.tbRangoFinal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbRangoInicial)
        Me.Controls.Add(Me.tbCS)
        Me.Controls.Add(Me.tbB)
        Me.Controls.Add(Me.tbA)
        Me.Controls.Add(Me.tbFuncion)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGraficar)
        Me.Controls.Add(Me.btnTrapecios)
        Me.Controls.Add(Me.btnRectangulos)
        Me.Controls.Add(Me.Graf)
        Me.Controls.Add(Me.salida)
        Me.Name = "Form1"
        Me.Text = "Integración numérica"
        CType(Me.salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Graf As DataVisualization.Charting.Chart
    Friend WithEvents btnRectangulos As Button
    Friend WithEvents btnTrapecios As Button
    Friend WithEvents btnGraficar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents tbFuncion As TextBox
    Friend WithEvents tbA As TextBox
    Friend WithEvents tbB As TextBox
    Friend WithEvents tbCS As TextBox
    Friend WithEvents tbRangoInicial As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbRangoFinal As TextBox
    Friend WithEvents btnSimpson As Button
End Class
