Namespace T415077
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
            Me.barEditItem2 = New DevExpress.XtraBars.BarEditItem()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
            Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2, Me.bar3})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barEditItem1, Me.barEditItem2, Me.barButtonItem1})
            Me.barManager1.MainMenu = Me.bar2
            Me.barManager1.MaxItemId = 5
            Me.barManager1.StatusBar = Me.bar3
            ' 
            ' bar1
            ' 
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 1
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.Text = "Tools"
            ' 
            ' bar2
            ' 
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.Text = "Main menu"
            ' 
            ' bar3
            ' 
            Me.bar3.BarName = "Status bar"
            Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar3.DockCol = 0
            Me.bar3.DockRow = 0
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar3.OptionsBar.AllowQuickCustomization = False
            Me.bar3.OptionsBar.DrawDragBorder = False
            Me.bar3.OptionsBar.UseWholeRow = True
            Me.bar3.Text = "Status bar"
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(853, 49)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 307)
            Me.barDockControlBottom.Size = New System.Drawing.Size(853, 23)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 49)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 258)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(853, 49)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 258)
            ' 
            ' barEditItem1
            '     
            Me.barEditItem1.Caption = "button"
            Me.barEditItem1.Edit = Nothing
            Me.barEditItem1.Id = 1
            Me.barEditItem1.Name = "barEditItem1"
            ' 
            ' barEditItem2
            '        
            Me.barEditItem2.Caption = "button 2"
            Me.barEditItem2.Edit = Nothing
            Me.barEditItem2.Id = 2
            Me.barEditItem2.Name = "barEditItem2"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "barButtonItem1"
            Me.barButtonItem1.Id = 3
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' propertyGridControl1
            ' 
            Me.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.propertyGridControl1.Location = New System.Drawing.Point(0, 49)
            Me.propertyGridControl1.Name = "propertyGridControl1"
            Me.propertyGridControl1.OptionsBehavior.AllowDynamicRowLoading = False
            Me.propertyGridControl1.Size = New System.Drawing.Size(260, 258)
            Me.propertyGridControl1.TabIndex = 4
            ' 
            ' openFileDialog1
            ' 
            Me.openFileDialog1.FileName = "openFileDialog1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(853, 330)
            Me.Controls.Add(Me.propertyGridControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private barManager1 As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Private bar2 As DevExpress.XtraBars.Bar
        Private barEditItem1 As DevExpress.XtraBars.BarEditItem

        Private barEditItem2 As DevExpress.XtraBars.BarEditItem
        Private bar3 As DevExpress.XtraBars.Bar
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Private propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
        Private openFileDialog1 As System.Windows.Forms.OpenFileDialog




    End Class
End Namespace

