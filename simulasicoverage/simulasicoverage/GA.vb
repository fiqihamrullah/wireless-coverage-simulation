Imports System.Windows.Forms
Public Class GA
    Dim nKromosom As Integer
    Dim pop_size As Integer
    Dim prob_crossover As Double
    Dim prob_mutasi As Double
    Dim max_gen As Integer
    Dim lstpopulasi As List(Of Kromosom) 'Populasi Sekarang
    Dim lstpopulasibaru As List(Of Kromosom) 'Populasi Generasi Selanjutnya
    Dim luas_service_area As Double
    Dim envrealwidthm As Double, envrealheightm As Double
    Dim rtb As RichTextBox, dg As DataGridView
    Dim stopprocess As Boolean
    Dim idxbestchromosom As Kromosom
    Dim currgen As Integer
    Dim best As Double = 0
    Dim modesimulasi As Boolean
    Public Sub New(ByVal luas_service_area As Double, ByVal pop_size As Integer, ByVal prob_crossover As Double, ByVal prob_mutasi As Double, ByVal max_gen As Integer, ByVal nKromosom As Integer, ByVal modesim As Boolean)
        Me.luas_service_area = luas_service_area
        Me.pop_size = pop_size
        Me.prob_crossover = prob_crossover
        Me.prob_mutasi = prob_mutasi
        Me.max_gen = max_gen
        Me.nKromosom = nKromosom
        lstpopulasi = New List(Of Kromosom)
        lstpopulasibaru = New List(Of Kromosom)
        modesimulasi = modesim
    End Sub
    Public Function GetCurrentGeneration() As Integer
        Return currgen
    End Function
    Public Sub SetViewerLogger(ByVal rtb As RichTextBox, ByVal dg As DataGridView)
        Me.rtb = rtb
        Me.dg = dg
    End Sub
    Public Sub Evolusi()
        Dim tot_coverage_individu As Double
        Dim i As Integer
        Dim igen As Integer
        stopprocess = False
        AddLog("Jumlah Kromosom " + pop_size.ToString() + ", Gen " + nKromosom.ToString())
        For igen = 0 To max_gen - 1
            AddLog("Generasi " + (igen + 1).ToString())
            currgen = igen + 1
            Seleksi()
            For i = 0 To lstpopulasi.Count - 1
                AddLog("Kromosom " + (i + 1).ToString() + "-->" + ((lstpopulasibaru(i).Fitness() / luas_service_area) * 100).ToString() + " %")
                ' MessageBox.Show(lstpopulasi(i).Fitness().ToString())
            Next i

            For i = 0 To Populasi.Count - 1
                tot_coverage_individu = lstpopulasibaru(i).Fitness() / luas_service_area
                'MessageBox.Show("Total Coverage Individu " + (tot_coverage_individu * 100).ToString() + " %")
            Next i

            'CrossOver
            Dim randomGen As New Random, nrand As Double
            Dim ortu1 As Kromosom, ortu2 As Kromosom
            Dim posc As Integer, posc2 As Integer
            Dim bortu1 As Boolean = False, bortu2 As Boolean = False
            For i = 0 To Populasi.Count - 1
                nrand = randomGen.NextDouble()
                If (nrand < prob_crossover) Then
                    If (bortu1 = False) Then
                        ortu1 = lstpopulasibaru(i)
                        posc = i
                        bortu1 = True
                        '  MessageBox.Show("Satu")
                    Else
                        ortu2 = lstpopulasibaru(i)
                        posc2 = i
                        bortu2 = True
                        ' MessageBox.Show("Dua")
                    End If
                End If

                If (bortu2 = True) Then
                    ortu1.CrossOver(ortu2)
                    AddLog("Kromosom " + (posc + 1).ToString() + " CrossOver " + (posc2 + 1).ToString())

                    bortu1 = False
                    bortu2 = False
                End If
            Next i
            'Mutasi
            For i = 0 To pop_size - 1
                For j = 0 To nKromosom - 1
                    nrand = randomGen.NextDouble()
                    If (nrand < prob_mutasi) Then
                        AddLog("Kromosom " + (i + 1).ToString() + " ,Mutasikan Gen " + (j + 1).ToString())
                        lstpopulasibaru(i).Mutasi(j, envrealwidthm, envrealheightm)
                    End If
                Next j
            Next i
            Dim tempchromosom As Kromosom
            Dim posg As Integer, lastg As Integer
            lastg = dg.Rows.Count
            If (igen >= 1) Then
                For i = 0 To Populasi.Count - 1
                    tempchromosom = lstpopulasibaru(i)
                    For j = 0 To nKromosom - 1
                        dg.Rows.Add()
                        posg = (j + (nKromosom * i)) + lastg
                        dg.Rows(posg).Cells(0).Value = igen + 1
                        dg.Rows(posg).Cells(1).Value = i + 1
                        dg.Rows(posg).Cells(2).Value = tempchromosom.GetGen(j).NamaSensor
                        dg.Rows(posg).Cells(3).Value = tempchromosom.GetGen(j).PosX
                        dg.Rows(posg).Cells(4).Value = tempchromosom.GetGen(j).PosY
                    Next j
                Next i
            End If

            'Generasi Baru
            For i = 0 To Populasi.Count - 1
                lstpopulasi(i).Copy(lstpopulasibaru(i).AllGen)
            Next
            Application.DoEvents()
            If (modesimulasi) Then
                Threading.Thread.Sleep(500)
            End If
            If stopprocess = True Then
                Exit For
            End If
        Next igen

    End Sub
    Public Sub stopEvolusi()
        stopprocess = True
    End Sub
    Private Function ConvertPxtoM(ByVal px As Double) As Double
        Dim hasil As Integer
        hasil = px * (480 / 50)
        Return hasil
    End Function
    Private Function GetChromosomFitTest(ByVal nrand As Double) As Kromosom
        Dim i As Integer
        Dim idxterpilih As Integer
        For i = 0 To pop_size - 1
            If nrand < lstpopulasi(i).FitnessKomulatif Then
                idxterpilih = i
                Exit For
            End If
        Next i
        Return lstpopulasi(idxterpilih)
    End Function
    Public Function GetBestChromosom() As Kromosom
        Return idxbestchromosom
    End Function
    Private Sub Seleksi()
        'Menggunakan Metode Roulette Wheel
        Dim totfitness As Double
        Dim komfitness As Double = 0 'Fitness Komulatif
        Dim i As Integer
        Dim randomGen As New Random, nrand As Double
        Dim krobaru As Kromosom
        ' best = 0
        'Mencari Total Fitness
        For i = 0 To lstpopulasi.Count - 1
            If lstpopulasi(i).Fitness > best Then
                best = lstpopulasi(i).Fitness
                ' MessageBox.Show(best.ToString())
                idxbestchromosom = New Kromosom()
                idxbestchromosom.Copy(lstpopulasi(i).AllGen)
            End If

            totfitness += lstpopulasi(i).Fitness()
        Next i
        'Mencari Fitness Relatif
        For i = 0 To lstpopulasi.Count - 1
            lstpopulasi(i).FitnessRelatif = lstpopulasi(i).Fitness / totfitness
        Next i
        'Mencari Fitness Komulatif
        For i = 0 To lstpopulasi.Count - 1
            komfitness += lstpopulasi(i).FitnessRelatif
            lstpopulasi(i).FitnessKomulatif = komfitness
        Next i
        'Menentukan Bilangan Acak Pemilihan dan Memilih Kromosom
        lstpopulasibaru.Clear()
        For i = 0 To pop_size
            nrand = randomGen.NextDouble
            krobaru = (GetChromosomFitTest(nrand))
            lstpopulasibaru.Add(krobaru)
        Next i
    End Sub
    Public ReadOnly Property Populasi() As List(Of Kromosom)
        Get
            Return lstpopulasi
        End Get
    End Property
    Private Sub AddLog(ByVal text As String)
        rtb.Text = rtb.Text + text + Environment.NewLine
        rtb.Select(rtb.TextLength - 1, 1)

    End Sub

    Public Sub inisialGenerasiAwal(ByVal width As Integer, ByVal height As Integer, ByVal nmSensor() As String, ByVal radiusSensor() As Double)
        Dim rand As Random
        Dim curChromosom As Kromosom
        Dim genome As Gen
        Dim ipop, jkrom As Integer
        rand = New Random
        envrealwidthm = width
        envrealheightm = height
        For ipop = 0 To pop_size - 1
            curChromosom = New Kromosom()
            For jkrom = 0 To nKromosom - 1
                genome = New Gen()
                genome.PosX = rand.NextDouble() * width
                genome.PosY = rand.NextDouble() * height
                '      MessageBox.Show(genome.PosX.ToString())
                '     MessageBox.Show(genome.PosY.ToString())
                genome.Radius = radiusSensor(jkrom)
                genome.NamaSensor = nmSensor(jkrom)
                ' MessageBox.Show(radiusSensor(jkrom))
                dg.Rows.Add()
                dg.Rows(jkrom + (nKromosom * ipop)).Cells(0).Value = "1"
                dg.Rows(jkrom + (nKromosom * ipop)).Cells(1).Value = ipop + 1
                dg.Rows(jkrom + (nKromosom * ipop)).Cells(2).Value = nmSensor(jkrom)
                dg.Rows(jkrom + (nKromosom * ipop)).Cells(3).Value = genome.PosX
                dg.Rows(jkrom + (nKromosom * ipop)).Cells(4).Value = genome.PosY
                curChromosom.AddGen(genome)



            Next
            '   MessageBox.Show("Selesai Satu Kromosom")
            curChromosom.checkCoverage()
            Populasi.Add(curChromosom)
        Next
       
    End Sub


End Class
