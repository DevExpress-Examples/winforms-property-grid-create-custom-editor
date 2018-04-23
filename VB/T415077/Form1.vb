Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraVerticalGrid.Rows
Imports System

Namespace T415077
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim file As New Data.File() With {.Path = "C:\Home", .Path2 = "C:\Public"}
            Me.propertyGridControl1.SelectedObject = file
        End Sub
        Private Sub edit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
            Me.openFileDialog1.ShowDialog()
        End Sub
        Private Sub Form1_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
            Dim edit As New RepositoryItemButtonEdit()
            AddHandler edit.ButtonClick, AddressOf edit_ButtonClick
            TryCast(Me.propertyGridControl1.Rows(0), CategoryRow).ChildRows("rowPath2").Properties.RowEdit = edit
        End Sub
    End Class
End Namespace
