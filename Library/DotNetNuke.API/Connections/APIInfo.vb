Public Class App_WorkInfo
    Protected _workID As String = String.Empty
    Protected _id As Integer
    Protected _businessID As String = String.Empty
    Protected _business_Name As String = String.Empty
    Protected _logo As String = String.Empty
    Protected _ages As String = String.Empty
    Protected _title As String = String.Empty
    Protected _expiredDate As String = String.Empty
    Protected _experience_Name As String = String.Empty
    Protected _salary_Name As String = String.Empty
    Public Property Work_ID As String
        Get
            Return _workID
        End Get
        Set(ByVal value As String)
            _workID = value
        End Set
    End Property

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Business_ID As String
        Get
            Return _businessID
        End Get
        Set(ByVal value As String)
            _businessID = value
        End Set
    End Property

    Public Property Business_Name As String
        Get
            Return _business_Name
        End Get
        Set(ByVal value As String)
            _business_Name = value
        End Set
    End Property

    Public Property Logo As String
        Get
            Return _logo
        End Get
        Set(ByVal value As String)
            _logo = value
        End Set
    End Property
    Public Property Ages As String
        Get
            Return _ages
        End Get
        Set(ByVal value As String)
            _ages = value
        End Set
    End Property
    Public Property Title As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            _title = value
        End Set
    End Property
    Public Property ExpiredDate As String
        Get
            Return _expiredDate
        End Get
        Set(ByVal value As String)
            _expiredDate = value
        End Set
    End Property
    Public Property Experience_Name As String
        Get
            Return _experience_Name
        End Get
        Set(ByVal value As String)
            _experience_Name = value
        End Set
    End Property
    Public Property Salary_Name As String
        Get
            Return _salary_Name
        End Get
        Set(ByVal value As String)
            _salary_Name = value
        End Set
    End Property
End Class
