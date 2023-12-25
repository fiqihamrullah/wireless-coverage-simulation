<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.dgvDaftarNode = New System.Windows.Forms.GroupBox
        Me.rtb = New System.Windows.Forms.RichTextBox
        Me.btnRemove = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtProbMutasi = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtProbCrossOver = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtUkuranPopulasi = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtMaxGen = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnBangkitkan = New System.Windows.Forms.Button
        Me.dgvNodeInit = New System.Windows.Forms.DataGridView
        Me.Node = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Radius = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnTambah = New System.Windows.Forms.Button
        Me.txtRadius = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNmNode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvNodeTerpilih = New System.Windows.Forms.DataGridView
        Me.Generasi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kromosom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NodeTerpilih = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.XPos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.YPos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkmode = New System.Windows.Forms.CheckBox
        Me.chkmetode = New System.Windows.Forms.CheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtjumlah = New System.Windows.Forms.TextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dgvDaftarNode.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvNodeInit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNodeTerpilih, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(8, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(480, 480)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 597)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(480, 12)
        Me.ProgressBar1.TabIndex = 1
        '
        'dgvDaftarNode
        '
        Me.dgvDaftarNode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDaftarNode.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.dgvDaftarNode.Controls.Add(Me.Label11)
        Me.dgvDaftarNode.Controls.Add(Me.rtb)
        Me.dgvDaftarNode.Controls.Add(Me.btnRemove)
        Me.dgvDaftarNode.Controls.Add(Me.Panel1)
        Me.dgvDaftarNode.Controls.Add(Me.dgvNodeInit)
        Me.dgvDaftarNode.Controls.Add(Me.btnTambah)
        Me.dgvDaftarNode.Controls.Add(Me.txtjumlah)
        Me.dgvDaftarNode.Controls.Add(Me.txtRadius)
        Me.dgvDaftarNode.Controls.Add(Me.Label2)
        Me.dgvDaftarNode.Controls.Add(Me.txtNmNode)
        Me.dgvDaftarNode.Controls.Add(Me.Label1)
        Me.dgvDaftarNode.Location = New System.Drawing.Point(498, 12)
        Me.dgvDaftarNode.Name = "dgvDaftarNode"
        Me.dgvDaftarNode.Size = New System.Drawing.Size(300, 597)
        Me.dgvDaftarNode.TabIndex = 2
        Me.dgvDaftarNode.TabStop = False
        Me.dgvDaftarNode.Text = "Pengaturan"
        '
        'rtb
        '
        Me.rtb.Location = New System.Drawing.Point(18, 414)
        Me.rtb.Name = "rtb"
        Me.rtb.Size = New System.Drawing.Size(269, 177)
        Me.rtb.TabIndex = 12
        Me.rtb.Text = ""
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(191, 60)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(47, 36)
        Me.btnRemove.TabIndex = 11
        Me.btnRemove.Text = "-"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtProbMutasi)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtProbCrossOver)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtUkuranPopulasi)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtMaxGen)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnBangkitkan)
        Me.Panel1.Location = New System.Drawing.Point(17, 302)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 106)
        Me.Panel1.TabIndex = 10
        '
        'txtProbMutasi
        '
        Me.txtProbMutasi.Location = New System.Drawing.Point(105, 59)
        Me.txtProbMutasi.Name = "txtProbMutasi"
        Me.txtProbMutasi.Size = New System.Drawing.Size(84, 20)
        Me.txtProbMutasi.TabIndex = 6
        Me.txtProbMutasi.Text = "0.05"
        Me.txtProbMutasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Prob. Mutasi"
        '
        'txtProbCrossOver
        '
        Me.txtProbCrossOver.Location = New System.Drawing.Point(105, 35)
        Me.txtProbCrossOver.Name = "txtProbCrossOver"
        Me.txtProbCrossOver.Size = New System.Drawing.Size(84, 20)
        Me.txtProbCrossOver.TabIndex = 6
        Me.txtProbCrossOver.Text = "0.8"
        Me.txtProbCrossOver.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Prob. CrossOver"
        '
        'txtUkuranPopulasi
        '
        Me.txtUkuranPopulasi.Location = New System.Drawing.Point(105, 12)
        Me.txtUkuranPopulasi.Name = "txtUkuranPopulasi"
        Me.txtUkuranPopulasi.Size = New System.Drawing.Size(84, 20)
        Me.txtUkuranPopulasi.TabIndex = 6
        Me.txtUkuranPopulasi.Text = "4"
        Me.txtUkuranPopulasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ukuran Populasi"
        '
        'txtMaxGen
        '
        Me.txtMaxGen.Location = New System.Drawing.Point(106, 81)
        Me.txtMaxGen.Name = "txtMaxGen"
        Me.txtMaxGen.Size = New System.Drawing.Size(84, 20)
        Me.txtMaxGen.TabIndex = 6
        Me.txtMaxGen.Text = "2000"
        Me.txtMaxGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Maksimum Generasi"
        '
        'btnBangkitkan
        '
        Me.btnBangkitkan.Location = New System.Drawing.Point(196, 12)
        Me.btnBangkitkan.Name = "btnBangkitkan"
        Me.btnBangkitkan.Size = New System.Drawing.Size(69, 91)
        Me.btnBangkitkan.TabIndex = 7
        Me.btnBangkitkan.Text = "Bangkitkan"
        Me.btnBangkitkan.UseVisualStyleBackColor = True
        '
        'dgvNodeInit
        '
        Me.dgvNodeInit.AllowUserToAddRows = False
        Me.dgvNodeInit.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow
        Me.dgvNodeInit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvNodeInit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNodeInit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Node, Me.Radius})
        Me.dgvNodeInit.Location = New System.Drawing.Point(17, 107)
        Me.dgvNodeInit.Name = "dgvNodeInit"
        Me.dgvNodeInit.Size = New System.Drawing.Size(271, 189)
        Me.dgvNodeInit.TabIndex = 8
        '
        'Node
        '
        Me.Node.HeaderText = "Node"
        Me.Node.Name = "Node"
        '
        'Radius
        '
        Me.Radius.HeaderText = "Radius"
        Me.Radius.Name = "Radius"
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(191, 23)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(45, 36)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "+"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(90, 50)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(95, 20)
        Me.txtRadius.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Radius(m)"
        '
        'txtNmNode
        '
        Me.txtNmNode.Location = New System.Drawing.Point(90, 25)
        Me.txtNmNode.Name = "txtNmNode"
        Me.txtNmNode.Size = New System.Drawing.Size(95, 20)
        Me.txtNmNode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Node :"
        '
        'dgvNodeTerpilih
        '
        Me.dgvNodeTerpilih.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgvNodeTerpilih.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvNodeTerpilih.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNodeTerpilih.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Generasi, Me.Kromosom, Me.NodeTerpilih, Me.XPos, Me.YPos})
        Me.dgvNodeTerpilih.Location = New System.Drawing.Point(804, 37)
        Me.dgvNodeTerpilih.Name = "dgvNodeTerpilih"
        Me.dgvNodeTerpilih.Size = New System.Drawing.Size(378, 572)
        Me.dgvNodeTerpilih.TabIndex = 9
        '
        'Generasi
        '
        Me.Generasi.HeaderText = "Generasi"
        Me.Generasi.Name = "Generasi"
        Me.Generasi.Width = 60
        '
        'Kromosom
        '
        Me.Kromosom.HeaderText = "Kromosom"
        Me.Kromosom.Name = "Kromosom"
        Me.Kromosom.Width = 60
        '
        'NodeTerpilih
        '
        Me.NodeTerpilih.HeaderText = "Node"
        Me.NodeTerpilih.Name = "NodeTerpilih"
        Me.NodeTerpilih.Width = 50
        '
        'XPos
        '
        Me.XPos.HeaderText = "X"
        Me.XPos.Name = "XPos"
        Me.XPos.Width = 50
        '
        'YPos
        '
        Me.YPos.HeaderText = "Y"
        Me.YPos.Name = "YPos"
        Me.YPos.Width = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 515)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 76)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lingkungan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(83, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "480px : 50m"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(83, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "480px : 50m"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Panjang"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Lebar"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'chkmode
        '
        Me.chkmode.AutoSize = True
        Me.chkmode.Location = New System.Drawing.Point(808, 17)
        Me.chkmode.Name = "chkmode"
        Me.chkmode.Size = New System.Drawing.Size(94, 17)
        Me.chkmode.TabIndex = 10
        Me.chkmode.Text = "Mode Simulasi"
        Me.chkmode.UseVisualStyleBackColor = True
        '
        'chkmetode
        '
        Me.chkmetode.AutoSize = True
        Me.chkmetode.Checked = True
        Me.chkmetode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkmetode.Location = New System.Drawing.Point(19, 15)
        Me.chkmetode.Name = "chkmetode"
        Me.chkmetode.Size = New System.Drawing.Size(115, 17)
        Me.chkmetode.TabIndex = 11
        Me.chkmetode.Text = "Algoritma Genetika"
        Me.chkmetode.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Jumlah"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(90, 74)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(95, 20)
        Me.txtjumlah.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1179, 621)
        Me.Controls.Add(Me.chkmetode)
        Me.Controls.Add(Me.chkmode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvDaftarNode)
        Me.Controls.Add(Me.dgvNodeTerpilih)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simulasi Coverage dengan Algoritma Genetika"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dgvDaftarNode.ResumeLayout(False)
        Me.dgvDaftarNode.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvNodeInit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNodeTerpilih, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents dgvDaftarNode As System.Windows.Forms.GroupBox
    Friend WithEvents btnBangkitkan As System.Windows.Forms.Button
    Friend WithEvents txtMaxGen As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents txtRadius As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNmNode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvNodeInit As System.Windows.Forms.DataGridView
    Friend WithEvents dgvNodeTerpilih As System.Windows.Forms.DataGridView
    Friend WithEvents Node As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Radius As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtProbMutasi As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtProbCrossOver As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUkuranPopulasi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents rtb As System.Windows.Forms.RichTextBox
    Friend WithEvents Generasi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kromosom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NodeTerpilih As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents XPos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YPos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents chkmode As System.Windows.Forms.CheckBox
    Friend WithEvents chkmetode As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox

End Class
