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
        Me.Viewer = New Patagames.Pdf.Net.Controls.WinForms.PdfViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SearchFlag = New System.Windows.Forms.Label()
        Me.cbWholeWord = New System.Windows.Forms.CheckBox()
        Me.FindNextButton = New System.Windows.Forms.Button()
        Me.SearchText = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.PointerSelect = New System.Windows.Forms.ToolStripButton()
        Me.PanSelect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ZoomIn = New System.Windows.Forms.ToolStripButton()
        Me.ZoomReset = New System.Windows.Forms.ToolStripButton()
        Me.ZoomOut = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MessLabel
        '
        Me.MessLabel.BackColor = System.Drawing.SystemColors.Info
        Me.MessLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MessLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessLabel.Location = New System.Drawing.Point(0, 64)
        Me.MessLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MessLabel.Name = "MessLabel"
        Me.MessLabel.Size = New System.Drawing.Size(1117, 27)
        Me.MessLabel.TabIndex = 2
        Me.MessLabel.Text = "     Message"
        Me.MessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Viewer
        '
        Me.Viewer.AllowSetDocument = False
        Me.Viewer.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Viewer.CurrentIndex = -1
        Me.Viewer.CurrentPageHighlightColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Viewer.Document = Nothing
        Me.Viewer.FormHighlightColor = System.Drawing.Color.Transparent
        Me.Viewer.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY
        Me.Viewer.LoadingIconText = "Loading..."
        Me.Viewer.Location = New System.Drawing.Point(0, 99)
        Me.Viewer.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.[Default]
        Me.Viewer.Name = "Viewer"
        Me.Viewer.Padding = New System.Windows.Forms.Padding(10)
        Me.Viewer.PageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Viewer.PageAutoDispose = True
        Me.Viewer.PageBackColor = System.Drawing.Color.White
        Me.Viewer.PageBorderColor = System.Drawing.Color.Black
        Me.Viewer.PageMargin = New System.Windows.Forms.Padding(10)
        Me.Viewer.PageSeparatorColor = System.Drawing.Color.Gray
        Me.Viewer.RenderFlags = CType((Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT Or Patagames.Pdf.Enums.RenderFlags.FPDF_NO_CATCH), Patagames.Pdf.Enums.RenderFlags)
        Me.Viewer.ShowCurrentPageHighlight = True
        Me.Viewer.ShowLoadingIcon = True
        Me.Viewer.ShowPageSeparator = True
        Me.Viewer.Size = New System.Drawing.Size(1117, 350)
        Me.Viewer.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.Zoom
        Me.Viewer.TabIndex = 3
        Me.Viewer.TextSelectColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Viewer.TilesCount = 2
        Me.Viewer.UseProgressiveRender = True
        Me.Viewer.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical
        Me.Viewer.Zoom = 1.0!
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.SearchFlag)
        Me.Panel1.Controls.Add(Me.cbWholeWord)
        Me.Panel1.Controls.Add(Me.FindNextButton)
        Me.Panel1.Controls.Add(Me.SearchText)
        Me.Panel1.Controls.Add(Me.SearchButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1117, 39)
        Me.Panel1.TabIndex = 4
        '
        'SearchFlag
        '
        Me.SearchFlag.AutoSize = True
        Me.SearchFlag.ForeColor = System.Drawing.Color.Red
        Me.SearchFlag.Location = New System.Drawing.Point(436, 15)
        Me.SearchFlag.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SearchFlag.Name = "SearchFlag"
        Me.SearchFlag.Size = New System.Drawing.Size(124, 13)
        Me.SearchFlag.TabIndex = 5
        Me.SearchFlag.Text = "Searching, Please wait..."
        Me.SearchFlag.Visible = False
        '
        'cbWholeWord
        '
        Me.cbWholeWord.AutoSize = True
        Me.cbWholeWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbWholeWord.Location = New System.Drawing.Point(264, 13)
        Me.cbWholeWord.Margin = New System.Windows.Forms.Padding(2)
        Me.cbWholeWord.Name = "cbWholeWord"
        Me.cbWholeWord.Size = New System.Drawing.Size(116, 17)
        Me.cbWholeWord.TabIndex = 4
        Me.cbWholeWord.Text = "Match Whole Word"
        Me.cbWholeWord.UseVisualStyleBackColor = True
        '
        'FindNextButton
        '
        Me.FindNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FindNextButton.Location = New System.Drawing.Point(194, 10)
        Me.FindNextButton.Margin = New System.Windows.Forms.Padding(2)
        Me.FindNextButton.Name = "FindNextButton"
        Me.FindNextButton.Size = New System.Drawing.Size(56, 22)
        Me.FindNextButton.TabIndex = 3
        Me.FindNextButton.Text = "Next"
        Me.FindNextButton.UseVisualStyleBackColor = True
        Me.FindNextButton.Visible = False
        '
        'SearchText
        '
        Me.SearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchText.Location = New System.Drawing.Point(70, 11)
        Me.SearchText.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(120, 20)
        Me.SearchText.TabIndex = 2
        '
        'SearchButton
        '
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Location = New System.Drawing.Point(9, 10)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(56, 22)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 91)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1117, 8)
        Me.Panel2.TabIndex = 5
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PointerSelect, Me.PanSelect, Me.ToolStripSeparator1, Me.ZoomIn, Me.ZoomReset, Me.ZoomOut})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1117, 25)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'PointerSelect
        '
        Me.PointerSelect.Checked = True
        Me.PointerSelect.CheckOnClick = True
        Me.PointerSelect.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PointerSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PointerSelect.Image = CType(resources.GetObject("PointerSelect.Image"), System.Drawing.Image)
        Me.PointerSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PointerSelect.Name = "PointerSelect"
        Me.PointerSelect.Size = New System.Drawing.Size(23, 22)
        Me.PointerSelect.Text = "ToolStripButton1"
        Me.PointerSelect.ToolTipText = "PointerTool"
        '
        'PanSelect
        '
        Me.PanSelect.CheckOnClick = True
        Me.PanSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PanSelect.Image = CType(resources.GetObject("PanSelect.Image"), System.Drawing.Image)
        Me.PanSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PanSelect.Name = "PanSelect"
        Me.PanSelect.Size = New System.Drawing.Size(23, 22)
        Me.PanSelect.Text = "ToolStripButton2"
        Me.PanSelect.ToolTipText = "Pan Tool"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ZoomIn
        '
        Me.ZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ZoomIn.Image = CType(resources.GetObject("ZoomIn.Image"), System.Drawing.Image)
        Me.ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ZoomIn.Name = "ZoomIn"
        Me.ZoomIn.Size = New System.Drawing.Size(23, 22)
        Me.ZoomIn.Text = "ToolStripButton3"
        Me.ZoomIn.ToolTipText = "Zoom In"
        '
        'ZoomReset
        '
        Me.ZoomReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ZoomReset.Image = CType(resources.GetObject("ZoomReset.Image"), System.Drawing.Image)
        Me.ZoomReset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ZoomReset.Name = "ZoomReset"
        Me.ZoomReset.Size = New System.Drawing.Size(23, 22)
        Me.ZoomReset.Text = "ToolStripButton4"
        Me.ZoomReset.ToolTipText = "Zoom Reset"
        '
        'ZoomOut
        '
        Me.ZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ZoomOut.Image = CType(resources.GetObject("ZoomOut.Image"), System.Drawing.Image)
        Me.ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ZoomOut.Name = "ZoomOut"
        Me.ZoomOut.Size = New System.Drawing.Size(23, 22)
        Me.ZoomOut.Text = "ToolStripButton5"
        Me.ZoomOut.ToolTipText = "Zoom Out"
        '
        'DMViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 449)
        Me.Controls.Add(Me.Viewer)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MessLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "DMViewer"
        Me.Text = "DMViewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MessLabel As System.Windows.Forms.Label
    Friend WithEvents Viewer As Patagames.Pdf.Net.Controls.WinForms.PdfViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SearchText As System.Windows.Forms.TextBox
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents FindNextButton As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbWholeWord As System.Windows.Forms.CheckBox
    Friend WithEvents SearchFlag As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents PointerSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ZoomIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ZoomReset As System.Windows.Forms.ToolStripButton
    Friend WithEvents ZoomOut As System.Windows.Forms.ToolStripButton

End Class
