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
        Me.txtStoreID = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtLocalCon = New System.Windows.Forms.TextBox()
        Me.txtCloudConn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbSyncData = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbTest = New System.Windows.Forms.ToolStripButton()
        Me.tsbFillTxt = New System.Windows.Forms.ToolStripButton()
        Me.rtbLogs = New System.Windows.Forms.RichTextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtStoreID
        '
        Me.txtStoreID.Location = New System.Drawing.Point(120, 45)
        Me.txtStoreID.Name = "txtStoreID"
        Me.txtStoreID.Size = New System.Drawing.Size(495, 21)
        Me.txtStoreID.TabIndex = 0
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(120, 71)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(495, 21)
        Me.txtUserID.TabIndex = 1
        '
        'txtLocalCon
        '
        Me.txtLocalCon.Location = New System.Drawing.Point(120, 97)
        Me.txtLocalCon.Name = "txtLocalCon"
        Me.txtLocalCon.Size = New System.Drawing.Size(495, 21)
        Me.txtLocalCon.TabIndex = 2
        '
        'txtCloudConn
        '
        Me.txtCloudConn.Location = New System.Drawing.Point(120, 123)
        Me.txtCloudConn.Name = "txtCloudConn"
        Me.txtCloudConn.Size = New System.Drawing.Size(495, 21)
        Me.txtCloudConn.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Store ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "User ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Local Conn"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cloud Conn"
        '
        'rbSyncData
        '
        Me.rbSyncData.AutoSize = True
        Me.rbSyncData.Location = New System.Drawing.Point(120, 150)
        Me.rbSyncData.Name = "rbSyncData"
        Me.rbSyncData.Size = New System.Drawing.Size(74, 17)
        Me.rbSyncData.TabIndex = 8
        Me.rbSyncData.TabStop = True
        Me.rbSyncData.Text = "Sync Data"
        Me.rbSyncData.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbTest, Me.tsbFillTxt})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(730, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbTest
        '
        Me.tsbTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbTest.Image = CType(resources.GetObject("tsbTest.Image"), System.Drawing.Image)
        Me.tsbTest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTest.Name = "tsbTest"
        Me.tsbTest.Size = New System.Drawing.Size(31, 22)
        Me.tsbTest.Text = "Test"
        '
        'tsbFillTxt
        '
        Me.tsbFillTxt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbFillTxt.Image = CType(resources.GetObject("tsbFillTxt.Image"), System.Drawing.Image)
        Me.tsbFillTxt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFillTxt.Name = "tsbFillTxt"
        Me.tsbFillTxt.Size = New System.Drawing.Size(31, 22)
        Me.tsbFillTxt.Text = "Test"
        '
        'rtbLogs
        '
        Me.rtbLogs.Location = New System.Drawing.Point(120, 173)
        Me.rtbLogs.Name = "rtbLogs"
        Me.rtbLogs.Size = New System.Drawing.Size(495, 96)
        Me.rtbLogs.TabIndex = 10
        Me.rtbLogs.Text = ""
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(120, 275)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(495, 23)
        Me.ProgressBar1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(424, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 378)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.rtbLogs)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.rbSyncData)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCloudConn)
        Me.Controls.Add(Me.txtLocalCon)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.txtStoreID)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStoreID As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtLocalCon As TextBox
    Friend WithEvents txtCloudConn As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rbSyncData As RadioButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbTest As ToolStripButton
    Friend WithEvents tsbFillTxt As ToolStripButton
    Friend WithEvents rtbLogs As RichTextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
End Class
