Public Class Kromosom
    Private kumpulangen As List(Of Gen)
    Dim coverage_total As Double
    Dim fitness_relatif As Double
    Dim fitness_komulatif As Double
    Public Sub New()
        kumpulangen = New List(Of Gen)
    End Sub
    
    Public Sub Copy(ByVal genmodif As List(Of Gen))
        Dim i As Integer

        If (kumpulangen.Count = 0) Then
            For i = 0 To genmodif.Count - 1
                kumpulangen.Add(New Gen())
            Next
        End If

        For i = 0 To genmodif.Count - 1

            kumpulangen(i).Copy(genmodif(i))
        Next i
        checkCoverage()
    End Sub
    Public Property AllGen() As List(Of Gen)
        Get
            Return kumpulangen
        End Get
        Set(ByVal value As List(Of Gen))
            kumpulangen = value
        End Set
    End Property
    Public Property FitnessRelatif() As Double
        Get
            Return fitness_relatif
        End Get
        Set(ByVal value As Double)
            fitness_relatif = value
        End Set
    End Property
    Public Property FitnessKomulatif() As Double
        Get
            Return fitness_komulatif
        End Get
        Set(ByVal value As Double)
            fitness_komulatif = value
        End Set
    End Property
    Public Sub AddGen(ByVal newgen As Gen)
        kumpulangen.Add(newgen)
    End Sub
    Public Sub CrossOver(ByVal krom As Kromosom)
        Dim pos As Integer
        Dim random As New Random
        Dim i As Integer
        Dim offspring1, offspring2 As Kromosom
        offspring1 = New Kromosom
        offspring2 = New Kromosom
        pos = random.NextDouble() * kumpulangen.Count

        For i = 0 To kumpulangen.Count - 1
            If i < pos Then
                offspring1.AddGen(kumpulangen(i))
                offspring2.AddGen(krom.GetGen(i))

            Else
                offspring1.AddGen(krom.GetGen(i))
                offspring2.AddGen(kumpulangen(i))

            End If

        Next i
        'Diteruskan Sedikit
        Copy(offspring1.AllGen)
        krom.Copy(offspring2.AllGen)
    End Sub
    Public Sub Mutasi(ByVal igen As Integer, ByVal width As Integer, ByVal height As Integer)
        Dim pos As Integer
        Dim random As New Random
        'pos = random.NextDouble() * kumpulangen.Count
        'For i = 0 To kumpulangen.Count - 1
        '    If i >= pos Then
        '        kumpulangen(i).PosX = random.NextDouble() * width
        '        kumpulangen(i).PosY = random.NextDouble() * height
        '    End If
        'Next i
        kumpulangen(igen).PosX = random.NextDouble() * width
        kumpulangen(igen).PosY = random.NextDouble() * height
    End Sub
    Public Function GetGen(ByVal idx As Integer) As Gen
        Return kumpulangen.Item(idx)
    End Function
    Public Sub checkCoverage()
        Dim a As Integer
        Dim b As Integer
        Dim r As Integer
        Dim i As Integer, j As Integer
        For j = 0 To kumpulangen.Count - 1
            kumpulangen(j).IsInCoverage = False
        Next j
        'For i = 0 To kumpulangen.Count - 2
        '    For j = i + 1 To kumpulangen.Count - 1
        '        a = Math.Pow(kumpulangen(i).PosX - kumpulangen(j).PosX, 2)
        '        b = Math.Pow(kumpulangen(i).PosY - kumpulangen(j).PosY, 2)
        '        r = Math.Pow(kumpulangen(j).Radius, 2)
        '        If ((a + b) > (r * 6)) Then
        '            ' MessageBox.Show("Masuk 1")
        '            If (kumpulangen(j).IsInCoverage <> False) Then
        '                kumpulangen(j).IsInCoverage = True  'nilai 1
        '            End If
        '        Else
        '            '  MessageBox.Show("Masuk 2")
        '            '   If (kumpulangen(j).IsInCoverage <> False) Then
        '            kumpulangen(j).IsInCoverage = False 'nilai 0
        '            'End If
        '        End If
        '    Next j
        'Next i
        For i = 0 To kumpulangen.Count - 2
            For j = i + 1 To kumpulangen.Count - 1
                a = Math.Pow(kumpulangen(i).PosX - kumpulangen(j).PosX, 2)
                b = Math.Pow(kumpulangen(i).PosY - kumpulangen(j).PosY, 2)
                r = Math.Pow(kumpulangen(i).Radius, 2)
                If ((a + b) < (r + 70)) Then
                    ' MessageBox.Show("Masuk 1")
                    If (kumpulangen(j).IsInCoverage = False) Then
                        kumpulangen(j).IsInCoverage = True  'nilai 1
                    End If
                End If

            Next j
        Next i
    End Sub
  

    Public Function Fitness() As Double
        Dim fitn As Double
        Dim i As Integer
        Dim cov As Double
        Dim rtemp As Integer
        Dim ipos As Integer
        For i = 0 To kumpulangen.Count - 1
            '  MessageBox.Show("yupz")
            ipos = 0
            If (kumpulangen(i).IsInCoverage = False) Then
                ' MessageBox.Show("Masuk : " + kumpulangen(i).Coverage.ToString())
                If (kumpulangen(i).PosX + kumpulangen(i).Radius > 50) Or (kumpulangen(i).PosY + kumpulangen(i).Radius > 50) Then
                    ' MessageBox.Show(kumpulangen(i).PosX.ToString())
                    If (kumpulangen(i).PosX + kumpulangen(i).Radius > 50) Then
                        rtemp = 50 - kumpulangen(i).PosX
                        cov = 3.14 * rtemp * rtemp
                        ipos += 1
                    End If


                    If (kumpulangen(i).PosY + kumpulangen(i).Radius > 50) Then
                        rtemp = 50 - kumpulangen(i).PosY
                        cov = 3.14 * rtemp * rtemp
                        ipos += 1
                    End If
                    cov = cov / ipos
                ElseIf (kumpulangen(i).PosX - kumpulangen(i).Radius < 0) Or (kumpulangen(i).PosY - kumpulangen(i).Radius < 0) Then
                    If (kumpulangen(i).PosX - kumpulangen(i).Radius < 0) Then
                        rtemp = kumpulangen(i).Radius - kumpulangen(i).PosX
                        cov = 3.14 * rtemp * rtemp
                        ipos += 1
                    End If


                    If (kumpulangen(i).PosY - kumpulangen(i).Radius < 0) Then
                        rtemp = kumpulangen(i).Radius - kumpulangen(i).PosY
                        cov = 3.14 * rtemp * rtemp
                        ipos += 1
                    End If
                    cov = cov / ipos
                Else
                    cov = kumpulangen(i).Coverage
                    '   MessageBox.Show(cov.ToString())
                End If
                fitn = fitn + cov
            End If
        Next

        Return fitn
    End Function


End Class
