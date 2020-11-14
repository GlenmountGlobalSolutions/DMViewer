<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DMViewer))
        Me.MessLabel = New System.Windows.Forms.Label()
        Me.Viewer = New PdfiumViewer.PdfViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.SearchText = New System.Windows.Forms.ToolStripTextBox()
        Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.printPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.printMultiplePagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.findToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.renderToBitmapsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cutMarginsWhenPrintingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.shrinkToMarginsWhenPrintingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.deleteCurrentPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rotateCurrentPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rotate0ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rotate90ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rotate180ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rotate270ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.showRangeOfPagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.informationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MessLabel
        '
        Me.MessLabel.BackColor = System.Drawing.SystemColors.Info
        Me.MessLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MessLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessLabel.Location = New System.Drawing.Point(0, 413)
        Me.MessLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MessLabel.Name = "MessLabel"
        Me.MessLabel.Size = New System.Drawing.Size(1321, 36)
        Me.MessLabel.TabIndex = 2
        Me.MessLabel.Text = "     Message"
        Me.MessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Viewer
        '
        Me.Viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Viewer.Location = New System.Drawing.Point(0, 51)
        Me.Viewer.Margin = New System.Windows.Forms.Padding(15, 16, 15, 16)
        Me.Viewer.Name = "Viewer"
        Me.Viewer.Size = New System.Drawing.Size(1321, 362)
        Me.Viewer.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.toolStrip1)
        Me.Panel1.Controls.Add(Me.menuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1321, 51)
        Me.Panel1.TabIndex = 4
        '
        'toolStrip1
        '
        Me.toolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripLabel1, Me.SearchText, Me.toolStripButton2})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(1319, 25)
        Me.toolStrip1.TabIndex = 8
        Me.toolStrip1.Text = "toolStrip1"
        '
        'toolStripLabel1
        '
        Me.toolStripLabel1.Name = "toolStripLabel1"
        Me.toolStripLabel1.Size = New System.Drawing.Size(45, 22)
        Me.toolStripLabel1.Text = "Search:"
        '
        'SearchText
        '
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(100, 25)
        '
        'toolStripButton2
        '
        Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton2.Image = CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image)
        Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton2.Name = "toolStripButton2"
        Me.toolStripButton2.Size = New System.Drawing.Size(34, 22)
        Me.toolStripButton2.Text = "Find"
        '
        'menuStrip1
        '
        Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.toolsToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(1319, 24)
        Me.menuStrip1.TabIndex = 7
        Me.menuStrip1.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openToolStripMenuItem, Me.toolStripMenuItem1, Me.printPreviewToolStripMenuItem, Me.printMultiplePagesToolStripMenuItem, Me.toolStripMenuItem3, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'openToolStripMenuItem
        '
        Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
        Me.openToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.openToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.openToolStripMenuItem.Text = "&Open"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'printPreviewToolStripMenuItem
        '
        Me.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem"
        Me.printPreviewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.printPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'printMultiplePagesToolStripMenuItem
        '
        Me.printMultiplePagesToolStripMenuItem.Name = "printMultiplePagesToolStripMenuItem"
        Me.printMultiplePagesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.printMultiplePagesToolStripMenuItem.Text = "Print Multiple Pages"
        '
        'toolStripMenuItem3
        '
        Me.toolStripMenuItem3.Name = "toolStripMenuItem3"
        Me.toolStripMenuItem3.Size = New System.Drawing.Size(177, 6)
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.exitToolStripMenuItem.Text = "E&xit"
        '
        'toolsToolStripMenuItem
        '
        Me.toolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.findToolStripMenuItem, Me.toolStripMenuItem7, Me.renderToBitmapsToolStripMenuItem, Me.toolStripMenuItem2, Me.cutMarginsWhenPrintingToolStripMenuItem, Me.shrinkToMarginsWhenPrintingToolStripMenuItem, Me.toolStripMenuItem4, Me.deleteCurrentPageToolStripMenuItem, Me.rotateCurrentPageToolStripMenuItem, Me.toolStripMenuItem5, Me.showRangeOfPagesToolStripMenuItem, Me.toolStripMenuItem6, Me.informationToolStripMenuItem})
        Me.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem"
        Me.toolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.toolsToolStripMenuItem.Text = "&Tools"
        '
        'findToolStripMenuItem
        '
        Me.findToolStripMenuItem.Name = "findToolStripMenuItem"
        Me.findToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.findToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.findToolStripMenuItem.Text = "&Find"
        '
        'toolStripMenuItem7
        '
        Me.toolStripMenuItem7.Name = "toolStripMenuItem7"
        Me.toolStripMenuItem7.Size = New System.Drawing.Size(241, 6)
        '
        'renderToBitmapsToolStripMenuItem
        '
        Me.renderToBitmapsToolStripMenuItem.Name = "renderToBitmapsToolStripMenuItem"
        Me.renderToBitmapsToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.renderToBitmapsToolStripMenuItem.Text = "&Render to Bitmaps"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(241, 6)
        '
        'cutMarginsWhenPrintingToolStripMenuItem
        '
        Me.cutMarginsWhenPrintingToolStripMenuItem.Name = "cutMarginsWhenPrintingToolStripMenuItem"
        Me.cutMarginsWhenPrintingToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.cutMarginsWhenPrintingToolStripMenuItem.Text = "Cut margins when printing"
        '
        'shrinkToMarginsWhenPrintingToolStripMenuItem
        '
        Me.shrinkToMarginsWhenPrintingToolStripMenuItem.Name = "shrinkToMarginsWhenPrintingToolStripMenuItem"
        Me.shrinkToMarginsWhenPrintingToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.shrinkToMarginsWhenPrintingToolStripMenuItem.Text = "Shrink to margins when printing"
        '
        'toolStripMenuItem4
        '
        Me.toolStripMenuItem4.Name = "toolStripMenuItem4"
        Me.toolStripMenuItem4.Size = New System.Drawing.Size(241, 6)
        '
        'deleteCurrentPageToolStripMenuItem
        '
        Me.deleteCurrentPageToolStripMenuItem.Name = "deleteCurrentPageToolStripMenuItem"
        Me.deleteCurrentPageToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.deleteCurrentPageToolStripMenuItem.Text = "Delete Current Page"
        '
        'rotateCurrentPageToolStripMenuItem
        '
        Me.rotateCurrentPageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rotate0ToolStripMenuItem, Me.rotate90ToolStripMenuItem, Me.rotate180ToolStripMenuItem, Me.rotate270ToolStripMenuItem})
        Me.rotateCurrentPageToolStripMenuItem.Name = "rotateCurrentPageToolStripMenuItem"
        Me.rotateCurrentPageToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.rotateCurrentPageToolStripMenuItem.Text = "Rotate Current Page"
        '
        'rotate0ToolStripMenuItem
        '
        Me.rotate0ToolStripMenuItem.Name = "rotate0ToolStripMenuItem"
        Me.rotate0ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.rotate0ToolStripMenuItem.Text = "Rotate 0°"
        '
        'rotate90ToolStripMenuItem
        '
        Me.rotate90ToolStripMenuItem.Name = "rotate90ToolStripMenuItem"
        Me.rotate90ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.rotate90ToolStripMenuItem.Text = "Rotate 90°"
        '
        'rotate180ToolStripMenuItem
        '
        Me.rotate180ToolStripMenuItem.Name = "rotate180ToolStripMenuItem"
        Me.rotate180ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.rotate180ToolStripMenuItem.Text = "Rotate 180°"
        '
        'rotate270ToolStripMenuItem
        '
        Me.rotate270ToolStripMenuItem.Name = "rotate270ToolStripMenuItem"
        Me.rotate270ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.rotate270ToolStripMenuItem.Text = "Rotate 270°"
        '
        'toolStripMenuItem5
        '
        Me.toolStripMenuItem5.Name = "toolStripMenuItem5"
        Me.toolStripMenuItem5.Size = New System.Drawing.Size(241, 6)
        '
        'showRangeOfPagesToolStripMenuItem
        '
        Me.showRangeOfPagesToolStripMenuItem.Name = "showRangeOfPagesToolStripMenuItem"
        Me.showRangeOfPagesToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.showRangeOfPagesToolStripMenuItem.Text = "Show range of pages"
        '
        'toolStripMenuItem6
        '
        Me.toolStripMenuItem6.Name = "toolStripMenuItem6"
        Me.toolStripMenuItem6.Size = New System.Drawing.Size(241, 6)
        '
        'informationToolStripMenuItem
        '
        Me.informationToolStripMenuItem.Name = "informationToolStripMenuItem"
        Me.informationToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.informationToolStripMenuItem.Text = "Information"
        '
        'Timer1
        '
        '
        'DMViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1321, 449)
        Me.Controls.Add(Me.Viewer)
        Me.Controls.Add(Me.MessLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "DMViewer"
        Me.Text = "DMViewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MessLabel As System.Windows.Forms.Label
    Friend WithEvents Viewer As PdfiumViewer.PdfViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents toolStrip1 As ToolStrip
    Private WithEvents toolStripLabel1 As ToolStripLabel
    Private WithEvents SearchText As ToolStripTextBox
    Private WithEvents toolStripButton2 As ToolStripButton
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents fileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents openToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem1 As ToolStripSeparator
    Private WithEvents printPreviewToolStripMenuItem As ToolStripMenuItem
    Private WithEvents printMultiplePagesToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem3 As ToolStripSeparator
    Private WithEvents exitToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents findToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem7 As ToolStripSeparator
    Private WithEvents renderToBitmapsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem2 As ToolStripSeparator
    Private WithEvents cutMarginsWhenPrintingToolStripMenuItem As ToolStripMenuItem
    Private WithEvents shrinkToMarginsWhenPrintingToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem4 As ToolStripSeparator
    Private WithEvents deleteCurrentPageToolStripMenuItem As ToolStripMenuItem
    Private WithEvents rotateCurrentPageToolStripMenuItem As ToolStripMenuItem
    Private WithEvents rotate0ToolStripMenuItem As ToolStripMenuItem
    Private WithEvents rotate90ToolStripMenuItem As ToolStripMenuItem
    Private WithEvents rotate180ToolStripMenuItem As ToolStripMenuItem
    Private WithEvents rotate270ToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem5 As ToolStripSeparator
    Private WithEvents showRangeOfPagesToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem6 As ToolStripSeparator
    Private WithEvents informationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
End Class
