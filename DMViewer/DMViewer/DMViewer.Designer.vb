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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DMViewer))
        Me.MessLabel = New System.Windows.Forms.Label()
        Me.Viewer = New PdfiumViewer.PdfViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.SearchText = New System.Windows.Forms.ToolStripTextBox()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me._zoom = New System.Windows.Forms.ToolStripTextBox()
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me._fitWidth = New System.Windows.Forms.ToolStripButton()
        Me._fitHeight = New System.Windows.Forms.ToolStripButton()
        Me._fitBest = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me._rotateLeft = New System.Windows.Forms.ToolStripButton()
        Me._rotateRight = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me._showToolbar = New System.Windows.Forms.ToolStripButton()
        Me._showBookmarks = New System.Windows.Forms.ToolStripButton()
        Me._getTextFromPage = New System.Windows.Forms.ToolStripButton()
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
        Me.MessLabel.Location = New System.Drawing.Point(0, 509)
        Me.MessLabel.Name = "MessLabel"
        Me.MessLabel.Size = New System.Drawing.Size(1761, 44)
        Me.MessLabel.TabIndex = 2
        Me.MessLabel.Text = "     Message"
        Me.MessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Viewer
        '
        Me.Viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Viewer.Location = New System.Drawing.Point(0, 48)
        Me.Viewer.Margin = New System.Windows.Forms.Padding(20)
        Me.Viewer.Name = "Viewer"
        Me.Viewer.Size = New System.Drawing.Size(1761, 461)
        Me.Viewer.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.toolStrip1)
        Me.Panel1.Controls.Add(Me.menuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1761, 48)
        Me.Panel1.TabIndex = 4
        '
        'toolStrip1
        '
        Me.toolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripLabel1, Me.SearchText, Me.toolStripSeparator1, Me.toolStripButton1, Me.toolStripButton2, Me.toolStripSeparator2, Me.toolStripLabel2, Me._zoom, Me.toolStripSeparator7, Me.toolStripButton4, Me.toolStripButton3, Me.toolStripSeparator3, Me._fitWidth, Me._fitHeight, Me._fitBest, Me.toolStripSeparator5, Me._rotateLeft, Me._rotateRight, Me.toolStripSeparator6, Me._showToolbar, Me._showBookmarks, Me._getTextFromPage})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(1759, 27)
        Me.toolStrip1.TabIndex = 8
        Me.toolStrip1.Text = "toolStrip1"
        '
        'toolStripLabel1
        '
        Me.toolStripLabel1.Name = "toolStripLabel1"
        Me.toolStripLabel1.Size = New System.Drawing.Size(56, 24)
        Me.toolStripLabel1.Text = "Search:"
        '
        'SearchText
        '
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(132, 27)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'toolStripButton1
        '
        Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image)
        Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton1.Name = "toolStripButton1"
        Me.toolStripButton1.Size = New System.Drawing.Size(23, 24)
        Me.toolStripButton1.Text = "<"
        '
        'toolStripButton2
        '
        Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton2.Image = CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image)
        Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton2.Name = "toolStripButton2"
        Me.toolStripButton2.Size = New System.Drawing.Size(23, 24)
        Me.toolStripButton2.Text = ">"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'toolStripLabel2
        '
        Me.toolStripLabel2.Name = "toolStripLabel2"
        Me.toolStripLabel2.Size = New System.Drawing.Size(52, 24)
        Me.toolStripLabel2.Text = "Zoom:"
        '
        '_zoom
        '
        Me._zoom.Name = "_zoom"
        Me._zoom.Size = New System.Drawing.Size(132, 27)
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 27)
        '
        'toolStripButton4
        '
        Me.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton4.Image = CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image)
        Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton4.Name = "toolStripButton4"
        Me.toolStripButton4.Size = New System.Drawing.Size(23, 24)
        Me.toolStripButton4.Text = "+"
        '
        'toolStripButton3
        '
        Me.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton3.Image = CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image)
        Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton3.Name = "toolStripButton3"
        Me.toolStripButton3.Size = New System.Drawing.Size(23, 24)
        Me.toolStripButton3.Text = "-"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        '_fitWidth
        '
        Me._fitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me._fitWidth.Image = CType(resources.GetObject("_fitWidth.Image"), System.Drawing.Image)
        Me._fitWidth.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._fitWidth.Name = "_fitWidth"
        Me._fitWidth.Size = New System.Drawing.Size(73, 24)
        Me._fitWidth.Text = "Fit Width"
        '
        '_fitHeight
        '
        Me._fitHeight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me._fitHeight.Image = CType(resources.GetObject("_fitHeight.Image"), System.Drawing.Image)
        Me._fitHeight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._fitHeight.Name = "_fitHeight"
        Me._fitHeight.Size = New System.Drawing.Size(78, 24)
        Me._fitHeight.Text = "Fit Height"
        '
        '_fitBest
        '
        Me._fitBest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me._fitBest.Image = CType(resources.GetObject("_fitBest.Image"), System.Drawing.Image)
        Me._fitBest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._fitBest.Name = "_fitBest"
        Me._fitBest.Size = New System.Drawing.Size(61, 24)
        Me._fitBest.Text = "Fit Best"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        '_rotateLeft
        '
        Me._rotateLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me._rotateLeft.Image = CType(resources.GetObject("_rotateLeft.Image"), System.Drawing.Image)
        Me._rotateLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._rotateLeft.Name = "_rotateLeft"
        Me._rotateLeft.Size = New System.Drawing.Size(86, 24)
        Me._rotateLeft.Text = "Rotate Left"
        '
        '_rotateRight
        '
        Me._rotateRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me._rotateRight.Image = CType(resources.GetObject("_rotateRight.Image"), System.Drawing.Image)
        Me._rotateRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._rotateRight.Name = "_rotateRight"
        Me._rotateRight.Size = New System.Drawing.Size(96, 24)
        Me._rotateRight.Text = "Rotate Right"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        '_showToolbar
        '
        Me._showToolbar.CheckOnClick = True
        Me._showToolbar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me._showToolbar.Image = CType(resources.GetObject("_showToolbar.Image"), System.Drawing.Image)
        Me._showToolbar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._showToolbar.Name = "_showToolbar"
        Me._showToolbar.Size = New System.Drawing.Size(104, 24)
        Me._showToolbar.Text = "Show Toolbar"
        '
        '_showBookmarks
        '
        Me._showBookmarks.CheckOnClick = True
        Me._showBookmarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me._showBookmarks.Image = CType(resources.GetObject("_showBookmarks.Image"), System.Drawing.Image)
        Me._showBookmarks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._showBookmarks.Name = "_showBookmarks"
        Me._showBookmarks.Size = New System.Drawing.Size(126, 24)
        Me._showBookmarks.Text = "Show Bookmarks"
        '
        '_getTextFromPage
        '
        Me._getTextFromPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me._getTextFromPage.Image = CType(resources.GetObject("_getTextFromPage.Image"), System.Drawing.Image)
        Me._getTextFromPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._getTextFromPage.Name = "_getTextFromPage"
        Me._getTextFromPage.Size = New System.Drawing.Size(67, 24)
        Me._getTextFromPage.Text = "Get Text"
        Me._getTextFromPage.ToolTipText = "Get Text From Current Page"
        '
        'menuStrip1
        '
        Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.toolsToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.menuStrip1.Size = New System.Drawing.Size(1759, 28)
        Me.menuStrip1.TabIndex = 7
        Me.menuStrip1.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openToolStripMenuItem, Me.toolStripMenuItem1, Me.printPreviewToolStripMenuItem, Me.printMultiplePagesToolStripMenuItem, Me.toolStripMenuItem3, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'openToolStripMenuItem
        '
        Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
        Me.openToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.openToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.openToolStripMenuItem.Text = "&Open"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(212, 6)
        '
        'printPreviewToolStripMenuItem
        '
        Me.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem"
        Me.printPreviewToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.printPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'printMultiplePagesToolStripMenuItem
        '
        Me.printMultiplePagesToolStripMenuItem.Name = "printMultiplePagesToolStripMenuItem"
        Me.printMultiplePagesToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.printMultiplePagesToolStripMenuItem.Text = "Print Multiple Pages"
        '
        'toolStripMenuItem3
        '
        Me.toolStripMenuItem3.Name = "toolStripMenuItem3"
        Me.toolStripMenuItem3.Size = New System.Drawing.Size(212, 6)
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.exitToolStripMenuItem.Text = "E&xit"
        '
        'toolsToolStripMenuItem
        '
        Me.toolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.findToolStripMenuItem, Me.toolStripMenuItem7, Me.renderToBitmapsToolStripMenuItem, Me.toolStripMenuItem2, Me.cutMarginsWhenPrintingToolStripMenuItem, Me.shrinkToMarginsWhenPrintingToolStripMenuItem, Me.toolStripMenuItem4, Me.deleteCurrentPageToolStripMenuItem, Me.rotateCurrentPageToolStripMenuItem, Me.toolStripMenuItem5, Me.showRangeOfPagesToolStripMenuItem, Me.toolStripMenuItem6, Me.informationToolStripMenuItem})
        Me.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem"
        Me.toolsToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.toolsToolStripMenuItem.Text = "&Tools"
        '
        'findToolStripMenuItem
        '
        Me.findToolStripMenuItem.Name = "findToolStripMenuItem"
        Me.findToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.findToolStripMenuItem.Size = New System.Drawing.Size(294, 26)
        Me.findToolStripMenuItem.Text = "&Find"
        '
        'toolStripMenuItem7
        '
        Me.toolStripMenuItem7.Name = "toolStripMenuItem7"
        Me.toolStripMenuItem7.Size = New System.Drawing.Size(291, 6)
        '
        'renderToBitmapsToolStripMenuItem
        '
        Me.renderToBitmapsToolStripMenuItem.Name = "renderToBitmapsToolStripMenuItem"
        Me.renderToBitmapsToolStripMenuItem.Size = New System.Drawing.Size(294, 26)
        Me.renderToBitmapsToolStripMenuItem.Text = "&Render to Bitmaps"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(291, 6)
        '
        'cutMarginsWhenPrintingToolStripMenuItem
        '
        Me.cutMarginsWhenPrintingToolStripMenuItem.Name = "cutMarginsWhenPrintingToolStripMenuItem"
        Me.cutMarginsWhenPrintingToolStripMenuItem.Size = New System.Drawing.Size(294, 26)
        Me.cutMarginsWhenPrintingToolStripMenuItem.Text = "Cut margins when printing"
        '
        'shrinkToMarginsWhenPrintingToolStripMenuItem
        '
        Me.shrinkToMarginsWhenPrintingToolStripMenuItem.Name = "shrinkToMarginsWhenPrintingToolStripMenuItem"
        Me.shrinkToMarginsWhenPrintingToolStripMenuItem.Size = New System.Drawing.Size(294, 26)
        Me.shrinkToMarginsWhenPrintingToolStripMenuItem.Text = "Shrink to margins when printing"
        '
        'toolStripMenuItem4
        '
        Me.toolStripMenuItem4.Name = "toolStripMenuItem4"
        Me.toolStripMenuItem4.Size = New System.Drawing.Size(291, 6)
        '
        'deleteCurrentPageToolStripMenuItem
        '
        Me.deleteCurrentPageToolStripMenuItem.Name = "deleteCurrentPageToolStripMenuItem"
        Me.deleteCurrentPageToolStripMenuItem.Size = New System.Drawing.Size(294, 26)
        Me.deleteCurrentPageToolStripMenuItem.Text = "Delete Current Page"
        '
        'rotateCurrentPageToolStripMenuItem
        '
        Me.rotateCurrentPageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rotate0ToolStripMenuItem, Me.rotate90ToolStripMenuItem, Me.rotate180ToolStripMenuItem, Me.rotate270ToolStripMenuItem})
        Me.rotateCurrentPageToolStripMenuItem.Name = "rotateCurrentPageToolStripMenuItem"
        Me.rotateCurrentPageToolStripMenuItem.Size = New System.Drawing.Size(294, 26)
        Me.rotateCurrentPageToolStripMenuItem.Text = "Rotate Current Page"
        '
        'rotate0ToolStripMenuItem
        '
        Me.rotate0ToolStripMenuItem.Name = "rotate0ToolStripMenuItem"
        Me.rotate0ToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.rotate0ToolStripMenuItem.Text = "Rotate 0°"
        '
        'rotate90ToolStripMenuItem
        '
        Me.rotate90ToolStripMenuItem.Name = "rotate90ToolStripMenuItem"
        Me.rotate90ToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.rotate90ToolStripMenuItem.Text = "Rotate 90°"
        '
        'rotate180ToolStripMenuItem
        '
        Me.rotate180ToolStripMenuItem.Name = "rotate180ToolStripMenuItem"
        Me.rotate180ToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.rotate180ToolStripMenuItem.Text = "Rotate 180°"
        '
        'rotate270ToolStripMenuItem
        '
        Me.rotate270ToolStripMenuItem.Name = "rotate270ToolStripMenuItem"
        Me.rotate270ToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.rotate270ToolStripMenuItem.Text = "Rotate 270°"
        '
        'toolStripMenuItem5
        '
        Me.toolStripMenuItem5.Name = "toolStripMenuItem5"
        Me.toolStripMenuItem5.Size = New System.Drawing.Size(291, 6)
        '
        'showRangeOfPagesToolStripMenuItem
        '
        Me.showRangeOfPagesToolStripMenuItem.Name = "showRangeOfPagesToolStripMenuItem"
        Me.showRangeOfPagesToolStripMenuItem.Size = New System.Drawing.Size(294, 26)
        Me.showRangeOfPagesToolStripMenuItem.Text = "Show range of pages"
        '
        'toolStripMenuItem6
        '
        Me.toolStripMenuItem6.Name = "toolStripMenuItem6"
        Me.toolStripMenuItem6.Size = New System.Drawing.Size(291, 6)
        '
        'informationToolStripMenuItem
        '
        Me.informationToolStripMenuItem.Name = "informationToolStripMenuItem"
        Me.informationToolStripMenuItem.Size = New System.Drawing.Size(294, 26)
        Me.informationToolStripMenuItem.Text = "Information"
        '
        'DMViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1761, 553)
        Me.Controls.Add(Me.Viewer)
        Me.Controls.Add(Me.MessLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Private WithEvents toolStripSeparator1 As ToolStripSeparator
    Private WithEvents toolStripButton1 As ToolStripButton
    Private WithEvents toolStripButton2 As ToolStripButton
    Private WithEvents toolStripSeparator2 As ToolStripSeparator
    Private WithEvents toolStripLabel2 As ToolStripLabel
    Private WithEvents _zoom As ToolStripTextBox
    Private WithEvents toolStripSeparator7 As ToolStripSeparator
    Private WithEvents toolStripButton4 As ToolStripButton
    Private WithEvents toolStripButton3 As ToolStripButton
    Private WithEvents toolStripSeparator3 As ToolStripSeparator
    Private WithEvents _fitWidth As ToolStripButton
    Private WithEvents _fitHeight As ToolStripButton
    Private WithEvents _fitBest As ToolStripButton
    Private WithEvents toolStripSeparator5 As ToolStripSeparator
    Private WithEvents _rotateLeft As ToolStripButton
    Private WithEvents _rotateRight As ToolStripButton
    Private WithEvents toolStripSeparator6 As ToolStripSeparator
    Private WithEvents _showToolbar As ToolStripButton
    Private WithEvents _showBookmarks As ToolStripButton
    Private WithEvents _getTextFromPage As ToolStripButton
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
End Class
