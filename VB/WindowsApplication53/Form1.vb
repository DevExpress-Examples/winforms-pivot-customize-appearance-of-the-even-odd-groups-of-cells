Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace WindowsApplication53

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            PopulateTable()
            pivotGridControl1.RefreshData()
            pivotGridControl1.BestFit()
            pivotGridControl1.OptionsView.ShowColumnGrandTotals = False
        End Sub

        Private Sub PopulateTable()
            Dim myTable As DataTable = dataSet1.Tables("Data")
            myTable.Rows.Add(New Object() {"Aaa", Date.Today, 7, 3})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddDays(1), 4, 1})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today, 12, 6})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddDays(1), 14, 7})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today, 11, 1})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today.AddDays(1), 10, 3})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddYears(1), 4, 5})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddYears(1).AddDays(1), 2, 8})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddYears(1), 3, 9})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddDays(1).AddYears(1), 1, 5})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today.AddYears(1), 8, 3})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today.AddDays(1).AddYears(1), 22})
        End Sub

        Private Sub pivotGridControl1_CustomAppearance(ByVal sender As Object, ByVal e As PivotCustomAppearanceEventArgs)
            Dim groupIndex As Integer = GetGroupIndex(CType(sender, PivotGridControl), e)
            If groupIndex Mod 2 = 0 Then e.Appearance.BackColor = Color.GreenYellow
        End Sub

        Private Function GetGroupIndex(ByVal pivot As PivotGridControl, ByVal e As PivotCustomAppearanceEventArgs) As Integer
            Dim columnFields As PivotGridField() = pivot.GetFieldsByArea(PivotArea.ColumnArea).ToArray()
            Dim groupIndex As Integer = -1
            Dim previous As Object() = New Object(columnFields.Length - 1) {}
            Dim current As Object() = New Object(columnFields.Length - 1) {}
            GetValuesByIndex(pivot, columnFields, previous, 0)
            For i As Integer = 1 To e.ColumnIndex
                GetValuesByIndex(pivot, columnFields, current, i)
                If Not ValuesEquals(previous, current) Then
                    groupIndex += 1
                    current.CopyTo(previous, 0)
                End If
            Next

            Dim o As List(Of Object) = New List(Of Object)()
            Return groupIndex
        End Function

        Private Function ValuesEquals(ByVal previous As Object(), ByVal current As Object()) As Boolean
            For i As Integer = 0 To previous.Length - 1
                If Not Equals(previous(i), current(i)) Then Return False
            Next

            Return True
        End Function

        Private Sub GetValuesByIndex(ByVal pivot As PivotGridControl, ByVal fields As PivotGridField(), ByVal current As Object(), ByVal index As Integer)
            For i As Integer = 0 To fields.Length - 1
                current(i) = pivot.GetFieldValue(fields(i), index)
            Next
        End Sub
    End Class
End Namespace
