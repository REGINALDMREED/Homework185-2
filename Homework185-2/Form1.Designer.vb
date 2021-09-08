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
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picMarathon = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        CType(Me.picMarathon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(35, 64)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(182, 23)
        Me.btnView.TabIndex = 0
        Me.btnView.Text = "View Marathon Detail"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(53, 309)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(182, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picMarathon
        '
        Me.picMarathon.Location = New System.Drawing.Point(250, 64)
        Me.picMarathon.Name = "picMarathon"
        Me.picMarathon.Size = New System.Drawing.Size(100, 256)
        Me.picMarathon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMarathon.TabIndex = 2
        Me.picMarathon.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Application title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Phrase"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(50, 232)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(91, 14)
        Me.lblInfo.TabIndex = 5
        Me.lblInfo.Text = "Marathon detail"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 402)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picMarathon)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnView)
        Me.Name = "Form1"
        CType(Me.picMarathon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnView As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picMarathon As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblInfo As Label
End Class
