Public Class RandomMethod
    Dim nmsensor() As String
    Dim radiusSensor() As Double
    Dim pt() As Point
    Dim imax As Integer
    Dim coverage As Double
    Dim curIterasi As Integer
    Dim bstop As Boolean
    Public Sub New(ByVal imax As Integer)
        Me.imax = imax
    End Sub
    Public Sub setNamaSensor(ByVal nmsensor() As String)
        Me.nmsensor = nmsensor
    End Sub
    Public Function GetNamaSensor(ByVal idx As Integer) As String
        Return nmsensor(idx)
    End Function
    Public Sub setRadiusSensor(ByVal radiussensor() As Double)
        Me.radiusSensor = radiussensor
    End Sub
    Public Function GetRadiusSensor(ByVal idx As Integer) As Double
        Return radiusSensor(idx)
    End Function
    Public Function GetNodePoint(ByVal idx As Integer) As Point
        Return pt(idx)
    End Function
    Public Sub Randomize(ByVal width As Integer, ByVal height As Integer)
        Dim rand As New Random
        ReDim pt(nmsensor.Length)
        Dim i As Integer, iterasi As Integer
        Dim fitn As Double
        Dim rtemp As Double
        Dim ipos As Integer

        Dim cov As Double
        bstop = False
        For iterasi = 0 To imax - 1
            ipos = 0
            If bstop = True Then
                Exit For
            End If
            For i = 0 To pt.Length - 1

                pt(i).X = rand.NextDouble() * width
                pt(i).Y = rand.NextDouble() * height
                System.Threading.Thread.Sleep(1)
                Application.DoEvents()
            Next
            curIterasi = iterasi

            fitn = 0




            For i = 0 To pt.Length - 2
               
                If (pt(i).X + radiusSensor(i) > 50) Or (pt(i).Y + radiusSensor(i) > 50) Then
                    If (pt(i).X + radiusSensor(i) > 50) Then
                        rtemp = 50 - radiusSensor(i)
                        cov = 3.14 * rtemp * rtemp
                        ipos += 1
                    End If


                    If (pt(i).Y + radiusSensor(i) > 50) Then
                        rtemp = 50 - radiusSensor(i)
                        cov = 3.14 * rtemp * rtemp
                        ipos += 1
                    End If
                    cov = cov / ipos
                ElseIf (pt(i).X - radiusSensor(i) < 0) Or (pt(i).Y - radiusSensor(i) < 0) Then
                    If (pt(i).X - radiusSensor(i) < 0) Then
                        rtemp = radiusSensor(i) - pt(i).X
                        cov = 3.14 * rtemp * rtemp
                        ipos += 1
                    End If


                    If (pt(i).Y - radiusSensor(i) < 0) Then
                        rtemp = radiusSensor(i) - pt(i).Y
                        cov = 3.14 * rtemp * rtemp
                        ipos += 1
                    End If
                    cov = cov / ipos
                Else
                    cov = Math.PI * radiusSensor(i) * radiusSensor(i)
                End If
                fitn = fitn + cov

            Next
            coverage = fitn


        Next iterasi
        coverage = coverage Mod (width * height)
    End Sub
    Public Function GetCurrentIteration() As Integer
        Return curIterasi
    End Function
    Public Function GetCoverage() As Double
        Return coverage
    End Function
    Public Sub StopRandom()
        bstop = True
    End Sub
End Class
