<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyForm
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
        components = New ComponentModel.Container()
        InputSize = New TextBox()
        InputSizeLabel = New Label()
        NumOfTransmissionsLabel = New Label()
        NumOfTransmissions = New TextBox()
        Timer1 = New Timer(components)
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' InputSize
        ' 
        InputSize.Location = New Point(159, 65)
        InputSize.Name = "InputSize"
        InputSize.Size = New Size(113, 23)
        InputSize.TabIndex = 0
        ' 
        ' InputSizeLabel
        ' 
        InputSizeLabel.AccessibleName = "InputSize"
        InputSizeLabel.AutoSize = True
        InputSizeLabel.Location = New Point(12, 68)
        InputSizeLabel.Name = "InputSizeLabel"
        InputSizeLabel.Size = New Size(62, 15)
        InputSizeLabel.TabIndex = 1
        InputSizeLabel.Text = "Size of File"
        ' 
        ' NumOfTransmissionsLabel
        ' 
        NumOfTransmissionsLabel.AccessibleName = "InputSize"
        NumOfTransmissionsLabel.AutoSize = True
        NumOfTransmissionsLabel.Location = New Point(12, 117)
        NumOfTransmissionsLabel.Name = "NumOfTransmissionsLabel"
        NumOfTransmissionsLabel.Size = New Size(141, 15)
        NumOfTransmissionsLabel.TabIndex = 3
        NumOfTransmissionsLabel.Text = "Number of Transmissions"
        ' 
        ' NumOfTransmissions
        ' 
        NumOfTransmissions.Location = New Point(159, 114)
        NumOfTransmissions.Name = "NumOfTransmissions"
        NumOfTransmissions.ReadOnly = True
        NumOfTransmissions.Size = New Size(113, 23)
        NumOfTransmissions.TabIndex = 2
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(251, 15)
        Label1.TabIndex = 4
        Label1.Text = "Enter size of file then press run in the emulator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(87, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 15)
        Label2.TabIndex = 5
        Label2.Text = "Student ID: 7432"
        ' 
        ' MyForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(284, 176)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(NumOfTransmissionsLabel)
        Controls.Add(NumOfTransmissions)
        Controls.Add(InputSizeLabel)
        Controls.Add(InputSize)
        Name = "MyForm"
        Text = "#2 Packets"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents InputSize As TextBox
    Friend WithEvents InputSizeLabel As Label
    Friend WithEvents NumOfTransmissionsLabel As Label
    Friend WithEvents NumOfTransmissions As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
