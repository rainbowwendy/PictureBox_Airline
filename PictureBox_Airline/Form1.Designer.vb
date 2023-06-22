<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Business = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        Label3 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label1 = New Label()
        Business.SuspendLayout()
        SuspendLayout()
        ' 
        ' Business
        ' 
        Business.Controls.Add(TabPage1)
        Business.Controls.Add(TabPage2)
        Business.Location = New Point(12, 29)
        Business.Name = "Business"
        Business.SelectedIndex = 0
        Business.Size = New Size(1109, 682)
        Business.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.AllowDrop = True
        TabPage1.AutoScroll = True
        TabPage1.BackColor = Color.Transparent
        TabPage1.ForeColor = SystemColors.Control
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1101, 649)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Business"' 
        ' TabPage2
        ' 
        TabPage2.AutoScroll = True
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1101, 649)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Economy"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.HotTrack
        Label3.Location = New Point(1139, 225)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 1
        Label3.Text = "First Name"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.HotTrack
        Label4.Location = New Point(1139, 269)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 20)
        Label4.TabIndex = 2
        Label4.Text = "Last Name"' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(1221, 217)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(144, 27)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(1221, 266)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(144, 27)
        TextBox4.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(1139, 177)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 20)
        Label1.TabIndex = 6
        Label1.Text = "Please fill your name and select your seat"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1452, 769)
        Controls.Add(Label1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Business)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "Form1"
        Text = "Form1"
        TransparencyKey = Color.MistyRose
        Business.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Business As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
