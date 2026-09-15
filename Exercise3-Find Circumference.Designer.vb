<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblDiameter = New Label()
        txtDiameter = New TextBox()
        btnCalculate = New Button()
        lblCircumference = New Label()
        btnEnd = New Button()
        SuspendLayout()
        ' 
        ' lblDiameter
        ' 
        lblDiameter.Location = New Point(48, 89)
        lblDiameter.Name = "lblDiameter"
        lblDiameter.Size = New Size(210, 96)
        lblDiameter.TabIndex = 0
        lblDiameter.Text = "ENTER THE CIRCLE DIAMETER"
        ' 
        ' txtDiameter
        ' 
        txtDiameter.BorderStyle = BorderStyle.FixedSingle
        txtDiameter.Location = New Point(386, 110)
        txtDiameter.Name = "txtDiameter"
        txtDiameter.Size = New Size(200, 39)
        txtDiameter.TabIndex = 1
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.Bisque
        btnCalculate.FlatAppearance.BorderColor = Color.Gray
        btnCalculate.FlatAppearance.BorderSize = 4
        btnCalculate.FlatStyle = FlatStyle.Flat
        btnCalculate.Location = New Point(258, 275)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(328, 140)
        btnCalculate.TabIndex = 2
        btnCalculate.Text = "CALCULATE CIRCUMFERENCE"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' lblCircumference
        ' 
        lblCircumference.Location = New Point(48, 460)
        lblCircumference.Name = "lblCircumference"
        lblCircumference.Size = New Size(538, 46)
        lblCircumference.TabIndex = 3
        lblCircumference.Text = "THE CIRCUMFERENCE = "
        ' 
        ' btnEnd
        ' 
        btnEnd.BackColor = Color.Bisque
        btnEnd.FlatAppearance.BorderColor = Color.Gray
        btnEnd.FlatAppearance.BorderSize = 4
        btnEnd.FlatStyle = FlatStyle.Flat
        btnEnd.Location = New Point(258, 584)
        btnEnd.Name = "btnEnd"
        btnEnd.Size = New Size(186, 67)
        btnEnd.TabIndex = 4
        btnEnd.Text = "END"
        btnEnd.UseVisualStyleBackColor = False
        ' 
        ' mainForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Bisque
        ClientSize = New Size(826, 856)
        Controls.Add(btnEnd)
        Controls.Add(lblCircumference)
        Controls.Add(btnCalculate)
        Controls.Add(txtDiameter)
        Controls.Add(lblDiameter)
        Name = "mainForm"
        Text = "Find Circumference"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDiameter As Label
    Friend WithEvents txtDiameter As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblCircumference As Label
    Friend WithEvents btnEnd As Button

End Class
