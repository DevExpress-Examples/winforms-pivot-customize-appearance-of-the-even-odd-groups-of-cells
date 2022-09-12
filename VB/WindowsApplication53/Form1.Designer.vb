Namespace WindowsApplication53

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim dataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.dataSet1 = New System.Data.DataSet()
            Me.dataTable1 = New System.Data.DataTable()
            Me.dataColumn1 = New System.Data.DataColumn()
            Me.dataColumn2 = New System.Data.DataColumn()
            Me.dataColumn3 = New System.Data.DataColumn()
            Me.dataColumn4 = New System.Data.DataColumn()
            Me.fieldName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldValueX = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldValueY = New DevExpress.XtraPivotGrid.PivotGridField()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl1.DataSource = Me.bindingSource1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldName, Me.fieldYear, Me.fieldValueX, Me.fieldDate, Me.fieldValueY})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near
            Me.pivotGridControl1.Size = New System.Drawing.Size(796, 292)
            Me.pivotGridControl1.TabIndex = 0
            AddHandler Me.pivotGridControl1.CustomAppearance, New DevExpress.XtraPivotGrid.PivotCustomAppearanceEventHandler(AddressOf Me.pivotGridControl1_CustomAppearance)
            ' 
            ' bindingSource1
            ' 
            Me.bindingSource1.DataMember = "Data"
            Me.bindingSource1.DataSource = Me.dataSet1
            ' 
            ' dataSet1
            ' 
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() {Me.dataTable1})
            ' 
            ' dataTable1
            ' 
            Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.dataColumn1, Me.dataColumn2, Me.dataColumn3, Me.dataColumn4})
            Me.dataTable1.TableName = "Data"
            ' 
            ' dataColumn1
            ' 
            Me.dataColumn1.ColumnName = "Name"
            ' 
            ' dataColumn2
            ' 
            Me.dataColumn2.ColumnName = "Date"
            Me.dataColumn2.DataType = GetType(System.DateTime)
            ' 
            ' dataColumn3
            ' 
            Me.dataColumn3.ColumnName = "ValueX"
            Me.dataColumn3.DataType = GetType(Decimal)
            ' 
            ' dataColumn4
            ' 
            Me.dataColumn4.ColumnName = "ValueY"
            Me.dataColumn4.DataType = GetType(Decimal)
            ' 
            ' fieldName
            ' 
            Me.fieldName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldName.AreaIndex = 0
            dataSourceColumnBinding1.ColumnName = "Name"
            Me.fieldName.DataBinding = dataSourceColumnBinding1
            Me.fieldName.Name = "fieldName"
            ' 
            ' fieldYear
            ' 
            Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.Caption = "Year"
            dataSourceColumnBinding2.ColumnName = "Date"
            dataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldYear.DataBinding = dataSourceColumnBinding2
            Me.fieldYear.Name = "fieldYear"
            ' 
            ' fieldValueX
            ' 
            Me.fieldValueX.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValueX.AreaIndex = 0
            Me.fieldValueX.Caption = "X"
            dataSourceColumnBinding3.ColumnName = "ValueX"
            Me.fieldValueX.DataBinding = dataSourceColumnBinding3
            Me.fieldValueX.Name = "fieldValueX"
            ' 
            ' fieldDate
            ' 
            Me.fieldDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldDate.AreaIndex = 1
            Me.fieldDate.Caption = "Date"
            dataSourceColumnBinding4.ColumnName = "Date"
            dataSourceColumnBinding4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.[Date]
            Me.fieldDate.DataBinding = dataSourceColumnBinding4
            Me.fieldDate.Name = "fieldDate"
            ' 
            ' fieldValueY
            ' 
            Me.fieldValueY.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValueY.AreaIndex = 1
            Me.fieldValueY.Caption = "Y"
            dataSourceColumnBinding5.ColumnName = "ValueY"
            Me.fieldValueY.DataBinding = dataSourceColumnBinding5
            Me.fieldValueY.Name = "fieldValueY"
            Me.fieldValueY.Options.ShowGrandTotal = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(796, 292)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private dataSet1 As System.Data.DataSet

        Private dataTable1 As System.Data.DataTable

        Private dataColumn1 As System.Data.DataColumn

        Private dataColumn2 As System.Data.DataColumn

        Private dataColumn3 As System.Data.DataColumn

        Private fieldName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldValueX As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldDate As DevExpress.XtraPivotGrid.PivotGridField

        Private dataColumn4 As System.Data.DataColumn

        Private fieldValueY As DevExpress.XtraPivotGrid.PivotGridField

        Private bindingSource1 As System.Windows.Forms.BindingSource
    End Class
End Namespace
