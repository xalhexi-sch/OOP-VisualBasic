Option Strict On
Imports System.Windows.Forms
Imports System.Drawing

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form title
        Me.Text = "University Server Monitor 2025"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.LightSteelBlue ' form background color

        ' Fill ComboBox with ONLINE / OFFLINE
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("ONLINE")
        cmbStatus.Items.Add("OFFLINE")
        cmbStatus.SelectedItem = "SELECT OPTION"

        ' Make result box read-only and colorful
        txtResult.ReadOnly = True
        txtResult.BackColor = Color.White
        txtResult.ForeColor = Color.Black
        txtResult.Font = New Font("Segoe UI", 12, FontStyle.Bold)

        ' Set label colors
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = Color.DarkBlue
            End If
        Next

        ' Button style
        btnShowStatus.BackColor = Color.MediumSeaGreen
        btnShowStatus.ForeColor = Color.White
        btnShowStatus.FlatStyle = FlatStyle.Flat
        btnShowStatus.Font = New Font("Segoe UI", 10, FontStyle.Bold)
    End Sub

    Private Sub btnShowStatus_Click(sender As Object, e As EventArgs) Handles btnShowStatus.Click
        Dim name As String = txtName.Text.Trim()
        Dim location As String = txtLocation.Text.Trim()
        Dim conn As String = txtConnection.Text.Trim()
        Dim mode As String = If(cmbStatus.SelectedItem IsNot Nothing, cmbStatus.SelectedItem.ToString(), "OFFLINE")

        ' Validation
        If String.IsNullOrWhiteSpace(name) OrElse String.IsNullOrWhiteSpace(location) OrElse String.IsNullOrWhiteSpace(conn) Then
            MessageBox.Show("Please fill in Name, Location and Connection.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Create Server object and get status
        Dim server As New Server(name, location, conn)
        Dim status As String = server.StatusReport(mode)

        ' Show popup with details
        Dim info As String = String.Format(
            "Name: {0}{1}Location: {2}{3}Connection: {4}{5}Status: {6}",
            server.Name, Environment.NewLine,
            server.Location, Environment.NewLine,
            server.Connection, Environment.NewLine,
            status)

        MessageBox.Show(info, "Server Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Display status in the result box with color
        txtResult.Text = status
        If mode.ToUpper() = "ONLINE" Then
            txtResult.ForeColor = Color.Green
        Else
            txtResult.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtResult_TextChanged(sender As Object, e As EventArgs) Handles txtResult.TextChanged

    End Sub

    Private Sub lblResult_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub
End Class
