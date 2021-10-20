<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form19
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form19))
        Dim Наименование_книгLabel As System.Windows.Forms.Label
        Dim ОписаниеLabel As System.Windows.Forms.Label
        Dim Год_изданияLabel As System.Windows.Forms.Label
        Dim АвторLabel As System.Windows.Forms.Label
        Dim ГородLabel As System.Windows.Forms.Label
        Dim АдресLabel As System.Windows.Forms.Label
        Dim НаименованиеLabel As System.Windows.Forms.Label
        Dim Наименование_книг__которые_пользуются_популярностьюLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataSet3 = New GUI_Библиотека.DataSet3()
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Фильтры_для_отображения_книг_отдельных_издательствTableAdapter = New GUI_Библиотека.DataSet3TableAdapters.Фильтры_для_отображения_книг_отдельных_издательствTableAdapter()
        Me.TableAdapterManager = New GUI_Библиотека.DataSet3TableAdapters.TableAdapterManager()
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Наименование_книгTextBox = New System.Windows.Forms.TextBox()
        Me.ОписаниеTextBox = New System.Windows.Forms.TextBox()
        Me.Год_изданияTextBox = New System.Windows.Forms.TextBox()
        Me.АвторTextBox = New System.Windows.Forms.TextBox()
        Me.ГородTextBox = New System.Windows.Forms.TextBox()
        Me.АдресTextBox = New System.Windows.Forms.TextBox()
        Me.НаименованиеTextBox = New System.Windows.Forms.TextBox()
        Me.Наименование_книг__которые_пользуются_популярностьюTextBox = New System.Windows.Forms.TextBox()
        Наименование_книгLabel = New System.Windows.Forms.Label()
        ОписаниеLabel = New System.Windows.Forms.Label()
        Год_изданияLabel = New System.Windows.Forms.Label()
        АвторLabel = New System.Windows.Forms.Label()
        ГородLabel = New System.Windows.Forms.Label()
        АдресLabel = New System.Windows.Forms.Label()
        НаименованиеLabel = New System.Windows.Forms.Label()
        Наименование_книг__которые_пользуются_популярностьюLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Фильтры_для_отображения_книг_отдельных_издательствBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(551, 31)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Отображения книг отдельных издательств"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(897, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 41)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "Назад"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Фильтры_для_отображения_книг_отдельных_издательствBindingSource
        '
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingSource.DataMember = "Фильтры для отображения книг отдельных издательств"
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingSource.DataSource = Me.DataSet3
        '
        'Фильтры_для_отображения_книг_отдельных_издательствTableAdapter
        '
        Me.Фильтры_для_отображения_книг_отдельных_издательствTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = GUI_Библиотека.DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator
        '
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.BindingSource = Me.Фильтры_для_отображения_книг_отдельных_издательствBindingSource
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigatorSaveItem})
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.Name = "Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator"
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.Size = New System.Drawing.Size(1019, 25)
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.TabIndex = 88
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.Text = "BindingNavigator1"
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
        'Фильтры_для_отображения_книг_отдельных_издательствBindingNavigatorSaveItem
        '
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigatorSaveItem.Enabled = False
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigatorSaveItem.Image = CType(resources.GetObject("Фильтры_для_отображения_книг_отдельных_издательствBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigatorSaveItem.Name = "Фильтры_для_отображения_книг_отдельных_издательствBindingNavigatorSaveItem"
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Наименование_книгLabel
        '
        Наименование_книгLabel.AutoSize = True
        Наименование_книгLabel.Location = New System.Drawing.Point(364, 149)
        Наименование_книгLabel.Name = "Наименование_книгLabel"
        Наименование_книгLabel.Size = New System.Drawing.Size(112, 13)
        Наименование_книгLabel.TabIndex = 88
        Наименование_книгLabel.Text = "Наименование книг:"
        '
        'Наименование_книгTextBox
        '
        Me.Наименование_книгTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтры_для_отображения_книг_отдельных_издательствBindingSource, "Наименование книг", True))
        Me.Наименование_книгTextBox.Location = New System.Drawing.Point(675, 146)
        Me.Наименование_книгTextBox.Name = "Наименование_книгTextBox"
        Me.Наименование_книгTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Наименование_книгTextBox.TabIndex = 89
        '
        'ОписаниеLabel
        '
        ОписаниеLabel.AutoSize = True
        ОписаниеLabel.Location = New System.Drawing.Point(364, 175)
        ОписаниеLabel.Name = "ОписаниеLabel"
        ОписаниеLabel.Size = New System.Drawing.Size(60, 13)
        ОписаниеLabel.TabIndex = 90
        ОписаниеLabel.Text = "Описание:"
        '
        'ОписаниеTextBox
        '
        Me.ОписаниеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтры_для_отображения_книг_отдельных_издательствBindingSource, "Описание", True))
        Me.ОписаниеTextBox.Location = New System.Drawing.Point(675, 172)
        Me.ОписаниеTextBox.Name = "ОписаниеTextBox"
        Me.ОписаниеTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ОписаниеTextBox.TabIndex = 91
        '
        'Год_изданияLabel
        '
        Год_изданияLabel.AutoSize = True
        Год_изданияLabel.Location = New System.Drawing.Point(364, 201)
        Год_изданияLabel.Name = "Год_изданияLabel"
        Год_изданияLabel.Size = New System.Drawing.Size(73, 13)
        Год_изданияLabel.TabIndex = 92
        Год_изданияLabel.Text = "Год издания:"
        '
        'Год_изданияTextBox
        '
        Me.Год_изданияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтры_для_отображения_книг_отдельных_издательствBindingSource, "Год издания", True))
        Me.Год_изданияTextBox.Location = New System.Drawing.Point(675, 198)
        Me.Год_изданияTextBox.Name = "Год_изданияTextBox"
        Me.Год_изданияTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Год_изданияTextBox.TabIndex = 93
        '
        'АвторLabel
        '
        АвторLabel.AutoSize = True
        АвторLabel.Location = New System.Drawing.Point(364, 227)
        АвторLabel.Name = "АвторLabel"
        АвторLabel.Size = New System.Drawing.Size(40, 13)
        АвторLabel.TabIndex = 94
        АвторLabel.Text = "Автор:"
        '
        'АвторTextBox
        '
        Me.АвторTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтры_для_отображения_книг_отдельных_издательствBindingSource, "Автор", True))
        Me.АвторTextBox.Location = New System.Drawing.Point(675, 224)
        Me.АвторTextBox.Name = "АвторTextBox"
        Me.АвторTextBox.Size = New System.Drawing.Size(100, 20)
        Me.АвторTextBox.TabIndex = 95
        '
        'ГородLabel
        '
        ГородLabel.AutoSize = True
        ГородLabel.Location = New System.Drawing.Point(364, 253)
        ГородLabel.Name = "ГородLabel"
        ГородLabel.Size = New System.Drawing.Size(40, 13)
        ГородLabel.TabIndex = 96
        ГородLabel.Text = "Город:"
        '
        'ГородTextBox
        '
        Me.ГородTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтры_для_отображения_книг_отдельных_издательствBindingSource, "Город", True))
        Me.ГородTextBox.Location = New System.Drawing.Point(675, 250)
        Me.ГородTextBox.Name = "ГородTextBox"
        Me.ГородTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ГородTextBox.TabIndex = 97
        '
        'АдресLabel
        '
        АдресLabel.AutoSize = True
        АдресLabel.Location = New System.Drawing.Point(364, 279)
        АдресLabel.Name = "АдресLabel"
        АдресLabel.Size = New System.Drawing.Size(41, 13)
        АдресLabel.TabIndex = 98
        АдресLabel.Text = "Адрес:"
        '
        'АдресTextBox
        '
        Me.АдресTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтры_для_отображения_книг_отдельных_издательствBindingSource, "Адрес", True))
        Me.АдресTextBox.Location = New System.Drawing.Point(675, 276)
        Me.АдресTextBox.Name = "АдресTextBox"
        Me.АдресTextBox.Size = New System.Drawing.Size(100, 20)
        Me.АдресTextBox.TabIndex = 99
        '
        'НаименованиеLabel
        '
        НаименованиеLabel.AutoSize = True
        НаименованиеLabel.Location = New System.Drawing.Point(364, 305)
        НаименованиеLabel.Name = "НаименованиеLabel"
        НаименованиеLabel.Size = New System.Drawing.Size(86, 13)
        НаименованиеLabel.TabIndex = 100
        НаименованиеLabel.Text = "Наименование:"
        '
        'НаименованиеTextBox
        '
        Me.НаименованиеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтры_для_отображения_книг_отдельных_издательствBindingSource, "Наименование", True))
        Me.НаименованиеTextBox.Location = New System.Drawing.Point(675, 302)
        Me.НаименованиеTextBox.Name = "НаименованиеTextBox"
        Me.НаименованиеTextBox.Size = New System.Drawing.Size(100, 20)
        Me.НаименованиеTextBox.TabIndex = 101
        '
        'Наименование_книг__которые_пользуются_популярностьюLabel
        '
        Наименование_книг__которые_пользуются_популярностьюLabel.AutoSize = True
        Наименование_книг__которые_пользуются_популярностьюLabel.Location = New System.Drawing.Point(364, 331)
        Наименование_книг__которые_пользуются_популярностьюLabel.Name = "Наименование_книг__которые_пользуются_популярностьюLabel"
        Наименование_книг__которые_пользуются_популярностьюLabel.Size = New System.Drawing.Size(305, 13)
        Наименование_книг__которые_пользуются_популярностьюLabel.TabIndex = 102
        Наименование_книг__которые_пользуются_популярностьюLabel.Text = "Наименование книг  которые пользуются популярностью:"
        '
        'Наименование_книг__которые_пользуются_популярностьюTextBox
        '
        Me.Наименование_книг__которые_пользуются_популярностьюTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Фильтры_для_отображения_книг_отдельных_издательствBindingSource, "Наименование книг_ которые пользуются популярностью", True))
        Me.Наименование_книг__которые_пользуются_популярностьюTextBox.Location = New System.Drawing.Point(675, 328)
        Me.Наименование_книг__которые_пользуются_популярностьюTextBox.Name = "Наименование_книг__которые_пользуются_популярностьюTextBox"
        Me.Наименование_книг__которые_пользуются_популярностьюTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Наименование_книг__которые_пользуются_популярностьюTextBox.TabIndex = 103
        '
        'Form19
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 422)
        Me.Controls.Add(Наименование_книгLabel)
        Me.Controls.Add(Me.Наименование_книгTextBox)
        Me.Controls.Add(ОписаниеLabel)
        Me.Controls.Add(Me.ОписаниеTextBox)
        Me.Controls.Add(Год_изданияLabel)
        Me.Controls.Add(Me.Год_изданияTextBox)
        Me.Controls.Add(АвторLabel)
        Me.Controls.Add(Me.АвторTextBox)
        Me.Controls.Add(ГородLabel)
        Me.Controls.Add(Me.ГородTextBox)
        Me.Controls.Add(АдресLabel)
        Me.Controls.Add(Me.АдресTextBox)
        Me.Controls.Add(НаименованиеLabel)
        Me.Controls.Add(Me.НаименованиеTextBox)
        Me.Controls.Add(Наименование_книг__которые_пользуются_популярностьюLabel)
        Me.Controls.Add(Me.Наименование_книг__которые_пользуются_популярностьюTextBox)
        Me.Controls.Add(Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form19"
        Me.Text = "Form19"
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Фильтры_для_отображения_книг_отдельных_издательствBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.ResumeLayout(False)
        Me.Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataSet3 As DataSet3
    Friend WithEvents Фильтры_для_отображения_книг_отдельных_издательствBindingSource As BindingSource
    Friend WithEvents Фильтры_для_отображения_книг_отдельных_издательствTableAdapter As DataSet3TableAdapters.Фильтры_для_отображения_книг_отдельных_издательствTableAdapter
    Friend WithEvents TableAdapterManager As DataSet3TableAdapters.TableAdapterManager
    Friend WithEvents Фильтры_для_отображения_книг_отдельных_издательствBindingNavigator As BindingNavigator
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
    Friend WithEvents Фильтры_для_отображения_книг_отдельных_издательствBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Наименование_книгTextBox As TextBox
    Friend WithEvents ОписаниеTextBox As TextBox
    Friend WithEvents Год_изданияTextBox As TextBox
    Friend WithEvents АвторTextBox As TextBox
    Friend WithEvents ГородTextBox As TextBox
    Friend WithEvents АдресTextBox As TextBox
    Friend WithEvents НаименованиеTextBox As TextBox
    Friend WithEvents Наименование_книг__которые_пользуются_популярностьюTextBox As TextBox
End Class
