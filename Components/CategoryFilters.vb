Public Class CategoryFilter


    Private _strName As String
    ''' <summary>
    ''' Category Name
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Name() As String

        Get
            Return _strName
        End Get
        Set(ByVal value As String)
            _strName = value
        End Set
    End Property


    Private _FilterText As String
    ''' <summary>
    ''' Full filter text
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FilterText() As String
        Get
            Return _FilterText
        End Get
        Set(ByVal value As String)
            _FilterText = value
        End Set
    End Property


    Private _lstFilter As List(Of String)

    Public Property lstFilter() As List(Of String)
        Get
            Return _lstFilter
        End Get
        Set(ByVal value As List(Of String))
            _lstFilter = value
        End Set
    End Property




    Private _Errors As String = String.Empty

    Public Property Errors() As String
        Get
            Return _Errors
        End Get
        Set(ByVal value As String)
            _Errors = value
        End Set
    End Property




    Public Shared Function FromString(Search As String) As CategoryFilter


        Dim retval As New CategoryFilter

        Dim m As Match = Regex.Match(Search, "^(?<name>.*?):(?<text>.*)$")

        Select Case m.Groups.Count
            Case 1
                retval.FilterText = ".*"
                retval.Name = m.Groups("name").Value

            Case Is > 2


                retval.Name = m.Groups("name").Value
                retval.FilterText = m.Groups("text").Value

            Case Else
                retval.AddError(Search, "Split on "":"" failed")

        End Select


        Return retval


    End Function

    Private Sub AddError(ErrorSourse As String, ErrorText As String)

        Errors &= String.Format("Error Parsing ""{0}"": {1}", ErrorSourse, ErrorText)

    End Sub




End Class



Public Class CategoryFilters

    Private _Filters As List(Of CategoryFilter)

    Public Property Filters() As List(Of CategoryFilter)
        Get
            Return _Filters
        End Get
        Set(ByVal value As List(Of CategoryFilter))
            _Filters = value
        End Set
    End Property

    Public Sub New(Search As String)

        Dim List As New List(Of CategoryFilter)

        For Each sItem As String In Regex.Split(Search, "[\r?\n]", RegexOptions.Singleline)

            Dim Filter As New CategoryFilter
            Filter = CategoryFilter.FromString(sItem)

            If Filter.Errors = String.Empty Then

                List.Add(Filter)

            End If


        Next

        Me.Filters = List

    End Sub


    Public Sub AddFilter(filter As CategoryFilter)

        Me.Filters.Add(filter)

    End Sub

    Public Function GetCategory(Search As String) As String

        If Not Search = String.Empty Then

            If Not Me.Filters.Count = 0 Then
                For Each Filter As CategoryFilter In Me.Filters

                    If Regex.IsMatch(Search, Filter.FilterText, RegexOptions.IgnoreCase) Then

                        Return Filter.Name

                    End If

                Next
            Else
                Return "Error"
            End If

        End If


        Return ""


    End Function

End Class

