Imports System.IO

Public Class Form1
    Dim myconn As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query.Enabled = False
    End Sub
    Private Sub Connect_Click(sender As Object, e As EventArgs) Handles Connect.Click
        If Connect.Tag = 1 Then
            Connect.Tag = 0
            myConnect()
        Else
            txt_ip_server.Enabled = True
            txt_port.Enabled = True
            txt_user.Enabled = True
            txt_password.Enabled = True
            txt_database.Enabled = True
            Connect.Tag = 1
            Connect.Text = "Connect"
        End If

    End Sub
    Public Sub myConnect()
        myconn = ConfigMySql.SetConnect(txt_ip_server.Text, txt_user.Text, txt_password.Text, txt_database.Text, txt_port.Text)
        If ConfigMySql.Test_connect(myconn) = True Then
            txt_ip_server.Enabled = False
            txt_port.Enabled = False
            txt_user.Enabled = False
            txt_password.Enabled = False
            txt_database.Enabled = False
            query.Enabled = True
            Connect.Tag = 0
            Connect.Text = "disconnect"
            GetAllTable()
        Else
            MessageBox.Show("error connecttion", "mySql error !!!")
        End If
    End Sub
    Public Sub GetAllTable()
        txt_table_name.Items.Clear()
        Dim dt As New DataTable
        dt = ConfigMySql.SelectData(myconn, "SELECT table_name FROM information_schema.tables WHERE table_type = 'base table' And table_schema='" & txt_database.Text & "';")
        If dt.Rows.Count > 0 Then
            For ir As Integer = 0 To dt.Rows.Count - 1
                Dim dr As DataRow = dt.Rows(ir)
                txt_table_name.Items.Add(dr("table_name"))
            Next
        End If
    End Sub
    Private Sub txt_table_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_table_name.SelectedIndexChanged
        If txt_table_name.Text <> "" Then
            strSql.Text = "Select * From " & txt_table_name.Text & " LIMIT 0, 20"
            query_Click(sender, e)
        End If
    End Sub
    Private Sub query_Click(sender As Object, e As EventArgs) Handles query.Click
        If myconn = "" Then
            myConnect()
        End If
        Try
            DataGridView1.DataSource = Nothing
            DataGridView1.Rows.Clear()
            DataGridView1.Columns.Clear()
            DataGridView1.DataSource = ConfigMySql.SelectData(myconn, strSql.Text)
            log(strSql.Text)
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            DataGridView1.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub log(my_log As String)
        Dim strFile As String = "log_query.txt"
        Dim fileExists As Boolean = File.Exists(strFile)
        'Using sw As New StreamWriter(File.Open(strFile, FileMode.OpenOrCreate))
        '    sw.WriteLine(
        '        IIf(fileExists, "Sql Query  Log at-- " & DateTime.Now, my_log))
        'End Using 
        Dim lotno As String = "log_query"
        FileOpen(1, (strFile), OpenMode.Append)
        PrintLine(1, "Start Time :", Now())
        PrintLine(1, "log_query :", vbNewLine & my_log)
        FileClose(1)
    End Sub

    Public Sub CopyToClipboardWithHeaders(ByVal _dgv As DataGridView)
        _dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Dim dataObj As DataObject = _dgv.GetClipboardContent()
        If dataObj IsNot Nothing Then Clipboard.SetDataObject(dataObj)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub
    Dim MousePosition As New Point
    Private Sub dataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.Button = MouseButtons.Right Then
            DataGridView1.CurrentCell = DataGridView1(e.ColumnIndex, e.RowIndex)

            Dim relativeClickedPosition = MousePosition
            Dim screenClickedPosition = (TryCast(sender, Control)).PointToScreen(relativeClickedPosition)
            ContextMenuStrip1.Show(screenClickedPosition)
        End If
    End Sub

    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDown

        If e.Button = MouseButtons.Right Then
            MousePosition = e.Location
            'Dim relativeClickedPosition = e.Location
            'Dim screenClickedPosition = (TryCast(sender, Control)).PointToScreen(relativeClickedPosition)
            'ContextMenuStrip1.Show(screenClickedPosition)
        End If
    End Sub

    Private Sub CoppyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoppyToolStripMenuItem.Click
        CopyToClipboardWithHeaders(DataGridView1)
    End Sub


    Private Sub strSql_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles strSql.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        Else
            Dim dddd = e.KeyChar
        End If
    End Sub

    Private Sub strSql_KeyDown(sender As Object, e As KeyEventArgs) Handles strSql.KeyDown
        'If e.KeyCode = Keys.Control Then
        '    DirectCast(sender, TextBox).SelectAll()
        '    e.Handled = True
        'End If
    End Sub
End Class
