Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms

Namespace T415077.UIEditors

    Friend Class FilteredFileNameEditor
        Inherits UITypeEditor

        Private ofd As OpenFileDialog = New OpenFileDialog()

        Public Overrides Function GetEditStyle(ByVal context As ITypeDescriptorContext) As UITypeEditorEditStyle
            Return UITypeEditorEditStyle.Modal
        End Function

        Public Overrides Function EditValue(ByVal context As ITypeDescriptorContext, ByVal provider As IServiceProvider, ByVal value As Object) As Object
            ofd.FileName = value.ToString()
            ofd.Filter = "Text File|*.txt|All Files|*.*"
            If ofd.ShowDialog() = DialogResult.OK Then
                Return ofd.FileName
            End If

            Return MyBase.EditValue(context, provider, value)
        End Function
    End Class
End Namespace
