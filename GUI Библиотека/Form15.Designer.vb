<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form15))
        Dim Наименование_должностиLabel As System.Windows.Forms.Label
        Dim ОкладLabel As System.Windows.Forms.Label
        Dim ОбязанностиLabel As System.Windows.Forms.Label
        Dim ТребованияLabel As System.Windows.Forms.Label
        Dim ФИОLabel As System.Windows.Forms.Label
        Dim ВозрастLabel As System.Windows.Forms.Label
        Dim ПолLabel As System.Windows.Forms.Label
        Dim АдресLabel As System.Windows.Forms.Label
        Dim Пасопортные_данныеLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet3 = New GUI_Библиотека.DataSet3()
        Me.Фильтр_для_отображения_отдельных_должностейBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Фильтр_для_отображения_отдельных_должностейTableAdapter = New GUI_Библиотека.DataSet3TableAdapters.Фильтр_для_отображения_отдельных_должностейTableAdapter()
        Me.TableAdapterManager = New GUI_Библиотека.DataSet3TableAdapters.TableAdapterManager()
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Наименование_должностиTextBox = New System.Windows.Forms.TextBox()
        Me.ОкладTextBox = New System.Windows.Forms.TextBox()
        Me.ОбязанностиTextBox = New System.Windows.Forms.TextBox()
        Me.ТребованияTextBox = New System.Windows.Forms.TextBox()
        Me.ФИОTextBox = New System.Windows.Forms.TextBox()
        Me.ВозрастTextBox = New System.Windows.Forms.TextBox()
        Me.ПолTextBox = New System.Windows.Forms.TextBox()
        Me.АдресTextBox = New System.Windows.Forms.TextBox()
        Me.Пасопортные_данныеTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Наименование_должностиLabel = New System.Windows.Forms.Label()
        ОкладLabel = New System.Windows.Forms.Label()
        ОбязанностиLabel = New System.Windows.Forms.Label()
        ТребованияLabel = New System.Windows.Forms.Label()
        ФИОLabel = New System.Windows.Forms.Label()
        ВозрастLabel = New System.Windows.Forms.Label()
        ПолLabel = New System.Windows.Forms.Label()
        АдресLabel = New System.Windows.Forms.Label()
        Пасопортные_данныеLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Фильтр_для_отображения_отдельных_должностейBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(485, 31)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Отображения отдельных должностей"
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Фильтр_для_отображения_отдельных_должностейBindingSource
        '
        Me.Фильтр_для_отображения_отдельных_должностейBindingSource.DataMember = "Фильтр для отображения отдельных должностей"
        Me.Фильтр_для_отображения_отдельных_должностейBindingSource.DataSource = Me.DataSet3
        '
        'Фильтр_для_отображения_отдельных_должностейTableAdapter
        '
        Me.Фильтр_для_отображения_отдельных_должностейTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = GUI_Библиотека.DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Фильтр_для_отображения_отдельных_должностейBindingNavigator
        '
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.BindingSource = Me.Фильтр_для_отображения_отдельных_должностейBindingSource
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Фильтр_для_отображения_отдельных_должностейBindingNavigatorSaveItem})
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.Name = "Фильтр_для_отображения_отдельных_должностейBindingNavigator"
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.TabIndex = 31
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.Text = "BindingNavigator1"
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
        'Фильтр_для_отображения_отдельных_должностейBindingNavigatorSaveItem
        '
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigatorSaveItem.Enabled = False
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigatorSaveItem.Image = CType(resources.GetObject("Фильтр_для_отображения_отдельных_должностейBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigatorSaveItem.Name = "Фильтр_для_отображения_отдельных_должностейBindingNavigatorSaveItem"
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Наименование_должностиLabel
        '
        Наименование_должностиLabel.AutoSize = True
        Наименование_должностиLabel.Location = New System.Drawing.Point(231, 135)
        Наименование_должностиLabel.Name = "Наименование_должностиLabel"
        Наименование_должностиLabel.Size = New System.Drawing.Size(144, 13)
        Наименование_должностиLabel.TabIndex = 31
        Наименование_должностиLabel.Text = "Наименование должности:"
        '
        'Наименование_должностиTextBox
        '
        Me.Наименование_должностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтр_для_отображения_отдельных_должностейBindingSource, "Наименование должности", True))
        Me.Наименование_должностиTextBox.Location = New System.Drawing.Point(381, 132)
        Me.Наименование_должностиTextBox.Name = "Наименование_должностиTextBox"
        Me.Наименование_должностиTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Наименование_должностиTextBox.TabIndex = 32
        '
        'ОкладLabel
        '
        ОкладLabel.AutoSize = True
        ОкладLabel.Location = New System.Drawing.Point(231, 161)
        ОкладLabel.Name = "ОкладLabel"
        ОкладLabel.Size = New System.Drawing.Size(42, 13)
        ОкладLabel.TabIndex = 33
        ОкладLabel.Text = "Оклад:"
        '
        'ОкладTextBox
        '
        Me.ОкладTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтр_для_отображения_отдельных_должностейBindingSource, "Оклад", True))
        Me.ОкладTextBox.Location = New System.Drawing.Point(381, 158)
        Me.ОкладTextBox.Name = "ОкладTextBox"
        Me.ОкладTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ОкладTextBox.TabIndex = 34
        '
        'ОбязанностиLabel
        '
        ОбязанностиLabel.AutoSize = True
        ОбязанностиLabel.Location = New System.Drawing.Point(231, 187)
        ОбязанностиLabel.Name = "ОбязанностиLabel"
        ОбязанностиLabel.Size = New System.Drawing.Size(77, 13)
        ОбязанностиLabel.TabIndex = 35
        ОбязанностиLabel.Text = "Обязанности:"
        '
        'ОбязанностиTextBox
        '
        Me.ОбязанностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтр_для_отображения_отдельных_должностейBindingSource, "Обязанности", True))
        Me.ОбязанностиTextBox.Location = New System.Drawing.Point(381, 184)
        Me.ОбязанностиTextBox.Name = "ОбязанностиTextBox"
        Me.ОбязанностиTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ОбязанностиTextBox.TabIndex = 36
        '
        'ТребованияLabel
        '
        ТребованияLabel.AutoSize = True
        ТребованияLabel.Location = New System.Drawing.Point(231, 213)
        ТребованияLabel.Name = "ТребованияLabel"
        ТребованияLabel.Size = New System.Drawing.Size(71, 13)
        ТребованияLabel.TabIndex = 37
        ТребованияLabel.Text = "Требования:"
        '
        'ТребованияTextBox
        '
        Me.ТребованияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтр_для_отображения_отдельных_должностейBindingSource, "Требования", True))
        Me.ТребованияTextBox.Location = New System.Drawing.Point(381, 210)
        Me.ТребованияTextBox.Name = "ТребованияTextBox"
        Me.ТребованияTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ТребованияTextBox.TabIndex = 38
        '
        'ФИОLabel
        '
        ФИОLabel.AutoSize = True
        ФИОLabel.Location = New System.Drawing.Point(231, 239)
        ФИОLabel.Name = "ФИОLabel"
        ФИОLabel.Size = New System.Drawing.Size(37, 13)
        ФИОLabel.TabIndex = 39
        ФИОLabel.Text = "ФИО:"
        '
        'ФИОTextBox
        '
        Me.ФИОTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтр_для_отображения_отдельных_должностейBindingSource, "ФИО", True))
        Me.ФИОTextBox.Location = New System.Drawing.Point(381, 236)
        Me.ФИОTextBox.Name = "ФИОTextBox"
        Me.ФИОTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ФИОTextBox.TabIndex = 40
        '
        'ВозрастLabel
        '
        ВозрастLabel.AutoSize = True
        ВозрастLabel.Location = New System.Drawing.Point(231, 265)
        ВозрастLabel.Name = "ВозрастLabel"
        ВозрастLabel.Size = New System.Drawing.Size(52, 13)
        ВозрастLabel.TabIndex = 41
        ВозрастLabel.Text = "Возраст:"
        '
        'ВозрастTextBox
        '
        Me.ВозрастTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтр_для_отображения_отдельных_должностейBindingSource, "Возраст", True))
        Me.ВозрастTextBox.Location = New System.Drawing.Point(381, 262)
        Me.ВозрастTextBox.Name = "ВозрастTextBox"
        Me.ВозрастTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ВозрастTextBox.TabIndex = 42
        '
        'ПолLabel
        '
        ПолLabel.AutoSize = True
        ПолLabel.Location = New System.Drawing.Point(231, 291)
        ПолLabel.Name = "ПолLabel"
        ПолLabel.Size = New System.Drawing.Size(30, 13)
        ПолLabel.TabIndex = 43
        ПолLabel.Text = "Пол:"
        '
        'ПолTextBox
        '
        Me.ПолTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтр_для_отображения_отдельных_должностейBindingSource, "Пол", True))
        Me.ПолTextBox.Location = New System.Drawing.Point(381, 288)
        Me.ПолTextBox.Name = "ПолTextBox"
        Me.ПолTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ПолTextBox.TabIndex = 44
        '
        'АдресLabel
        '
        АдресLabel.AutoSize = True
        АдресLabel.Location = New System.Drawing.Point(231, 317)
        АдресLabel.Name = "АдресLabel"
        АдресLabel.Size = New System.Drawing.Size(41, 13)
        АдресLabel.TabIndex = 45
        АдресLabel.Text = "Адрес:"
        '
        'АдресTextBox
        '
        Me.АдресTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтр_для_отображения_отдельных_должностейBindingSource, "Адрес", True))
        Me.АдресTextBox.Location = New System.Drawing.Point(381, 314)
        Me.АдресTextBox.Name = "АдресTextBox"
        Me.АдресTextBox.Size = New System.Drawing.Size(100, 20)
        Me.АдресTextBox.TabIndex = 46
        '
        'Пасопортные_данныеLabel
        '
        Пасопортные_данныеLabel.AutoSize = True
        Пасопортные_данныеLabel.Location = New System.Drawing.Point(231, 343)
        Пасопортные_данныеLabel.Name = "Пасопортные_данныеLabel"
        Пасопортные_данныеLabel.Size = New System.Drawing.Size(120, 13)
        Пасопортные_данныеLabel.TabIndex = 47
        Пасопортные_данныеLabel.Text = "Пасопортные данные:"
        '
        'Пасопортные_данныеTextBox
        '
        Me.Пасопортные_данныеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтр_для_отображения_отдельных_должностейBindingSource, "Пасопортные данные", True))
        Me.Пасопортные_данныеTextBox.Location = New System.Drawing.Point(381, 340)
        Me.Пасопортные_данныеTextBox.Name = "Пасопортные_данныеTextBox"
        Me.Пасопортные_данныеTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Пасопортные_данныеTextBox.TabIndex = 48
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(705, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 38)
        Me.Button1.TabIndex = 84
        Me.Button1.Text = "Назад"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
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
        Me.Controls.Add(Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form15"
        Me.Text = "Form15"
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Фильтр_для_отображения_отдельных_должностейBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.ResumeLayout(False)
        Me.Фильтр_для_отображения_отдельных_должностейBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet3 As DataSet3
    Friend WithEvents Фильтр_для_отображения_отдельных_должностейBindingSource As BindingSource
    Friend WithEvents Фильтр_для_отображения_отдельных_должностейTableAdapter As DataSet3TableAdapters.Фильтр_для_отображения_отдельных_должностейTableAdapter
    Friend WithEvents TableAdapterManager As DataSet3TableAdapters.TableAdapterManager
    Friend WithEvents Фильтр_для_отображения_отдельных_должностейBindingNavigator As BindingNavigator
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
    Friend WithEvents Фильтр_для_отображения_отдельных_должностейBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Наименование_должностиTextBox As TextBox
    Friend WithEvents ОкладTextBox As TextBox
    Friend WithEvents ОбязанностиTextBox As TextBox
    Friend WithEvents ТребованияTextBox As TextBox
    Friend WithEvents ФИОTextBox As TextBox
    Friend WithEvents ВозрастTextBox As TextBox
    Friend WithEvents ПолTextBox As TextBox
    Friend WithEvents АдресTextBox As TextBox
    Friend WithEvents Пасопортные_данныеTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
