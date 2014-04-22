<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.size = New System.Windows.Forms.Label()
        Me.kb = New System.Windows.Forms.RadioButton()
        Me.b = New System.Windows.Forms.RadioButton()
        Me.gb = New System.Windows.Forms.RadioButton()
        Me.mb = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.result = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tracks = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.seconds = New System.Windows.Forms.TextBox()
        Me.bit = New System.Windows.Forms.TextBox()
        Me.kHz = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'size
        '
        Me.size.AutoSize = True
        Me.size.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.size.Location = New System.Drawing.Point(69, 196)
        Me.size.Name = "size"
        Me.size.Size = New System.Drawing.Size(0, 16)
        Me.size.TabIndex = 33
        '
        'kb
        '
        Me.kb.AutoSize = True
        Me.kb.Location = New System.Drawing.Point(64, 19)
        Me.kb.Name = "kb"
        Me.kb.Size = New System.Drawing.Size(39, 17)
        Me.kb.TabIndex = 3
        Me.kb.Text = "KB"
        Me.kb.UseVisualStyleBackColor = True
        '
        'b
        '
        Me.b.AutoSize = True
        Me.b.Location = New System.Drawing.Point(10, 19)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(51, 17)
        Me.b.TabIndex = 2
        Me.b.TabStop = True
        Me.b.Text = "Bytes"
        Me.b.UseVisualStyleBackColor = True
        '
        'gb
        '
        Me.gb.AutoSize = True
        Me.gb.Location = New System.Drawing.Point(149, 19)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(40, 17)
        Me.gb.TabIndex = 1
        Me.gb.TabStop = True
        Me.gb.Text = "GB"
        Me.gb.UseVisualStyleBackColor = True
        '
        'mb
        '
        Me.mb.AutoSize = True
        Me.mb.Checked = True
        Me.mb.Location = New System.Drawing.Point(105, 19)
        Me.mb.Name = "mb"
        Me.mb.Size = New System.Drawing.Size(41, 17)
        Me.mb.TabIndex = 0
        Me.mb.TabStop = True
        Me.mb.Text = "MB"
        Me.mb.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(84, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Location = New System.Drawing.Point(87, 184)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(0, 13)
        Me.result.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(87, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 16)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "File Size:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.kb)
        Me.GroupBox1.Controls.Add(Me.b)
        Me.GroupBox1.Controls.Add(Me.gb)
        Me.GroupBox1.Controls.Add(Me.mb)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(199, 50)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Units"
        '
        'tracks
        '
        Me.tracks.Location = New System.Drawing.Point(94, 84)
        Me.tracks.Name = "tracks"
        Me.tracks.Size = New System.Drawing.Size(51, 20)
        Me.tracks.TabIndex = 27
        Me.tracks.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Tracks"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(144, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "- bit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(144, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "seconds"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(144, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "kHz"
        '
        'seconds
        '
        Me.seconds.Location = New System.Drawing.Point(94, 58)
        Me.seconds.Name = "seconds"
        Me.seconds.Size = New System.Drawing.Size(51, 20)
        Me.seconds.TabIndex = 22
        Me.seconds.Text = "60"
        '
        'bit
        '
        Me.bit.Location = New System.Drawing.Point(94, 32)
        Me.bit.Name = "bit"
        Me.bit.Size = New System.Drawing.Size(51, 20)
        Me.bit.TabIndex = 21
        Me.bit.Text = "16"
        '
        'kHz
        '
        Me.kHz.Location = New System.Drawing.Point(94, 6)
        Me.kHz.Name = "kHz"
        Me.kHz.Size = New System.Drawing.Size(51, 20)
        Me.kHz.TabIndex = 20
        Me.kHz.Text = "44.1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Bit Depth"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Duration"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Sampling Rate"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 221)
        Me.Controls.Add(Me.size)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tracks)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.seconds)
        Me.Controls.Add(Me.bit)
        Me.Controls.Add(Me.kHz)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Audio File Size"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents size As System.Windows.Forms.Label
    Friend WithEvents kb As System.Windows.Forms.RadioButton
    Friend WithEvents b As System.Windows.Forms.RadioButton
    Friend WithEvents gb As System.Windows.Forms.RadioButton
    Friend WithEvents mb As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents result As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tracks As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents seconds As System.Windows.Forms.TextBox
    Friend WithEvents bit As System.Windows.Forms.TextBox
    Friend WithEvents kHz As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
