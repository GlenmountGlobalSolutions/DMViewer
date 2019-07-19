Imports PdfiumViewer
Imports System.Windows.Forms
Imports System

Public Class DMViewer

    Private _FileToOpen As String = String.Empty
    Private _SearchTerm As String = String.Empty
    Private _search As PdfSearchManager
    Private _WholeWord As Boolean = True
    Private _StartPage As Integer = 0
    Private _TimerTicked As Boolean = False
    Private _TimeDelay As Integer = 50
    Private Sub DMViewer_Load(sender As Object, e As EventArgs) Handles Me.Load

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
            ElseIf arg.Contains("/t=") OrElse arg.Contains("/T=") Then
                'Search delay parameter
                arg = arg.Replace("/t=", "")
                arg = arg.Replace("/T=", "")
                _TimeDelay = Convert.ToInt32(arg)
            Else
                'We are assuming we have a filename if we do not already have one.  Else ignore
                If _FileToOpen = String.Empty Then _FileToOpen = arg
            End If
        Next

        If _FileToOpen <> String.Empty Then
            Viewer.Document?.Dispose()
            Viewer.Document = OpenDocument(_FileToOpen)
            renderToBitmapsToolStripMenuItem.Enabled = True
            Viewer.ZoomMode = PdfViewerZoomMode.FitWidth
            Viewer.Renderer.Zoom = 1

            If _StartPage <> 0 Then
                Viewer.Renderer.Page = _StartPage
            End If
            _search = New PdfSearchManager(Viewer.Renderer)
            Timer1.Interval = _TimeDelay
            Timer1.Start()
        Else
            OpenFile()
        End If

    End Sub

    Private Sub OpenFile()
        Dim form As OpenFileDialog = New OpenFileDialog

        form.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*"
        form.RestoreDirectory = True
        form.Title = "Open PDF File"

        If form.ShowDialog(Me) <> DialogResult.OK Then
            Dispose()
            Return
        End If

        Viewer.Document?.Dispose()
        Viewer.Document = OpenDocument(form.FileName)
        renderToBitmapsToolStripMenuItem.Enabled = True
        Viewer.ZoomMode = PdfViewerZoomMode.FitWidth
        Viewer.Renderer.Zoom = 1
    End Sub

    Private Function OpenDocument(fileName As String) As PdfDocument
        Try
            Return PdfDocument.Load(Me, fileName)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Private Sub DoSearch(_SearchText As String)
        If _SearchText <> String.Empty Then
            If Not _search.Search(_SearchText) Then
                MessageBox.Show(Me, "No matches found.")
                Return
            End If
            _search.FindNext(True)
        End If
    End Sub

    Private Sub toolStripButton2_Click(sender As Object, e As EventArgs) Handles toolStripButton2.Click
        DoSearch(SearchText.Text)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not _TimerTicked Then
            DoSearch(_SearchTerm)
            _TimerTicked = True
        End If

    End Sub
End Class
