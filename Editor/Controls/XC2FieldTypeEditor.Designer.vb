﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XC2FieldTypeEditor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.ValueLabel = New System.Windows.Forms.Label()
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.ValueDropdown = New System.Windows.Forms.TextBox()
        Me.TypeDropdown = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.Location = New System.Drawing.Point(305, 57)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(94, 30)
        Me.UpdateBtn.TabIndex = 19
        Me.UpdateBtn.Text = "Set Value"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'ValueLabel
        '
        Me.ValueLabel.AutoSize = True
        Me.ValueLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValueLabel.Location = New System.Drawing.Point(249, 2)
        Me.ValueLabel.Name = "ValueLabel"
        Me.ValueLabel.Size = New System.Drawing.Size(104, 21)
        Me.ValueLabel.TabIndex = 18
        Me.ValueLabel.Text = "FIELD_VALUE"
        Me.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeLabel.Location = New System.Drawing.Point(2, 2)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(92, 21)
        Me.TypeLabel.TabIndex = 17
        Me.TypeLabel.Text = "FIELD_TYPE"
        Me.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValueDropdown
        '
        Me.ValueDropdown.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValueDropdown.Location = New System.Drawing.Point(253, 26)
        Me.ValueDropdown.Name = "ValueDropdown"
        Me.ValueDropdown.Size = New System.Drawing.Size(146, 25)
        Me.ValueDropdown.TabIndex = 16
        '
        'TypeDropdown
        '
        Me.TypeDropdown.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeDropdown.FormattingEnabled = True
        Me.TypeDropdown.Location = New System.Drawing.Point(6, 26)
        Me.TypeDropdown.Name = "TypeDropdown"
        Me.TypeDropdown.Size = New System.Drawing.Size(241, 25)
        Me.TypeDropdown.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Max items = 99, Max halos = 99999999"
        '
        'XC2FieldTypeEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.ValueLabel)
        Me.Controls.Add(Me.TypeLabel)
        Me.Controls.Add(Me.ValueDropdown)
        Me.Controls.Add(Me.TypeDropdown)
        Me.Name = "XC2FieldTypeEditor"
        Me.Size = New System.Drawing.Size(405, 93)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateBtn As Button
    Friend WithEvents ValueLabel As Label
    Friend WithEvents TypeLabel As Label
    Friend WithEvents ValueDropdown As TextBox
    Friend WithEvents TypeDropdown As ComboBox
    Friend WithEvents Label1 As Label
End Class
