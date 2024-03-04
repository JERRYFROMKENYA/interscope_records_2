Public Class UserSession
    Private Shared _instance As UserSession
    Private Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As UserSession
        Get
            If _instance Is Nothing Then
                _instance = New UserSession()
            End If
            Return _instance
        End Get
    End Property

    Public Property LoggedInUsername As String
End Class

