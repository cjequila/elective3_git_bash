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
        Me.name_textbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.age_textbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.address_textbox = New System.Windows.Forms.TextBox()
        Me.txt_button = New System.Windows.Forms.Button()
        Me.xml_button = New System.Windows.Forms.Button()
        Me.json_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'name_textbox
        '
        Me.name_textbox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_textbox.Location = New System.Drawing.Point(176, 70)
        Me.name_textbox.Name = "name_textbox"
        Me.name_textbox.Size = New System.Drawing.Size(189, 22)
        Me.name_textbox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Age"
        '
        'age_textbox
        '
        Me.age_textbox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age_textbox.Location = New System.Drawing.Point(176, 98)
        Me.age_textbox.Name = "age_textbox"
        Me.age_textbox.Size = New System.Drawing.Size(64, 22)
        Me.age_textbox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Address"
        '
        'address_textbox
        '
        Me.address_textbox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_textbox.Location = New System.Drawing.Point(176, 129)
        Me.address_textbox.Name = "address_textbox"
        Me.address_textbox.Size = New System.Drawing.Size(187, 22)
        Me.address_textbox.TabIndex = 5
        '
        'txt_button
        '
        Me.txt_button.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_button.Location = New System.Drawing.Point(79, 180)
        Me.txt_button.Name = "txt_button"
        Me.txt_button.Size = New System.Drawing.Size(77, 27)
        Me.txt_button.TabIndex = 6
        Me.txt_button.Text = "TXT"
        Me.txt_button.UseVisualStyleBackColor = True
        '
        'xml_button
        '
        Me.xml_button.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xml_button.Location = New System.Drawing.Point(186, 180)
        Me.xml_button.Name = "xml_button"
        Me.xml_button.Size = New System.Drawing.Size(77, 27)
        Me.xml_button.TabIndex = 7
        Me.xml_button.Text = "XML"
        Me.xml_button.UseVisualStyleBackColor = True
        '
        'json_button
        '
        Me.json_button.BackColor = System.Drawing.SystemColors.ControlLight
        Me.json_button.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.json_button.Location = New System.Drawing.Point(286, 180)
        Me.json_button.Name = "json_button"
        Me.json_button.Size = New System.Drawing.Size(77, 27)
        Me.json_button.TabIndex = 8
        Me.json_button.Text = "JSON"
        Me.json_button.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 281)
        Me.Controls.Add(Me.json_button)
        Me.Controls.Add(Me.xml_button)
        Me.Controls.Add(Me.txt_button)
        Me.Controls.Add(Me.address_textbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.age_textbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.name_textbox)
        Me.name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents name_textbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents age_textbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents address_textbox As TextBox
    Friend WithEvents txt_button As Button
    Friend WithEvents xml_button As Button
    Friend WithEvents json_button As Button
End Class
