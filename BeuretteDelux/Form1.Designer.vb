<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenommerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropriétésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopierVersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MulticopieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.DéplacerVersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultidéplacementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.VérifierLesMAJToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.CopieToolStripMenuItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        resources.ApplyResources(Me.FichierToolStripMenuItem, "FichierToolStripMenuItem")
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.ToolStripMenuItem1, Me.RenommerToolStripMenuItem, Me.SupprimerToolStripMenuItem, Me.ToolStripMenuItem2, Me.PropriétésToolStripMenuItem, Me.ToolStripMenuItem3, Me.VérifierLesMAJToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        '
        'OuvrirToolStripMenuItem
        '
        resources.ApplyResources(Me.OuvrirToolStripMenuItem, "OuvrirToolStripMenuItem")
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        '
        'ToolStripMenuItem1
        '
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        '
        'RenommerToolStripMenuItem
        '
        resources.ApplyResources(Me.RenommerToolStripMenuItem, "RenommerToolStripMenuItem")
        Me.RenommerToolStripMenuItem.Name = "RenommerToolStripMenuItem"
        '
        'SupprimerToolStripMenuItem
        '
        resources.ApplyResources(Me.SupprimerToolStripMenuItem, "SupprimerToolStripMenuItem")
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        '
        'ToolStripMenuItem2
        '
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        '
        'PropriétésToolStripMenuItem
        '
        resources.ApplyResources(Me.PropriétésToolStripMenuItem, "PropriétésToolStripMenuItem")
        Me.PropriétésToolStripMenuItem.Name = "PropriétésToolStripMenuItem"
        '
        'ToolStripMenuItem3
        '
        resources.ApplyResources(Me.ToolStripMenuItem3, "ToolStripMenuItem3")
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        '
        'QuitterToolStripMenuItem
        '
        resources.ApplyResources(Me.QuitterToolStripMenuItem, "QuitterToolStripMenuItem")
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        '
        'CopieToolStripMenuItem
        '
        resources.ApplyResources(Me.CopieToolStripMenuItem, "CopieToolStripMenuItem")
        Me.CopieToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopierVersToolStripMenuItem, Me.MulticopieToolStripMenuItem, Me.ToolStripMenuItem4, Me.DéplacerVersToolStripMenuItem, Me.MultidéplacementToolStripMenuItem})
        Me.CopieToolStripMenuItem.Name = "CopieToolStripMenuItem"
        '
        'CopierVersToolStripMenuItem
        '
        resources.ApplyResources(Me.CopierVersToolStripMenuItem, "CopierVersToolStripMenuItem")
        Me.CopierVersToolStripMenuItem.Name = "CopierVersToolStripMenuItem"
        '
        'MulticopieToolStripMenuItem
        '
        resources.ApplyResources(Me.MulticopieToolStripMenuItem, "MulticopieToolStripMenuItem")
        Me.MulticopieToolStripMenuItem.Name = "MulticopieToolStripMenuItem"
        '
        'ToolStripMenuItem4
        '
        resources.ApplyResources(Me.ToolStripMenuItem4, "ToolStripMenuItem4")
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        '
        'DéplacerVersToolStripMenuItem
        '
        resources.ApplyResources(Me.DéplacerVersToolStripMenuItem, "DéplacerVersToolStripMenuItem")
        Me.DéplacerVersToolStripMenuItem.Name = "DéplacerVersToolStripMenuItem"
        '
        'MultidéplacementToolStripMenuItem
        '
        resources.ApplyResources(Me.MultidéplacementToolStripMenuItem, "MultidéplacementToolStripMenuItem")
        Me.MultidéplacementToolStripMenuItem.Name = "MultidéplacementToolStripMenuItem"
        '
        'ToolStrip1
        '
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Name = "ToolStrip1"
        '
        'StatusStrip1
        '
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'TreeView1
        '
        resources.ApplyResources(Me.TreeView1, "TreeView1")
        Me.TreeView1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Name = "TreeView1"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Win7_Directory.ico")
        Me.ImageList1.Images.SetKeyName(1, "Win7_Disk.ico")
        Me.ImageList1.Images.SetKeyName(2, "Win7_CDisk.ico")
        Me.ImageList1.Images.SetKeyName(3, "Win7_Removable.ico")
        Me.ImageList1.Images.SetKeyName(4, "Win7_DVDROM.ico")
        Me.ImageList1.Images.SetKeyName(5, "Win7_NetDisk.ico")
        '
        'ListView1
        '
        resources.ApplyResources(Me.ListView1, "ListView1")
        Me.ListView1.HideSelection = False
        Me.ListView1.LargeImageList = Me.ImageList3
        Me.ListView1.Name = "ListView1"
        Me.ListView1.SmallImageList = Me.ImageList2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList3.Images.SetKeyName(0, "Win7_Directory.ico")
        Me.ImageList3.Images.SetKeyName(1, "Win7_File.ico")
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "Win7_Directory.ico")
        Me.ImageList2.Images.SetKeyName(1, "Win7_File.ico")
        '
        'VérifierLesMAJToolStripMenuItem
        '
        resources.ApplyResources(Me.VérifierLesMAJToolStripMenuItem, "VérifierLesMAJToolStripMenuItem")
        Me.VérifierLesMAJToolStripMenuItem.Name = "VérifierLesMAJToolStripMenuItem"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents RenommerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents PropriétésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ImageList3 As ImageList
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents CopieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopierVersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MulticopieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents DéplacerVersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultidéplacementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VérifierLesMAJToolStripMenuItem As ToolStripMenuItem
End Class
