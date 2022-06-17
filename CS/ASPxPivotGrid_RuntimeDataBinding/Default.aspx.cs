using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.XtraPivotGrid;
using System.Linq;

namespace ASPxPivotGrid_RuntimeDataBinding {
    public partial class _Default : Page {
        //private AccessDataSource ds;
        private SqlDataSource ds;
        private ASPxPivotGrid ASPxPivotGrid1;
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            // Initializes a data source.
            ds = new SqlDataSource("System.Data.OleDb","Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\nwind.mdb",
                "SELECT [CategoryName], [ProductName], [ProductSales], [ShippedDate] FROM [ProductReports]");

            // Initializes ASPxPivotGrid.
            ASPxPivotGrid1 = new ASPxPivotGrid();
            ASPxPivotGrid1.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;

            // Binds ASPxPivotGrid to the data source.
            ASPxPivotGrid1.DataSource = ds;
            
            // Places the Pivot Grid onto a page.
            form1.Controls.Add(ASPxPivotGrid1);

            if (ASPxPivotGrid1.Fields.Count != 0) 
                return;

            // Creates Pivot Grid fields for all data source columns.
            ASPxPivotGrid1.RetrieveFields();

            // Locates the Pivot Grid fields in appropriate areas.
            ASPxPivotGrid1.Fields["CategoryName"].Area = PivotArea.RowArea;
            ASPxPivotGrid1.Fields["ProductName"].Area = PivotArea.RowArea;
            ASPxPivotGrid1.Fields["ShippedDate"].Area = PivotArea.ColumnArea;
            ASPxPivotGrid1.Fields["ProductSales"].Area = PivotArea.DataArea;
            (ASPxPivotGrid1.Fields["ShippedDate"].DataBinding as DataSourceColumnBinding).GroupInterval = PivotGroupInterval.DateYear;

        }
    }
}
