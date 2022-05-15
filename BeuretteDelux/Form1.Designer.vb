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
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.CopieToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(660, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.ToolStripMenuItem1, Me.RenommerToolStripMenuItem, Me.SupprimerToolStripMenuItem, Me.ToolStripMenuItem2, Me.PropriétésToolStripMenuItem, Me.ToolStripMenuItem3, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "&Fichier"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.OuvrirToolStripMenuItem.Text = "&Ouvrir"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(130, 6)
        '
        'RenommerToolStripMenuItem
        '
        Me.RenommerToolStripMenuItem.Name = "RenommerToolStripMenuItem"
        Me.RenommerToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.RenommerToolStripMenuItem.Text = "&Renommer"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SupprimerToolStripMenuItem.Text = "&Supprimer"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(130, 6)
        '
        'PropriétésToolStripMenuItem
        '
        Me.PropriétésToolStripMenuItem.Name = "PropriétésToolStripMenuItem"
        Me.PropriétésToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.PropriétésToolStripMenuItem.Text = "&Propriétés"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(130, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.QuitterToolStripMenuItem.Text = "&Quitter"
        '
        'CopieToolStripMenuItem
        '
        Me.CopieToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopierVersToolStripMenuItem, Me.MulticopieToolStripMenuItem, Me.ToolStripMenuItem4, Me.DéplacerVersToolStripMenuItem, Me.MultidéplacementToolStripMenuItem})
        Me.CopieToolStripMenuItem.Name = "CopieToolStripMenuItem"
        Me.CopieToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.CopieToolStripMenuItem.Text = "&Manipulation"
        '
        'CopierVersToolStripMenuItem
        '
        Me.CopierVersToolStripMenuItem.Name = "CopierVersToolStripMenuItem"
        Me.CopierVersToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CopierVersToolStripMenuItem.Text = "&Copier vers..."
        '
        'MulticopieToolStripMenuItem
        '
        Me.MulticopieToolStripMenuItem.Name = "MulticopieToolStripMenuItem"
        Me.MulticopieToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.MulticopieToolStripMenuItem.Text = "M&ulti-copie"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(173, 6)
        '
        'DéplacerVersToolStripMenuItem
        '
        Me.DéplacerVersToolStripMenuItem.Name = "DéplacerVersToolStripMenuItem"
        Me.DéplacerVersToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.DéplacerVersToolStripMenuItem.Text = "&Déplacer vers..."
        '
        'MultidéplacementToolStripMenuItem
        '
        Me.MultidéplacementToolStripMenuItem.Name = "MultidéplacementToolStripMenuItem"
        Me.MultidéplacementToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.MultidéplacementToolStripMenuItem.Text = "Mu&lti-déplacement"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(660, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 448)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(660, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TreeView1
        '
        Me.TreeView1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(0, 49)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 1
        Me.TreeView1.Size = New System.Drawing.Size(173, 399)
        Me.TreeView1.TabIndex = 3
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
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.HideSelection = False
        Me.ListView1.LargeImageList = Me.ImageList3
        Me.ListView1.Location = New System.Drawing.Point(173, 49)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(487, 399)
        Me.ListView1.SmallImageList = Me.ImageList2
        Me.ListView1.TabIndex = 4
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 470)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
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
End Class
