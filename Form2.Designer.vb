<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.pnlBrowser = New System.Windows.Forms.Panel()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnBack.Location = New System.Drawing.Point(0, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(38, 38)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "◀"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnForward
        '
        Me.btnForward.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnForward.Location = New System.Drawing.Point(44, 12)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(38, 38)
        Me.btnForward.TabIndex = 1
        Me.btnForward.Text = "▶"
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'btnReload
        '
        Me.btnReload.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnReload.Location = New System.Drawing.Point(88, 12)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(38, 38)
        Me.btnReload.TabIndex = 2
        Me.btnReload.Text = "↻"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'pnlBrowser
        '
        Me.pnlBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBrowser.BackgroundImage = CType(resources.GetObject("pnlBrowser.BackgroundImage"), System.Drawing.Image)
        Me.pnlBrowser.Location = New System.Drawing.Point(0, 56)
        Me.pnlBrowser.Name = "pnlBrowser"
        Me.pnlBrowser.Size = New System.Drawing.Size(1007, 670)
        Me.pnlBrowser.TabIndex = 3
        '
        'txtURL
        '
        Me.txtURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtURL.Location = New System.Drawing.Point(132, 24)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(820, 20)
        Me.txtURL.TabIndex = 0
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(958, 12)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(38, 38)
        Me.btnSettings.TabIndex = 4
        Me.btnSettings.Text = "⚙"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.pnlBrowser)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.btnForward)
        Me.Controls.Add(Me.btnBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "SolZeWeb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnForward As Button
    Friend WithEvents btnReload As Button
    Friend WithEvents pnlBrowser As Panel
    Friend WithEvents txtURL As TextBox
    Friend WithEvents btnSettings As Button
End Class
