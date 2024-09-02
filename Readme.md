<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128577281/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2986)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Pivot Grid for Web Forms - How to Create and Bind Pivot Grid to Data in Code

This example demonstrates how to create a Pivot Grid and bind it to data via code.

In this example, the [ASPxPivotGrid](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxPivotGrid.ASPxPivotGrid) and SqlDataSource instances are created and initialized in code. 

Assign the SqlDataSource instance to the [ASPxPivotGrid.DataSource](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxPivotGrid.ASPxPivotGrid.DataSource) property to bind the Pivot Grid to data. Then call the [ASPxPivotGrid.RetrieveFields](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxPivotGrid.ASPxPivotGrid.RetrieveFields.overloads) method to generate [DataSourceColumnBinding](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxPivotGrid.DataSourceColumnBinding?v=22.1) objects for each Pivot Grid field.

## Files to Review

- [Default.aspx](./CS/ASPxPivotGrid_RuntimeDataBinding/Default.aspx) (VB: [Default.aspx](./VB/ASPxPivotGrid_RuntimeDataBinding/Default.aspx))
- [Default.aspx.cs](./CS/ASPxPivotGrid_RuntimeDataBinding/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/ASPxPivotGrid_RuntimeDataBinding/Default.aspx.vb))

## Documentation

- [Binding to Data in Pivot Grid](https://docs.devexpress.com/AspNet/7258/components/pivot-grid/binding-to-data/binding-to-data-overview?p=netframework#code)




<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=web-forms-pivot-grid-bind-to-sql-data-source&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=web-forms-pivot-grid-bind-to-sql-data-source&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
