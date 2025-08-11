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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.txtConnection = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnShowStatus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(219, 123)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(69, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Server Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(314, 123)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(194, 20)
        Me.txtName.TabIndex = 1
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(206, 149)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(82, 13)
        Me.lblLocation.TabIndex = 2
        Me.lblLocation.Text = "Server Location"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(314, 149)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(194, 20)
        Me.txtLocation.TabIndex = 3
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.Location = New System.Drawing.Point(200, 175)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(88, 13)
        Me.lblConnection.TabIndex = 4
        Me.lblConnection.Text = "Connection Type" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'txtConnection
        '
        Me.txtConnection.Location = New System.Drawing.Point(314, 175)
        Me.txtConnection.Name = "txtConnection"
        Me.txtConnection.Size = New System.Drawing.Size(194, 20)
        Me.txtConnection.TabIndex = 5
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(152, 204)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(141, 13)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Status (ONLINE / OFFLINE)" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"ONLINE", "OFFLINE"})
        Me.cmbStatus.Location = New System.Drawing.Point(314, 201)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(194, 21)
        Me.cmbStatus.TabIndex = 7
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(217, 276)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(71, 13)
        Me.lblResult.TabIndex = 8
        Me.lblResult.Text = "Server Status" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(314, 273)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(194, 20)
        Me.txtResult.TabIndex = 9
        '
        'btnShowStatus
        '
        Me.btnShowStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowStatus.Location = New System.Drawing.Point(314, 311)
        Me.btnShowStatus.Name = "btnShowStatus"
        Me.btnShowStatus.Size = New System.Drawing.Size(194, 37)
        Me.btnShowStatus.TabIndex = 10
        Me.btnShowStatus.Text = "Show Server Status" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.btnShowStatus.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.btnShowStatus)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtConnection)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "University Server Monitor 2025"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblConnection As System.Windows.Forms.Label
    Friend WithEvents txtConnection As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents btnShowStatus As System.Windows.Forms.Button

End Class
