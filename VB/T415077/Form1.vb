Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraVerticalGrid.Rows
Imports System

Namespace T415077

    Public Partial Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim file As Data.File = New Data.File() With {.Path = "C:\Home", .Path2 = "C:\Public"}
            propertyGridControl1.SelectedObject = file
        End Sub

        Private Sub edit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
            openFileDialog1.ShowDialog()
        End Sub

        Private Sub Form1_Shown(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As RepositoryItemButtonEdit = New RepositoryItemButtonEdit()
            AddHandler edit.ButtonClick, AddressOf edit_ButtonClick
            TryCast(propertyGridControl1.Rows(0), CategoryRow).ChildRows("rowPath2").Properties.RowEdit = edit
        End Sub
    End Class
End Namespace
