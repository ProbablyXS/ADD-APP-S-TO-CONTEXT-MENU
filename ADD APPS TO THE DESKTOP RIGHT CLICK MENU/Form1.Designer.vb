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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NameBoxText1 = New System.Windows.Forms.TextBox()
        Me.DestinationFolderBoxText1 = New System.Windows.Forms.TextBox()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.DestinationFolderLabel1 = New System.Windows.Forms.Label()
        Me.DeleteButton1 = New System.Windows.Forms.Button()
        Me.NameDeleteLabel1 = New System.Windows.Forms.Label()
        Me.NameDeleteBoxText1 = New System.Windows.Forms.TextBox()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonApply = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'NameBoxText1
        '
        Me.NameBoxText1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NameBoxText1.Location = New System.Drawing.Point(280, 38)
        Me.NameBoxText1.Name = "NameBoxText1"
        Me.NameBoxText1.Size = New System.Drawing.Size(100, 20)
        Me.NameBoxText1.TabIndex = 0
        '
        'DestinationFolderBoxText1
        '
        Me.DestinationFolderBoxText1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DestinationFolderBoxText1.Location = New System.Drawing.Point(226, 12)
        Me.DestinationFolderBoxText1.Name = "DestinationFolderBoxText1"
        Me.DestinationFolderBoxText1.Size = New System.Drawing.Size(258, 20)
        Me.DestinationFolderBoxText1.TabIndex = 2
        Me.DestinationFolderBoxText1.Text = "C:\\\.exe"
        '
        'NameLabel1
        '
        Me.NameLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NameLabel1.AutoSize = True
        Me.NameLabel1.BackColor = System.Drawing.Color.Transparent
        Me.NameLabel1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel1.Location = New System.Drawing.Point(234, 39)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(40, 15)
        Me.NameLabel1.TabIndex = 3
        Me.NameLabel1.Text = "Name"
        '
        'DestinationFolderLabel1
        '
        Me.DestinationFolderLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DestinationFolderLabel1.AutoSize = True
        Me.DestinationFolderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.DestinationFolderLabel1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DestinationFolderLabel1.Location = New System.Drawing.Point(9, 14)
        Me.DestinationFolderLabel1.Name = "DestinationFolderLabel1"
        Me.DestinationFolderLabel1.Size = New System.Drawing.Size(107, 15)
        Me.DestinationFolderLabel1.TabIndex = 4
        Me.DestinationFolderLabel1.Text = "Destination folder"
        '
        'DeleteButton1
        '
        Me.DeleteButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DeleteButton1.Location = New System.Drawing.Point(377, 208)
        Me.DeleteButton1.Name = "DeleteButton1"
        Me.DeleteButton1.Size = New System.Drawing.Size(97, 19)
        Me.DeleteButton1.TabIndex = 5
        Me.DeleteButton1.Text = "Delete"
        Me.DeleteButton1.UseVisualStyleBackColor = True
        '
        'NameDeleteLabel1
        '
        Me.NameDeleteLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NameDeleteLabel1.AutoSize = True
        Me.NameDeleteLabel1.BackColor = System.Drawing.Color.Transparent
        Me.NameDeleteLabel1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameDeleteLabel1.Location = New System.Drawing.Point(331, 234)
        Me.NameDeleteLabel1.Name = "NameDeleteLabel1"
        Me.NameDeleteLabel1.Size = New System.Drawing.Size(40, 15)
        Me.NameDeleteLabel1.TabIndex = 7
        Me.NameDeleteLabel1.Text = "Name"
        '
        'NameDeleteBoxText1
        '
        Me.NameDeleteBoxText1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NameDeleteBoxText1.Location = New System.Drawing.Point(377, 233)
        Me.NameDeleteBoxText1.Name = "NameDeleteBoxText1"
        Me.NameDeleteBoxText1.Size = New System.Drawing.Size(97, 20)
        Me.NameDeleteBoxText1.TabIndex = 6
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonBrowse.Location = New System.Drawing.Point(122, 12)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(98, 20)
        Me.ButtonBrowse.TabIndex = 8
        Me.ButtonBrowse.Text = "Browse"
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ButtonApply
        '
        Me.ButtonApply.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonApply.Location = New System.Drawing.Point(386, 38)
        Me.ButtonApply.Name = "ButtonApply"
        Me.ButtonApply.Size = New System.Drawing.Size(98, 20)
        Me.ButtonApply.TabIndex = 9
        Me.ButtonApply.Text = "Apply"
        Me.ButtonApply.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 132)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(300, 121)
        Me.ListBox1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(499, 266)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ButtonApply)
        Me.Controls.Add(Me.ButtonBrowse)
        Me.Controls.Add(Me.NameDeleteLabel1)
        Me.Controls.Add(Me.NameDeleteBoxText1)
        Me.Controls.Add(Me.DeleteButton1)
        Me.Controls.Add(Me.DestinationFolderLabel1)
        Me.Controls.Add(Me.NameLabel1)
        Me.Controls.Add(Me.DestinationFolderBoxText1)
        Me.Controls.Add(Me.NameBoxText1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADDXSATTDRCM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameBoxText1 As System.Windows.Forms.TextBox
    Friend WithEvents DestinationFolderBoxText1 As System.Windows.Forms.TextBox
    Friend WithEvents NameLabel1 As System.Windows.Forms.Label
    Friend WithEvents DestinationFolderLabel1 As System.Windows.Forms.Label
    Friend WithEvents DeleteButton1 As System.Windows.Forms.Button
    Friend WithEvents NameDeleteLabel1 As System.Windows.Forms.Label
    Friend WithEvents NameDeleteBoxText1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonBrowse As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ButtonApply As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
