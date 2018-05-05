<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Directory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NameLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim E_mailLabel As System.Windows.Forms.Label
        Dim BirthdayLabel As System.Windows.Forms.Label
        Dim Wechat_IDLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.E_mailTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdayTextBox = New System.Windows.Forms.TextBox()
        Me.Wechat_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Load = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.Button()
        Me.ContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactsDataSet = New WindowsApplication36.contactsDataSet()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WechatIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactsTableAdapter = New WindowsApplication36.contactsDataSetTableAdapters.ContactsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication36.contactsDataSetTableAdapters.TableAdapterManager()
        Me.PasswordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PasswordDataSet = New WindowsApplication36.passwordDataSet()
        Me.PasswordTableAdapter = New WindowsApplication36.passwordDataSetTableAdapters.PasswordTableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication36.passwordDataSetTableAdapters.TableAdapterManager()
        NameLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        E_mailLabel = New System.Windows.Forms.Label()
        BirthdayLabel = New System.Windows.Forms.Label()
        Wechat_IDLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(10, 37)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 1
        NameLabel.Text = "Name:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(11, 75)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 3
        PhoneLabel.Text = "Phone:"
        '
        'E_mailLabel
        '
        E_mailLabel.AutoSize = True
        E_mailLabel.Location = New System.Drawing.Point(10, 116)
        E_mailLabel.Name = "E_mailLabel"
        E_mailLabel.Size = New System.Drawing.Size(38, 13)
        E_mailLabel.TabIndex = 5
        E_mailLabel.Text = "E-mail:"
        '
        'BirthdayLabel
        '
        BirthdayLabel.AutoSize = True
        BirthdayLabel.Location = New System.Drawing.Point(10, 158)
        BirthdayLabel.Name = "BirthdayLabel"
        BirthdayLabel.Size = New System.Drawing.Size(48, 13)
        BirthdayLabel.TabIndex = 7
        BirthdayLabel.Text = "Birthday:"
        '
        'Wechat_IDLabel
        '
        Wechat_IDLabel.AutoSize = True
        Wechat_IDLabel.Location = New System.Drawing.Point(10, 193)
        Wechat_IDLabel.Name = "Wechat_IDLabel"
        Wechat_IDLabel.Size = New System.Drawing.Size(62, 13)
        Wechat_IDLabel.TabIndex = 9
        Wechat_IDLabel.Text = "Wechat ID:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.BirthdayDataGridViewTextBoxColumn, Me.WechatIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ContactsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(239, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(545, 285)
        Me.DataGridView1.TabIndex = 0
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(78, 34)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(140, 20)
        Me.NameTextBox.TabIndex = 2
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(78, 72)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(140, 20)
        Me.PhoneTextBox.TabIndex = 4
        '
        'E_mailTextBox
        '
        Me.E_mailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "E-mail", True))
        Me.E_mailTextBox.Location = New System.Drawing.Point(78, 113)
        Me.E_mailTextBox.Name = "E_mailTextBox"
        Me.E_mailTextBox.Size = New System.Drawing.Size(140, 20)
        Me.E_mailTextBox.TabIndex = 6
        '
        'BirthdayTextBox
        '
        Me.BirthdayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "Birthday", True))
        Me.BirthdayTextBox.Location = New System.Drawing.Point(78, 155)
        Me.BirthdayTextBox.Name = "BirthdayTextBox"
        Me.BirthdayTextBox.Size = New System.Drawing.Size(140, 20)
        Me.BirthdayTextBox.TabIndex = 8
        '
        'Wechat_IDTextBox
        '
        Me.Wechat_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "Wechat ID", True))
        Me.Wechat_IDTextBox.Location = New System.Drawing.Point(78, 190)
        Me.Wechat_IDTextBox.Name = "Wechat_IDTextBox"
        Me.Wechat_IDTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Wechat_IDTextBox.TabIndex = 10
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(29, 235)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(73, 32)
        Me.Add.TabIndex = 11
        Me.Add.Text = "Add New"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(123, 235)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(77, 31)
        Me.Save.TabIndex = 12
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(28, 288)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(73, 31)
        Me.Delete.TabIndex = 13
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Load
        '
        Me.Load.Location = New System.Drawing.Point(123, 288)
        Me.Load.Name = "Load"
        Me.Load.Size = New System.Drawing.Size(77, 31)
        Me.Load.TabIndex = 14
        Me.Load.Text = "Load"
        Me.Load.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(295, 343)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(71, 24)
        Me.Search.TabIndex = 15
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(29, 346)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(227, 20)
        Me.TextBox1.TabIndex = 16
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(419, 343)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(128, 24)
        Me.pass.TabIndex = 17
        Me.pass.Text = "Set Password"
        Me.pass.UseVisualStyleBackColor = True
        '
        'ContactsBindingSource
        '
        Me.ContactsBindingSource.DataMember = "Contacts"
        Me.ContactsBindingSource.DataSource = Me.ContactsDataSet
        '
        'ContactsDataSet
        '
        Me.ContactsDataSet.DataSetName = "contactsDataSet"
        Me.ContactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "E-mail"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "E-mail"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'BirthdayDataGridViewTextBoxColumn
        '
        Me.BirthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday"
        Me.BirthdayDataGridViewTextBoxColumn.HeaderText = "Birthday"
        Me.BirthdayDataGridViewTextBoxColumn.Name = "BirthdayDataGridViewTextBoxColumn"
        '
        'WechatIDDataGridViewTextBoxColumn
        '
        Me.WechatIDDataGridViewTextBoxColumn.DataPropertyName = "Wechat ID"
        Me.WechatIDDataGridViewTextBoxColumn.HeaderText = "Wechat ID"
        Me.WechatIDDataGridViewTextBoxColumn.Name = "WechatIDDataGridViewTextBoxColumn"
        '
        'ContactsTableAdapter
        '
        Me.ContactsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ContactsTableAdapter = Me.ContactsTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication36.contactsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PasswordBindingSource
        '
        Me.PasswordBindingSource.DataMember = "Password"
        Me.PasswordBindingSource.DataSource = Me.PasswordDataSet
        '
        'PasswordDataSet
        '
        Me.PasswordDataSet.DataSetName = "passwordDataSet"
        Me.PasswordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PasswordTableAdapter
        '
        Me.PasswordTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PasswordTableAdapter = Me.PasswordTableAdapter
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication36.passwordDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Directory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 428)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Load)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Wechat_IDLabel)
        Me.Controls.Add(Me.Wechat_IDTextBox)
        Me.Controls.Add(BirthdayLabel)
        Me.Controls.Add(Me.BirthdayTextBox)
        Me.Controls.Add(E_mailLabel)
        Me.Controls.Add(Me.E_mailTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Directory"
        Me.Text = "Phone Directory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ContactsDataSet As WindowsApplication36.contactsDataSet
    Friend WithEvents ContactsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContactsTableAdapter As WindowsApplication36.contactsDataSetTableAdapters.ContactsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication36.contactsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents E_mailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BirthdayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Wechat_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Load As System.Windows.Forms.Button
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BirthdayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WechatIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents pass As System.Windows.Forms.Button
    Friend WithEvents PasswordDataSet As WindowsApplication36.passwordDataSet
    Friend WithEvents PasswordBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PasswordTableAdapter As WindowsApplication36.passwordDataSetTableAdapters.PasswordTableAdapter
    Friend WithEvents TableAdapterManager1 As WindowsApplication36.passwordDataSetTableAdapters.TableAdapterManager

End Class
