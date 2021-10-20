<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form20
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form20))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataSet3 = New GUI_Библиотека.DataSet3()
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___TableAdapter = New GUI_Библиотека.DataSet3TableAdapters.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___TableAdapter()
        Me.TableAdapterManager = New GUI_Библиотека.DataSet3TableAdapters.TableAdapterManager()
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.SuspendLayout()
        CType(Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1005, 31)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Отображения сданных и не сданных книг на основе запроса "" Книги на руках """
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(1223, 530)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 67)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "Назад"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingSource
        '
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingSource.DataMember = "Фильтры для отображения сданных и не сданных книг (На основе запроса "" Книги на р" &
    "уках "")"
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingSource.DataSource = Me.DataSet3
        '
        'Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___TableAdapter
        '
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = GUI_Библиотека.DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator
        '
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.BindingSource = Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingSource
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigatorSaveItem})
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.Name = "Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_р" &
    "уках___BindingNavigator"
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.Size = New System.Drawing.Size(1426, 25)
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.TabIndex = 88
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 15)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigatorSaveItem
        '
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigatorSaveItem.Enabled = False
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigatorSaveItem.Image = CType(resources.GetObject("Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_р" &
        "уках___BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigatorSaveItem.Name = "Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_р" &
    "уках___BindingNavigatorSaveItem"
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___DataGridView
        '
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___DataGridView.AutoGenerateColumns = False
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___DataGridView.DataSource = Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingSource
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___DataGridView.Location = New System.Drawing.Point(42, 119)
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___DataGridView.Name = "Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_р" &
    "уках___DataGridView"
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___DataGridView.Size = New System.Drawing.Size(1282, 362)
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___DataGridView.TabIndex = 88
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ФИО сотрудников"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ФИО сотрудников"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Отметка о возврате"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Отметка о возврате"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Дата возврата"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Дата возврата"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Дата выдачи"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Дата выдачи"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ФИО читателя"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ФИО читателя"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Дата рождения читателя"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Дата рождения читателя"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Пол читателя"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Пол читателя"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Адрес читателя"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Адрес читателя"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Паспортные данные"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Паспортные данные"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Наименование"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Наименование"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Автор"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Автор"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Год издания"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Год издания"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Form20
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1426, 623)
        Me.Controls.Add(Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___DataGridView)
        Me.Controls.Add(Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form20"
        Me.Text = "Form20"
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.ResumeLayout(False)
        Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator.PerformLayout()
        CType(Me.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataSet3 As DataSet3
    Friend WithEvents Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingSource As BindingSource
    Friend WithEvents Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___TableAdapter As DataSet3TableAdapters.Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___TableAdapter
    Friend WithEvents TableAdapterManager As DataSet3TableAdapters.TableAdapterManager
    Friend WithEvents Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Фильтры_для_отображения_сданных_и_не_сданных_книг__На_основе_запроса___Книги_на_руках___DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
End Class
