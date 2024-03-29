Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class TimeScalesEditForm
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
Me.btnDefaults = New DevExpress.XtraEditors.SimpleButton
Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
Me.btnRemove = New DevExpress.XtraEditors.SimpleButton
Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
Me.lbTimeScales = New DevExpress.XtraEditors.ListBoxControl
Me.propertyGrid1 = New DevExpress.XtraVerticalGrid.PropertyGridControl
CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
Me.splitContainerControl1.SuspendLayout()
CType(Me.lbTimeScales, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.propertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'btnDefaults
'
Me.btnDefaults.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
Me.btnDefaults.ImageIndex = 2
Me.btnDefaults.Location = New System.Drawing.Point(255, 288)
Me.btnDefaults.Name = "btnDefaults"
Me.btnDefaults.Size = New System.Drawing.Size(125, 24)
Me.btnDefaults.TabIndex = 30
Me.btnDefaults.Text = "Restore &Defaults"
'
'btnAdd
'
Me.btnAdd.ImageIndex = 2
Me.btnAdd.Location = New System.Drawing.Point(12, 288)
Me.btnAdd.Name = "btnAdd"
Me.btnAdd.Size = New System.Drawing.Size(80, 24)
Me.btnAdd.TabIndex = 29
Me.btnAdd.Text = "&Add"
'
'btnRemove
'
Me.btnRemove.ImageIndex = 2
Me.btnRemove.Location = New System.Drawing.Point(98, 288)
Me.btnRemove.Name = "btnRemove"
Me.btnRemove.Size = New System.Drawing.Size(80, 24)
Me.btnRemove.TabIndex = 28
Me.btnRemove.Text = "&Remove"
'
'splitContainerControl1
'
Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Top
Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
Me.splitContainerControl1.Name = "splitContainerControl1"
Me.splitContainerControl1.Panel1.Controls.Add(Me.lbTimeScales)
Me.splitContainerControl1.Panel1.Text = "Panel1"
Me.splitContainerControl1.Panel2.Controls.Add(Me.propertyGrid1)
Me.splitContainerControl1.Panel2.Text = "Panel2"
Me.splitContainerControl1.Size = New System.Drawing.Size(392, 282)
Me.splitContainerControl1.SplitterPosition = 182
Me.splitContainerControl1.TabIndex = 29
Me.splitContainerControl1.Text = "splitContainerControl1"
'
'lbTimeScales
'
Me.lbTimeScales.Dock = System.Windows.Forms.DockStyle.Fill
Me.lbTimeScales.ItemHeight = 16
Me.lbTimeScales.Location = New System.Drawing.Point(0, 0)
Me.lbTimeScales.Name = "lbTimeScales"
Me.lbTimeScales.Size = New System.Drawing.Size(182, 282)
Me.lbTimeScales.TabIndex = 26
'
'propertyGrid1
'
Me.propertyGrid1.AutoGenerateRows = True
Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
Me.propertyGrid1.Location = New System.Drawing.Point(0, 0)
Me.propertyGrid1.Name = "propertyGrid1"
Me.propertyGrid1.OptionsView.ShowRootCategories = False
Me.propertyGrid1.Size = New System.Drawing.Size(205, 282)
Me.propertyGrid1.TabIndex = 25
'
'TimeScalesEditForm
'
Me.ClientSize = New System.Drawing.Size(392, 324)
Me.Controls.Add(Me.btnDefaults)
Me.Controls.Add(Me.btnAdd)
Me.Controls.Add(Me.splitContainerControl1)
Me.Controls.Add(Me.btnRemove)
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
Me.Name = "TimeScalesEditForm"
Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
Me.Text = "TimeScales"
CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
Me.splitContainerControl1.ResumeLayout(False)
CType(Me.lbTimeScales, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.propertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)

End Sub

		#End Region
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		Private WithEvents btnDefaults As SimpleButton
		Private WithEvents btnAdd As SimpleButton
		Private WithEvents btnRemove As SimpleButton
		Private splitContainerControl1 As SplitContainerControl
		Private WithEvents lbTimeScales As ListBoxControl
		Private propertyGrid1 As PropertyGridControl
	End Class
End Namespace
