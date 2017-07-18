Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.homepage = "https://google.hu/"
        My.Settings.Save()
        My.Settings.setupcomplete = True
        My.Settings.Save()
        Form2.Show
        Me.Close()
        'MsgBox("Vége", MsgBoxStyle.Information) // Ez volt fejlesztés alatt a teszt.
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.homepage = "https://github.com/solze" '// Ez lesz a kezdőoldalunk, amit a "macskakörmök" közé írunk.
        My.Settings.Save() '// Ez elmenti a változtatásokat
        My.Settings.setupcomplete = True '// Ez átváltoztatja a "setupcomplete" változót True értékre, így a "Kezdő lépések" csak 1x fognak elindulni
        My.Settings.Save() '// Ez elmenti a változtatásokat.
        Form2.Show
        Me.Close()
        'MsgBox("Vége", MsgBoxStyle.Information) // Ez volt fejlesztés alatt a teszt.
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.homepage = "https://youtube.com/"
        My.Settings.Save()
        My.Settings.setupcomplete = True
        My.Settings.Save()
        Form2.Show
        Me.Close()
        'MsgBox("Vége", MsgBoxStyle.Information) // Ez volt fejlesztés alatt a teszt.
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Settings.homepage = "http://www.startlap.hu/"
        My.Settings.Save()
        My.Settings.setupcomplete = True
        My.Settings.Save()
        Form2.Show
        Me.Close()
        'MsgBox("Vége", MsgBoxStyle.Information) // Ez volt fejlesztés alatt a teszt.
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Settings.homepage = "http://index.hu/"
        My.Settings.Save()
        My.Settings.setupcomplete = True
        My.Settings.Save()
        Form2.Show
        Me.Close()
        'MsgBox("Vége", MsgBoxStyle.Information) // Ez volt fejlesztés alatt a teszt.
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        My.Settings.homepage = TextBox1.Text
        My.Settings.Save()
        My.Settings.setupcomplete = True
        My.Settings.Save()
        Form2.Show
        Me.Close()
        'MsgBox("Vége", MsgBoxStyle.Information) // Ez volt fejlesztés alatt a teszt.
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.setupcomplete = True Then
            Form2.Show()
            Me.Close()
        End If
    End Sub
End Class
