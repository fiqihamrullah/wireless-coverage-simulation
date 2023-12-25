Imports System.Drawing.Drawing2D
Public Class Form1
    Dim mykromosom As Kromosom
    Dim envlengthpx As Integer = 480
    Dim envwidthpx As Integer = 480
    Dim envreallengthm As Integer = 50
    Dim envrealwidthm As Integer = 50
    Dim ga As GA
    Dim randmethod As RandomMethod
    Dim curkromosom As Kromosom
    Dim cl() As Color
    Dim nmsensor() As String
    Dim radiusSensor() As Double
    Private Sub PictureBox1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        Dim x As Integer, y As Integer
        Dim strfitness As String
        Dim g As Graphics
        Dim onemeter As Integer
        onemeter = ConvertMtoPx(1)
        g = e.Graphics

        Dim i As Integer
        For i = 0 To PictureBox1.Height Step onemeter
            g.DrawLine(New Pen(Color.DarkGreen), 0, i, PictureBox1.Width, i)
        Next i
        For i = 0 To PictureBox1.Width Step onemeter
            g.DrawLine(New Pen(Color.DarkGreen), i, 0, i, PictureBox1.Height)
        Next i
        If (chkmetode.Checked) Then
            g.DrawString("Generasi :", New Font("Verdana", 16, FontStyle.Bold), Brushes.Yellow, 10, 10)
        Else
            g.DrawString("Iterasi :", New Font("Verdana", 16, FontStyle.Bold), Brushes.Yellow, 10, 10)
        End If
        Dim jari2 As Integer = 2
        Dim diameterpoint As Integer = jari2 * 2
        Dim radius As Double, diameter As Integer
        If Not (ga Is Nothing) Then
            If Not (ga.GetBestChromosom Is Nothing) Then
                g.DrawString(ga.GetCurrentGeneration().ToString(), New Font("Verdana", 16, FontStyle.Bold), Brushes.Yellow, 130, 10)
                g.DrawString("Best Fitness:", New Font("Arial", 16, FontStyle.Bold), Brushes.Yellow, 200, 10)
                curkromosom = ga.GetBestChromosom
                'MessageBox.Show(curkromosom.Fitness())
                strfitness = Math.Round(((curkromosom.Fitness() / (envrealwidthm * envreallengthm)) * 100), 2)
                g.DrawString(strfitness.ToString() + " %", New Font("Arial", 16, FontStyle.Bold), Brushes.LightYellow, 350, 10)
                For i = 0 To curkromosom.AllGen.Count - 1
                    x = ConvertMtoPx(curkromosom.GetGen(i).PosX)
                    y = ConvertMtoPx(curkromosom.GetGen(i).PosY)
                    radius = ConvertMtoPx(curkromosom.GetGen(i).Radius)
                    diameter = ConvertMtoPx(curkromosom.GetGen(i).Diameter)

                    g.DrawEllipse(New Pen(Color.Red, 3), x - jari2, y - jari2, diameterpoint, diameterpoint)

                    g.FillEllipse(Brushes.Red, x - jari2, y - jari2, diameterpoint - 1, diameterpoint - 1)

                    colorCircle(g, x - CType(radius, Integer), y - CType(radius, Integer), diameter, diameter, cl(i))
                    g.DrawEllipse(New Pen(Color.Yellow, 1), x - CType(radius, Integer), y - CType(radius, Integer), diameter, diameter)
                    g.DrawString(curkromosom.GetGen(i).NamaSensor + "(" + curkromosom.GetGen(i).Radius.ToString() + ")", New Font("Verdana", 8, FontStyle.Regular), Brushes.SkyBlue, (x - jari2) - 10, (y - jari2) - 20)
                    g.DrawString("(" + curkromosom.GetGen(i).PosX.ToString() + "," + curkromosom.GetGen(i).PosY.ToString() + ")", New Font("Verdana", 6, FontStyle.Regular), Brushes.Yellow, (x - jari2) - 10, (y - jari2) + 10)
                Next i
            End If
        Else
            If Not randmethod Is Nothing Then
                g.DrawString((randmethod.GetCurrentIteration() + 1).ToString(), New Font("Verdana", 16, FontStyle.Bold), Brushes.Yellow, 130, 10)
                g.DrawString("Best Fitness:", New Font("Arial", 16, FontStyle.Bold), Brushes.Yellow, 200, 10)
                strfitness = Math.Round(((randmethod.GetCoverage().ToString / (envrealwidthm * envreallengthm)) * 100), 2)
                g.DrawString(strfitness.ToString() + " %", New Font("Arial", 16, FontStyle.Bold), Brushes.LightYellow, 350, 10)
                For i = 0 To radiusSensor.Length - 2
                    x = ConvertMtoPx(randmethod.GetNodePoint(i).X)
                    y = ConvertMtoPx(randmethod.GetNodePoint(i).Y)
                    radius = ConvertMtoPx(randmethod.GetRadiusSensor(i))

                    diameter = ConvertMtoPx(randmethod.GetRadiusSensor(i) * 2)
                    ' MessageBox.Show(randmethod.GetRadiusSensor(i))
                    g.DrawEllipse(New Pen(Color.Red, 3), x - jari2, y - jari2, diameterpoint, diameterpoint)

                    g.FillEllipse(Brushes.Red, x - jari2, y - jari2, diameterpoint - 1, diameterpoint - 1)

                    'MessageBox.Show(diameter.ToString())
                    If (diameter = 0) Then
                        ' MessageBox.Show("Pernah NOl")
                        Exit For
                    End If
                    colorCircle(g, x - CType(radius, Integer), y - CType(radius, Integer), diameter, diameter, cl(i))
                    g.DrawEllipse(New Pen(Color.Yellow, 1), x - CType(radius, Integer), y - CType(radius, Integer), diameter, diameter)
                    g.DrawString(randmethod.GetNamaSensor(i) + "(" + randmethod.GetRadiusSensor(i).ToString() + ")", New Font("Verdana", 8, FontStyle.Regular), Brushes.SkyBlue, (x - jari2) - 10, (y - jari2) - 20)
                    g.DrawString("(" + randmethod.GetNodePoint(i).X.ToString() + "," + randmethod.GetNodePoint(i).Y.ToString() + ")", New Font("Verdana", 6, FontStyle.Regular), Brushes.Yellow, (x - jari2) - 10, (y - jari2) + 10)
                Next i
            End If
        End If
    End Sub
    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Dim data(2) As String
        Dim i, j As Integer
        If (txtNmNode.Text = "" Or txtRadius.Text = "" Or txtjumlah.Text = "") Then

            MessageBox.Show("Node atau Radius atau jumlah Tidak Boleh Kosong!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            data(0) = txtNmNode.Text
            data(1) = txtRadius.Text
            j = Integer.Parse(txtjumlah.Text)
            For i = 0 To j - 1
                dgvNodeInit.Rows.Add(data)
            Next i
            txtNmNode.Text = ""
            txtRadius.Text = "0"
        End If


        txtNmNode.Focus()

    End Sub
    Private Sub colorCircle(ByVal g As Graphics, ByVal x As Single, ByVal y As Single, ByVal width As Integer, ByVal height As Integer, ByVal c As Color)
        Dim gp As GraphicsPath
        Dim pgb As PathGradientBrush
        gp = New GraphicsPath()
        gp.AddEllipse(x, y, width, height)


        pgb = New PathGradientBrush(gp)
        pgb.CenterPoint = New PointF(x + (width / 2), y + (height / 2))
        pgb.CenterColor = Color.White
        pgb.SurroundColors = New Color() {c}

        pgb.SetBlendTriangularShape(0.5F, 1.0F)
        pgb.FocusScales = New PointF(0.0F, 0.0F)

        g.FillPath(pgb, gp)


    End Sub
    Private Sub btnBangkitkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBangkitkan.Click

        Dim i As Integer
        ReDim nmsensor(dgvNodeInit.Rows.Count)
        ReDim radiusSensor(dgvNodeInit.Rows.Count)
        ReDim cl(dgvNodeInit.Rows.Count)
        Dim rand As New Random
        If btnBangkitkan.Text = "Bangkitkan" Then
            ProgressBar1.Maximum = CType(txtMaxGen.Text, Integer)
            rtb.Text = ""
            dgvNodeTerpilih.Rows.Clear()


            For i = 0 To dgvNodeInit.Rows.Count - 1
                nmsensor(i) = dgvNodeInit.Rows(i).Cells(0).Value
                radiusSensor(i) = CType(dgvNodeInit.Rows(i).Cells(1).Value, Double)
                '  MessageBox.Show(radiusSensor(i).ToString())
                cl(i) = Color.FromArgb(128, rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255))
            Next
            btnBangkitkan.Text = "Stop"
            If chkmetode.Checked Then
                ga = New GA(envreallengthm * envrealwidthm, CType(txtUkuranPopulasi.Text, Integer), CType(txtProbCrossOver.Text, Double), CType(txtProbMutasi.Text, Double), CType(txtMaxGen.Text, Integer), dgvNodeInit.Rows.Count, chkmode.Checked)
                ga.SetViewerLogger(rtb, dgvNodeTerpilih)
                ga.inisialGenerasiAwal(envrealwidthm, envreallengthm, nmsensor, radiusSensor)


                PictureBox1.Invalidate()
                ga.Evolusi()
            Else
                randmethod = New RandomMethod(Convert.ToInt32(txtMaxGen.Text))
                randmethod.setNamaSensor(nmsensor)
                randmethod.setRadiusSensor(radiusSensor)
                randmethod.Randomize(envrealwidthm, envreallengthm)
            End If
            MessageBox.Show("Pembangkitan Solusi Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnBangkitkan.Text = "Bangkitkan"
        Else
            If chkmetode.Checked Then
                ga.stopEvolusi()
            Else
                randmethod.StopRandom()
            End If
            btnBangkitkan.Text = "Bangkitkan"
            MessageBox.Show("Proses Dihentikan!", "Berhenti", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

    End Sub
    Public Function ConvertMtoPx(ByVal m As Double) As Double
        Dim hasil As Integer
        hasil = m * (envlengthpx / envreallengthm)
        Return hasil
    End Function
    Public Function ConvertPxtoM(ByVal px As Double) As Double
        Dim hasil As Integer
        hasil = px * (envreallengthm / envlengthpx)
        Return hasil
    End Function

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If IsReference(dgvNodeInit.CurrentRow) And dgvNodeInit.RowCount > 0 Then
            dgvNodeInit.Rows.Remove(dgvNodeInit.CurrentRow)
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PictureBox1.Invalidate()
        If Not (ga Is Nothing) Then
            ProgressBar1.Value = ga.GetCurrentGeneration
        End If
    End Sub
End Class
