<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form14
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form14))
        Dim Наименование_должностиLabel As System.Windows.Forms.Label
        Dim ОкладLabel As System.Windows.Forms.Label
        Dim ОбязанностиLabel As System.Windows.Forms.Label
        Dim ТребованияLabel As System.Windows.Forms.Label
        Dim ФИОLabel As System.Windows.Forms.Label
        Dim ВозрастLabel As System.Windows.Forms.Label
        Dim ПолLabel As System.Windows.Forms.Label
        Dim АдресLabel As System.Windows.Forms.Label
        Dim Пасопортные_данныеLabel As System.Windows.Forms.Label
        Dim Код_должностиLabel As System.Windows.Forms.Label
        Dim Код_сотрудникаLabel As System.Windows.Forms.Label
        Dim Expr1Label As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataSet2 = New GUI_Библиотека.DataSet2()
        Me.Отдел_кадровBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Отдел_кадровTableAdapter = New GUI_Библиотека.DataSet2TableAdapters.Отдел_кадровTableAdapter()
        Me.TableAdapterManager = New GUI_Библиотека.DataSet2TableAdapters.TableAdapterManager()
        Me.Отдел_кадровBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Отдел_кадровBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Наименование_должностиTextBox = New System.Windows.Forms.TextBox()
        Me.ОкладTextBox = New System.Windows.Forms.TextBox()
        Me.ОбязанностиTextBox = New System.Windows.Forms.TextBox()
        Me.ТребованияTextBox = New System.Windows.Forms.TextBox()
        Me.ФИОTextBox = New System.Windows.Forms.TextBox()
        Me.ВозрастTextBox = New System.Windows.Forms.TextBox()
        Me.ПолTextBox = New System.Windows.Forms.TextBox()
        Me.АдресTextBox = New System.Windows.Forms.TextBox()
        Me.Пасопортные_данныеTextBox = New System.Windows.Forms.TextBox()
        Me.Код_должностиTextBox = New System.Windows.Forms.TextBox()
        Me.Код_сотрудникаTextBox = New System.Windows.Forms.TextBox()
        Me.Expr1TextBox = New System.Windows.Forms.TextBox()
        Наименование_должностиLabel = New System.Windows.Forms.Label()
        ОкладLabel = New System.Windows.Forms.Label()
        ОбязанностиLabel = New System.Windows.Forms.Label()
        ТребованияLabel = New System.Windows.Forms.Label()
        ФИОLabel = New System.Windows.Forms.Label()
        ВозрастLabel = New System.Windows.Forms.Label()
        ПолLabel = New System.Windows.Forms.Label()
        АдресLabel = New System.Windows.Forms.Label()
        Пасопортные_данныеLabel = New System.Windows.Forms.Label()
        Код_должностиLabel = New System.Windows.Forms.Label()
        Код_сотрудникаLabel = New System.Windows.Forms.Label()
        Expr1Label = New System.Windows.Forms.Label()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Отдел_кадровBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Отдел_кадровBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Отдел_кадровBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(385, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 31)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Отдел кадров"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(700, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 38)
        Me.Button1.TabIndex = 83
        Me.Button1.Text = "Назад"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Отдел_кадровBindingSource
        '
        Me.Отдел_кадровBindingSource.DataMember = "Отдел кадров"
        Me.Отдел_кадровBindingSource.DataSource = Me.DataSet2
        '
        'Отдел_кадровTableAdapter
        '
        Me.Отдел_кадровTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = GUI_Библиотека.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Отдел_кадровBindingNavigator
        '
        Me.Отдел_кадровBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Отдел_кадровBindingNavigator.BindingSource = Me.Отдел_кадровBindingSource
        Me.Отдел_кадровBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Отдел_кадровBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Отдел_кадровBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Отдел_кадровBindingNavigatorSaveItem})
        Me.Отдел_кадровBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Отдел_кадровBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Отдел_кадровBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Отдел_кадровBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Отдел_кадровBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Отдел_кадровBindingNavigator.Name = "Отдел_кадровBindingNavigator"
        Me.Отдел_кадровBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Отдел_кадровBindingNavigator.Size = New System.Drawing.Size(783, 25)
        Me.Отдел_кадровBindingNavigator.TabIndex = 84
        Me.Отдел_кадровBindingNavigator.Text = "BindingNavigator1"
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
        'Отдел_кадровBindingNavigatorSaveItem
        '
        Me.Отдел_кадровBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Отдел_кадровBindingNavigatorSaveItem.Enabled = False
        Me.Отдел_кадровBindingNavigatorSaveItem.Image = CType(resources.GetObject("Отдел_кадровBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Отдел_кадровBindingNavigatorSaveItem.Name = "Отдел_кадровBindingNavigatorSaveItem"
        Me.Отдел_кадровBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.Отдел_кадровBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Наименование_должностиLabel
        '
        Наименование_должностиLabel.AutoSize = True
        Наименование_должностиLabel.Location = New System.Drawing.Point(340, 103)
        Наименование_должностиLabel.Name = "Наименование_должностиLabel"
        Наименование_должностиLabel.Size = New System.Drawing.Size(144, 13)
        Наименование_должностиLabel.TabIndex = 84
        Наименование_должностиLabel.Text = "Наименование должности:"
        '
        'Наименование_должностиTextBox
        '
        Me.Наименование_должностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Отдел_кадровBindingSource, "Наименование должности", True))
        Me.Наименование_должностиTextBox.Location = New System.Drawing.Point(490, 100)
        Me.Наименование_должностиTextBox.Name = "Наименование_должностиTextBox"
        Me.Наименование_должностиTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Наименование_должностиTextBox.TabIndex = 85
        '
        'ОкладLabel
        '
        ОкладLabel.AutoSize = True
        ОкладLabel.Location = New System.Drawing.Point(340, 129)
        ОкладLabel.Name = "ОкладLabel"
        ОкладLabel.Size = New System.Drawing.Size(42, 13)
        ОкладLabel.TabIndex = 86
        ОкладLabel.Text = "Оклад:"
        '
        'ОкладTextBox
        '
        Me.ОкладTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Отдел_кадровBindingSource, "Оклад", True))
        Me.ОкладTextBox.Location = New System.Drawing.Point(490, 126)
        Me.ОкладTextBox.Name = "ОкладTextBox"
        Me.ОкладTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ОкладTextBox.TabIndex = 87
        '
        'ОбязанностиLabel
        '
        ОбязанностиLabel.AutoSize = True
        ОбязанностиLabel.Location = New System.Drawing.Point(340, 155)
        ОбязанностиLabel.Name = "ОбязанностиLabel"
        ОбязанностиLabel.Size = New System.Drawing.Size(77, 13)
        ОбязанностиLabel.TabIndex = 88
        ОбязанностиLabel.Text = "Обязанности:"
        '
        'ОбязанностиTextBox
        '
        Me.ОбязанностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Отдел_кадровBindingSource, "Обязанности", True))
        Me.ОбязанностиTextBox.Location = New System.Drawing.Point(490, 152)
        Me.ОбязанностиTextBox.Name = "ОбязанностиTextBox"
        Me.ОбязанностиTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ОбязанностиTextBox.TabIndex = 89
        '
        'ТребованияLabel
        '
        ТребованияLabel.AutoSize = True
        ТребованияLabel.Location = New System.Drawing.Point(340, 185)
        ТребованияLabel.Name = "ТребованияLabel"
        ТребованияLabel.Size = New System.Drawing.Size(71, 13)
        ТребованияLabel.TabIndex = 90
        ТребованияLabel.Text = "Требования:"
        '
        'ТребованияTextBox
        '
        Me.ТребованияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Отдел_кадровBindingSource, "Требования", True))
        Me.ТребованияTextBox.Location = New System.Drawing.Point(490, 178)
        Me.ТребованияTextBox.Name = "ТребованияTextBox"
        Me.ТребованияTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ТребованияTextBox.TabIndex = 91
        '
        'ФИОLabel
        '
        ФИОLabel.AutoSize = True
        ФИОLabel.Location = New System.Drawing.Point(340, 207)
        ФИОLabel.Name = "ФИОLabel"
        ФИОLabel.Size = New System.Drawing.Size(37, 13)
        ФИОLabel.TabIndex = 92
        ФИОLabel.Text = "ФИО:"
        '
        'ФИОTextBox
        '
        Me.ФИОTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Отдел_кадровBindingSource, "ФИО", True))
        Me.ФИОTextBox.Location = New System.Drawing.Point(490, 204)
        Me.ФИОTextBox.Name = "ФИОTextBox"
        Me.ФИОTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ФИОTextBox.TabIndex = 93
        '
        'ВозрастLabel
        '
        ВозрастLabel.AutoSize = True
        ВозрастLabel.Location = New System.Drawing.Point(340, 233)
        ВозрастLabel.Name = "ВозрастLabel"
        ВозрастLabel.Size = New System.Drawing.Size(52, 13)
        ВозрастLabel.TabIndex = 94
        ВозрастLabel.Text = "Возраст:"
        '
        'ВозрастTextBox
        '
        Me.ВозрастTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Отдел_кадровBindingSource, "Возраст", True))
        Me.ВозрастTextBox.Location = New System.Drawing.Point(490, 230)
        Me.ВозрастTextBox.Name = "ВозрастTextBox"
        Me.ВозрастTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ВозрастTextBox.TabIndex = 95
        '
        'ПолLabel
        '
        ПолLabel.AutoSize = True
        ПолLabel.Location = New System.Drawing.Point(340, 259)
        ПолLabel.Name = "ПолLabel"
        ПолLabel.Size = New System.Drawing.Size(30, 13)
        ПолLabel.TabIndex = 96
        ПолLabel.Text = "Пол:"
        '
        'ПолTextBox
        '
        Me.ПолTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Отдел_кадровBindingSource, "Пол", True))
        Me.ПолTextBox.Location = New System.Drawing.Point(490, 256)
        Me.ПолTextBox.Name = "ПолTextBox"
        Me.ПолTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ПолTextBox.TabIndex = 97
        '
        'АдресLabel
        '
        АдресLabel.AutoSize = True
        АдресLabel.Location = New System.Drawing.Point(340, 285)
        АдресLabel.Name = "АдресLabel"
        АдресLabel.Size = New System.Drawing.Size(41, 13)
        АдресLabel.TabIndex = 98
        АдресLabel.Text = "Адрес:"
        '
        'АдресTextBox
        '
        Me.АдресTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Отдел_кадровBindingSource, "Адрес", True))
        Me.АдресTextBox.Location = New System.Drawing.Point(490, 282)
        Me.АдресTextBox.Name = "АдресTextBox"
        Me.АдресTextBox.Size = New System.Drawing.Size(100, 20)
        Me.АдресTextBox.TabIndex = 99
        '
        'Пасопортные_данныеLabel
        '
        Пасопортные_данныеLabel.AutoSize = True
        Пасопортные_данныеLabel.Location = New System.Drawing.Point(340, 311)
        Пасопортные_данныеLabel.Name = "Пасопортные_данныеLabel"
        Пасопортные_данныеLabel.Size = New System.Drawing.Size(120, 13)
        Пасопортные_данныеLabel.TabIndex = 100
        Пасопортные_данныеLabel.Text = "Пасопортные данные:"
        '
        'Пасопортные_данныеTextBox
        '
        Me.Пасопортные_данныеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Отдел_кадровBindingSource, "Пасопортные данные", True))
        Me.Пасопортные_данныеTextBox.Location = New System.Drawing.Point(490, 308)
        Me.Пасопортные_данныеTextBox.Name = "Пасопортные_данныеTextBox"
        Me.Пасопортные_данныеTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Пасопортные_данныеTextBox.TabIndex = 101
        '
        'Код_должностиLabel
        '
        Код_должностиLabel.AutoSize = True
        Код_должностиLabel.Location = New System.Drawing.Point(340, 337)
        Код_должностиLabel.Name = "Код_должностиLabel"
        Код_должностиLabel.Size = New System.Drawing.Size(87, 13)
        Код_должностиLabel.TabIndex = 102
        Код_должностиLabel.Text = "Код должности:"
        '
        'Код_должностиTextBox
        '
        Me.Код_должностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Отдел_кадровBindingSource, "Код должности", True))
        Me.Код_должностиTextBox.Location = New System.Drawing.Point(490, 334)
        Me.Код_должностиTextBox.Name = "Код_должностиTextBox"
        Me.Код_должностиTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Код_должностиTextBox.TabIndex = 103
        '
        'Код_сотрудникаLabel
        '
        Код_сотрудникаLabel.AutoSize = True
        Код_сотрудникаLabel.Location = New System.Drawing.Point(340, 363)
        Код_сотрудникаLabel.Name = "Код_сотрудникаLabel"
        Код_сотрудникаLabel.Size = New System.Drawing.Size(90, 13)
        Код_сотрудникаLabel.TabIndex = 104
        Код_сотрудникаLabel.Text = "Код сотрудника:"
        '
        'Код_сотрудникаTextBox
        '
        Me.Код_сотрудникаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Отдел_кадровBindingSource, "Код сотрудника", True))
        Me.Код_сотрудникаTextBox.Location = New System.Drawing.Point(490, 360)
        Me.Код_сотрудникаTextBox.Name = "Код_сотрудникаTextBox"
        Me.Код_сотрудникаTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Код_сотрудникаTextBox.TabIndex = 105
        '
        'Expr1Label
        '
        Expr1Label.AutoSize = True
        Expr1Label.Location = New System.Drawing.Point(340, 389)
        Expr1Label.Name = "Expr1Label"
        Expr1Label.Size = New System.Drawing.Size(37, 13)
        Expr1Label.TabIndex = 106
        Expr1Label.Text = "Expr1:"
        '
        'Expr1TextBox
        '
        Me.Expr1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Отдел_кадровBindingSource, "Expr1", True))
        Me.Expr1TextBox.Location = New System.Drawing.Point(490, 386)
        Me.Expr1TextBox.Name = "Expr1TextBox"
        Me.Expr1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Expr1TextBox.TabIndex = 107
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 425)
        Me.Controls.Add(Наименование_должностиLabel)
        Me.Controls.Add(Me.Наименование_должностиTextBox)
        Me.Controls.Add(ОкладLabel)
        Me.Controls.Add(Me.ОкладTextBox)
        Me.Controls.Add(ОбязанностиLabel)
        Me.Controls.Add(Me.ОбязанностиTextBox)
        Me.Controls.Add(ТребованияLabel)
        Me.Controls.Add(Me.ТребованияTextBox)
        Me.Controls.Add(ФИОLabel)
        Me.Controls.Add(Me.ФИОTextBox)
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
        Me.Controls.Add(Код_сотрудникаLabel)
        Me.Controls.Add(Me.Код_сотрудникаTextBox)
        Me.Controls.Add(Expr1Label)
        Me.Controls.Add(Me.Expr1TextBox)
        Me.Controls.Add(Me.Отдел_кадровBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form14"
        Me.Text = "Form14"
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Отдел_кадровBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Отдел_кадровBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Отдел_кадровBindingNavigator.ResumeLayout(False)
        Me.Отдел_кадровBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents Отдел_кадровBindingSource As BindingSource
    Friend WithEvents Отдел_кадровTableAdapter As DataSet2TableAdapters.Отдел_кадровTableAdapter
    Friend WithEvents TableAdapterManager As DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents Отдел_кадровBindingNavigator As BindingNavigator
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
    Friend WithEvents Отдел_кадровBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Наименование_должностиTextBox As TextBox
    Friend WithEvents ОкладTextBox As TextBox
    Friend WithEvents ОбязанностиTextBox As TextBox
    Friend WithEvents ТребованияTextBox As TextBox
    Friend WithEvents ФИОTextBox As TextBox
    Friend WithEvents ВозрастTextBox As TextBox
    Friend WithEvents ПолTextBox As TextBox
    Friend WithEvents АдресTextBox As TextBox
    Friend WithEvents Пасопортные_данныеTextBox As TextBox
    Friend WithEvents Код_должностиTextBox As TextBox
    Friend WithEvents Код_сотрудникаTextBox As TextBox
    Friend WithEvents Expr1TextBox As TextBox
End Class
