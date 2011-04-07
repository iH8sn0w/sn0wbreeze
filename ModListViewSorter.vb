Option Explicit On
Option Strict On
Imports System
Imports System.Windows.Forms

Module ModListViewSorter

    Public Class ListViewItemSorterClass
        Implements Collections.IComparer
        ' Note:				Please report any bugs or improvement suggestions to LarsLoeskowAtWork@hotmail.com
        ' Info:				Visit http://dotnet.nbit.se/lal/prod/VB/ListViewItemSorter/Info.aspx
        ' History:
        ' 2001-08-03 LAL Created using VB.NET 7.0 Beta 2.
        ' 2001-08-08 LAL Support culture settings that differ from the current Windows settings.
        ' 2002-09-06 LAL More .NET-ified naming convention, Option Strict On and XML-documentation. Added the "Class" suffix to avoid problems when used in inherited ListView control.
        Private Const m_sTypeName As String = "ListViewItemSorterClass"  ' For debug purposes.
        Protected m_nColumn As Int32 = -1  ' The column to sort on.
        Protected m_nColumnType As ListViewColumnType = ListViewColumnType.Text ' Text, Numeric or Date.
        Protected m_nCompareMethod As Microsoft.VisualBasic.CompareMethod = Microsoft.VisualBasic.CompareMethod.Text     ' Text column CompareMethod can be Binary or Text.
        Protected m_bCompareFromLeftToDiff As Boolean = True
        Protected m_nSortOrder As Int32 = CompareResult.FirstIsBiggerThanSecond    ' Ascending or Descending sort.
        Protected m_oCulture As Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture     ' Default to Current Culture Settings.
        ''' <summary>
        ''' The column to sort on.
        ''' </summary>
        ''' 	
        Public Property Column() As Int32
            ' History:
            ' 2001-08-03 LAL Created.
            Get
                Return m_nColumn
            End Get
            Set(ByVal value As Int32)
                m_nColumn = value
            End Set
        End Property
        ''' <summary>
        ''' Text, Numeric or Date.
        ''' </summary>
        ''' 	
        Public Property ColumnType() As ListViewColumnType
            ' History:
            ' 2001-08-03 LAL Created.
            Get
                Return m_nColumnType
            End Get
            Set(ByVal value As ListViewColumnType)
                m_nColumnType = value
            End Set
        End Property
        ''' <summary>
        ''' Text columns can be sorted Binary (case sensitive sort order derived from the internal binary representations of the characters) or Text (case-insensitive text sort order determined by the system's LocaleID value).
        ''' </summary>
        ''' 
        Public Property CompareMethod() As Microsoft.VisualBasic.CompareMethod
            ' History:
            ' 2001-08-03 LAL Created.
            Get
                Return m_nCompareMethod
            End Get
            Set(ByVal value As Microsoft.VisualBasic.CompareMethod)
                m_nCompareMethod = value
            End Set
        End Property
        ''' <summary>
        ''' Specifies in which way a Text column should be handled.
        ''' </summary>
        ''' <remark>
        ''' True = Compare each char from left until one is bigger or smaller than the other (i.e. "ab2" is smaller than "AB1" when casesensitive, because "a" is smaller than "A"). I.e. behave a lot like StrComp() - but honor the CultureInfo setting!
        ''' False = Compare using the dotNET frameworks string.compare() method (which says that "ab" is smaller than "AB" when casesensitive, BUT "ab2" is BIGGER than "AB1" even when casesensitive...).
        ''' </remark>
        ''' 
        Public Property CompareFromLeftToDiff() As Boolean
            ' History:
            ' 2001-08-08 LAL Created.
            Get
                Return m_bCompareFromLeftToDiff
            End Get
            Set(ByVal value As Boolean)
                m_bCompareFromLeftToDiff = value
            End Set
        End Property
        ''' <summary>
        ''' Ascending or Descending sort.
        ''' </summary>
        ''' 
        Public Property SortOrder() As System.Windows.Forms.SortOrder    ' Return a value from the enum named "SortOrder" in System.Windows.Forms.
            ' History:
            ' 2001-08-03 LAL Created.
            Get
                ' Return last SortOrder.
                Select Case m_nSortOrder
                    Case CompareResult.FirstIsSmallerThanSecond
                        Return System.Windows.Forms.SortOrder.Ascending
                    Case CompareResult.FirstIsBiggerThanSecond
                        Return System.Windows.Forms.SortOrder.Descending
                    Case Else
                        Return System.Windows.Forms.SortOrder.None
                End Select
            End Get
            Set(ByVal value As System.Windows.Forms.SortOrder)
                ' Set the SortOrder to be used at next sort.
                Const sMemberName As String = "SortOrder.Set"
                Select Case value
                    Case System.Windows.Forms.SortOrder.Ascending
                        m_nSortOrder = CompareResult.FirstIsSmallerThanSecond
                    Case System.Windows.Forms.SortOrder.Descending
                        m_nSortOrder = CompareResult.FirstIsBiggerThanSecond
                    Case Else
                        ' Invalid value (i.e. CompareResult.FirstIsEqualToSecond).
                        Debug.WriteLine(m_sTypeName & "." & sMemberName & ": Invalid Value. SortOrder is NOT set!")
                        Return                   ' Abort.
                End Select
            End Set
        End Property
        ''' <summary>
        ''' The Culture Settings to use in variable type conversion and comparisons.
        ''' </summary>
        ''' <remark>
        ''' The default is the current thread (i.e. system) locale setting. 
        ''' Set it to "" to reset it to the default.
        ''' Set it to "iv" to use an invariant culture (based on the English culture).
        ''' </remark>
        ''' 
        Public Property CultureInfoName() As String
            ' Related info: 	http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpref/html/frlrfsystemglobalizationcultureinfoclasstopic.asp
            ' History:
            ' 2001-08-08 LAL Created.
            ' 2001-08-29 LAL Added the cultureinfoname "neutral".
            Get
                Return m_oCulture.Name
            End Get
            Set(ByVal value As String)
                Select Case LCase(value)
                    Case ""
                        m_oCulture = Globalization.CultureInfo.CurrentCulture                    ' Use the current thread (i.e. system) locale setting.
                    Case "iv", "inv", "invariant", "neutral", "culture-insensitive", "culture insensitive", "cultureinsensitive"
                        m_oCulture = Globalization.CultureInfo.InvariantCulture                 ' Use an invariant culture (based on the english culture). Info: Dates convert well if they are in ISO format (i.e. "yyyy-MM-dd") or american format (i.e. "MM/dd/yyyy").
                    Case Else
                        m_oCulture = Globalization.CultureInfo.CreateSpecificCulture(value)                  ' Info: Raises an error if Value contains an invalid CultureInfoName.
                End Select
            End Set
        End Property
        ''' <summary>
        ''' An easy way to invert the sortorder of the next sort (ascending turns descending and vice versa).
        ''' </summary>
        ''' 
        Public Function InvertSortOrder() As System.Windows.Forms.SortOrder  ' Return a value from the enum named "SortOrder" in System.Windows.Forms.
            ' History:
            ' 2001-08-03 LAL Created.
            'Const sMemberName As String = "InvertSortOrder"
            Select Case m_nSortOrder
                Case CompareResult.FirstIsEqualToSecond
                    m_nSortOrder = CompareResult.FirstIsSmallerThanSecond
                    Return System.Windows.Forms.SortOrder.Ascending
                Case CompareResult.FirstIsSmallerThanSecond
                    m_nSortOrder = CompareResult.FirstIsBiggerThanSecond
                    Return System.Windows.Forms.SortOrder.Descending
                Case CompareResult.FirstIsBiggerThanSecond
                    m_nSortOrder = CompareResult.FirstIsSmallerThanSecond
                    Return System.Windows.Forms.SortOrder.Ascending
            End Select
        End Function
        ''' <summary>
        ''' Returns column type based on column contents.
        ''' </summary>
        ''' 
        Public Function DetectColumnType(ByVal theListView As ListView, ByVal columnIndex As Int32) As ListViewColumnType
            ' History:
            ' 2001-08-03 LAL Created.
            ' 2001-08-04 LAL Optimized for better performance.
            ' 2001-08-08 LAL Support different culture settings (i.e. changed IsNumeric() and IsDate() to <datatype>.Parse() and error handlers).
            Const sMemberName As String = "DetectColumnType"
            'Dim nTextCount As Int32
            Dim nNumericCount As Int32
            Dim nDateCount As Int32
            Dim oRowItem As ListViewItem
            Dim sTxt As String
            Dim nValue As Double
            Dim dDate As Date
            If theListView Is Nothing Then
                Debug.WriteLine(m_sTypeName & "." & sMemberName & ": oListView Is Nothing. No ColumnType is detected.")
                Return ListViewColumnType.Text           ' Invalid. Abort!
            End If
            If columnIndex < 0 Then
                Debug.WriteLine(m_sTypeName & "." & sMemberName & ": nColumn < 0. No ColumnType is detected.")
                Return ListViewColumnType.Text           ' Invalid. Abort!
            End If
            Try
                theListView.Cursor = Cursors.WaitCursor
                For Each oRowItem In theListView.Items
                    If columnIndex < oRowItem.SubItems.Count Then
                        ' The column exists in listview rowitem.
                        sTxt = oRowItem.SubItems.Item(columnIndex).Text
                        If Len(sTxt) > 0 Then
                            ' Not empty. Detect type...:
                            If nNumericCount > 0 Then
                                Try
                                    nValue = Double.Parse(sTxt, m_oCulture.NumberFormat)                                 ' Convert to double.
                                Catch
                                    Debug.WriteLine(m_sTypeName & "." & sMemberName & ": Column " & columnIndex & " is ColumnType Text.")
                                    Return ListViewColumnType.Text                               ' If one row in the column is text (i.e. not ANY other type) then the entire column is classed as columntype text.
                                End Try
                            ElseIf nDateCount > 0 Then
                                Try
                                    dDate = Date.Parse(sTxt, m_oCulture.DateTimeFormat)                              ' Convert to date.
                                Catch
                                    Debug.WriteLine(m_sTypeName & "." & sMemberName & ": Column " & columnIndex & " is ColumnType Text.")
                                    Return ListViewColumnType.Text                               ' If one row in the column is text (i.e. not ANY other type) then the entire column is classed as columntype text.
                                End Try
                            Else
                                Try
                                    nValue = Double.Parse(sTxt, m_oCulture.NumberFormat)                                 ' Convert to double.
                                    nNumericCount += 1
                                Catch
                                    ' Not a numeric.
                                    Try
                                        dDate = Date.Parse(sTxt, m_oCulture.DateTimeFormat)                                 ' Convert to date.
                                        nDateCount += 1
                                    Catch
                                        ' Not a numeric and not a date = a text.
                                        Debug.WriteLine(m_sTypeName & "." & sMemberName & ": Column " & columnIndex & " is ColumnType Text.")
                                        Return ListViewColumnType.Text                                   ' If one row in the column is text (i.e. not ANY other type) then the entire column is classed as columntype text.
                                    End Try
                                End Try
                            End If
                        Else
                            ' Ignore empty strings.
                        End If
                    Else
                        ' Ignore rows with missing subitems.
                    End If
                Next
                ' All rows are checked. Return the result of the autodetection.
                If nDateCount > 0 Then
                    Debug.WriteLine(m_sTypeName & "." & sMemberName & ": Column " & columnIndex & " is ColumnType Date.")
                    Return ListViewColumnType.Date
                End If
                If nNumericCount > 0 Then
                    Debug.WriteLine(m_sTypeName & "." & sMemberName & ": Column " & columnIndex & " is ColumnType Numeric.")
                    Return ListViewColumnType.Numeric
                End If
                Debug.WriteLine(m_sTypeName & "." & sMemberName & ": Column " & columnIndex & " is ColumnType Text.")
                Return ListViewColumnType.Text
            Finally
                theListView.Cursor = Cursors.Default
            End Try
        End Function
        ''' <summary>
        ''' Compare two strings using the CurrentCulture CultureInfo.
        ''' </summary>
        ''' 	
        Protected Overloads Function StringCompare( _
         ByVal string1 As String, _
         ByVal string2 As String, _
         Optional ByVal compare As Microsoft.VisualBasic.CompareMethod = Microsoft.VisualBasic.CompareMethod.Text _
        ) As CompareResult
            Return Me.StringCompare(string1, string2, System.Globalization.CultureInfo.CurrentCulture, compare:=compare)
        End Function
        ''' <summary>
        ''' Compare two strings using the specified CultureInfo.
        ''' </summary>
        ''' 	
        Protected Overloads Function StringCompare( _
         ByVal string1 As String, _
         ByVal string2 As String, _
         ByVal culture As System.Globalization.CultureInfo, _
         Optional ByVal compare As Microsoft.VisualBasic.CompareMethod = Microsoft.VisualBasic.CompareMethod.Text _
        ) As CompareResult
            Dim bIgnoreCase As Boolean = (m_nCompareMethod = Microsoft.VisualBasic.CompareMethod.Text)
            Dim sChar1 As String
            Dim sChar2 As String
            Dim nCompRC As Int32
            Dim nPos As Int32
            For nPos = 1 To Len(string1)
                sChar1 = Mid(string1, nPos, 1)
                sChar2 = Mid(string2, nPos, 1)
                nCompRC = String.Compare(sChar1, sChar2, bIgnoreCase, culture)
                If nCompRC <> CompareResult.FirstIsEqualToSecond Then
                    ' They are NOT equal.
                    Return CType(nCompRC, CompareResult)                ' Return the result of the comparison.
                End If
                ' They are identical. Continue with the next char.
            Next
            ' No more characters in string1.
            If Len(Mid(string2, nPos + 1)) > 0 Then
                ' More characters in string2.
                Return CompareResult.FirstIsSmallerThanSecond
            End If
            Return CompareResult.FirstIsEqualToSecond
        End Function

        ' Returns a value indicating the result of the comparison.


        Public Function Compare(ByVal object1 As Object, ByVal object2 As Object) As Int32 Implements Collections.IComparer.Compare
            ' History:
            ' 2001-08-03 LAL Created.
            ' 2001-08-08 LAL Support for culture settings.
            Const sMemberName As String = "Compare"
            Dim oRowItem1 As ListViewItem
            Dim oRowItem2 As ListViewItem
            Dim sTxt1 As String
            Dim sTxt2 As String

            sTxt1 = ""
            sTxt2 = ""

            Try
                ' Convert from Object type to ListViewItem type...:
                oRowItem1 = CType(object1, ListViewItem)
                oRowItem2 = CType(object2, ListViewItem)
            Catch
                Debug.WriteLine(m_sTypeName & "." & sMemberName & ": Wrong type of objects. Class misuse detected! No sorting is performed!")
                Return CompareResult.FirstIsEqualToSecond            ' No sorting.
            End Try
            If m_nColumn < 0 Then
                ' Invalid column.
                Debug.WriteLine(m_sTypeName & "." & sMemberName & ": m_nColumn < 0. No sorting is performed!")
                Return CompareResult.FirstIsEqualToSecond            ' No sorting.
            End If
            ' Get the text in the column in the rowitem...:
            If m_nColumn < oRowItem1.SubItems.Count Then
                ' The subitem exists in listview rowitem 1.
                sTxt1 = oRowItem1.SubItems.Item(m_nColumn).Text
            End If
            If m_nColumn < oRowItem2.SubItems.Count Then
                ' The subitem exists in listview rowitem 2.
                sTxt2 = oRowItem2.SubItems.Item(m_nColumn).Text
            End If
            ' Handle empty values...:
            If Len(sTxt1) = 0 Then
                If Len(sTxt2) = 0 Then
                    Return CompareResult.FirstIsEqualToSecond               ' Both are zero length = No sorting.
                End If
                Return m_nSortOrder          ' The first is empty, but not the second = first is smaller than the second.
            ElseIf Len(sTxt2) = 0 Then
                Return -m_nSortOrder             ' The second is empty, but not the first = first is bigger than the second.
            End If
            ' Compare the two values...:
            Select Case m_nColumnType
                Case ListViewColumnType.Text
                    If m_bCompareFromLeftToDiff = True Then
                        Return -m_nSortOrder * StringCompare(sTxt1, sTxt2, m_oCulture, compare:=m_nCompareMethod)
                    Else
                        Return -m_nSortOrder * String.Compare(sTxt1, sTxt2, (m_nCompareMethod = Microsoft.VisualBasic.CompareMethod.Text), m_oCulture)
                    End If
                Case ListViewColumnType.Numeric
                    Dim nValue1 As Double
                    Dim nValue2 As Double
                    Try
                        nValue1 = CType(sTxt1, Double)
                        nValue1 = Double.Parse(sTxt1, m_oCulture.NumberFormat)                  ' Convert to double.
                    Catch
                        Debug.WriteLine(m_sTypeName & "." & sMemberName & ": Column " & m_nColumn & " is NOT of ColumnType Numeric.")
                        Return CompareResult.FirstIsEqualToSecond                    ' No sorting.
                    End Try
                    Try
                        nValue2 = Double.Parse(sTxt2, m_oCulture.NumberFormat)                   ' Convert to double.
                    Catch
                        Debug.WriteLine(m_sTypeName & "." & sMemberName & ": Column " & m_nColumn & " is NOT of ColumnType Numeric.")
                        Return CompareResult.FirstIsEqualToSecond                    ' No sorting.
                    End Try
                    If nValue1 < nValue2 Then
                        Return m_nSortOrder
                    End If
                    If nValue1 > nValue2 Then
                        Return -m_nSortOrder
                    End If
                    Return CompareResult.FirstIsEqualToSecond                ' No sorting.
                Case ListViewColumnType.Date
                    Dim dDate1 As Date
                    Dim dDate2 As Date
                    Try
                        dDate1 = Date.Parse(sTxt1, m_oCulture.DateTimeFormat)                    ' Convert to date.
                    Catch
                        Debug.WriteLine(m_sTypeName & "." & sMemberName & ": Column " & m_nColumn & " is NOT of ColumnType Date.")
                        Return CompareResult.FirstIsEqualToSecond                    ' No sorting.
                    End Try
                    Try
                        dDate2 = Date.Parse(sTxt2, m_oCulture.DateTimeFormat)                    ' Convert to date.
                    Catch
                        Debug.WriteLine(m_sTypeName & "." & sMemberName & ": Column " & m_nColumn & " is NOT of ColumnType Date.")
                        Return CompareResult.FirstIsEqualToSecond                    ' No sorting.
                    End Try
                    Return -m_nSortOrder * Date.Compare(dDate1, dDate2)
                Case Else
                    Debug.WriteLine(m_sTypeName & "." & sMemberName & ": m_nColumnType=" & m_nColumnType & " is not a handled Column Type. No sorting is performed!")
                    Return CompareResult.FirstIsEqualToSecond                ' No sorting.
            End Select
        End Function
    End Class
    ' - - -
    Public Enum ListViewColumnType
        [Text] = 1
        [Numeric]
        [Date]
        [AutoDetect]
    End Enum
    ' - - -
    Public Enum CompareResult
        [FirstIsSmallerThanSecond] = -1
        [FirstIsEqualToSecond] = 0
        [FirstIsBiggerThanSecond] = 1
    End Enum


End Module
