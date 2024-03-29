Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.XtraPivotGrid

Namespace ASPxPivotGrid_RuntimeDataBinding

    Public Partial Class _Default
        Inherits Page

        'private AccessDataSource ds;
        Private ds As SqlDataSource

        Private ASPxPivotGrid1 As ASPxPivotGrid

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            ' Initializes a data source.
            ds = New SqlDataSource("System.Data.OleDb", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\nwind.mdb", "SELECT [CategoryName], [ProductName], [ProductSales], [ShippedDate] FROM [ProductReports]")
            ' Initializes ASPxPivotGrid.
            ASPxPivotGrid1 = New ASPxPivotGrid()
            ASPxPivotGrid1.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized
            ' Binds ASPxPivotGrid to the data source.
            ASPxPivotGrid1.DataSource = ds
            ' Places the Pivot Grid onto a page.
            form1.Controls.Add(ASPxPivotGrid1)
            If ASPxPivotGrid1.Fields.Count <> 0 Then Return
            ' Creates Pivot Grid fields for all data source columns.
            ASPxPivotGrid1.RetrieveFields()
            ' Locates the Pivot Grid fields in appropriate areas.
            ASPxPivotGrid1.Fields("CategoryName").Area = PivotArea.RowArea
            ASPxPivotGrid1.Fields("ProductName").Area = PivotArea.RowArea
            ASPxPivotGrid1.Fields("ShippedDate").Area = PivotArea.ColumnArea
            ASPxPivotGrid1.Fields("ProductSales").Area = PivotArea.DataArea
            TryCast(ASPxPivotGrid1.Fields("ShippedDate").DataBinding, DataSourceColumnBinding).GroupInterval = PivotGroupInterval.DateYear
        End Sub
    End Class
End Namespace
