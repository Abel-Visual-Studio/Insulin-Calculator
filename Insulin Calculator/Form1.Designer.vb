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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        CarbohydrateFactorToolStripMenuItem = New ToolStripMenuItem()
        CarbFactorInput = New ToolStripTextBox()
        ToolStripSeparator1 = New ToolStripSeparator()
        GlucoseFactorToolStripMenuItem = New ToolStripMenuItem()
        GlucoseTargetInput = New ToolStripTextBox()
        GlucoseToolStripMenuItem = New ToolStripMenuItem()
        GlucoseFactorInput = New ToolStripTextBox()
        ToolStripSeparator2 = New ToolStripSeparator()
        SaveSettingsToolStripMenuItem = New ToolStripMenuItem()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        MaterialTextBox1 = New MaterialSkin.Controls.MaterialTextBox()
        MaterialTextBox2 = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        ResultLabel = New MaterialSkin.Controls.MaterialLabel()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, SettingsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(366, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(93, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CarbohydrateFactorToolStripMenuItem, ToolStripSeparator1, GlucoseFactorToolStripMenuItem, GlucoseToolStripMenuItem, ToolStripSeparator2, SaveSettingsToolStripMenuItem})
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(61, 20)
        SettingsToolStripMenuItem.Text = "Settings"
        ' 
        ' CarbohydrateFactorToolStripMenuItem
        ' 
        CarbohydrateFactorToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CarbFactorInput})
        CarbohydrateFactorToolStripMenuItem.Name = "CarbohydrateFactorToolStripMenuItem"
        CarbohydrateFactorToolStripMenuItem.Size = New Size(187, 22)
        CarbohydrateFactorToolStripMenuItem.Text = "Carbohydrate Factor"
        ' 
        ' CarbFactorInput
        ' 
        CarbFactorInput.Name = "CarbFactorInput"
        CarbFactorInput.Size = New Size(100, 23)
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(184, 6)
        ' 
        ' GlucoseFactorToolStripMenuItem
        ' 
        GlucoseFactorToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GlucoseTargetInput})
        GlucoseFactorToolStripMenuItem.Name = "GlucoseFactorToolStripMenuItem"
        GlucoseFactorToolStripMenuItem.Size = New Size(187, 22)
        GlucoseFactorToolStripMenuItem.Text = "Glucose Target Factor"
        ' 
        ' GlucoseTargetInput
        ' 
        GlucoseTargetInput.Name = "GlucoseTargetInput"
        GlucoseTargetInput.Size = New Size(100, 23)
        ' 
        ' GlucoseToolStripMenuItem
        ' 
        GlucoseToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GlucoseFactorInput})
        GlucoseToolStripMenuItem.Name = "GlucoseToolStripMenuItem"
        GlucoseToolStripMenuItem.Size = New Size(187, 22)
        GlucoseToolStripMenuItem.Text = "Glucose Factor"
        ' 
        ' GlucoseFactorInput
        ' 
        GlucoseFactorInput.Name = "GlucoseFactorInput"
        GlucoseFactorInput.Size = New Size(100, 23)
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(184, 6)
        ' 
        ' SaveSettingsToolStripMenuItem
        ' 
        SaveSettingsToolStripMenuItem.Name = "SaveSettingsToolStripMenuItem"
        SaveSettingsToolStripMenuItem.Size = New Size(187, 22)
        SaveSettingsToolStripMenuItem.Text = "Save Settings"
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(132, 200)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(103, 36)
        MaterialButton1.TabIndex = 6
        MaterialButton1.Text = "Calculate"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(12, 39)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(103, 19)
        MaterialLabel1.TabIndex = 7
        MaterialLabel1.Text = "Blood Glucose"
        ' 
        ' MaterialTextBox1
        ' 
        MaterialTextBox1.AnimateReadOnly = False
        MaterialTextBox1.BorderStyle = BorderStyle.None
        MaterialTextBox1.Depth = 0
        MaterialTextBox1.Font = New Font("Microsoft Sans Serif", 12F)
        MaterialTextBox1.LeadingIcon = Nothing
        MaterialTextBox1.LeaveOnEnterKey = True
        MaterialTextBox1.Location = New Point(12, 61)
        MaterialTextBox1.MaxLength = 50
        MaterialTextBox1.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox1.Multiline = False
        MaterialTextBox1.Name = "MaterialTextBox1"
        MaterialTextBox1.Size = New Size(342, 50)
        MaterialTextBox1.TabIndex = 8
        MaterialTextBox1.Text = "Enter Blood Glucose"
        MaterialTextBox1.TrailingIcon = Nothing
        MaterialTextBox1.UseAccent = False
        ' 
        ' MaterialTextBox2
        ' 
        MaterialTextBox2.AnimateReadOnly = False
        MaterialTextBox2.BorderStyle = BorderStyle.None
        MaterialTextBox2.Depth = 0
        MaterialTextBox2.Font = New Font("Microsoft Sans Serif", 12F)
        MaterialTextBox2.LeadingIcon = Nothing
        MaterialTextBox2.LeaveOnEnterKey = True
        MaterialTextBox2.Location = New Point(12, 141)
        MaterialTextBox2.MaxLength = 50
        MaterialTextBox2.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox2.Multiline = False
        MaterialTextBox2.Name = "MaterialTextBox2"
        MaterialTextBox2.Size = New Size(342, 50)
        MaterialTextBox2.TabIndex = 10
        MaterialTextBox2.Text = "Enter Carbohydrates"
        MaterialTextBox2.TrailingIcon = Nothing
        MaterialTextBox2.UseAccent = False
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.Location = New Point(12, 119)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(104, 19)
        MaterialLabel2.TabIndex = 9
        MaterialLabel2.Text = "Carbohydrates"
        ' 
        ' ResultLabel
        ' 
        ResultLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ResultLabel.AutoSize = True
        ResultLabel.Depth = 0
        ResultLabel.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        ResultLabel.Location = New Point(152, 253)
        ResultLabel.MouseState = MaterialSkin.MouseState.HOVER
        ResultLabel.Name = "ResultLabel"
        ResultLabel.Size = New Size(63, 19)
        ResultLabel.TabIndex = 11
        ResultLabel.Text = "0.0 Units"
        ResultLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(366, 294)
        Controls.Add(ResultLabel)
        Controls.Add(MaterialTextBox2)
        Controls.Add(MaterialLabel2)
        Controls.Add(MaterialTextBox1)
        Controls.Add(MaterialLabel1)
        Controls.Add(MaterialButton1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Insulin Calculator"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialTextBox1 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBox2 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ResultLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CarbohydrateFactorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarbFactorInput As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GlucoseFactorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GlucoseTargetInput As ToolStripTextBox
    Friend WithEvents GlucoseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GlucoseFactorInput As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SaveSettingsToolStripMenuItem As ToolStripMenuItem

End Class
