Public Class Directory
    Dim globalflag As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PasswordDataSet.Password' table. You can move, or remove it, as needed.
        Me.PasswordTableAdapter.Fill(Me.PasswordDataSet.Password)
    End Sub

    Private Sub Load_Click(sender As Object, e As EventArgs) Handles Load.Click
        Dim pw As String = PasswordTableAdapter.FillBy().ToString
        Dim flag As Boolean = False
        Do Until globalflag = True Or flag = True
            Dim inp As String = InputBox("Enter Password", "Login", "")
            If inp = pw Then
                globalflag = True
            ElseIf inp <> pw And inp <> "" Then
                MessageBox.Show("Wrong!")
            ElseIf inp = "" Then
                flag = True
            End If
        Loop
        If globalflag = True Then
            'TODO: This line of code loads data into the 'ContactsDataSet.Contacts' table. You can move, or remove it, as needed.
            Me.ContactsTableAdapter.Fill(Me.ContactsDataSet.Contacts)
        End If
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        ContactsBindingSource.AddNew()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Try
            ContactsBindingSource.EndEdit()
            ContactsTableAdapter.Update(ContactsDataSet.Contacts)
            MessageBox.Show("Save Completed!")
        Catch ex As Exception
            MessageBox.Show("Whoops, there was an error.")
        End Try
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        ContactsBindingSource.RemoveCurrent()
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        ContactsTableAdapter.Fillby(ContactsDataSet.Contacts, TextBox1.Text, TextBox1.Text, TextBox1.Text, TextBox1.Text, TextBox1.Text)
    End Sub
    Private Sub pass_Click(sender As Object, e As EventArgs) Handles pass.Click
        Dim pw As String = PasswordTableAdapter.FillBy().ToString
        Dim flag As Boolean = False
        Dim flag2 As Boolean = False
        Do Until flag = True Or flag2 = True
            Dim inp As String = InputBox("Enter Password", "Set Password", "")
            If inp = pw Then
                MessageBox.Show("Correct!")
                flag = True
            ElseIf inp <> pw And inp <> "" Then
                MessageBox.Show("WRONG!")
            ElseIf inp = "" Then
                flag2 = True
            End If
        Loop
        If flag = True Then
            Dim flag3 As Boolean = False
            Do Until flag3 = True
                Dim newpass As String = InputBox("Set Password", "Set Password", "")
                If newpass <> "" Then
                    PasswordTableAdapter.UpdateQuery(newpass)
                    PasswordTableAdapter.Update(PasswordDataSet.Password)
                    flag3 = True
                Else
                    MessageBox.Show("Please type in a password!")
                End If
            Loop
        End If
    End Sub
End Class
