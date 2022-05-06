<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_table_name = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_database = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_port = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_ip_server = New System.Windows.Forms.TextBox()
        Me.Connect = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.strSql = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.query = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CoppyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txt_table_name)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txt_database)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_port)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_user)
        Me.Panel1.Controls.Add(Me.txt_ip_server)
        Me.Panel1.Controls.Add(Me.Connect)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_password)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1264, 82)
        Me.Panel1.TabIndex = 0
        '
        'txt_table_name
        '
        Me.txt_table_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_table_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txt_table_name.FormattingEnabled = True
        Me.txt_table_name.Location = New System.Drawing.Point(83, 50)
        Me.txt_table_name.Name = "txt_table_name"
        Me.txt_table_name.Size = New System.Drawing.Size(262, 24)
        Me.txt_table_name.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "All Table :"
        '
        'txt_database
        '
        Me.txt_database.Location = New System.Drawing.Point(921, 15)
        Me.txt_database.Name = "txt_database"
        Me.txt_database.Size = New System.Drawing.Size(164, 22)
        Me.txt_database.TabIndex = 4
        Me.txt_database.Text = "test"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(802, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Database Name : "
        '
        'txt_port
        '
        Me.txt_port.Location = New System.Drawing.Point(278, 15)
        Me.txt_port.Name = "txt_port"
        Me.txt_port.Size = New System.Drawing.Size(67, 22)
        Me.txt_port.TabIndex = 1
        Me.txt_port.Text = "3306"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Port :"
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(465, 15)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(118, 22)
        Me.txt_user.TabIndex = 2
        Me.txt_user.Text = "root"
        '
        'txt_ip_server
        '
        Me.txt_ip_server.Location = New System.Drawing.Point(83, 15)
        Me.txt_ip_server.Name = "txt_ip_server"
        Me.txt_ip_server.Size = New System.Drawing.Size(131, 22)
        Me.txt_ip_server.TabIndex = 0
        Me.txt_ip_server.Text = "127.0.0.1"
        '
        'Connect
        '
        Me.Connect.Location = New System.Drawing.Point(1101, 3)
        Me.Connect.Name = "Connect"
        Me.Connect.Size = New System.Drawing.Size(107, 50)
        Me.Connect.TabIndex = 6
        Me.Connect.Tag = "1"
        Me.Connect.Text = "Connect"
        Me.Connect.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(597, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password : "
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(684, 15)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(101, 22)
        Me.txt_password.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(368, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "User Name : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Server IP :"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 107)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.strSql)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1264, 403)
        Me.SplitContainer1.SplitterDistance = 116
        Me.SplitContainer1.TabIndex = 1
        '
        'strSql
        '
        Me.strSql.BackColor = System.Drawing.Color.DimGray
        Me.strSql.Dock = System.Windows.Forms.DockStyle.Fill
        Me.strSql.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strSql.ForeColor = System.Drawing.Color.White
        Me.strSql.Location = New System.Drawing.Point(0, 0)
        Me.strSql.Margin = New System.Windows.Forms.Padding(30, 10, 3, 3)
        Me.strSql.Multiline = True
        Me.strSql.Name = "strSql"
        Me.strSql.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.strSql.Size = New System.Drawing.Size(1064, 116)
        Me.strSql.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.query)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1064, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 116)
        Me.Panel2.TabIndex = 1
        '
        'query
        '
        Me.query.Location = New System.Drawing.Point(22, 18)
        Me.query.Name = "query"
        Me.query.Size = New System.Drawing.Size(107, 47)
        Me.query.TabIndex = 7
        Me.query.Text = "SQL Query"
        Me.query.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1264, 283)
        Me.DataGridView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CoppyToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(113, 28)
        Me.ContextMenuStrip1.Text = "Coppy"
        '
        'CoppyToolStripMenuItem
        '
        Me.CoppyToolStripMenuItem.Name = "CoppyToolStripMenuItem"
        Me.CoppyToolStripMenuItem.Size = New System.Drawing.Size(112, 24)
        Me.CoppyToolStripMenuItem.Text = "Copy"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1288, 522)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MySQL Database"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Connect As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents strSql As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents query As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CoppyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txt_port As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_ip_server As TextBox
    Friend WithEvents txt_database As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_table_name As ComboBox
    Friend WithEvents Label6 As Label
End Class
