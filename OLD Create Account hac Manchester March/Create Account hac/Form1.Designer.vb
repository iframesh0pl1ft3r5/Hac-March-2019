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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.age = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Phone_number = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.workAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Font = New System.Drawing.Font("Terminator Two", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(590, 62)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SUBMIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(12, 93)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(125, 26)
        Me.Username.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(144, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(143, 93)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(199, 26)
        Me.Password.TabIndex = 3
        Me.Password.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(345, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Age"
        '
        'age
        '
        Me.age.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age.Location = New System.Drawing.Point(348, 93)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(51, 26)
        Me.age.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Swiss911 UCm BT", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(590, 61)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Please Sign Up to access easyHello"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(405, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Phone Number"
        '
        'Phone_number
        '
        Me.Phone_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_number.Location = New System.Drawing.Point(404, 93)
        Me.Phone_number.Name = "Phone_number"
        Me.Phone_number.Size = New System.Drawing.Size(177, 26)
        Me.Phone_number.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Address"
        '
        'address
        '
        Me.address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(12, 156)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(569, 26)
        Me.address.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 29)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Work Address"
        '
        'workAddress
        '
        Me.workAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.workAddress.Location = New System.Drawing.Point(11, 221)
        Me.workAddress.Name = "workAddress"
        Me.workAddress.Size = New System.Drawing.Size(570, 26)
        Me.workAddress.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 29)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Email Address"
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(11, 282)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(570, 26)
        Me.email.TabIndex = 14
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 380)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.workAddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Phone_number)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Sign Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents age As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Phone_number As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents address As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents workAddress As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Timer1 As Timer
End Class
