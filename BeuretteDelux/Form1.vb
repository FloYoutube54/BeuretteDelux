Imports System.IO
Imports Microsoft.WindowsAPICodePack.Dialogs

Public Class Form1

    Dim dlg As New TaskDialog

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each drive As DriveInfo In DriveInfo.GetDrives()
            Dim thisdrive As TreeNode = TreeView1.Nodes.Add(drive.Name)
            If drive.DriveType = DriveType.CDRom Then
                thisdrive.ImageIndex = 4
                thisdrive.SelectedImageIndex = 4
            ElseIf drive.DriveType = DriveType.Fixed Then
                thisdrive.ImageIndex = 1
                thisdrive.SelectedImageIndex = 1
            ElseIf drive.DriveType = DriveType.Removable Then
                thisdrive.ImageIndex = 3
                thisdrive.SelectedImageIndex = 3
            ElseIf drive.DriveType = DriveType.Network Then
                thisdrive.ImageIndex = 5
                thisdrive.SelectedImageIndex = 5
            End If

            If drive.Name = "C:\" Then
                thisdrive.ImageIndex = 2
                thisdrive.SelectedImageIndex = 2
            End If
            thisdrive.Nodes.Add("Expand")
        Next
    End Sub

    Private Sub TreeView1_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles TreeView1.BeforeExpand
        Dim node As TreeNode = e.Node
        node.Nodes.Clear()

        Try
            For Each dir As DirectoryInfo In New DirectoryInfo(node.FullPath).GetDirectories()
                Dim newNode As New TreeNode(dir.Name)
                newNode.ImageIndex = 0
                newNode.SelectedImageIndex = 0
                newNode.Nodes.Add("Expand")
                node.Nodes.Add(newNode)
            Next
        Catch ex As UnauthorizedAccessException
            Dim restart As New TaskDialogButton("restart", "Redémarrer en administrateur")
            Dim close As New TaskDialogButton("close", "Fermer")
            AddHandler restart.Click, AddressOf restart_Click
            AddHandler close.Click, AddressOf close_Click
            restart.Default = True
            restart.UseElevationIcon = True
            dlg.Controls.Add(restart)
            dlg.Controls.Add(close)
            dlg.Caption = "Accès refusé"
            dlg.InstructionText = ex.Message
            dlg.Icon = TaskDialogStandardIcon.Error
            dlg.Show()
        Catch ex As IOException
            dlg.StandardButtons = TaskDialogStandardButtons.Close
            dlg.Caption = "Accès refusé"
            dlg.InstructionText = ex.Message
            dlg.Icon = TaskDialogStandardIcon.Error
            dlg.Show()
        End Try
    End Sub

    Private Sub restart_Click(sender As Object, e As EventArgs)
        'restart as admin
        Dim psi As New ProcessStartInfo()
        psi.FileName = Application.ExecutablePath
        psi.Verb = "runas"
        psi.UseShellExecute = True
        psi.WindowStyle = ProcessWindowStyle.Normal
        psi.CreateNoWindow = False
        Process.Start(psi)
        Application.Exit()
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs)
        dlg.Close()
    End Sub

    Private Sub TreeView1_BeforeSelect(sender As Object, e As TreeViewCancelEventArgs) Handles TreeView1.BeforeSelect
        ListView1.Items.Clear()

        Try
            Dim path As String = e.Node.FullPath
            For Each directory As DirectoryInfo In New DirectoryInfo(path).GetDirectories()
                Dim item As New ListViewItem(directory.Name)
                item.ImageIndex = 0
                ListView1.Items.Add(item)
            Next
            For Each file As FileInfo In New DirectoryInfo(path).GetFiles()
                Dim item As New ListViewItem(file.Name)
                item.ImageIndex = 1
                ListView1.Items.Add(item)
            Next
        Catch ex As UnauthorizedAccessException
            Dim restart As New TaskDialogButton("restart", "Redémarrer en administrateur")
            Dim close As New TaskDialogButton("close", "Fermer")
            AddHandler restart.Click, AddressOf restart_Click
            AddHandler close.Click, AddressOf close_Click
            restart.Default = True
            restart.UseElevationIcon = True
            dlg.Controls.Add(restart)
            dlg.Controls.Add(close)
            dlg.Caption = "Accès refusé"
            dlg.InstructionText = ex.Message
            dlg.Icon = TaskDialogStandardIcon.Error
            dlg.Show()
        Catch ex As IOException
            dlg.StandardButtons = TaskDialogStandardButtons.Close
            dlg.Caption = "Accès refusé"
            dlg.InstructionText = ex.Message
            dlg.Icon = TaskDialogStandardIcon.Error
            dlg.Show()
        End Try
    End Sub
End Class
