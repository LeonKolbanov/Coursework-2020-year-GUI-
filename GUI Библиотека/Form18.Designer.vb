<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form18
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form18))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet3 = New GUI_Библиотека.DataSet3()
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__TableAdapter = New GUI_Библиотека.DataSet3TableAdapters.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__TableAdapter()
        Me.TableAdapterManager = New GUI_Библиотека.DataSet3TableAdapters.TableAdapterManager()
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.SuspendLayout()
        CType(Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(946, 31)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Отображения книг отдельных годов издания на основе запроса ""Каталог"""
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingSource
        '
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingSource.DataMember = "Фильтры для отображения книг отдельных годов издания (На основе запроса ""Каталог""" &
    ")"
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingSource.DataSource = Me.DataSet3
        '
        'Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__TableAdapter
        '
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = GUI_Библиотека.DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator
        '
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.BindingSource = Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingSource
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigatorSaveItem})
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.Name = "Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог_" &
    "_BindingNavigator"
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.Size = New System.Drawing.Size(1177, 25)
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.TabIndex = 33
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.Text = "BindingNavigator1"
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
        'Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigatorSaveItem
        '
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigatorSaveItem.Enabled = False
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigatorSaveItem.Image = CType(resources.GetObject("Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог_" &
        "_BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigatorSaveItem.Name = "Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог_" &
    "_BindingNavigatorSaveItem"
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__DataGridView
        '
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__DataGridView.AutoGenerateColumns = False
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__DataGridView.DataSource = Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingSource
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__DataGridView.Location = New System.Drawing.Point(224, 96)
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__DataGridView.Name = "Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог_" &
    "_DataGridView"
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__DataGridView.Size = New System.Drawing.Size(608, 301)
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__DataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Год издания"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Год издания"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Описание"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Описание"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Наименование книг"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Наименование книг"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Автор"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Автор"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Наименование"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Наименование"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(1016, 514)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 67)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "Назад"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 631)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__DataGridView)
        Me.Controls.Add(Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form18"
        Me.Text = "Form18"
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.ResumeLayout(False)
        Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator.PerformLayout()
        CType(Me.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet3 As DataSet3
    Friend WithEvents Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingSource As BindingSource
    Friend WithEvents Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__TableAdapter As DataSet3TableAdapters.Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__TableAdapter
    Friend WithEvents TableAdapterManager As DataSet3TableAdapters.TableAdapterManager
    Friend WithEvents Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigator As BindingNavigator
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
    Friend WithEvents Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Фильтры_для_отображения_книг_отдельных_годов_издания__На_основе_запроса__Каталог__DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
