Imports Patagames.Pdf.Net
Imports Patagames.Pdf.Net.PdfSearch
Imports Patagames.Pdf.Net.Controls.WinForms


Public Class DMViewer

    Private _FileToOpen As String = String.Empty
    Private _SearchTerm As String = String.Empty
    Private WithEvents _search As PdfSearch = Nothing
    Private _Results As FoundText() = {}
    Private _ResIndex As Integer = -1
    Private _WholeWord As Boolean = True
    Private _StartPage As Integer = 0

    Private Sub DMViewer_Load(sender As Object, e As EventArgs) Handles Me.Load
        PdfCommon.Initialize()

        'Hide the message label
        MessLabel.Visible = False

        'Get command line parameters, first is the filename
        For Each arg As String In My.Application.CommandLineArgs
            'Strip any quotes
            arg = arg.Replace("""", "")
            If arg.Contains("/m=") OrElse arg.Contains("/M=") Then
                'Message parameter
                'Remove param flag text
                arg = arg.Replace("/m=", "")
                arg = arg.Replace("/M=", "")
                MessLabel.Text = arg
                MessLabel.Visible = True

            ElseIf arg.Contains("/s=") OrElse arg.Contains("/S=") Then
                'Search terms parameter
                'Remove param flag text
                arg = arg.Replace("/s=", "")
                arg = arg.Replace("/S=", "")
                _SearchTerm = arg
                SearchText.Text = _SearchTerm

            ElseIf arg.Contains("/p=") OrElse arg.Contains("/P=") Then
                'Start page parameter
                'Remove param flag text
                arg = arg.Replace("/p=", "")
                arg = arg.Replace("/P=", "")
                _StartPage = Convert.ToInt32(arg)

            Else
                'We are assuming we have a filename if we do not already have one.  Else ignore
                If _FileToOpen = String.Empty Then _FileToOpen = arg
            End If
        Next

        If _FileToOpen <> String.Empty Then
            Viewer.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.FitToWidth
            Viewer.LoadDocument(_FileToOpen)
            If _SearchTerm <> String.Empty Then DoSearch()
        End If

    End Sub

    Private Sub DoSearch()
        SearchFlag.Visible = True
        _ResIndex = -1
        _search = New PdfSearch(Viewer.Document)
        If SearchText.Text <> String.Empty Then
            If cbWholeWord.Checked Then
                _search.Start(SearchText.Text, Patagames.Pdf.Enums.FindFlags.MatchWholeWord)
            Else
                _search.Start(SearchText.Text, Patagames.Pdf.Enums.FindFlags.None)
            End If
        End If
    End Sub

    Private Sub GetNext()
        If _Results.Count > 0 AndAlso _ResIndex > -1 Then
            _ResIndex += 1
            If _ResIndex >= _Results.Count Then _ResIndex = 0
            GotoResult(_ResIndex)
        End If
    End Sub

    Private Sub _search_SearchCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles _search.SearchCompleted
        If e IsNot Nothing Then
            If e.Result IsNot Nothing Then
                _Results = DirectCast(e.Result, FoundText())
                'If we have a start page, use it to find the first result
                If _StartPage > 0 Then
                    Dim idx As Integer = 0
                    For Each res As FoundText In _Results
                        If res.PageIndex >= _StartPage Then
                            _ResIndex = idx
                            Exit For
                        End If
                        idx += 1
                    Next
                Else
                    _ResIndex = 0
                End If
                GotoResult(_ResIndex)
            End If
        End If
        SearchFlag.Visible = False
    End Sub

    Private Sub GotoResult(ResIndex As Integer)
        If _Results.Count > 0 Then
            'Grab the first and scroll to it
            Dim res As FoundText = _Results(ResIndex)
            With Viewer
                .CurrentIndex = res.PageIndex
                .ScrollToPage(res.PageIndex)
                .ScrollToChar(res.CharIndex)
            End With
            'Highlight the text
            Viewer.HighlightText(res.PageIndex, res.CharIndex, res.CharsCount, Color.Aqua)
            FindNextButton.Visible = True
        Else
            Viewer.RemoveHighlightFromText()
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        DoSearch()
    End Sub

    Private Sub FindNextButton_Click(sender As Object, e As EventArgs) Handles FindNextButton.Click
        GetNext()
    End Sub

    Private Sub Viewer_MouseWheel(sender As Object, e As MouseEventArgs) Handles Viewer.MouseWheel
        If My.Computer.Keyboard.CtrlKeyDown Then
            If e.Delta > 0 Then
                Viewer.Zoom += CSng(0.05)
            ElseIf e.Delta < 0 Then
                Viewer.Zoom -= CSng(0.05)
            End If
        End If
    End Sub

    Private Sub PointerSelect_Click(sender As Object, e As EventArgs) Handles PointerSelect.Click
        If PointerSelect.Checked Then Viewer.MouseMode = MouseModes.Default
    End Sub

    Private Sub PanSelect_Click(sender As Object, e As EventArgs) Handles PanSelect.Click
        If PanSelect.Checked Then Viewer.MouseMode = MouseModes.PanTool
    End Sub

    Private Sub ZoomIn_Click(sender As Object, e As EventArgs) Handles ZoomIn.Click
        Viewer.SizeMode = SizeModes.Zoom
        Viewer.Zoom += CSng(0.05)
    End Sub

    Private Sub ZoomReset_Click(sender As Object, e As EventArgs) Handles ZoomReset.Click
        Viewer.Zoom = 1
        Viewer.SizeMode = SizeModes.FitToWidth
    End Sub

    Private Sub ZoomOut_Click(sender As Object, e As EventArgs) Handles ZoomOut.Click
        Viewer.SizeMode = SizeModes.Zoom
        Viewer.Zoom -= CSng(0.05)
    End Sub

End Class
