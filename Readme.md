<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2986)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Pivot Grid for Web Forms - How to create and bind Pivot Grid to data in code

This example demonstrates how to create a Pivot Grid and bind it to data via code.

In this example, the [ASPxPivotGrid](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxPivotGrid.ASPxPivotGrid) and SqlDataSource instances are created and initialized in code. The Pivot Grid is bound to data by assigning the SqlDataSource instance to the [ASPxPivotGrid.DataSource](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxPivotGrid.ASPxPivotGrid.DataSource) property. Then the [ASPxPivotGrid.RetrieveFields](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxPivotGrid.ASPxPivotGrid.RetrieveFields.overloads) method is used to create pivot grid fields for all data source fields.

## Files to Look At

- [Default.aspx](./CS/ASPxPivotGrid_RuntimeDataBinding/Default.aspx) (VB: [Default.aspx](./VB/ASPxPivotGrid_RuntimeDataBinding/Default.aspx))
- [Default.aspx.cs](./CS/ASPxPivotGrid_RuntimeDataBinding/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/ASPxPivotGrid_RuntimeDataBinding/Default.aspx.vb))

## Documentation

- [Binding to Data in Pivot Grid](https://docs.devexpress.com/AspNet/7258/components/pivot-grid/binding-to-data/binding-to-data-overview?p=netframework#code)




