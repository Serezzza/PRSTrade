<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Postavshiki
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ЛичныйDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.НаименованиеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ИННDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ДатаПриемаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.КолвоЗаказовDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.АдресDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.КонтактыDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ДополнительноDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПоставщикиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PostavshikiDataSet = New PRS_Trade_v._1._0.PostavshikiDataSet()
        Me.ПоставщикиTableAdapter = New PRS_Trade_v._1._0.PostavshikiDataSetTableAdapters.ПоставщикиTableAdapter()
        Me.TableAdapterManager1 = New PRS_Trade_v._1._0.PostavshikiDataSetTableAdapters.TableAdapterManager()
        Me.SearchBox1 = New PRS_Trade_v._1._0.SearchBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПоставщикиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostavshikiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.ЛичныйDataGridViewTextBoxColumn, Me.НаименованиеDataGridViewTextBoxColumn, Me.ИННDataGridViewTextBoxColumn, Me.ДатаПриемаDataGridViewTextBoxColumn, Me.КолвоЗаказовDataGridViewTextBoxColumn, Me.АдресDataGridViewTextBoxColumn, Me.КонтактыDataGridViewTextBoxColumn, Me.ДополнительноDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ПоставщикиBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(753, 389)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "№"
        Me.DataGridViewTextBoxColumn1.HeaderText = "№"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'ЛичныйDataGridViewTextBoxColumn
        '
        Me.ЛичныйDataGridViewTextBoxColumn.DataPropertyName = "Личный №"
        Me.ЛичныйDataGridViewTextBoxColumn.HeaderText = "Личный №"
        Me.ЛичныйDataGridViewTextBoxColumn.Name = "ЛичныйDataGridViewTextBoxColumn"
        '
        'НаименованиеDataGridViewTextBoxColumn
        '
        Me.НаименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование"
        Me.НаименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование"
        Me.НаименованиеDataGridViewTextBoxColumn.Name = "НаименованиеDataGridViewTextBoxColumn"
        '
        'ИННDataGridViewTextBoxColumn
        '
        Me.ИННDataGridViewTextBoxColumn.DataPropertyName = "ИНН"
        Me.ИННDataGridViewTextBoxColumn.HeaderText = "ИНН"
        Me.ИННDataGridViewTextBoxColumn.Name = "ИННDataGridViewTextBoxColumn"
        '
        'ДатаПриемаDataGridViewTextBoxColumn
        '
        Me.ДатаПриемаDataGridViewTextBoxColumn.DataPropertyName = "Дата приема"
        Me.ДатаПриемаDataGridViewTextBoxColumn.HeaderText = "Дата приема"
        Me.ДатаПриемаDataGridViewTextBoxColumn.Name = "ДатаПриемаDataGridViewTextBoxColumn"
        '
        'КолвоЗаказовDataGridViewTextBoxColumn
        '
        Me.КолвоЗаказовDataGridViewTextBoxColumn.DataPropertyName = "Кол-во заказов"
        Me.КолвоЗаказовDataGridViewTextBoxColumn.HeaderText = "Кол-во заказов"
        Me.КолвоЗаказовDataGridViewTextBoxColumn.Name = "КолвоЗаказовDataGridViewTextBoxColumn"
        '
        'АдресDataGridViewTextBoxColumn
        '
        Me.АдресDataGridViewTextBoxColumn.DataPropertyName = "Адрес"
        Me.АдресDataGridViewTextBoxColumn.HeaderText = "Адрес"
        Me.АдресDataGridViewTextBoxColumn.Name = "АдресDataGridViewTextBoxColumn"
        '
        'КонтактыDataGridViewTextBoxColumn
        '
        Me.КонтактыDataGridViewTextBoxColumn.DataPropertyName = "Контакты"
        Me.КонтактыDataGridViewTextBoxColumn.HeaderText = "Контакты"
        Me.КонтактыDataGridViewTextBoxColumn.Name = "КонтактыDataGridViewTextBoxColumn"
        '
        'ДополнительноDataGridViewTextBoxColumn
        '
        Me.ДополнительноDataGridViewTextBoxColumn.DataPropertyName = "Дополнительно"
        Me.ДополнительноDataGridViewTextBoxColumn.HeaderText = "Дополнительно"
        Me.ДополнительноDataGridViewTextBoxColumn.Name = "ДополнительноDataGridViewTextBoxColumn"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'ПоставщикиBindingSource
        '
        Me.ПоставщикиBindingSource.DataMember = "Поставщики"
        Me.ПоставщикиBindingSource.DataSource = Me.PostavshikiDataSet
        '
        'PostavshikiDataSet
        '
        Me.PostavshikiDataSet.DataSetName = "PostavshikiDataSet"
        Me.PostavshikiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ПоставщикиTableAdapter
        '
        Me.ПоставщикиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = PRS_Trade_v._1._0.PostavshikiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.ПоставщикиTableAdapter = Me.ПоставщикиTableAdapter
        '
        'SearchBox1
        '
        Me.SearchBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchBox1.Location = New System.Drawing.Point(0, 0)
        Me.SearchBox1.Name = "SearchBox1"
        Me.SearchBox1.Size = New System.Drawing.Size(753, 34)
        Me.SearchBox1.TabIndex = 1
        Me.SearchBox1.Visible = False
        '
        'Postavshiki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 389)
        Me.Controls.Add(Me.SearchBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Postavshiki"
        Me.Text = "Поставщики"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПоставщикиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostavshikiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PostavshikiDataSet As PRS_Trade_v._1._0.PostavshikiDataSet
    Friend WithEvents ПоставщикиBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ПоставщикиTableAdapter As PRS_Trade_v._1._0.PostavshikiDataSetTableAdapters.ПоставщикиTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЛичныйDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents НаименованиеDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ИННDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДатаПриемаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents КолвоЗаказовDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents АдресDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents КонтактыDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДополнительноDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager1 As PRS_Trade_v._1._0.PostavshikiDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SearchBox1 As PRS_Trade_v._1._0.SearchBox
End Class
