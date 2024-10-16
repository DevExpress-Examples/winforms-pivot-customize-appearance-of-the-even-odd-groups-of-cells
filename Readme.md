<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579601/22.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3226)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Pivot Grid for WinForms - Customize Appearance of the Even/Odd Groups of Cells

This example shows how to to apply a custom appearance to a set of cells, corresponding to the same field values. Even and odd sets of cells are painted with different colors. 

![Pivot Grid](image/pivot-grid.png)

## Example Overview

Use the [PivotGridControl.GetFieldValue](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.GetFieldValue(DevExpress.XtraPivotGrid.PivotGridField-System.Int32)) method to get field value by a column index. Then, compare field values, corresponding to a processed cell, with field values, corresponding to a previous cell. Handle the [PivotGridControl.CustomAppearance](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomAppearance) event to paint an even cells group green-yelow.


## Files to Review
<!-- default file list -->
* [Form1.cs](./CS/WindowsApplication53/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication53/Form1.vb))
* [Program.cs](./CS/WindowsApplication53/Program.cs) (VB: [Program.vb](./VB/WindowsApplication53/Program.vb))
<!-- default file list end -->

## More Examples 

- [Pivot Grid for WinForms - Change the Field Value Header Background](https://github.com/DevExpress-Examples/how-to-change-the-field-value-header-appearance-backcolor-or-draw-it-manually-e2809)
- [Pivot Grid for WinForms - Customize Cells](https://github.com/DevExpress-Examples/winforms-pivot-customize-cell)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivot-customize-appearance-of-the-even-odd-groups-of-cells&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivot-customize-appearance-of-the-even-odd-groups-of-cells&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
