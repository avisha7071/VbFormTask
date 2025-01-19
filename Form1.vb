Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim con As New SqlConnection("Data Source=SAHIL\SQLEXPRESS1;Initial Catalog=testproject;Persist Security Info=True;User ID=sa;Password=***********;Encrypt=False;Trusted_Connection=yes")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim FirstName As String = txtFirstName.Text
        Dim LastName As String = txtLastName.Text
        Dim Mobile As String = txtMobile.Text
        Dim Email As String = txtEmail.Text
        Dim Website As String = txtWebsite.Text
        Dim ABN As String = txtAbn.Text

        con.Open()

        If String.IsNullOrEmpty(txtFirstName.Text) AndAlso String.IsNullOrEmpty(txtLastName.Text) AndAlso String.IsNullOrEmpty(txtMobile.Text) AndAlso String.IsNullOrEmpty(txtEmail.Text) AndAlso String.IsNullOrEmpty(txtWebsite.Text) AndAlso String.IsNullOrEmpty(txtAbn.Text) Then
            MessageBox.Show("Contains Empty value or Null Value")
        Else
            Dim command As New SqlCommand("Insert into Customers Values('" & FirstName & "','" & LastName & "','" & Mobile & "','" & Email & "','" & Website & "','" & ABN & "')", con)
            command.ExecuteNonQuery()
        End If

        con.Close()
        MessageBox.Show("sucessfully inserted")
        LoadDataInGrid()


    End Sub
    Private Sub LoadDataInGrid()

        Dim command As New SqlCommand("Select * from Customers", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInGrid()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim ProductId As Integer
        ProductId = Convert.ToInt32(product_id.Text)
        Dim FirstName As String = txtFirstName.Text
        Dim LastName As String = txtLastName.Text
        Dim Mobile As String = txtMobile.Text
        Dim Email As String = txtEmail.Text
        Dim Website As String = txtWebsite.Text
        Dim ABN As String = txtAbn.Text

        con.Open()
        If String.IsNullOrEmpty(txtFirstName.Text) AndAlso String.IsNullOrEmpty(txtLastName.Text) AndAlso String.IsNullOrEmpty(txtMobile.Text) AndAlso String.IsNullOrEmpty(txtEmail.Text) AndAlso String.IsNullOrEmpty(txtWebsite.Text) AndAlso String.IsNullOrEmpty(txtAbn.Text) Then
            MessageBox.Show("Contains Empty value or Null Value")
        Else
            Dim command As New SqlCommand("Update Customers set FirstName = '" & FirstName & "',LastName = '" & LastName & "',Mobile = '" & Mobile & "',Email = '" & Email & "',Website = '" & Website & "',ABN = '" & ABN & "' where ID = '" & ProductId & "' ", con)
            command.ExecuteNonQuery()
        End If
        con.Close()
        MessageBox.Show("sucessfully updated")
        LoadDataInGrid()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ProductId As Integer
        ProductId = Convert.ToInt32(product_id.Text)
        con.Open()
        Dim command As New SqlCommand("delete Customers where ID = '" & ProductId & "' ", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("sucessfully deleted")
        LoadDataInGrid()
    End Sub
End Class
