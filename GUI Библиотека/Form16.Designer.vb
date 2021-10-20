<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form16
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form16))
        Dim ФИО_сотрудниковLabel As System.Windows.Forms.Label
        Dim ФИО_читателяLabel As System.Windows.Forms.Label
        Dim Дата_рождения_читателяLabel As System.Windows.Forms.Label
        Dim Пол_читателяLabel As System.Windows.Forms.Label
        Dim Адрес_читателяLabel As System.Windows.Forms.Label
        Dim ТелефонLabel As System.Windows.Forms.Label
        Dim Паспортные_данныеLabel As System.Windows.Forms.Label
        Dim НаименованиеLabel As System.Windows.Forms.Label
        Dim АвторLabel As System.Windows.Forms.Label
        Dim Год_изданияLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet3 = New GUI_Библиотека.DataSet3()
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейTableAdapter = New GUI_Библиотека.DataSet3TableAdapters.Фильтры_для_отображения_книг_на_руках_отдельных_читателейTableAdapter()
        Me.TableAdapterManager = New GUI_Библиотека.DataSet3TableAdapters.TableAdapterManager()
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ФИО_сотрудниковTextBox = New System.Windows.Forms.TextBox()
        Me.ФИО_читателяTextBox = New System.Windows.Forms.TextBox()
        Me.Дата_рождения_читателяDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Пол_читателяTextBox = New System.Windows.Forms.TextBox()
        Me.Адрес_читателяTextBox = New System.Windows.Forms.TextBox()
        Me.ТелефонTextBox = New System.Windows.Forms.TextBox()
        Me.Паспортные_данныеTextBox = New System.Windows.Forms.TextBox()
        Me.НаименованиеTextBox = New System.Windows.Forms.TextBox()
        Me.АвторTextBox = New System.Windows.Forms.TextBox()
        Me.Год_изданияTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        ФИО_сотрудниковLabel = New System.Windows.Forms.Label()
        ФИО_читателяLabel = New System.Windows.Forms.Label()
        Дата_рождения_читателяLabel = New System.Windows.Forms.Label()
        Пол_читателяLabel = New System.Windows.Forms.Label()
        Адрес_читателяLabel = New System.Windows.Forms.Label()
        ТелефонLabel = New System.Windows.Forms.Label()
        Паспортные_данныеLabel = New System.Windows.Forms.Label()
        НаименованиеLabel = New System.Windows.Forms.Label()
        АвторLabel = New System.Windows.Forms.Label()
        Год_изданияLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(638, 31)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Отображения книг на руках отдельных читателей"
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource
        '
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource.DataMember = "Фильтры для отображения книг на руках отдельных читателей"
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource.DataSource = Me.DataSet3
        '
        'Фильтры_для_отображения_книг_на_руках_отдельных_читателейTableAdapter
        '
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = GUI_Библиотека.DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator
        '
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.BindingSource = Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigatorSaveItem})
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.Name = "Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator"
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.Size = New System.Drawing.Size(886, 25)
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.TabIndex = 32
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.Text = "BindingNavigator1"
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
        'Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigatorSaveItem
        '
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigatorSaveItem.Enabled = False
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigatorSaveItem.Image = CType(resources.GetObject("Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigatorSaveItem" &
        ".Image"), System.Drawing.Image)
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigatorSaveItem.Name = "Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigatorSaveItem" &
    ""
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'ФИО_сотрудниковLabel
        '
        ФИО_сотрудниковLabel.AutoSize = True
        ФИО_сотрудниковLabel.Location = New System.Drawing.Point(305, 122)
        ФИО_сотрудниковLabel.Name = "ФИО_сотрудниковLabel"
        ФИО_сотрудниковLabel.Size = New System.Drawing.Size(104, 13)
        ФИО_сотрудниковLabel.TabIndex = 32
        ФИО_сотрудниковLabel.Text = "ФИО сотрудников:"
        '
        'ФИО_сотрудниковTextBox
        '
        Me.ФИО_сотрудниковTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource, "ФИО сотрудников", True))
        Me.ФИО_сотрудниковTextBox.Location = New System.Drawing.Point(448, 119)
        Me.ФИО_сотрудниковTextBox.Name = "ФИО_сотрудниковTextBox"
        Me.ФИО_сотрудниковTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ФИО_сотрудниковTextBox.TabIndex = 33
        '
        'ФИО_читателяLabel
        '
        ФИО_читателяLabel.AutoSize = True
        ФИО_читателяLabel.Location = New System.Drawing.Point(305, 148)
        ФИО_читателяLabel.Name = "ФИО_читателяLabel"
        ФИО_читателяLabel.Size = New System.Drawing.Size(85, 13)
        ФИО_читателяLabel.TabIndex = 34
        ФИО_читателяLabel.Text = "ФИО читателя:"
        '
        'ФИО_читателяTextBox
        '
        Me.ФИО_читателяTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource, "ФИО читателя", True))
        Me.ФИО_читателяTextBox.Location = New System.Drawing.Point(448, 145)
        Me.ФИО_читателяTextBox.Name = "ФИО_читателяTextBox"
        Me.ФИО_читателяTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ФИО_читателяTextBox.TabIndex = 35
        '
        'Дата_рождения_читателяLabel
        '
        Дата_рождения_читателяLabel.AutoSize = True
        Дата_рождения_читателяLabel.Location = New System.Drawing.Point(305, 175)
        Дата_рождения_читателяLabel.Name = "Дата_рождения_читателяLabel"
        Дата_рождения_читателяLabel.Size = New System.Drawing.Size(137, 13)
        Дата_рождения_читателяLabel.TabIndex = 36
        Дата_рождения_читателяLabel.Text = "Дата рождения читателя:"
        '
        'Дата_рождения_читателяDateTimePicker
        '
        Me.Дата_рождения_читателяDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource, "Дата рождения читателя", True))
        Me.Дата_рождения_читателяDateTimePicker.Location = New System.Drawing.Point(448, 171)
        Me.Дата_рождения_читателяDateTimePicker.Name = "Дата_рождения_читателяDateTimePicker"
        Me.Дата_рождения_читателяDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_рождения_читателяDateTimePicker.TabIndex = 37
        '
        'Пол_читателяLabel
        '
        Пол_читателяLabel.AutoSize = True
        Пол_читателяLabel.Location = New System.Drawing.Point(305, 200)
        Пол_читателяLabel.Name = "Пол_читателяLabel"
        Пол_читателяLabel.Size = New System.Drawing.Size(78, 13)
        Пол_читателяLabel.TabIndex = 38
        Пол_читателяLabel.Text = "Пол читателя:"
        '
        'Пол_читателяTextBox
        '
        Me.Пол_читателяTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource, "Пол читателя", True))
        Me.Пол_читателяTextBox.Location = New System.Drawing.Point(448, 197)
        Me.Пол_читателяTextBox.Name = "Пол_читателяTextBox"
        Me.Пол_читателяTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Пол_читателяTextBox.TabIndex = 39
        '
        'Адрес_читателяLabel
        '
        Адрес_читателяLabel.AutoSize = True
        Адрес_читателяLabel.Location = New System.Drawing.Point(305, 226)
        Адрес_читателяLabel.Name = "Адрес_читателяLabel"
        Адрес_читателяLabel.Size = New System.Drawing.Size(89, 13)
        Адрес_читателяLabel.TabIndex = 40
        Адрес_читателяLabel.Text = "Адрес читателя:"
        '
        'Адрес_читателяTextBox
        '
        Me.Адрес_читателяTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource, "Адрес читателя", True))
        Me.Адрес_читателяTextBox.Location = New System.Drawing.Point(448, 223)
        Me.Адрес_читателяTextBox.Name = "Адрес_читателяTextBox"
        Me.Адрес_читателяTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Адрес_читателяTextBox.TabIndex = 41
        '
        'ТелефонLabel
        '
        ТелефонLabel.AutoSize = True
        ТелефонLabel.Location = New System.Drawing.Point(305, 252)
        ТелефонLabel.Name = "ТелефонLabel"
        ТелефонLabel.Size = New System.Drawing.Size(55, 13)
        ТелефонLabel.TabIndex = 42
        ТелефонLabel.Text = "Телефон:"
        '
        'ТелефонTextBox
        '
        Me.ТелефонTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource, "Телефон", True))
        Me.ТелефонTextBox.Location = New System.Drawing.Point(448, 249)
        Me.ТелефонTextBox.Name = "ТелефонTextBox"
        Me.ТелефонTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ТелефонTextBox.TabIndex = 43
        '
        'Паспортные_данныеLabel
        '
        Паспортные_данныеLabel.AutoSize = True
        Паспортные_данныеLabel.Location = New System.Drawing.Point(305, 278)
        Паспортные_данныеLabel.Name = "Паспортные_данныеLabel"
        Паспортные_данныеLabel.Size = New System.Drawing.Size(114, 13)
        Паспортные_данныеLabel.TabIndex = 44
        Паспортные_данныеLabel.Text = "Паспортные данные:"
        '
        'Паспортные_данныеTextBox
        '
        Me.Паспортные_данныеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource, "Паспортные данные", True))
        Me.Паспортные_данныеTextBox.Location = New System.Drawing.Point(448, 275)
        Me.Паспортные_данныеTextBox.Name = "Паспортные_данныеTextBox"
        Me.Паспортные_данныеTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Паспортные_данныеTextBox.TabIndex = 45
        '
        'НаименованиеLabel
        '
        НаименованиеLabel.AutoSize = True
        НаименованиеLabel.Location = New System.Drawing.Point(305, 304)
        НаименованиеLabel.Name = "НаименованиеLabel"
        НаименованиеLabel.Size = New System.Drawing.Size(86, 13)
        НаименованиеLabel.TabIndex = 46
        НаименованиеLabel.Text = "Наименование:"
        '
        'НаименованиеTextBox
        '
        Me.НаименованиеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource, "Наименование", True))
        Me.НаименованиеTextBox.Location = New System.Drawing.Point(448, 301)
        Me.НаименованиеTextBox.Name = "НаименованиеTextBox"
        Me.НаименованиеTextBox.Size = New System.Drawing.Size(200, 20)
        Me.НаименованиеTextBox.TabIndex = 47
        '
        'АвторLabel
        '
        АвторLabel.AutoSize = True
        АвторLabel.Location = New System.Drawing.Point(305, 330)
        АвторLabel.Name = "АвторLabel"
        АвторLabel.Size = New System.Drawing.Size(40, 13)
        АвторLabel.TabIndex = 48
        АвторLabel.Text = "Автор:"
        '
        'АвторTextBox
        '
        Me.АвторTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource, "Автор", True))
        Me.АвторTextBox.Location = New System.Drawing.Point(448, 327)
        Me.АвторTextBox.Name = "АвторTextBox"
        Me.АвторTextBox.Size = New System.Drawing.Size(200, 20)
        Me.АвторTextBox.TabIndex = 49
        '
        'Год_изданияLabel
        '
        Год_изданияLabel.AutoSize = True
        Год_изданияLabel.Location = New System.Drawing.Point(305, 356)
        Год_изданияLabel.Name = "Год_изданияLabel"
        Год_изданияLabel.Size = New System.Drawing.Size(73, 13)
        Год_изданияLabel.TabIndex = 50
        Год_изданияLabel.Text = "Год издания:"
        '
        'Год_изданияTextBox
        '
        Me.Год_изданияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource, "Год издания", True))
        Me.Год_изданияTextBox.Location = New System.Drawing.Point(448, 353)
        Me.Год_изданияTextBox.Name = "Год_изданияTextBox"
        Me.Год_изданияTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Год_изданияTextBox.TabIndex = 51
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(791, 420)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 38)
        Me.Button1.TabIndex = 85
        Me.Button1.Text = "Назад"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 470)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ФИО_сотрудниковLabel)
        Me.Controls.Add(Me.ФИО_сотрудниковTextBox)
        Me.Controls.Add(ФИО_читателяLabel)
        Me.Controls.Add(Me.ФИО_читателяTextBox)
        Me.Controls.Add(Дата_рождения_читателяLabel)
        Me.Controls.Add(Me.Дата_рождения_читателяDateTimePicker)
        Me.Controls.Add(Пол_читателяLabel)
        Me.Controls.Add(Me.Пол_читателяTextBox)
        Me.Controls.Add(Адрес_читателяLabel)
        Me.Controls.Add(Me.Адрес_читателяTextBox)
        Me.Controls.Add(ТелефонLabel)
        Me.Controls.Add(Me.ТелефонTextBox)
        Me.Controls.Add(Паспортные_данныеLabel)
        Me.Controls.Add(Me.Паспортные_данныеTextBox)
        Me.Controls.Add(НаименованиеLabel)
        Me.Controls.Add(Me.НаименованиеTextBox)
        Me.Controls.Add(АвторLabel)
        Me.Controls.Add(Me.АвторTextBox)
        Me.Controls.Add(Год_изданияLabel)
        Me.Controls.Add(Me.Год_изданияTextBox)
        Me.Controls.Add(Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form16"
        Me.Text = "Form16"
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.ResumeLayout(False)
        Me.Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet3 As DataSet3
    Friend WithEvents Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingSource As BindingSource
    Friend WithEvents Фильтры_для_отображения_книг_на_руках_отдельных_читателейTableAdapter As DataSet3TableAdapters.Фильтры_для_отображения_книг_на_руках_отдельных_читателейTableAdapter
    Friend WithEvents TableAdapterManager As DataSet3TableAdapters.TableAdapterManager
    Friend WithEvents Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigator As BindingNavigator
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
    Friend WithEvents Фильтры_для_отображения_книг_на_руках_отдельных_читателейBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ФИО_сотрудниковTextBox As TextBox
    Friend WithEvents ФИО_читателяTextBox As TextBox
    Friend WithEvents Дата_рождения_читателяDateTimePicker As DateTimePicker
    Friend WithEvents Пол_читателяTextBox As TextBox
    Friend WithEvents Адрес_читателяTextBox As TextBox
    Friend WithEvents ТелефонTextBox As TextBox
    Friend WithEvents Паспортные_данныеTextBox As TextBox
    Friend WithEvents НаименованиеTextBox As TextBox
    Friend WithEvents АвторTextBox As TextBox
    Friend WithEvents Год_изданияTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
