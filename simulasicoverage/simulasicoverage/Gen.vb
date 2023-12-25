Public Class Gen
    Private iPosX As Integer
    Private iPosY As Integer
    Private nradius As Double
    Private nm_sensor As String
    Private n_coverage As Double
    Private in_coverage As Boolean
    Public Sub New()
        in_coverage = True
    End Sub
    Public Sub Copy(ByVal gen As Gen)
        iPosX = gen.iPosX
        iPosY = gen.iPosY
        nradius = gen.nradius
        nm_sensor = gen.nm_sensor
        n_coverage = gen.n_coverage
        in_coverage = gen.in_coverage
        in_coverage = True
    End Sub
    Property PosX() As Integer
        Get
            Return iPosX
        End Get
        Set(ByVal value As Integer)
            iPosX = value
        End Set
    End Property

    Property PosY() As Integer
        Get
            Return iPosY
        End Get
        Set(ByVal value As Integer)
            iPosY = value
        End Set
    End Property
    Public Property Radius() As Double
        Get
            Return nradius
        End Get
        Set(ByVal Value As Double)
            nradius = Value

        End Set

    End Property
    Public ReadOnly Property Diameter() As Integer
        Get
            Return Radius * 2
        End Get

    End Property
    Public Property NamaSensor() As String
        Get
            Return nm_sensor
        End Get
        Set(ByVal value As String)
            nm_sensor = value
        End Set
    End Property
   
    Public ReadOnly Property Coverage() As Double
        Get
            Return Math.PI * Radius * Radius
        End Get
    End Property
    Public Property IsInCoverage() As Boolean
        Get
            Return in_coverage
        End Get
        Set(ByVal value As Boolean)
            in_coverage = value
        End Set
    End Property
End Class
