<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Personal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Personal))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ЛичныйНомерDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ФИОDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ДолжностьDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ДатаПриемаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПоследняяАктивностьDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ФотоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.АдресDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ТелефонDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ОтделDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ДополнительноDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ЛогинDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПарольDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПерсоналBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonalDataSet = New PRS_Trade_v._1._0.PersonalDataSet()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ПерсоналTableAdapter = New PRS_Trade_v._1._0.PersonalDataSetTableAdapters.ПерсоналTableAdapter()
        Me.TableAdapterManager1 = New PRS_Trade_v._1._0.PersonalDataSetTableAdapters.TableAdapterManager()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.ImageEditButtons1 = New PRS_Trade_v._1._0.ImageEditButtons()
        Me.SearchBox1 = New PRS_Trade_v._1._0.SearchBox()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПерсоналBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(897, 518)
        Me.SplitContainerControl1.SplitterPosition = 683
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SearchBox1)
        Me.GroupControl1.Controls.Add(Me.DataGridView1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(683, 518)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Список персонала (База Данных)"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.ЛичныйНомерDataGridViewTextBoxColumn, Me.ФИОDataGridViewTextBoxColumn, Me.ДолжностьDataGridViewTextBoxColumn, Me.ДатаПриемаDataGridViewTextBoxColumn, Me.ПоследняяАктивностьDataGridViewTextBoxColumn, Me.ФотоDataGridViewTextBoxColumn, Me.АдресDataGridViewTextBoxColumn, Me.ТелефонDataGridViewTextBoxColumn, Me.ОтделDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.ДополнительноDataGridViewTextBoxColumn, Me.ЛогинDataGridViewTextBoxColumn, Me.ПарольDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ПерсоналBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(679, 495)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "№"
        Me.DataGridViewTextBoxColumn1.HeaderText = "№"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'ЛичныйНомерDataGridViewTextBoxColumn
        '
        Me.ЛичныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Личный номер"
        Me.ЛичныйНомерDataGridViewTextBoxColumn.HeaderText = "Личный номер"
        Me.ЛичныйНомерDataGridViewTextBoxColumn.Name = "ЛичныйНомерDataGridViewTextBoxColumn"
        '
        'ФИОDataGridViewTextBoxColumn
        '
        Me.ФИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО"
        Me.ФИОDataGridViewTextBoxColumn.HeaderText = "ФИО"
        Me.ФИОDataGridViewTextBoxColumn.Name = "ФИОDataGridViewTextBoxColumn"
        '
        'ДолжностьDataGridViewTextBoxColumn
        '
        Me.ДолжностьDataGridViewTextBoxColumn.DataPropertyName = "Должность"
        Me.ДолжностьDataGridViewTextBoxColumn.HeaderText = "Должность"
        Me.ДолжностьDataGridViewTextBoxColumn.Name = "ДолжностьDataGridViewTextBoxColumn"
        '
        'ДатаПриемаDataGridViewTextBoxColumn
        '
        Me.ДатаПриемаDataGridViewTextBoxColumn.DataPropertyName = "Дата приема"
        Me.ДатаПриемаDataGridViewTextBoxColumn.HeaderText = "Дата приема"
        Me.ДатаПриемаDataGridViewTextBoxColumn.Name = "ДатаПриемаDataGridViewTextBoxColumn"
        '
        'ПоследняяАктивностьDataGridViewTextBoxColumn
        '
        Me.ПоследняяАктивностьDataGridViewTextBoxColumn.DataPropertyName = "Последняя активность"
        Me.ПоследняяАктивностьDataGridViewTextBoxColumn.HeaderText = "Последняя активность"
        Me.ПоследняяАктивностьDataGridViewTextBoxColumn.Name = "ПоследняяАктивностьDataGridViewTextBoxColumn"
        '
        'ФотоDataGridViewTextBoxColumn
        '
        Me.ФотоDataGridViewTextBoxColumn.DataPropertyName = "Фото"
        Me.ФотоDataGridViewTextBoxColumn.HeaderText = "Фото"
        Me.ФотоDataGridViewTextBoxColumn.Name = "ФотоDataGridViewTextBoxColumn"
        '
        'АдресDataGridViewTextBoxColumn
        '
        Me.АдресDataGridViewTextBoxColumn.DataPropertyName = "Адрес"
        Me.АдресDataGridViewTextBoxColumn.HeaderText = "Адрес"
        Me.АдресDataGridViewTextBoxColumn.Name = "АдресDataGridViewTextBoxColumn"
        '
        'ТелефонDataGridViewTextBoxColumn
        '
        Me.ТелефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон"
        Me.ТелефонDataGridViewTextBoxColumn.HeaderText = "Телефон"
        Me.ТелефонDataGridViewTextBoxColumn.Name = "ТелефонDataGridViewTextBoxColumn"
        '
        'ОтделDataGridViewTextBoxColumn
        '
        Me.ОтделDataGridViewTextBoxColumn.DataPropertyName = "Отдел"
        Me.ОтделDataGridViewTextBoxColumn.HeaderText = "Отдел"
        Me.ОтделDataGridViewTextBoxColumn.Name = "ОтделDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "E-mail"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "E-mail"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'ДополнительноDataGridViewTextBoxColumn
        '
        Me.ДополнительноDataGridViewTextBoxColumn.DataPropertyName = "Дополнительно"
        Me.ДополнительноDataGridViewTextBoxColumn.HeaderText = "Дополнительно"
        Me.ДополнительноDataGridViewTextBoxColumn.Name = "ДополнительноDataGridViewTextBoxColumn"
        '
        'ЛогинDataGridViewTextBoxColumn
        '
        Me.ЛогинDataGridViewTextBoxColumn.DataPropertyName = "Логин"
        Me.ЛогинDataGridViewTextBoxColumn.HeaderText = "Логин"
        Me.ЛогинDataGridViewTextBoxColumn.Name = "ЛогинDataGridViewTextBoxColumn"
        '
        'ПарольDataGridViewTextBoxColumn
        '
        Me.ПарольDataGridViewTextBoxColumn.DataPropertyName = "Пароль"
        Me.ПарольDataGridViewTextBoxColumn.HeaderText = "Пароль"
        Me.ПарольDataGridViewTextBoxColumn.Name = "ПарольDataGridViewTextBoxColumn"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'ПерсоналBindingSource
        '
        Me.ПерсоналBindingSource.DataMember = "Персонал"
        Me.ПерсоналBindingSource.DataSource = Me.PersonalDataSet
        '
        'PersonalDataSet
        '
        Me.PersonalDataSet.DataSetName = "PersonalDataSet"
        Me.PersonalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.GroupControl4)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(208, 518)
        Me.SplitContainerControl2.SplitterPosition = 169
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.BackColor = System.Drawing.Color.White
        Me.GroupControl2.Appearance.Options.UseBackColor = True
        Me.GroupControl2.Controls.Add(Me.ImageEditButtons1)
        Me.GroupControl2.Controls.Add(Me.pic)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(208, 169)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Фотография"
        '
        'pic
        '
        Me.pic.BackColor = System.Drawing.Color.Transparent
        Me.pic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic.Location = New System.Drawing.Point(2, 21)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(204, 146)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pic.TabIndex = 2
        Me.pic.TabStop = False
        '
        'GroupControl4
        '
        Me.GroupControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl4.Controls.Add(Me.Label11)
        Me.GroupControl4.Controls.Add(Me.Label10)
        Me.GroupControl4.Controls.Add(Me.Label9)
        Me.GroupControl4.Controls.Add(Me.Label8)
        Me.GroupControl4.Controls.Add(Me.Label7)
        Me.GroupControl4.Location = New System.Drawing.Point(0, 179)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(208, 165)
        Me.GroupControl4.TabIndex = 2
        Me.GroupControl4.Text = "Прочая информация"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Дополнительно:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "E-mail:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Отдел:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Телефон:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Адрес:"
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.Controls.Add(Me.Label6)
        Me.GroupControl3.Controls.Add(Me.Label5)
        Me.GroupControl3.Controls.Add(Me.Label4)
        Me.GroupControl3.Controls.Add(Me.Label3)
        Me.GroupControl3.Controls.Add(Me.Label2)
        Me.GroupControl3.Controls.Add(Me.Label1)
        Me.GroupControl3.Location = New System.Drawing.Point(0, 1)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(208, 172)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "Основная информация"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Логин:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Последняя активность:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Дата приема:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Должность:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ФИО:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Личный №:"
        '
        'ПерсоналTableAdapter
        '
        Me.ПерсоналTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = PRS_Trade_v._1._0.PersonalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.ПерсоналTableAdapter = Me.ПерсоналTableAdapter
        '
        'tmr
        '
        Me.tmr.Enabled = True
        '
        'ImageEditButtons1
        '
        Me.ImageEditButtons1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImageEditButtons1.BackColor = System.Drawing.Color.Transparent
        Me.ImageEditButtons1.BackgroundImage = CType(resources.GetObject("ImageEditButtons1.BackgroundImage"), System.Drawing.Image)
        Me.ImageEditButtons1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImageEditButtons1.Location = New System.Drawing.Point(45, 67)
        Me.ImageEditButtons1.MaximumSize = New System.Drawing.Size(119, 57)
        Me.ImageEditButtons1.MinimumSize = New System.Drawing.Size(119, 57)
        Me.ImageEditButtons1.Name = "ImageEditButtons1"
        Me.ImageEditButtons1.Size = New System.Drawing.Size(119, 57)
        Me.ImageEditButtons1.TabIndex = 1
        '
        'SearchBox1
        '
        Me.SearchBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchBox1.Location = New System.Drawing.Point(2, 21)
        Me.SearchBox1.Name = "SearchBox1"
        Me.SearchBox1.Size = New System.Drawing.Size(679, 35)
        Me.SearchBox1.TabIndex = 1
        Me.SearchBox1.Visible = False
        '
        'Personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 518)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "Personal"
        Me.Text = "Управление персоналом"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПерсоналBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ImageEditButtons1 As PRS_Trade_v._1._0.ImageEditButtons
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PersonalDataSet As PRS_Trade_v._1._0.PersonalDataSet
    Friend WithEvents ПерсоналBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ПерсоналTableAdapter As PRS_Trade_v._1._0.PersonalDataSetTableAdapters.ПерсоналTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЛичныйНомерDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ФИОDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДолжностьDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДатаПриемаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПоследняяАктивностьDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ФотоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents АдресDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ТелефонDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ОтделDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДополнительноDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЛогинDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПарольDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager1 As PRS_Trade_v._1._0.PersonalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tmr As System.Windows.Forms.Timer
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents SearchBox1 As PRS_Trade_v._1._0.SearchBox
End Class
