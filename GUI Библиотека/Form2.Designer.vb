<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Код_книгиLabel As System.Windows.Forms.Label
        Dim Код_читателяLabel As System.Windows.Forms.Label
        Dim Дата_выдачиLabel As System.Windows.Forms.Label
        Dim Дата_возвратаLabel As System.Windows.Forms.Label
        Dim Код_сотрудникаLabel As System.Windows.Forms.Label
        Dim Отметка_о_возвратеLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim Button1 As System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet1 = New GUI_Библиотека.DataSet1()
        Me.Выданные_книгиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Выданные_книгиTableAdapter = New GUI_Библиотека.DataSet1TableAdapters.Выданные_книгиTableAdapter()
        Me.TableAdapterManager = New GUI_Библиотека.DataSet1TableAdapters.TableAdapterManager()
        Me.Выданные_книгиBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Выданные_книгиBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Выданные_книгиDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Код_книгиTextBox = New System.Windows.Forms.TextBox()
        Me.Код_читателяTextBox = New System.Windows.Forms.TextBox()
        Me.Дата_выдачиDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Дата_возвратаDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Код_сотрудникаTextBox = New System.Windows.Forms.TextBox()
        Me.Отметка_о_возвратеCheckBox = New System.Windows.Forms.CheckBox()
        Код_книгиLabel = New System.Windows.Forms.Label()
        Код_читателяLabel = New System.Windows.Forms.Label()
        Дата_выдачиLabel = New System.Windows.Forms.Label()
        Дата_возвратаLabel = New System.Windows.Forms.Label()
        Код_сотрудникаLabel = New System.Windows.Forms.Label()
        Отметка_о_возвратеLabel = New System.Windows.Forms.Label()
        Button1 = New System.Windows.Forms.Button()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Выданные_книгиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Выданные_книгиBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Выданные_книгиBindingNavigator.SuspendLayout()
        CType(Me.Выданные_книгиDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Код_книгиLabel
        '
        Код_книгиLabel.AutoSize = True
        Код_книгиLabel.Location = New System.Drawing.Point(92, 398)
        Код_книгиLabel.Name = "Код_книгиLabel"
        Код_книгиLabel.Size = New System.Drawing.Size(61, 13)
        Код_книгиLabel.TabIndex = 3
        Код_книгиLabel.Text = "Код книги:"
        '
        'Код_читателяLabel
        '
        Код_читателяLabel.AutoSize = True
        Код_читателяLabel.Location = New System.Drawing.Point(91, 439)
        Код_читателяLabel.Name = "Код_читателяLabel"
        Код_читателяLabel.Size = New System.Drawing.Size(77, 13)
        Код_читателяLabel.TabIndex = 5
        Код_читателяLabel.Text = "Код читателя:"
        '
        'Дата_выдачиLabel
        '
        Дата_выдачиLabel.AutoSize = True
        Дата_выдачиLabel.Location = New System.Drawing.Point(91, 478)
        Дата_выдачиLabel.Name = "Дата_выдачиLabel"
        Дата_выдачиLabel.Size = New System.Drawing.Size(76, 13)
        Дата_выдачиLabel.TabIndex = 7
        Дата_выдачиLabel.Text = "Дата выдачи:"
        '
        'Дата_возвратаLabel
        '
        Дата_возвратаLabel.AutoSize = True
        Дата_возвратаLabel.Location = New System.Drawing.Point(92, 511)
        Дата_возвратаLabel.Name = "Дата_возвратаLabel"
        Дата_возвратаLabel.Size = New System.Drawing.Size(86, 13)
        Дата_возвратаLabel.TabIndex = 9
        Дата_возвратаLabel.Text = "Дата возврата:"
        '
        'Код_сотрудникаLabel
        '
        Код_сотрудникаLabel.AutoSize = True
        Код_сотрудникаLabel.Location = New System.Drawing.Point(92, 536)
        Код_сотрудникаLabel.Name = "Код_сотрудникаLabel"
        Код_сотрудникаLabel.Size = New System.Drawing.Size(90, 13)
        Код_сотрудникаLabel.TabIndex = 11
        Код_сотрудникаLabel.Text = "Код сотрудника:"
        '
        'Отметка_о_возвратеLabel
        '
        Отметка_о_возвратеLabel.AutoSize = True
        Отметка_о_возвратеLabel.Location = New System.Drawing.Point(92, 564)
        Отметка_о_возвратеLabel.Name = "Отметка_о_возвратеLabel"
        Отметка_о_возвратеLabel.Size = New System.Drawing.Size(113, 13)
        Отметка_о_возвратеLabel.TabIndex = 13
        Отметка_о_возвратеLabel.Text = "Отметка о возврате:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.Location = New System.Drawing.Point(298, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Выданные книги"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Выданные_книгиBindingSource
        '
        Me.Выданные_книгиBindingSource.DataMember = "Выданные книги"
        Me.Выданные_книгиBindingSource.DataSource = Me.DataSet1
        '
        'Выданные_книгиTableAdapter
        '
        Me.Выданные_книгиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = GUI_Библиотека.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Выданные_книгиTableAdapter = Me.Выданные_книгиTableAdapter
        Me.TableAdapterManager.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager.ЖанрыTableAdapter = Nothing
        Me.TableAdapterManager.ИздательстваTableAdapter = Nothing
        Me.TableAdapterManager.КнигиTableAdapter = Nothing
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.ЧитателиTableAdapter = Nothing
        '
        'Выданные_книгиBindingNavigator
        '
        Me.Выданные_книгиBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Выданные_книгиBindingNavigator.BindingSource = Me.Выданные_книгиBindingSource
        Me.Выданные_книгиBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Выданные_книгиBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Выданные_книгиBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Выданные_книгиBindingNavigatorSaveItem})
        Me.Выданные_книгиBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Выданные_книгиBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Выданные_книгиBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Выданные_книгиBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Выданные_книгиBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Выданные_книгиBindingNavigator.Name = "Выданные_книгиBindingNavigator"
        Me.Выданные_книгиBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Выданные_книгиBindingNavigator.Size = New System.Drawing.Size(894, 25)
        Me.Выданные_книгиBindingNavigator.TabIndex = 1
        Me.Выданные_книгиBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 22)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Выданные_книгиBindingNavigatorSaveItem
        '
        Me.Выданные_книгиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Выданные_книгиBindingNavigatorSaveItem.Image = CType(resources.GetObject("Выданные_книгиBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Выданные_книгиBindingNavigatorSaveItem.Name = "Выданные_книгиBindingNavigatorSaveItem"
        Me.Выданные_книгиBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Выданные_книгиBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Выданные_книгиDataGridView
        '
        Me.Выданные_книгиDataGridView.AutoGenerateColumns = False
        Me.Выданные_книгиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Выданные_книгиDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1})
        Me.Выданные_книгиDataGridView.DataSource = Me.Выданные_книгиBindingSource
        Me.Выданные_книгиDataGridView.Location = New System.Drawing.Point(75, 129)
        Me.Выданные_книгиDataGridView.Name = "Выданные_книгиDataGridView"
        Me.Выданные_книгиDataGridView.Size = New System.Drawing.Size(655, 225)
        Me.Выданные_книгиDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Код книги"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Код книги"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Код читателя"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Код читателя"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Дата возврата"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Дата возврата"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Код сотрудника"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Код сотрудника"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Отметка о возврате"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Отметка о возврате"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'Код_книгиTextBox
        '
        Me.Код_книгиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Выданные_книгиBindingSource, "Код книги", True))
        Me.Код_книгиTextBox.Location = New System.Drawing.Point(211, 395)
        Me.Код_книгиTextBox.Name = "Код_книгиTextBox"
        Me.Код_книгиTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Код_книгиTextBox.TabIndex = 4
        '
        'Код_читателяTextBox
        '
        Me.Код_читателяTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Выданные_книгиBindingSource, "Код читателя", True))
        Me.Код_читателяTextBox.Location = New System.Drawing.Point(211, 436)
        Me.Код_читателяTextBox.Name = "Код_читателяTextBox"
        Me.Код_читателяTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Код_читателяTextBox.TabIndex = 6
        '
        'Дата_выдачиDateTimePicker
        '
        Me.Дата_выдачиDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Выданные_книгиBindingSource, "Дата выдачи", True))
        Me.Дата_выдачиDateTimePicker.Location = New System.Drawing.Point(211, 478)
        Me.Дата_выдачиDateTimePicker.Name = "Дата_выдачиDateTimePicker"
        Me.Дата_выдачиDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_выдачиDateTimePicker.TabIndex = 8
        '
        'Дата_возвратаDateTimePicker
        '
        Me.Дата_возвратаDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Выданные_книгиBindingSource, "Дата возврата", True))
        Me.Дата_возвратаDateTimePicker.Location = New System.Drawing.Point(211, 507)
        Me.Дата_возвратаDateTimePicker.Name = "Дата_возвратаDateTimePicker"
        Me.Дата_возвратаDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_возвратаDateTimePicker.TabIndex = 10
        '
        'Код_сотрудникаTextBox
        '
        Me.Код_сотрудникаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Выданные_книгиBindingSource, "Код сотрудника", True))
        Me.Код_сотрудникаTextBox.Location = New System.Drawing.Point(211, 533)
        Me.Код_сотрудникаTextBox.Name = "Код_сотрудникаTextBox"
        Me.Код_сотрудникаTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Код_сотрудникаTextBox.TabIndex = 12
        '
        'Отметка_о_возвратеCheckBox
        '
        Me.Отметка_о_возвратеCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Выданные_книгиBindingSource, "Отметка о возврате", True))
        Me.Отметка_о_возвратеCheckBox.Location = New System.Drawing.Point(211, 559)
        Me.Отметка_о_возвратеCheckBox.Name = "Отметка_о_возвратеCheckBox"
        Me.Отметка_о_возвратеCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.Отметка_о_возвратеCheckBox.TabIndex = 14
        Me.Отметка_о_возвратеCheckBox.Text = "Есть или нет"
        Me.Отметка_о_возвратеCheckBox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Button1.Location = New System.Drawing.Point(783, 44)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(81, 29)
        Button1.TabIndex = 15
        Button1.Text = "Назад"
        Button1.UseVisualStyleBackColor = True
        AddHandler Button1.Click, AddressOf Me.Button1_Click
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 608)
        Me.Controls.Add(Button1)
        Me.Controls.Add(Код_книгиLabel)
        Me.Controls.Add(Me.Код_книгиTextBox)
        Me.Controls.Add(Код_читателяLabel)
        Me.Controls.Add(Me.Код_читателяTextBox)
        Me.Controls.Add(Дата_выдачиLabel)
        Me.Controls.Add(Me.Дата_выдачиDateTimePicker)
        Me.Controls.Add(Дата_возвратаLabel)
        Me.Controls.Add(Me.Дата_возвратаDateTimePicker)
        Me.Controls.Add(Код_сотрудникаLabel)
        Me.Controls.Add(Me.Код_сотрудникаTextBox)
        Me.Controls.Add(Отметка_о_возвратеLabel)
        Me.Controls.Add(Me.Отметка_о_возвратеCheckBox)
        Me.Controls.Add(Me.Выданные_книгиDataGridView)
        Me.Controls.Add(Me.Выданные_книгиBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Выданные_книгиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Выданные_книгиBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Выданные_книгиBindingNavigator.ResumeLayout(False)
        Me.Выданные_книгиBindingNavigator.PerformLayout()
        CType(Me.Выданные_книгиDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents Выданные_книгиBindingSource As BindingSource
    Friend WithEvents Выданные_книгиTableAdapter As DataSet1TableAdapters.Выданные_книгиTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Выданные_книгиBindingNavigator As BindingNavigator
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
    Friend WithEvents Выданные_книгиBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Выданные_книгиDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents Код_книгиTextBox As TextBox
    Friend WithEvents Код_читателяTextBox As TextBox
    Friend WithEvents Дата_выдачиDateTimePicker As DateTimePicker
    Friend WithEvents Дата_возвратаDateTimePicker As DateTimePicker
    Friend WithEvents Код_сотрудникаTextBox As TextBox
    Friend WithEvents Отметка_о_возвратеCheckBox As CheckBox
End Class
