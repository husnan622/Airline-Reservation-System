﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ticket_Status
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
        Me.components = New System.ComponentModel.Container()
        Me.Status = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Submit = New System.Windows.Forms.Button()
        Me.PnrNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.ForeColor = System.Drawing.Color.Red
        Me.Status.Location = New System.Drawing.Point(524, 389)
        Me.Status.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(0, 29)
        Me.Status.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(984, 234)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Submit
        '
        Me.Submit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(822, 234)
        Me.Submit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(112, 35)
        Me.Submit.TabIndex = 9
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = False
        '
        'PnrNo
        '
        Me.PnrNo.Location = New System.Drawing.Point(528, 234)
        Me.PnrNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PnrNo.Name = "PnrNo"
        Me.PnrNo.Size = New System.Drawing.Size(226, 26)
        Me.PnrNo.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(304, 389)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Status :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 234)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Enter PNR No :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(560, 78)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(360, 57)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "TICKET STATUS"
        '
        'Ticket_Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.PnrNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Ticket_Status"
        Me.Text = "Ticket_Status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents PnrNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
