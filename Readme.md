<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128639116/13.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T415077)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Property Grid - Use a custom cell editor

This example demonstrates how to implement a UI Type Editor (`FilteredFileNameEditor`) and use it within the [PropertyGridControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraVerticalGrid.PropertyGridControl).

1. Create a `FilteredFileNameEditor` class and implement the [UITypeEditor](https://learn.microsoft.com/en-us/previous-versions/ms171840(v=vs.140)?redirectedfrom=MSDN) interface:
   
    ```csharp
    internal class FilteredFileNameEditor : UITypeEditor {
        private OpenFileDialog ofd = new OpenFileDialog();
        public override UITypeEditorEditStyle GetEditStyle(
         ITypeDescriptorContext context) {
            return UITypeEditorEditStyle.Modal;
        }
        public override object EditValue(
         ITypeDescriptorContext context,
         IServiceProvider provider,
         object value) {
            ofd.FileName = value.ToString();
            ofd.Filter = "Text File|*.txt|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK) {
                return ofd.FileName;
            }
            return base.EditValue(context, provider, value);
        }
    }
    ```
2. Apply the `System.ComponentModel.Editor` attribute as follows:
    
    ```cs
    public class File {
        [System.ComponentModel.Editor(typeof(UIEditors.FilteredFileNameEditor),
          typeof(System.Drawing.Design.UITypeEditor))]
        public string Path { get; set; }
        public string Path2 { get; set; }
    }
    ```
3. Assign a `ButtonEdit` to a cell as shown in the [Assigning Editors to Editor Rows](https://docs.devexpress.com/WindowsForms/429/controls-and-libraries/vertical-grid/data-editing-and-validation/assigning-editors-to-editor-rows) topic.
   
    ```csharp
    private void Form1_Shown(object sender, EventArgs e) {
        RepositoryItemButtonEdit edit = new RepositoryItemButtonEdit();
        edit.ButtonClick += edit_ButtonClick;
        (this.propertyGridControl1.Rows[0] as CategoryRow).ChildRows["rowPath2"].Properties.RowEdit = edit;
    }
    ```
4. Handle the Button Editor's `ButtonClick` event.

    ```csharp
    void edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
        this.openFileDialog1.ShowDialog();
    }
    ```


## Files to Review

* [File.cs](./CS/T415077/Data/File.cs) (VB: [File.vb](./VB/T415077/Data/File.vb))
* [Form1.cs](./CS/T415077/Form1.cs) (VB: [Form1.vb](./VB/T415077/Form1.vb))
* [FilteredFileNameEditor.cs](./CS/T415077/UIEditors/FilteredFileNameEditor.cs) (VB: [FilteredFileNameEditor.vb](./VB/T415077/UIEditors/FilteredFileNameEditor.vb))
