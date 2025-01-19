<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtFirstName = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtLastName = New TextBox()
        txtMobile = New TextBox()
        txtEmail = New TextBox()
        txtWebsite = New TextBox()
        txtAbn = New TextBox()
        btnSave = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        DataGridView1 = New DataGridView()
        productID = New Label()
        product_id = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(181, 34)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(159, 27)
        txtFirstName.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(52, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 20)
        Label1.TabIndex = 1
        Label1.Text = "FirstName"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(52, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 2
        Label2.Text = "LastName"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(52, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 20)
        Label3.TabIndex = 3
        Label3.Text = "Mobile Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(52, 199)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 4
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(52, 254)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 20)
        Label5.TabIndex = 5
        Label5.Text = "Website"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(52, 307)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 20)
        Label6.TabIndex = 6
        Label6.Text = "ABN Number"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(181, 93)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(159, 27)
        txtLastName.TabIndex = 7
        ' 
        ' txtMobile
        ' 
        txtMobile.Location = New Point(181, 145)
        txtMobile.Name = "txtMobile"
        txtMobile.Size = New Size(159, 27)
        txtMobile.TabIndex = 8
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(181, 196)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(159, 27)
        txtEmail.TabIndex = 9
        ' 
        ' txtWebsite
        ' 
        txtWebsite.Location = New Point(181, 247)
        txtWebsite.Name = "txtWebsite"
        txtWebsite.Size = New Size(159, 27)
        txtWebsite.TabIndex = 10
        ' 
        ' txtAbn
        ' 
        txtAbn.Location = New Point(181, 300)
        txtAbn.Name = "txtAbn"
        txtAbn.Size = New Size(159, 27)
        txtAbn.TabIndex = 11
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(102, 366)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 12
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(252, 366)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(94, 29)
        btnEdit.TabIndex = 13
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(393, 366)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 14
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(54, 461)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(842, 265)
        DataGridView1.TabIndex = 15
        ' 
        ' productID
        ' 
        productID.AutoSize = True
        productID.Location = New Point(54, 7)
        productID.Name = "productID"
        productID.Size = New Size(77, 20)
        productID.TabIndex = 16
        productID.Text = "Product Id"
        ' 
        ' product_id
        ' 
        product_id.Location = New Point(181, 0)
        product_id.Name = "product_id"
        product_id.Size = New Size(165, 27)
        product_id.TabIndex = 17
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(968, 761)
        Controls.Add(product_id)
        Controls.Add(productID)
        Controls.Add(DataGridView1)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnSave)
        Controls.Add(txtAbn)
        Controls.Add(txtWebsite)
        Controls.Add(txtEmail)
        Controls.Add(txtMobile)
        Controls.Add(txtLastName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtFirstName)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtWebsite As TextBox
    Friend WithEvents txtAbn As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents productID As Label
    Friend WithEvents product_id As TextBox

End Class
