Imports CefSharp.WinForms
Imports CefSharp

Public Class Form2

    Private WithEvents browser As ChromiumWebBrowser

    Public Sub New()
        InitializeComponent()

        Dim settings As New CefSettings()
        CefSharp.Cef.Initialize(settings)
        ' Dokkolás
        browser = New ChromiumWebBrowser(My.Settings.homepage) With {
            .Dock = DockStyle.Fill
        }
        ' pnlBrowser panel böngészőre váltása
        pnlBrowser.Controls.Add(browser)

    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        ' Lap újratöltése
        browser.Reload()
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        ' Előre
        browser.Forward()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Vissza
        browser.Load(My.Settings.homepage)
    End Sub

    Private Sub txtURL_KeyDown(sender As Object, e As KeyEventArgs) Handles txtURL.KeyDown
        ' Enter megnyomásakor navigálás az URL-mezőben található webcímre
        If e.KeyCode = Keys.Enter Then
            browser.Load(txtURL.Text)
        End If
    End Sub
End Class