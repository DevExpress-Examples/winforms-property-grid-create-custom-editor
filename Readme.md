<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128639116/13.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T415077)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [File.cs](./CS/T415077/Data/File.cs) (VB: [File.vb](./VB/T415077/Data/File.vb))
* [Form1.cs](./CS/T415077/Form1.cs) (VB: [Form1.vb](./VB/T415077/Form1.vb))
* [FilteredFileNameEditor.cs](./CS/T415077/UIEditors/FilteredFileNameEditor.cs) (VB: [FilteredFileNameEditor.vb](./VB/T415077/UIEditors/FilteredFileNameEditor.vb))
<!-- default file list end -->
# How to use a custom editor for editing in the PropertyGridControl.


<p>This example demonstrates how to use a custom editor for editing in the <strong>PropertyGridControl</strong>.<br><br>This task can be completed in the following ways.<br>1. Use a custom <a href="https://msdn.microsoft.com/en-us/library/ms171840.aspx">UITypeEditor</a>. For this, create a custom <strong>UITypeEditor </strong>descendant and mark a property of a corresponding object with the <strong>System.ComponentModel.Editor</strong> attribute in the following manner:</p>


```cs
    public class File {
        [System.ComponentModel.Editor(typeof(UIEditors.FilteredFileNameEditor),
          typeof(System.Drawing.Design.UITypeEditor))]
        public string Path { get; set; }

```


<p> Please refer to the <a href="https://msdn.microsoft.com/en-us/library/system.drawing.design.uitypeeditor%28v=vs.110%29.aspx?f=255&MSPPError=-2147217396">UITypeEditor Class</a> article for more information.</p>
<p>2. Assign a <strong>ButtonEdit</strong> to a cell as shown in the <a href="https://documentation.devexpress.com/WindowsForms/CustomDocument429.aspx">Assigning Editors to Editor Rows</a>  article and handle its <strong>ButtonClick</strong> event.</p>

<br/>


