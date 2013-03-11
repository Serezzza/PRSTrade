<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Camera
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Camera))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.picOutput = New System.Windows.Forms.PictureBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.picOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.picOutput)
        Me.GroupControl1.Location = New System.Drawing.Point(1, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(457, 318)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Нажмите кнопку ""Сфотографировать"" для сохранения изображения"
        '
        'picOutput
        '
        Me.picOutput.BackColor = System.Drawing.Color.Black
        Me.picOutput.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picOutput.Location = New System.Drawing.Point(60, 24)
        Me.picOutput.Name = "picOutput"
        Me.picOutput.Size = New System.Drawing.Size(350, 269)
        Me.picOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOutput.TabIndex = 0
        Me.picOutput.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SimpleButton1.Location = New System.Drawing.Point(157, 324)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(141, 35)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Сф&отографировать"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SimpleButton2.Location = New System.Drawing.Point(304, 324)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(141, 35)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "О&тмена"
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Interval = 500
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SimpleButton3.Location = New System.Drawing.Point(16, 325)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(135, 34)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "Включить камеру"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 299)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(195, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Частота видеозаписи (кадров\с) FPS: "
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(212, 299)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "0"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(4, 366)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 20)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.Teal
        Me.LabelControl14.Location = New System.Drawing.Point(29, 368)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(382, 13)
        Me.LabelControl14.TabIndex = 25
        Me.LabelControl14.Text = "Включите камеру и сделайте снимок. Для получения справки нажмите F1."
        '
        'Camera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 389)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Camera"
        Me.Text = "Камера - фотография в профиль"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.picOutput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents picOutput As System.Windows.Forms.PictureBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
End Class
