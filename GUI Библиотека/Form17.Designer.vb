<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form17
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form17))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataSet3 = New GUI_Библиотека.DataSet3()
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Фильтры_для_отображения_книг_отдельных_авторовTableAdapter = New GUI_Библиотека.DataSet3TableAdapters.Фильтры_для_отображения_книг_отдельных_авторовTableAdapter()
        Me.TableAdapterManager = New GUI_Библиотека.DataSet3TableAdapters.TableAdapterManager()
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Фильтры_для_отображения_книг_отдельных_авторовDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Фильтры_для_отображения_книг_отдельных_авторовBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.SuspendLayout()
        CType(Me.Фильтры_для_отображения_книг_отдельных_авторовDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(495, 31)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Отображения книг отдельных авторов"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(733, 397)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 38)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "Назад"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Фильтры_для_отображения_книг_отдельных_авторовBindingSource
        '
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingSource.DataMember = "Фильтры для отображения книг отдельных авторов"
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingSource.DataSource = Me.DataSet3
        '
        'Фильтры_для_отображения_книг_отдельных_авторовTableAdapter
        '
        Me.Фильтры_для_отображения_книг_отдельных_авторовTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = GUI_Библиотека.DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator
        '
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.BindingSource = Me.Фильтры_для_отображения_книг_отдельных_авторовBindingSource
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigatorSaveItem})
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.Name = "Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator"
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.Size = New System.Drawing.Size(828, 25)
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.TabIndex = 87
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.Text = "BindingNavigator1"
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
        'Фильтры_для_отображения_книг_отдельных_авторовBindingNavigatorSaveItem
        '
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigatorSaveItem.Enabled = False
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigatorSaveItem.Image = CType(resources.GetObject("Фильтры_для_отображения_книг_отдельных_авторовBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigatorSaveItem.Name = "Фильтры_для_отображения_книг_отдельных_авторовBindingNavigatorSaveItem"
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Фильтры_для_отображения_книг_отдельных_авторовDataGridView
        '
        Me.Фильтры_для_отображения_книг_отдельных_авторовDataGridView.AutoGenerateColumns = False
        Me.Фильтры_для_отображения_книг_отдельных_авторовDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Фильтры_для_отображения_книг_отдельных_авторовDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Фильтры_для_отображения_книг_отдельных_авторовDataGridView.DataSource = Me.Фильтры_для_отображения_книг_отдельных_авторовBindingSource
        Me.Фильтры_для_отображения_книг_отдельных_авторовDataGridView.Location = New System.Drawing.Point(98, 117)
        Me.Фильтры_для_отображения_книг_отдельных_авторовDataGridView.Name = "Фильтры_для_отображения_книг_отдельных_авторовDataGridView"
        Me.Фильтры_для_отображения_книг_отдельных_авторовDataGridView.Size = New System.Drawing.Size(564, 165)
        Me.Фильтры_для_отображения_книг_отдельных_авторовDataGridView.TabIndex = 87
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Автор"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Автор"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Наименование"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Наименование"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Год издания"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Год издания"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Form17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 447)
        Me.Controls.Add(Me.Фильтры_для_отображения_книг_отдельных_авторовDataGridView)
        Me.Controls.Add(Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form17"
        Me.Text = "Form17"
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Фильтры_для_отображения_книг_отдельных_авторовBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.ResumeLayout(False)
        Me.Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator.PerformLayout()
        CType(Me.Фильтры_для_отображения_книг_отдельных_авторовDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataSet3 As DataSet3
    Friend WithEvents Фильтры_для_отображения_книг_отдельных_авторовBindingSource As BindingSource
    Friend WithEvents Фильтры_для_отображения_книг_отдельных_авторовTableAdapter As DataSet3TableAdapters.Фильтры_для_отображения_книг_отдельных_авторовTableAdapter
    Friend WithEvents TableAdapterManager As DataSet3TableAdapters.TableAdapterManager
    Friend WithEvents Фильтры_для_отображения_книг_отдельных_авторовBindingNavigator As BindingNavigator
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
    Friend WithEvents Фильтры_для_отображения_книг_отдельных_авторовBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Фильтры_для_отображения_книг_отдельных_авторовDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
