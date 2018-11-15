<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication53/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication53/Form1.vb))
* [Program.cs](./CS/WindowsApplication53/Program.cs) (VB: [Program.vb](./VB/WindowsApplication53/Program.vb))
<!-- default file list end -->
# How to customize appearance of the Even/Odd groups of cells.


<p>We have a few data fields in the pivot grid control. We want to apply a custom appearance to a set of cells, corresponding to the same Field Values. Even and odd sets of cells should be colorized with different colors. <br />
The easiest way to accomplish this task is to compare Field Values, corresponding to a processed cell, with Field Values, corresponding to a previous cell. We use the <strong>GetFieldValue</strong> method to get Field Value by a column index.<br />
This example is made with the XtraPivotGrid control. However, the same approach can be used with the ASPxPivotGrid and DXPivotGrid controls as well.</p>

<br/>


