Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraScheduler.Demos.Forms
	Public Partial Class UserDefinedFilterAppointmentForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
            Me.lblPrice = New System.Windows.Forms.Label
            Me.edtPrice = New DevExpress.XtraEditors.CalcEdit
            CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtStartDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtEndDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chkAllDay
            '
            '
            'edtLabel
            '
            '
            'edtShowTimeAs
            '
            '
            'tbSubject
            '
            '
            'edtResource
            '
            '
            'edtResources
            '
            '
            'chkReminder
            '
            '
            'tbDescription
            '
            Me.tbDescription.Location = New System.Drawing.Point(16, 198)
            Me.tbDescription.Size = New System.Drawing.Size(496, 144)
            Me.tbDescription.TabIndex = 15
            '
            'cbReminder
            '
            '
            'tbLocation
            '
            '
            'lblPrice
            '
            Me.lblPrice.AutoSize = True
            Me.lblPrice.Location = New System.Drawing.Point(16, 168)
            Me.lblPrice.Name = "lblPrice"
            Me.lblPrice.Size = New System.Drawing.Size(34, 13)
            Me.lblPrice.TabIndex = 37
            Me.lblPrice.Text = "&Price:"
            '
            'edtPrice
            '
            Me.edtPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.edtPrice.Location = New System.Drawing.Point(96, 165)
            Me.edtPrice.Name = "edtPrice"
            Me.edtPrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.edtPrice.Size = New System.Drawing.Size(216, 19)
            Me.edtPrice.TabIndex = 14
            '
            'UserDefinedFilterAppointmentForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(528, 382)
            Me.Controls.Add(Me.edtPrice)
            Me.Controls.Add(Me.lblPrice)
            Me.Name = "UserDefinedFilterAppointmentForm"
            Me.Controls.SetChildIndex(Me.tbDescription, 0)
            Me.Controls.SetChildIndex(Me.lblPrice, 0)
            Me.Controls.SetChildIndex(Me.edtPrice, 0)
            Me.Controls.SetChildIndex(Me.edtResources, 0)
            Me.Controls.SetChildIndex(Me.edtShowTimeAs, 0)
            Me.Controls.SetChildIndex(Me.edtEndTime, 0)
            Me.Controls.SetChildIndex(Me.edtEndDate, 0)
            Me.Controls.SetChildIndex(Me.btnRecurrence, 0)
            Me.Controls.SetChildIndex(Me.btnDelete, 0)
            Me.Controls.SetChildIndex(Me.btnCancel, 0)
            Me.Controls.SetChildIndex(Me.lblShowTimeAs, 0)
            Me.Controls.SetChildIndex(Me.lblEndTime, 0)
            Me.Controls.SetChildIndex(Me.lblLabel, 0)
            Me.Controls.SetChildIndex(Me.tbLocation, 0)
            Me.Controls.SetChildIndex(Me.lblSubject, 0)
            Me.Controls.SetChildIndex(Me.lblLocation, 0)
            Me.Controls.SetChildIndex(Me.tbSubject, 0)
            Me.Controls.SetChildIndex(Me.lblStartTime, 0)
            Me.Controls.SetChildIndex(Me.chkAllDay, 0)
            Me.Controls.SetChildIndex(Me.btnOk, 0)
            Me.Controls.SetChildIndex(Me.edtStartDate, 0)
            Me.Controls.SetChildIndex(Me.edtStartTime, 0)
            Me.Controls.SetChildIndex(Me.edtLabel, 0)
            Me.Controls.SetChildIndex(Me.chkReminder, 0)
            Me.Controls.SetChildIndex(Me.cbReminder, 0)
            Me.Controls.SetChildIndex(Me.lblResource, 0)
            Me.Controls.SetChildIndex(Me.edtResource, 0)
            CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtStartDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtEndDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private lblPrice As System.Windows.Forms.Label
		Private WithEvents edtPrice As DevExpress.XtraEditors.CalcEdit
	End Class
End Namespace
