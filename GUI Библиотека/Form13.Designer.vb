<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form13))
        Dim ФИО_сотрудниковLabel As System.Windows.Forms.Label
        Dim ВозрастLabel As System.Windows.Forms.Label
        Dim ПолLabel As System.Windows.Forms.Label
        Dim АдресLabel As System.Windows.Forms.Label
        Dim Пасопортные_данныеLabel As System.Windows.Forms.Label
        Dim Код_должностиLabel As System.Windows.Forms.Label
        Dim Код_читателяLabel As System.Windows.Forms.Label
        Dim Дата_выдачиLabel As System.Windows.Forms.Label
        Dim Дата_возвратаLabel As System.Windows.Forms.Label
        Dim Код_сотрудникаLabel As System.Windows.Forms.Label
        Dim Отметка_о_возвратеLabel As System.Windows.Forms.Label
        Dim ФИО_читателяLabel As System.Windows.Forms.Label
        Dim Дата_рождения_читателяLabel As System.Windows.Forms.Label
        Dim Пол_читателяLabel As System.Windows.Forms.Label
        Dim Адрес_читателяLabel As System.Windows.Forms.Label
        Dim ТелефонLabel As System.Windows.Forms.Label
        Dim Паспортные_данныеLabel As System.Windows.Forms.Label
        Dim НаименованиеLabel As System.Windows.Forms.Label
        Dim АвторLabel As System.Windows.Forms.Label
        Dim Год_изданияLabel As System.Windows.Forms.Label
        Dim Код_издательстваLabel As System.Windows.Forms.Label
        Dim Код_жанраLabel As System.Windows.Forms.Label
        Dim Expr3Label As System.Windows.Forms.Label
        Dim Expr4Label As System.Windows.Forms.Label
        Dim Код_книгиLabel As System.Windows.Forms.Label
        Dim Expr5Label As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet2 = New GUI_Библиотека.DataSet2()
        Me.Книги_на_рукахBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Книги_на_рукахTableAdapter = New GUI_Библиотека.DataSet2TableAdapters.Книги_на_рукахTableAdapter()
        Me.TableAdapterManager = New GUI_Библиотека.DataSet2TableAdapters.TableAdapterManager()
        Me.Книги_на_рукахBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Книги_на_рукахBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ФИО_сотрудниковTextBox = New System.Windows.Forms.TextBox()
        Me.ВозрастTextBox = New System.Windows.Forms.TextBox()
        Me.ПолTextBox = New System.Windows.Forms.TextBox()
        Me.АдресTextBox = New System.Windows.Forms.TextBox()
        Me.Пасопортные_данныеTextBox = New System.Windows.Forms.TextBox()
        Me.Код_должностиTextBox = New System.Windows.Forms.TextBox()
        Me.Код_читателяTextBox = New System.Windows.Forms.TextBox()
        Me.Дата_выдачиDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Дата_возвратаDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Код_сотрудникаTextBox = New System.Windows.Forms.TextBox()
        Me.Отметка_о_возвратеCheckBox = New System.Windows.Forms.CheckBox()
        Me.ФИО_читателяTextBox = New System.Windows.Forms.TextBox()
        Me.Дата_рождения_читателяDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Пол_читателяTextBox = New System.Windows.Forms.TextBox()
        Me.Адрес_читателяTextBox = New System.Windows.Forms.TextBox()
        Me.ТелефонTextBox = New System.Windows.Forms.TextBox()
        Me.Паспортные_данныеTextBox = New System.Windows.Forms.TextBox()
        Me.НаименованиеTextBox = New System.Windows.Forms.TextBox()
        Me.АвторTextBox = New System.Windows.Forms.TextBox()
        Me.Год_изданияTextBox = New System.Windows.Forms.TextBox()
        Me.Код_издательстваTextBox = New System.Windows.Forms.TextBox()
        Me.Код_жанраTextBox = New System.Windows.Forms.TextBox()
        Me.Expr3TextBox = New System.Windows.Forms.TextBox()
        Me.Expr4TextBox = New System.Windows.Forms.TextBox()
        Me.Код_книгиTextBox = New System.Windows.Forms.TextBox()
        Me.Expr5TextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        ФИО_сотрудниковLabel = New System.Windows.Forms.Label()
        ВозрастLabel = New System.Windows.Forms.Label()
        ПолLabel = New System.Windows.Forms.Label()
        АдресLabel = New System.Windows.Forms.Label()
        Пасопортные_данныеLabel = New System.Windows.Forms.Label()
        Код_должностиLabel = New System.Windows.Forms.Label()
        Код_читателяLabel = New System.Windows.Forms.Label()
        Дата_выдачиLabel = New System.Windows.Forms.Label()
        Дата_возвратаLabel = New System.Windows.Forms.Label()
        Код_сотрудникаLabel = New System.Windows.Forms.Label()
        Отметка_о_возвратеLabel = New System.Windows.Forms.Label()
        ФИО_читателяLabel = New System.Windows.Forms.Label()
        Дата_рождения_читателяLabel = New System.Windows.Forms.Label()
        Пол_читателяLabel = New System.Windows.Forms.Label()
        Адрес_читателяLabel = New System.Windows.Forms.Label()
        ТелефонLabel = New System.Windows.Forms.Label()
        Паспортные_данныеLabel = New System.Windows.Forms.Label()
        НаименованиеLabel = New System.Windows.Forms.Label()
        АвторLabel = New System.Windows.Forms.Label()
        Год_изданияLabel = New System.Windows.Forms.Label()
        Код_издательстваLabel = New System.Windows.Forms.Label()
        Код_жанраLabel = New System.Windows.Forms.Label()
        Expr3Label = New System.Windows.Forms.Label()
        Expr4Label = New System.Windows.Forms.Label()
        Код_книгиLabel = New System.Windows.Forms.Label()
        Expr5Label = New System.Windows.Forms.Label()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Книги_на_рукахBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Книги_на_рукахBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Книги_на_рукахBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(436, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 31)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Книги на руках"
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Книги_на_рукахBindingSource
        '
        Me.Книги_на_рукахBindingSource.DataMember = "Книги на руках"
        Me.Книги_на_рукахBindingSource.DataSource = Me.DataSet2
        '
        'Книги_на_рукахTableAdapter
        '
        Me.Книги_на_рукахTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = GUI_Библиотека.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Книги_на_рукахBindingNavigator
        '
        Me.Книги_на_рукахBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Книги_на_рукахBindingNavigator.BindingSource = Me.Книги_на_рукахBindingSource
        Me.Книги_на_рукахBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Книги_на_рукахBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Книги_на_рукахBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Книги_на_рукахBindingNavigatorSaveItem})
        Me.Книги_на_рукахBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Книги_на_рукахBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Книги_на_рукахBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Книги_на_рукахBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Книги_на_рукахBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Книги_на_рукахBindingNavigator.Name = "Книги_на_рукахBindingNavigator"
        Me.Книги_на_рукахBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Книги_на_рукахBindingNavigator.Size = New System.Drawing.Size(1273, 25)
        Me.Книги_на_рукахBindingNavigator.TabIndex = 30
        Me.Книги_на_рукахBindingNavigator.Text = "BindingNavigator1"
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
        'Книги_на_рукахBindingNavigatorSaveItem
        '
        Me.Книги_на_рукахBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Книги_на_рукахBindingNavigatorSaveItem.Enabled = False
        Me.Книги_на_рукахBindingNavigatorSaveItem.Image = CType(resources.GetObject("Книги_на_рукахBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Книги_на_рукахBindingNavigatorSaveItem.Name = "Книги_на_рукахBindingNavigatorSaveItem"
        Me.Книги_на_рукахBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.Книги_на_рукахBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'ФИО_сотрудниковLabel
        '
        ФИО_сотрудниковLabel.AutoSize = True
        ФИО_сотрудниковLabel.Location = New System.Drawing.Point(317, 83)
        ФИО_сотрудниковLabel.Name = "ФИО_сотрудниковLabel"
        ФИО_сотрудниковLabel.Size = New System.Drawing.Size(104, 13)
        ФИО_сотрудниковLabel.TabIndex = 30
        ФИО_сотрудниковLabel.Text = "ФИО сотрудников:"
        '
        'ФИО_сотрудниковTextBox
        '
        Me.ФИО_сотрудниковTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "ФИО сотрудников", True))
        Me.ФИО_сотрудниковTextBox.Location = New System.Drawing.Point(460, 80)
        Me.ФИО_сотрудниковTextBox.Name = "ФИО_сотрудниковTextBox"
        Me.ФИО_сотрудниковTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ФИО_сотрудниковTextBox.TabIndex = 31
        '
        'ВозрастLabel
        '
        ВозрастLabel.AutoSize = True
        ВозрастLabel.Location = New System.Drawing.Point(317, 109)
        ВозрастLabel.Name = "ВозрастLabel"
        ВозрастLabel.Size = New System.Drawing.Size(52, 13)
        ВозрастLabel.TabIndex = 32
        ВозрастLabel.Text = "Возраст:"
        '
        'ВозрастTextBox
        '
        Me.ВозрастTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Возраст", True))
        Me.ВозрастTextBox.Location = New System.Drawing.Point(460, 106)
        Me.ВозрастTextBox.Name = "ВозрастTextBox"
        Me.ВозрастTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ВозрастTextBox.TabIndex = 33
        '
        'ПолLabel
        '
        ПолLabel.AutoSize = True
        ПолLabel.Location = New System.Drawing.Point(317, 135)
        ПолLabel.Name = "ПолLabel"
        ПолLabel.Size = New System.Drawing.Size(30, 13)
        ПолLabel.TabIndex = 34
        ПолLabel.Text = "Пол:"
        '
        'ПолTextBox
        '
        Me.ПолTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Пол", True))
        Me.ПолTextBox.Location = New System.Drawing.Point(460, 132)
        Me.ПолTextBox.Name = "ПолTextBox"
        Me.ПолTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ПолTextBox.TabIndex = 35
        '
        'АдресLabel
        '
        АдресLabel.AutoSize = True
        АдресLabel.Location = New System.Drawing.Point(317, 161)
        АдресLabel.Name = "АдресLabel"
        АдресLabel.Size = New System.Drawing.Size(41, 13)
        АдресLabel.TabIndex = 36
        АдресLabel.Text = "Адрес:"
        '
        'АдресTextBox
        '
        Me.АдресTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Адрес", True))
        Me.АдресTextBox.Location = New System.Drawing.Point(460, 158)
        Me.АдресTextBox.Name = "АдресTextBox"
        Me.АдресTextBox.Size = New System.Drawing.Size(200, 20)
        Me.АдресTextBox.TabIndex = 37
        '
        'Пасопортные_данныеLabel
        '
        Пасопортные_данныеLabel.AutoSize = True
        Пасопортные_данныеLabel.Location = New System.Drawing.Point(317, 187)
        Пасопортные_данныеLabel.Name = "Пасопортные_данныеLabel"
        Пасопортные_данныеLabel.Size = New System.Drawing.Size(120, 13)
        Пасопортные_данныеLabel.TabIndex = 38
        Пасопортные_данныеLabel.Text = "Пасопортные данные:"
        '
        'Пасопортные_данныеTextBox
        '
        Me.Пасопортные_данныеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Пасопортные данные", True))
        Me.Пасопортные_данныеTextBox.Location = New System.Drawing.Point(460, 184)
        Me.Пасопортные_данныеTextBox.Name = "Пасопортные_данныеTextBox"
        Me.Пасопортные_данныеTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Пасопортные_данныеTextBox.TabIndex = 39
        '
        'Код_должностиLabel
        '
        Код_должностиLabel.AutoSize = True
        Код_должностиLabel.Location = New System.Drawing.Point(317, 213)
        Код_должностиLabel.Name = "Код_должностиLabel"
        Код_должностиLabel.Size = New System.Drawing.Size(87, 13)
        Код_должностиLabel.TabIndex = 40
        Код_должностиLabel.Text = "Код должности:"
        '
        'Код_должностиTextBox
        '
        Me.Код_должностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Код должности", True))
        Me.Код_должностиTextBox.Location = New System.Drawing.Point(460, 210)
        Me.Код_должностиTextBox.Name = "Код_должностиTextBox"
        Me.Код_должностиTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Код_должностиTextBox.TabIndex = 41
        '
        'Код_читателяLabel
        '
        Код_читателяLabel.AutoSize = True
        Код_читателяLabel.Location = New System.Drawing.Point(317, 239)
        Код_читателяLabel.Name = "Код_читателяLabel"
        Код_читателяLabel.Size = New System.Drawing.Size(77, 13)
        Код_читателяLabel.TabIndex = 42
        Код_читателяLabel.Text = "Код читателя:"
        '
        'Код_читателяTextBox
        '
        Me.Код_читателяTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Код читателя", True))
        Me.Код_читателяTextBox.Location = New System.Drawing.Point(460, 236)
        Me.Код_читателяTextBox.Name = "Код_читателяTextBox"
        Me.Код_читателяTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Код_читателяTextBox.TabIndex = 43
        '
        'Дата_выдачиLabel
        '
        Дата_выдачиLabel.AutoSize = True
        Дата_выдачиLabel.Location = New System.Drawing.Point(317, 266)
        Дата_выдачиLabel.Name = "Дата_выдачиLabel"
        Дата_выдачиLabel.Size = New System.Drawing.Size(76, 13)
        Дата_выдачиLabel.TabIndex = 44
        Дата_выдачиLabel.Text = "Дата выдачи:"
        '
        'Дата_выдачиDateTimePicker
        '
        Me.Дата_выдачиDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Книги_на_рукахBindingSource, "Дата выдачи", True))
        Me.Дата_выдачиDateTimePicker.Location = New System.Drawing.Point(460, 262)
        Me.Дата_выдачиDateTimePicker.Name = "Дата_выдачиDateTimePicker"
        Me.Дата_выдачиDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_выдачиDateTimePicker.TabIndex = 45
        '
        'Дата_возвратаLabel
        '
        Дата_возвратаLabel.AutoSize = True
        Дата_возвратаLabel.Location = New System.Drawing.Point(317, 292)
        Дата_возвратаLabel.Name = "Дата_возвратаLabel"
        Дата_возвратаLabel.Size = New System.Drawing.Size(86, 13)
        Дата_возвратаLabel.TabIndex = 46
        Дата_возвратаLabel.Text = "Дата возврата:"
        '
        'Дата_возвратаDateTimePicker
        '
        Me.Дата_возвратаDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Книги_на_рукахBindingSource, "Дата возврата", True))
        Me.Дата_возвратаDateTimePicker.Location = New System.Drawing.Point(460, 288)
        Me.Дата_возвратаDateTimePicker.Name = "Дата_возвратаDateTimePicker"
        Me.Дата_возвратаDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_возвратаDateTimePicker.TabIndex = 47
        '
        'Код_сотрудникаLabel
        '
        Код_сотрудникаLabel.AutoSize = True
        Код_сотрудникаLabel.Location = New System.Drawing.Point(317, 317)
        Код_сотрудникаLabel.Name = "Код_сотрудникаLabel"
        Код_сотрудникаLabel.Size = New System.Drawing.Size(90, 13)
        Код_сотрудникаLabel.TabIndex = 48
        Код_сотрудникаLabel.Text = "Код сотрудника:"
        '
        'Код_сотрудникаTextBox
        '
        Me.Код_сотрудникаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Код сотрудника", True))
        Me.Код_сотрудникаTextBox.Location = New System.Drawing.Point(460, 314)
        Me.Код_сотрудникаTextBox.Name = "Код_сотрудникаTextBox"
        Me.Код_сотрудникаTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Код_сотрудникаTextBox.TabIndex = 49
        '
        'Отметка_о_возвратеLabel
        '
        Отметка_о_возвратеLabel.AutoSize = True
        Отметка_о_возвратеLabel.Location = New System.Drawing.Point(317, 345)
        Отметка_о_возвратеLabel.Name = "Отметка_о_возвратеLabel"
        Отметка_о_возвратеLabel.Size = New System.Drawing.Size(113, 13)
        Отметка_о_возвратеLabel.TabIndex = 50
        Отметка_о_возвратеLabel.Text = "Отметка о возврате:"
        '
        'Отметка_о_возвратеCheckBox
        '
        Me.Отметка_о_возвратеCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Книги_на_рукахBindingSource, "Отметка о возврате", True))
        Me.Отметка_о_возвратеCheckBox.Location = New System.Drawing.Point(460, 340)
        Me.Отметка_о_возвратеCheckBox.Name = "Отметка_о_возвратеCheckBox"
        Me.Отметка_о_возвратеCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.Отметка_о_возвратеCheckBox.TabIndex = 51
        Me.Отметка_о_возвратеCheckBox.Text = "CheckBox1"
        Me.Отметка_о_возвратеCheckBox.UseVisualStyleBackColor = True
        '
        'ФИО_читателяLabel
        '
        ФИО_читателяLabel.AutoSize = True
        ФИО_читателяLabel.Location = New System.Drawing.Point(317, 373)
        ФИО_читателяLabel.Name = "ФИО_читателяLabel"
        ФИО_читателяLabel.Size = New System.Drawing.Size(85, 13)
        ФИО_читателяLabel.TabIndex = 52
        ФИО_читателяLabel.Text = "ФИО читателя:"
        '
        'ФИО_читателяTextBox
        '
        Me.ФИО_читателяTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "ФИО читателя", True))
        Me.ФИО_читателяTextBox.Location = New System.Drawing.Point(460, 370)
        Me.ФИО_читателяTextBox.Name = "ФИО_читателяTextBox"
        Me.ФИО_читателяTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ФИО_читателяTextBox.TabIndex = 53
        '
        'Дата_рождения_читателяLabel
        '
        Дата_рождения_читателяLabel.AutoSize = True
        Дата_рождения_читателяLabel.Location = New System.Drawing.Point(317, 400)
        Дата_рождения_читателяLabel.Name = "Дата_рождения_читателяLabel"
        Дата_рождения_читателяLabel.Size = New System.Drawing.Size(137, 13)
        Дата_рождения_читателяLabel.TabIndex = 54
        Дата_рождения_читателяLabel.Text = "Дата рождения читателя:"
        '
        'Дата_рождения_читателяDateTimePicker
        '
        Me.Дата_рождения_читателяDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Книги_на_рукахBindingSource, "Дата рождения читателя", True))
        Me.Дата_рождения_читателяDateTimePicker.Location = New System.Drawing.Point(460, 396)
        Me.Дата_рождения_читателяDateTimePicker.Name = "Дата_рождения_читателяDateTimePicker"
        Me.Дата_рождения_читателяDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_рождения_читателяDateTimePicker.TabIndex = 55
        '
        'Пол_читателяLabel
        '
        Пол_читателяLabel.AutoSize = True
        Пол_читателяLabel.Location = New System.Drawing.Point(317, 425)
        Пол_читателяLabel.Name = "Пол_читателяLabel"
        Пол_читателяLabel.Size = New System.Drawing.Size(78, 13)
        Пол_читателяLabel.TabIndex = 56
        Пол_читателяLabel.Text = "Пол читателя:"
        '
        'Пол_читателяTextBox
        '
        Me.Пол_читателяTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Пол читателя", True))
        Me.Пол_читателяTextBox.Location = New System.Drawing.Point(460, 422)
        Me.Пол_читателяTextBox.Name = "Пол_читателяTextBox"
        Me.Пол_читателяTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Пол_читателяTextBox.TabIndex = 57
        '
        'Адрес_читателяLabel
        '
        Адрес_читателяLabel.AutoSize = True
        Адрес_читателяLabel.Location = New System.Drawing.Point(317, 451)
        Адрес_читателяLabel.Name = "Адрес_читателяLabel"
        Адрес_читателяLabel.Size = New System.Drawing.Size(89, 13)
        Адрес_читателяLabel.TabIndex = 58
        Адрес_читателяLabel.Text = "Адрес читателя:"
        '
        'Адрес_читателяTextBox
        '
        Me.Адрес_читателяTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Адрес читателя", True))
        Me.Адрес_читателяTextBox.Location = New System.Drawing.Point(460, 448)
        Me.Адрес_читателяTextBox.Name = "Адрес_читателяTextBox"
        Me.Адрес_читателяTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Адрес_читателяTextBox.TabIndex = 59
        '
        'ТелефонLabel
        '
        ТелефонLabel.AutoSize = True
        ТелефонLabel.Location = New System.Drawing.Point(317, 477)
        ТелефонLabel.Name = "ТелефонLabel"
        ТелефонLabel.Size = New System.Drawing.Size(55, 13)
        ТелефонLabel.TabIndex = 60
        ТелефонLabel.Text = "Телефон:"
        '
        'ТелефонTextBox
        '
        Me.ТелефонTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Телефон", True))
        Me.ТелефонTextBox.Location = New System.Drawing.Point(460, 474)
        Me.ТелефонTextBox.Name = "ТелефонTextBox"
        Me.ТелефонTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ТелефонTextBox.TabIndex = 61
        '
        'Паспортные_данныеLabel
        '
        Паспортные_данныеLabel.AutoSize = True
        Паспортные_данныеLabel.Location = New System.Drawing.Point(317, 503)
        Паспортные_данныеLabel.Name = "Паспортные_данныеLabel"
        Паспортные_данныеLabel.Size = New System.Drawing.Size(114, 13)
        Паспортные_данныеLabel.TabIndex = 62
        Паспортные_данныеLabel.Text = "Паспортные данные:"
        '
        'Паспортные_данныеTextBox
        '
        Me.Паспортные_данныеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Паспортные данные", True))
        Me.Паспортные_данныеTextBox.Location = New System.Drawing.Point(460, 500)
        Me.Паспортные_данныеTextBox.Name = "Паспортные_данныеTextBox"
        Me.Паспортные_данныеTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Паспортные_данныеTextBox.TabIndex = 63
        '
        'НаименованиеLabel
        '
        НаименованиеLabel.AutoSize = True
        НаименованиеLabel.Location = New System.Drawing.Point(317, 529)
        НаименованиеLabel.Name = "НаименованиеLabel"
        НаименованиеLabel.Size = New System.Drawing.Size(86, 13)
        НаименованиеLabel.TabIndex = 64
        НаименованиеLabel.Text = "Наименование:"
        '
        'НаименованиеTextBox
        '
        Me.НаименованиеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Наименование", True))
        Me.НаименованиеTextBox.Location = New System.Drawing.Point(460, 526)
        Me.НаименованиеTextBox.Name = "НаименованиеTextBox"
        Me.НаименованиеTextBox.Size = New System.Drawing.Size(200, 20)
        Me.НаименованиеTextBox.TabIndex = 65
        '
        'АвторLabel
        '
        АвторLabel.AutoSize = True
        АвторLabel.Location = New System.Drawing.Point(317, 555)
        АвторLabel.Name = "АвторLabel"
        АвторLabel.Size = New System.Drawing.Size(40, 13)
        АвторLabel.TabIndex = 66
        АвторLabel.Text = "Автор:"
        '
        'АвторTextBox
        '
        Me.АвторTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Автор", True))
        Me.АвторTextBox.Location = New System.Drawing.Point(460, 552)
        Me.АвторTextBox.Name = "АвторTextBox"
        Me.АвторTextBox.Size = New System.Drawing.Size(200, 20)
        Me.АвторTextBox.TabIndex = 67
        '
        'Год_изданияLabel
        '
        Год_изданияLabel.AutoSize = True
        Год_изданияLabel.Location = New System.Drawing.Point(317, 581)
        Год_изданияLabel.Name = "Год_изданияLabel"
        Год_изданияLabel.Size = New System.Drawing.Size(73, 13)
        Год_изданияLabel.TabIndex = 68
        Год_изданияLabel.Text = "Год издания:"
        '
        'Год_изданияTextBox
        '
        Me.Год_изданияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Год издания", True))
        Me.Год_изданияTextBox.Location = New System.Drawing.Point(460, 578)
        Me.Год_изданияTextBox.Name = "Год_изданияTextBox"
        Me.Год_изданияTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Год_изданияTextBox.TabIndex = 69
        '
        'Код_издательстваLabel
        '
        Код_издательстваLabel.AutoSize = True
        Код_издательстваLabel.Location = New System.Drawing.Point(317, 607)
        Код_издательстваLabel.Name = "Код_издательстваLabel"
        Код_издательстваLabel.Size = New System.Drawing.Size(102, 13)
        Код_издательстваLabel.TabIndex = 70
        Код_издательстваLabel.Text = "Код издательства:"
        '
        'Код_издательстваTextBox
        '
        Me.Код_издательстваTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Код издательства", True))
        Me.Код_издательстваTextBox.Location = New System.Drawing.Point(460, 604)
        Me.Код_издательстваTextBox.Name = "Код_издательстваTextBox"
        Me.Код_издательстваTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Код_издательстваTextBox.TabIndex = 71
        '
        'Код_жанраLabel
        '
        Код_жанраLabel.AutoSize = True
        Код_жанраLabel.Location = New System.Drawing.Point(317, 633)
        Код_жанраLabel.Name = "Код_жанраLabel"
        Код_жанраLabel.Size = New System.Drawing.Size(64, 13)
        Код_жанраLabel.TabIndex = 72
        Код_жанраLabel.Text = "Код жанра:"
        '
        'Код_жанраTextBox
        '
        Me.Код_жанраTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Код жанра", True))
        Me.Код_жанраTextBox.Location = New System.Drawing.Point(460, 630)
        Me.Код_жанраTextBox.Name = "Код_жанраTextBox"
        Me.Код_жанраTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Код_жанраTextBox.TabIndex = 73
        '
        'Expr3Label
        '
        Expr3Label.AutoSize = True
        Expr3Label.Location = New System.Drawing.Point(317, 659)
        Expr3Label.Name = "Expr3Label"
        Expr3Label.Size = New System.Drawing.Size(37, 13)
        Expr3Label.TabIndex = 74
        Expr3Label.Text = "Expr3:"
        '
        'Expr3TextBox
        '
        Me.Expr3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Expr3", True))
        Me.Expr3TextBox.Location = New System.Drawing.Point(460, 656)
        Me.Expr3TextBox.Name = "Expr3TextBox"
        Me.Expr3TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Expr3TextBox.TabIndex = 75
        '
        'Expr4Label
        '
        Expr4Label.AutoSize = True
        Expr4Label.Location = New System.Drawing.Point(317, 685)
        Expr4Label.Name = "Expr4Label"
        Expr4Label.Size = New System.Drawing.Size(37, 13)
        Expr4Label.TabIndex = 76
        Expr4Label.Text = "Expr4:"
        '
        'Expr4TextBox
        '
        Me.Expr4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Expr4", True))
        Me.Expr4TextBox.Location = New System.Drawing.Point(460, 682)
        Me.Expr4TextBox.Name = "Expr4TextBox"
        Me.Expr4TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Expr4TextBox.TabIndex = 77
        '
        'Код_книгиLabel
        '
        Код_книгиLabel.AutoSize = True
        Код_книгиLabel.Location = New System.Drawing.Point(317, 711)
        Код_книгиLabel.Name = "Код_книгиLabel"
        Код_книгиLabel.Size = New System.Drawing.Size(61, 13)
        Код_книгиLabel.TabIndex = 78
        Код_книгиLabel.Text = "Код книги:"
        '
        'Код_книгиTextBox
        '
        Me.Код_книгиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Код книги", True))
        Me.Код_книгиTextBox.Location = New System.Drawing.Point(460, 708)
        Me.Код_книгиTextBox.Name = "Код_книгиTextBox"
        Me.Код_книгиTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Код_книгиTextBox.TabIndex = 79
        '
        'Expr5Label
        '
        Expr5Label.AutoSize = True
        Expr5Label.Location = New System.Drawing.Point(317, 737)
        Expr5Label.Name = "Expr5Label"
        Expr5Label.Size = New System.Drawing.Size(37, 13)
        Expr5Label.TabIndex = 80
        Expr5Label.Text = "Expr5:"
        '
        'Expr5TextBox
        '
        Me.Expr5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Книги_на_рукахBindingSource, "Expr5", True))
        Me.Expr5TextBox.Location = New System.Drawing.Point(460, 734)
        Me.Expr5TextBox.Name = "Expr5TextBox"
        Me.Expr5TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Expr5TextBox.TabIndex = 81
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(1162, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 47)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "Назад"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 896)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ФИО_сотрудниковLabel)
        Me.Controls.Add(Me.ФИО_сотрудниковTextBox)
        Me.Controls.Add(ВозрастLabel)
        Me.Controls.Add(Me.ВозрастTextBox)
        Me.Controls.Add(ПолLabel)
        Me.Controls.Add(Me.ПолTextBox)
        Me.Controls.Add(АдресLabel)
        Me.Controls.Add(Me.АдресTextBox)
        Me.Controls.Add(Пасопортные_данныеLabel)
        Me.Controls.Add(Me.Пасопортные_данныеTextBox)
        Me.Controls.Add(Код_должностиLabel)
        Me.Controls.Add(Me.Код_должностиTextBox)
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
        Me.Controls.Add(Код_издательстваLabel)
        Me.Controls.Add(Me.Код_издательстваTextBox)
        Me.Controls.Add(Код_жанраLabel)
        Me.Controls.Add(Me.Код_жанраTextBox)
        Me.Controls.Add(Expr3Label)
        Me.Controls.Add(Me.Expr3TextBox)
        Me.Controls.Add(Expr4Label)
        Me.Controls.Add(Me.Expr4TextBox)
        Me.Controls.Add(Код_книгиLabel)
        Me.Controls.Add(Me.Код_книгиTextBox)
        Me.Controls.Add(Expr5Label)
        Me.Controls.Add(Me.Expr5TextBox)
        Me.Controls.Add(Me.Книги_на_рукахBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form13"
        Me.Text = "Form13"
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Книги_на_рукахBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Книги_на_рукахBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Книги_на_рукахBindingNavigator.ResumeLayout(False)
        Me.Книги_на_рукахBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents Книги_на_рукахBindingSource As BindingSource
    Friend WithEvents Книги_на_рукахTableAdapter As DataSet2TableAdapters.Книги_на_рукахTableAdapter
    Friend WithEvents TableAdapterManager As DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents Книги_на_рукахBindingNavigator As BindingNavigator
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
    Friend WithEvents Книги_на_рукахBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ФИО_сотрудниковTextBox As TextBox
    Friend WithEvents ВозрастTextBox As TextBox
    Friend WithEvents ПолTextBox As TextBox
    Friend WithEvents АдресTextBox As TextBox
    Friend WithEvents Пасопортные_данныеTextBox As TextBox
    Friend WithEvents Код_должностиTextBox As TextBox
    Friend WithEvents Код_читателяTextBox As TextBox
    Friend WithEvents Дата_выдачиDateTimePicker As DateTimePicker
    Friend WithEvents Дата_возвратаDateTimePicker As DateTimePicker
    Friend WithEvents Код_сотрудникаTextBox As TextBox
    Friend WithEvents Отметка_о_возвратеCheckBox As CheckBox
    Friend WithEvents ФИО_читателяTextBox As TextBox
    Friend WithEvents Дата_рождения_читателяDateTimePicker As DateTimePicker
    Friend WithEvents Пол_читателяTextBox As TextBox
    Friend WithEvents Адрес_читателяTextBox As TextBox
    Friend WithEvents ТелефонTextBox As TextBox
    Friend WithEvents Паспортные_данныеTextBox As TextBox
    Friend WithEvents НаименованиеTextBox As TextBox
    Friend WithEvents АвторTextBox As TextBox
    Friend WithEvents Год_изданияTextBox As TextBox
    Friend WithEvents Код_издательстваTextBox As TextBox
    Friend WithEvents Код_жанраTextBox As TextBox
    Friend WithEvents Expr3TextBox As TextBox
    Friend WithEvents Expr4TextBox As TextBox
    Friend WithEvents Код_книгиTextBox As TextBox
    Friend WithEvents Expr5TextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
