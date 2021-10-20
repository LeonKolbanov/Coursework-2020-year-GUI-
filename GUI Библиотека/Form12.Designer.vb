<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form12))
        Dim ОписаниеLabel As System.Windows.Forms.Label
        Dim Наименование_книгLabel As System.Windows.Forms.Label
        Dim Год_изданияLabel As System.Windows.Forms.Label
        Dim АвторLabel As System.Windows.Forms.Label
        Dim ГородLabel As System.Windows.Forms.Label
        Dim АдресLabel As System.Windows.Forms.Label
        Dim НаименованиеLabel As System.Windows.Forms.Label
        Dim Код_издательстваLabel As System.Windows.Forms.Label
        Dim Код_жанраLabel As System.Windows.Forms.Label
        Dim Код_книгиLabel As System.Windows.Forms.Label
        Dim Expr1Label As System.Windows.Forms.Label
        Dim Наименование_книг__которые_пользуются_популярностьюLabel As System.Windows.Forms.Label
        Dim Expr4Label As System.Windows.Forms.Label
        Me.DataSet2 = New GUI_Библиотека.DataSet2()
        Me.КаталогBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.КаталогTableAdapter = New GUI_Библиотека.DataSet2TableAdapters.КаталогTableAdapter()
        Me.TableAdapterManager = New GUI_Библиотека.DataSet2TableAdapters.TableAdapterManager()
        Me.КаталогBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.КаталогBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ОписаниеTextBox = New System.Windows.Forms.TextBox()
        Me.Наименование_книгTextBox = New System.Windows.Forms.TextBox()
        Me.Год_изданияTextBox = New System.Windows.Forms.TextBox()
        Me.АвторTextBox = New System.Windows.Forms.TextBox()
        Me.ГородTextBox = New System.Windows.Forms.TextBox()
        Me.АдресTextBox = New System.Windows.Forms.TextBox()
        Me.НаименованиеTextBox = New System.Windows.Forms.TextBox()
        Me.Код_издательстваTextBox = New System.Windows.Forms.TextBox()
        Me.Код_жанраTextBox = New System.Windows.Forms.TextBox()
        Me.Код_книгиTextBox = New System.Windows.Forms.TextBox()
        Me.Expr1TextBox = New System.Windows.Forms.TextBox()
        Me.Наименование_книг__которые_пользуются_популярностьюTextBox = New System.Windows.Forms.TextBox()
        Me.Expr4TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        ОписаниеLabel = New System.Windows.Forms.Label()
        Наименование_книгLabel = New System.Windows.Forms.Label()
        Год_изданияLabel = New System.Windows.Forms.Label()
        АвторLabel = New System.Windows.Forms.Label()
        ГородLabel = New System.Windows.Forms.Label()
        АдресLabel = New System.Windows.Forms.Label()
        НаименованиеLabel = New System.Windows.Forms.Label()
        Код_издательстваLabel = New System.Windows.Forms.Label()
        Код_жанраLabel = New System.Windows.Forms.Label()
        Код_книгиLabel = New System.Windows.Forms.Label()
        Expr1Label = New System.Windows.Forms.Label()
        Наименование_книг__которые_пользуются_популярностьюLabel = New System.Windows.Forms.Label()
        Expr4Label = New System.Windows.Forms.Label()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КаталогBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КаталогBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.КаталогBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'КаталогBindingSource
        '
        Me.КаталогBindingSource.DataMember = "Каталог"
        Me.КаталогBindingSource.DataSource = Me.DataSet2
        '
        'КаталогTableAdapter
        '
        Me.КаталогTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = GUI_Библиотека.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'КаталогBindingNavigator
        '
        Me.КаталогBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.КаталогBindingNavigator.BindingSource = Me.КаталогBindingSource
        Me.КаталогBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.КаталогBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.КаталогBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.КаталогBindingNavigatorSaveItem})
        Me.КаталогBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.КаталогBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.КаталогBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.КаталогBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.КаталогBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.КаталогBindingNavigator.Name = "КаталогBindingNavigator"
        Me.КаталогBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.КаталогBindingNavigator.Size = New System.Drawing.Size(853, 25)
        Me.КаталогBindingNavigator.TabIndex = 0
        Me.КаталогBindingNavigator.Text = "BindingNavigator1"
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
        'КаталогBindingNavigatorSaveItem
        '
        Me.КаталогBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.КаталогBindingNavigatorSaveItem.Enabled = False
        Me.КаталогBindingNavigatorSaveItem.Image = CType(resources.GetObject("КаталогBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.КаталогBindingNavigatorSaveItem.Name = "КаталогBindingNavigatorSaveItem"
        Me.КаталогBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.КаталогBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'ОписаниеLabel
        '
        ОписаниеLabel.AutoSize = True
        ОписаниеLabel.Location = New System.Drawing.Point(42, 165)
        ОписаниеLabel.Name = "ОписаниеLabel"
        ОписаниеLabel.Size = New System.Drawing.Size(60, 13)
        ОписаниеLabel.TabIndex = 1
        ОписаниеLabel.Text = "Описание:"
        '
        'ОписаниеTextBox
        '
        Me.ОписаниеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КаталогBindingSource, "Описание", True))
        Me.ОписаниеTextBox.Location = New System.Drawing.Point(353, 162)
        Me.ОписаниеTextBox.Name = "ОписаниеTextBox"
        Me.ОписаниеTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ОписаниеTextBox.TabIndex = 2
        '
        'Наименование_книгLabel
        '
        Наименование_книгLabel.AutoSize = True
        Наименование_книгLabel.Location = New System.Drawing.Point(42, 191)
        Наименование_книгLabel.Name = "Наименование_книгLabel"
        Наименование_книгLabel.Size = New System.Drawing.Size(112, 13)
        Наименование_книгLabel.TabIndex = 3
        Наименование_книгLabel.Text = "Наименование книг:"
        '
        'Наименование_книгTextBox
        '
        Me.Наименование_книгTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КаталогBindingSource, "Наименование книг", True))
        Me.Наименование_книгTextBox.Location = New System.Drawing.Point(353, 188)
        Me.Наименование_книгTextBox.Name = "Наименование_книгTextBox"
        Me.Наименование_книгTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Наименование_книгTextBox.TabIndex = 4
        '
        'Год_изданияLabel
        '
        Год_изданияLabel.AutoSize = True
        Год_изданияLabel.Location = New System.Drawing.Point(42, 217)
        Год_изданияLabel.Name = "Год_изданияLabel"
        Год_изданияLabel.Size = New System.Drawing.Size(73, 13)
        Год_изданияLabel.TabIndex = 5
        Год_изданияLabel.Text = "Год издания:"
        '
        'Год_изданияTextBox
        '
        Me.Год_изданияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КаталогBindingSource, "Год издания", True))
        Me.Год_изданияTextBox.Location = New System.Drawing.Point(353, 214)
        Me.Год_изданияTextBox.Name = "Год_изданияTextBox"
        Me.Год_изданияTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Год_изданияTextBox.TabIndex = 6
        '
        'АвторLabel
        '
        АвторLabel.AutoSize = True
        АвторLabel.Location = New System.Drawing.Point(42, 243)
        АвторLabel.Name = "АвторLabel"
        АвторLabel.Size = New System.Drawing.Size(40, 13)
        АвторLabel.TabIndex = 7
        АвторLabel.Text = "Автор:"
        '
        'АвторTextBox
        '
        Me.АвторTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КаталогBindingSource, "Автор", True))
        Me.АвторTextBox.Location = New System.Drawing.Point(353, 240)
        Me.АвторTextBox.Name = "АвторTextBox"
        Me.АвторTextBox.Size = New System.Drawing.Size(100, 20)
        Me.АвторTextBox.TabIndex = 8
        '
        'ГородLabel
        '
        ГородLabel.AutoSize = True
        ГородLabel.Location = New System.Drawing.Point(42, 269)
        ГородLabel.Name = "ГородLabel"
        ГородLabel.Size = New System.Drawing.Size(40, 13)
        ГородLabel.TabIndex = 9
        ГородLabel.Text = "Город:"
        '
        'ГородTextBox
        '
        Me.ГородTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КаталогBindingSource, "Город", True))
        Me.ГородTextBox.Location = New System.Drawing.Point(353, 266)
        Me.ГородTextBox.Name = "ГородTextBox"
        Me.ГородTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ГородTextBox.TabIndex = 10
        '
        'АдресLabel
        '
        АдресLabel.AutoSize = True
        АдресLabel.Location = New System.Drawing.Point(42, 295)
        АдресLabel.Name = "АдресLabel"
        АдресLabel.Size = New System.Drawing.Size(41, 13)
        АдресLabel.TabIndex = 11
        АдресLabel.Text = "Адрес:"
        '
        'АдресTextBox
        '
        Me.АдресTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КаталогBindingSource, "Адрес", True))
        Me.АдресTextBox.Location = New System.Drawing.Point(353, 292)
        Me.АдресTextBox.Name = "АдресTextBox"
        Me.АдресTextBox.Size = New System.Drawing.Size(100, 20)
        Me.АдресTextBox.TabIndex = 12
        '
        'НаименованиеLabel
        '
        НаименованиеLabel.AutoSize = True
        НаименованиеLabel.Location = New System.Drawing.Point(42, 321)
        НаименованиеLabel.Name = "НаименованиеLabel"
        НаименованиеLabel.Size = New System.Drawing.Size(86, 13)
        НаименованиеLabel.TabIndex = 13
        НаименованиеLabel.Text = "Наименование:"
        '
        'НаименованиеTextBox
        '
        Me.НаименованиеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КаталогBindingSource, "Наименование", True))
        Me.НаименованиеTextBox.Location = New System.Drawing.Point(353, 318)
        Me.НаименованиеTextBox.Name = "НаименованиеTextBox"
        Me.НаименованиеTextBox.Size = New System.Drawing.Size(100, 20)
        Me.НаименованиеTextBox.TabIndex = 14
        '
        'Код_издательстваLabel
        '
        Код_издательстваLabel.AutoSize = True
        Код_издательстваLabel.Location = New System.Drawing.Point(42, 347)
        Код_издательстваLabel.Name = "Код_издательстваLabel"
        Код_издательстваLabel.Size = New System.Drawing.Size(102, 13)
        Код_издательстваLabel.TabIndex = 15
        Код_издательстваLabel.Text = "Код издательства:"
        '
        'Код_издательстваTextBox
        '
        Me.Код_издательстваTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КаталогBindingSource, "Код издательства", True))
        Me.Код_издательстваTextBox.Location = New System.Drawing.Point(353, 344)
        Me.Код_издательстваTextBox.Name = "Код_издательстваTextBox"
        Me.Код_издательстваTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Код_издательстваTextBox.TabIndex = 16
        '
        'Код_жанраLabel
        '
        Код_жанраLabel.AutoSize = True
        Код_жанраLabel.Location = New System.Drawing.Point(42, 373)
        Код_жанраLabel.Name = "Код_жанраLabel"
        Код_жанраLabel.Size = New System.Drawing.Size(64, 13)
        Код_жанраLabel.TabIndex = 17
        Код_жанраLabel.Text = "Код жанра:"
        '
        'Код_жанраTextBox
        '
        Me.Код_жанраTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КаталогBindingSource, "Код жанра", True))
        Me.Код_жанраTextBox.Location = New System.Drawing.Point(353, 370)
        Me.Код_жанраTextBox.Name = "Код_жанраTextBox"
        Me.Код_жанраTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Код_жанраTextBox.TabIndex = 18
        '
        'Код_книгиLabel
        '
        Код_книгиLabel.AutoSize = True
        Код_книгиLabel.Location = New System.Drawing.Point(42, 399)
        Код_книгиLabel.Name = "Код_книгиLabel"
        Код_книгиLabel.Size = New System.Drawing.Size(61, 13)
        Код_книгиLabel.TabIndex = 19
        Код_книгиLabel.Text = "Код книги:"
        '
        'Код_книгиTextBox
        '
        Me.Код_книгиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КаталогBindingSource, "Код книги", True))
        Me.Код_книгиTextBox.Location = New System.Drawing.Point(353, 396)
        Me.Код_книгиTextBox.Name = "Код_книгиTextBox"
        Me.Код_книгиTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Код_книгиTextBox.TabIndex = 20
        '
        'Expr1Label
        '
        Expr1Label.AutoSize = True
        Expr1Label.Location = New System.Drawing.Point(42, 425)
        Expr1Label.Name = "Expr1Label"
        Expr1Label.Size = New System.Drawing.Size(37, 13)
        Expr1Label.TabIndex = 21
        Expr1Label.Text = "Expr1:"
        '
        'Expr1TextBox
        '
        Me.Expr1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КаталогBindingSource, "Expr1", True))
        Me.Expr1TextBox.Location = New System.Drawing.Point(353, 422)
        Me.Expr1TextBox.Name = "Expr1TextBox"
        Me.Expr1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Expr1TextBox.TabIndex = 22
        '
        'Наименование_книг__которые_пользуются_популярностьюLabel
        '
        Наименование_книг__которые_пользуются_популярностьюLabel.AutoSize = True
        Наименование_книг__которые_пользуются_популярностьюLabel.Location = New System.Drawing.Point(42, 451)
        Наименование_книг__которые_пользуются_популярностьюLabel.Name = "Наименование_книг__которые_пользуются_популярностьюLabel"
        Наименование_книг__которые_пользуются_популярностьюLabel.Size = New System.Drawing.Size(305, 13)
        Наименование_книг__которые_пользуются_популярностьюLabel.TabIndex = 23
        Наименование_книг__которые_пользуются_популярностьюLabel.Text = "Наименование книг  которые пользуются популярностью:"
        '
        'Наименование_книг__которые_пользуются_популярностьюTextBox
        '
        Me.Наименование_книг__которые_пользуются_популярностьюTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КаталогBindingSource, "Наименование книг_ которые пользуются популярностью", True))
        Me.Наименование_книг__которые_пользуются_популярностьюTextBox.Location = New System.Drawing.Point(353, 448)
        Me.Наименование_книг__которые_пользуются_популярностьюTextBox.Name = "Наименование_книг__которые_пользуются_популярностьюTextBox"
        Me.Наименование_книг__которые_пользуются_популярностьюTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Наименование_книг__которые_пользуются_популярностьюTextBox.TabIndex = 24
        '
        'Expr4Label
        '
        Expr4Label.AutoSize = True
        Expr4Label.Location = New System.Drawing.Point(42, 477)
        Expr4Label.Name = "Expr4Label"
        Expr4Label.Size = New System.Drawing.Size(37, 13)
        Expr4Label.TabIndex = 25
        Expr4Label.Text = "Expr4:"
        '
        'Expr4TextBox
        '
        Me.Expr4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КаталогBindingSource, "Expr4", True))
        Me.Expr4TextBox.Location = New System.Drawing.Point(353, 474)
        Me.Expr4TextBox.Name = "Expr4TextBox"
        Me.Expr4TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Expr4TextBox.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 31)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Каталог"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(692, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 47)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Назад"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 541)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(ОписаниеLabel)
        Me.Controls.Add(Me.ОписаниеTextBox)
        Me.Controls.Add(Наименование_книгLabel)
        Me.Controls.Add(Me.Наименование_книгTextBox)
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
        Me.Controls.Add(Код_издательстваLabel)
        Me.Controls.Add(Me.Код_издательстваTextBox)
        Me.Controls.Add(Код_жанраLabel)
        Me.Controls.Add(Me.Код_жанраTextBox)
        Me.Controls.Add(Код_книгиLabel)
        Me.Controls.Add(Me.Код_книгиTextBox)
        Me.Controls.Add(Expr1Label)
        Me.Controls.Add(Me.Expr1TextBox)
        Me.Controls.Add(Наименование_книг__которые_пользуются_популярностьюLabel)
        Me.Controls.Add(Me.Наименование_книг__которые_пользуются_популярностьюTextBox)
        Me.Controls.Add(Expr4Label)
        Me.Controls.Add(Me.Expr4TextBox)
        Me.Controls.Add(Me.КаталогBindingNavigator)
        Me.Name = "Form12"
        Me.Text = "Form12"
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КаталогBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КаталогBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.КаталогBindingNavigator.ResumeLayout(False)
        Me.КаталогBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents КаталогBindingSource As BindingSource
    Friend WithEvents КаталогTableAdapter As DataSet2TableAdapters.КаталогTableAdapter
    Friend WithEvents TableAdapterManager As DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents КаталогBindingNavigator As BindingNavigator
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
    Friend WithEvents КаталогBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ОписаниеTextBox As TextBox
    Friend WithEvents Наименование_книгTextBox As TextBox
    Friend WithEvents Год_изданияTextBox As TextBox
    Friend WithEvents АвторTextBox As TextBox
    Friend WithEvents ГородTextBox As TextBox
    Friend WithEvents АдресTextBox As TextBox
    Friend WithEvents НаименованиеTextBox As TextBox
    Friend WithEvents Код_издательстваTextBox As TextBox
    Friend WithEvents Код_жанраTextBox As TextBox
    Friend WithEvents Код_книгиTextBox As TextBox
    Friend WithEvents Expr1TextBox As TextBox
    Friend WithEvents Наименование_книг__которые_пользуются_популярностьюTextBox As TextBox
    Friend WithEvents Expr4TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
