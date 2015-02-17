<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class state
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(state))
        Me.chkPhoneNumber = New System.Windows.Forms.CheckBox()
        Me.mskPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.grpYourOptions = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.picStateImage = New System.Windows.Forms.PictureBox()
        Me.lblNicknameInformation = New System.Windows.Forms.Label()
        Me.grpStateInformation = New System.Windows.Forms.GroupBox()
        Me.lblClimateInformation = New System.Windows.Forms.Label()
        Me.lblPopulationInformation = New System.Windows.Forms.Label()
        Me.lblNickname = New System.Windows.Forms.Label()
        Me.lblClimate = New System.Windows.Forms.Label()
        Me.lblPopulation = New System.Windows.Forms.Label()
        Me.lblStateOfX = New System.Windows.Forms.Label()
        Me.tipStateAdvisory = New System.Windows.Forms.ToolTip(Me.components)
        Me.radWashington = New System.Windows.Forms.RadioButton()
        Me.radCalifornia = New System.Windows.Forms.RadioButton()
        Me.radOregon = New System.Windows.Forms.RadioButton()
        Me.grpStateSelection = New System.Windows.Forms.GroupBox()
        Me.grpYourOptions.SuspendLayout()
        CType(Me.picStateImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStateInformation.SuspendLayout()
        Me.grpStateSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkPhoneNumber
        '
        Me.chkPhoneNumber.AutoSize = True
        Me.chkPhoneNumber.Location = New System.Drawing.Point(9, 241)
        Me.chkPhoneNumber.Name = "chkPhoneNumber"
        Me.chkPhoneNumber.Size = New System.Drawing.Size(63, 17)
        Me.chkPhoneNumber.TabIndex = 13
        Me.chkPhoneNumber.Text = "Phone?"
        Me.tipStateAdvisory.SetToolTip(Me.chkPhoneNumber, "Click here to enter a phone number")
        Me.chkPhoneNumber.UseVisualStyleBackColor = True
        '
        'mskPhoneNumber
        '
        Me.mskPhoneNumber.Location = New System.Drawing.Point(9, 264)
        Me.mskPhoneNumber.Mask = "(999) 000-0000"
        Me.mskPhoneNumber.Name = "mskPhoneNumber"
        Me.mskPhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.mskPhoneNumber.TabIndex = 11
        Me.tipStateAdvisory.SetToolTip(Me.mskPhoneNumber, "Enter a phone number")
        Me.mskPhoneNumber.Visible = False
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblState.Location = New System.Drawing.Point(206, 19)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(83, 31)
        Me.lblState.TabIndex = 10
        Me.lblState.Text = "State"
        '
        'grpYourOptions
        '
        Me.grpYourOptions.Controls.Add(Me.btnExit)
        Me.grpYourOptions.Controls.Add(Me.btnClearAll)
        Me.grpYourOptions.Location = New System.Drawing.Point(9, 120)
        Me.grpYourOptions.Name = "grpYourOptions"
        Me.grpYourOptions.Size = New System.Drawing.Size(115, 88)
        Me.grpYourOptions.TabIndex = 9
        Me.grpYourOptions.TabStop = False
        Me.grpYourOptions.Text = "Your Options"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(18, 50)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "&Exit"
        Me.tipStateAdvisory.SetToolTip(Me.btnExit, "Click to exit the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(18, 20)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(75, 23)
        Me.btnClearAll.TabIndex = 4
        Me.btnClearAll.Text = "&Clear All"
        Me.tipStateAdvisory.SetToolTip(Me.btnClearAll, "Click to reset the program")
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'picStateImage
        '
        Me.picStateImage.Image = CType(resources.GetObject("picStateImage.Image"), System.Drawing.Image)
        Me.picStateImage.Location = New System.Drawing.Point(203, 62)
        Me.picStateImage.Name = "picStateImage"
        Me.picStateImage.Size = New System.Drawing.Size(143, 96)
        Me.picStateImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStateImage.TabIndex = 8
        Me.picStateImage.TabStop = False
        Me.picStateImage.Visible = False
        '
        'lblNicknameInformation
        '
        Me.lblNicknameInformation.AutoSize = True
        Me.lblNicknameInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNicknameInformation.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNicknameInformation.Location = New System.Drawing.Point(36, 208)
        Me.lblNicknameInformation.Name = "lblNicknameInformation"
        Me.lblNicknameInformation.Size = New System.Drawing.Size(137, 16)
        Me.lblNicknameInformation.TabIndex = 11
        Me.lblNicknameInformation.Text = "Nickname Information"
        '
        'grpStateInformation
        '
        Me.grpStateInformation.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.grpStateInformation.Controls.Add(Me.lblNicknameInformation)
        Me.grpStateInformation.Controls.Add(Me.lblClimateInformation)
        Me.grpStateInformation.Controls.Add(Me.lblPopulationInformation)
        Me.grpStateInformation.Controls.Add(Me.lblNickname)
        Me.grpStateInformation.Controls.Add(Me.lblClimate)
        Me.grpStateInformation.Controls.Add(Me.lblPopulation)
        Me.grpStateInformation.Controls.Add(Me.lblStateOfX)
        Me.grpStateInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStateInformation.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.grpStateInformation.Location = New System.Drawing.Point(203, 170)
        Me.grpStateInformation.Name = "grpStateInformation"
        Me.grpStateInformation.Size = New System.Drawing.Size(396, 245)
        Me.grpStateInformation.TabIndex = 12
        Me.grpStateInformation.TabStop = False
        Me.grpStateInformation.Text = "State Information"
        Me.tipStateAdvisory.SetToolTip(Me.grpStateInformation, "State Information")
        Me.grpStateInformation.Visible = False
        '
        'lblClimateInformation
        '
        Me.lblClimateInformation.AutoSize = True
        Me.lblClimateInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClimateInformation.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblClimateInformation.Location = New System.Drawing.Point(36, 144)
        Me.lblClimateInformation.Name = "lblClimateInformation"
        Me.lblClimateInformation.Size = New System.Drawing.Size(121, 16)
        Me.lblClimateInformation.TabIndex = 10
        Me.lblClimateInformation.Text = "Climate Information"
        '
        'lblPopulationInformation
        '
        Me.lblPopulationInformation.AutoSize = True
        Me.lblPopulationInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPopulationInformation.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPopulationInformation.Location = New System.Drawing.Point(36, 85)
        Me.lblPopulationInformation.Name = "lblPopulationInformation"
        Me.lblPopulationInformation.Size = New System.Drawing.Size(140, 16)
        Me.lblPopulationInformation.TabIndex = 9
        Me.lblPopulationInformation.Text = "Population Information"
        '
        'lblNickname
        '
        Me.lblNickname.AutoSize = True
        Me.lblNickname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNickname.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblNickname.Location = New System.Drawing.Point(17, 175)
        Me.lblNickname.Name = "lblNickname"
        Me.lblNickname.Size = New System.Drawing.Size(95, 24)
        Me.lblNickname.TabIndex = 8
        Me.lblNickname.Text = "Nickname"
        '
        'lblClimate
        '
        Me.lblClimate.AutoSize = True
        Me.lblClimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClimate.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblClimate.Location = New System.Drawing.Point(18, 111)
        Me.lblClimate.Name = "lblClimate"
        Me.lblClimate.Size = New System.Drawing.Size(72, 24)
        Me.lblClimate.TabIndex = 7
        Me.lblClimate.Text = "Climate"
        '
        'lblPopulation
        '
        Me.lblPopulation.AutoSize = True
        Me.lblPopulation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPopulation.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPopulation.Location = New System.Drawing.Point(17, 54)
        Me.lblPopulation.Name = "lblPopulation"
        Me.lblPopulation.Size = New System.Drawing.Size(99, 24)
        Me.lblPopulation.TabIndex = 6
        Me.lblPopulation.Text = "Population"
        '
        'lblStateOfX
        '
        Me.lblStateOfX.AutoSize = True
        Me.lblStateOfX.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateOfX.ForeColor = System.Drawing.Color.Yellow
        Me.lblStateOfX.Location = New System.Drawing.Point(17, 25)
        Me.lblStateOfX.Name = "lblStateOfX"
        Me.lblStateOfX.Size = New System.Drawing.Size(210, 25)
        Me.lblStateOfX.TabIndex = 5
        Me.lblStateOfX.Text = "State Of Washington"
        '
        'radWashington
        '
        Me.radWashington.AutoSize = True
        Me.radWashington.Location = New System.Drawing.Point(18, 20)
        Me.radWashington.Name = "radWashington"
        Me.radWashington.Size = New System.Drawing.Size(82, 17)
        Me.radWashington.TabIndex = 1
        Me.radWashington.TabStop = True
        Me.radWashington.Text = "Washington"
        Me.tipStateAdvisory.SetToolTip(Me.radWashington, "Click to display state information")
        Me.radWashington.UseVisualStyleBackColor = True
        '
        'radCalifornia
        '
        Me.radCalifornia.AutoSize = True
        Me.radCalifornia.Location = New System.Drawing.Point(18, 66)
        Me.radCalifornia.Name = "radCalifornia"
        Me.radCalifornia.Size = New System.Drawing.Size(68, 17)
        Me.radCalifornia.TabIndex = 3
        Me.radCalifornia.TabStop = True
        Me.radCalifornia.Text = "California"
        Me.tipStateAdvisory.SetToolTip(Me.radCalifornia, "Click to display state information")
        Me.radCalifornia.UseVisualStyleBackColor = True
        '
        'radOregon
        '
        Me.radOregon.AutoSize = True
        Me.radOregon.Location = New System.Drawing.Point(18, 43)
        Me.radOregon.Name = "radOregon"
        Me.radOregon.Size = New System.Drawing.Size(60, 17)
        Me.radOregon.TabIndex = 2
        Me.radOregon.TabStop = True
        Me.radOregon.Text = "Oregon"
        Me.tipStateAdvisory.SetToolTip(Me.radOregon, "Click to display state information")
        Me.radOregon.UseVisualStyleBackColor = True
        '
        'grpStateSelection
        '
        Me.grpStateSelection.Controls.Add(Me.radWashington)
        Me.grpStateSelection.Controls.Add(Me.radCalifornia)
        Me.grpStateSelection.Controls.Add(Me.radOregon)
        Me.grpStateSelection.Location = New System.Drawing.Point(9, 19)
        Me.grpStateSelection.Name = "grpStateSelection"
        Me.grpStateSelection.Size = New System.Drawing.Size(115, 95)
        Me.grpStateSelection.TabIndex = 14
        Me.grpStateSelection.TabStop = False
        Me.grpStateSelection.Text = "State Selection"
        Me.tipStateAdvisory.SetToolTip(Me.grpStateSelection, "Click a radio button to get more information on a state")
        '
        'state
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 434)
        Me.Controls.Add(Me.chkPhoneNumber)
        Me.Controls.Add(Me.mskPhoneNumber)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.grpYourOptions)
        Me.Controls.Add(Me.picStateImage)
        Me.Controls.Add(Me.grpStateInformation)
        Me.Controls.Add(Me.grpStateSelection)
        Me.Name = "state"
        Me.Text = "Form1"
        Me.grpYourOptions.ResumeLayout(False)
        CType(Me.picStateImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStateInformation.ResumeLayout(False)
        Me.grpStateInformation.PerformLayout()
        Me.grpStateSelection.ResumeLayout(False)
        Me.grpStateSelection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkPhoneNumber As System.Windows.Forms.CheckBox
    Friend WithEvents tipStateAdvisory As System.Windows.Forms.ToolTip
    Friend WithEvents mskPhoneNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents grpYourOptions As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents picStateImage As System.Windows.Forms.PictureBox
    Friend WithEvents lblNicknameInformation As System.Windows.Forms.Label
    Friend WithEvents grpStateInformation As System.Windows.Forms.GroupBox
    Friend WithEvents lblClimateInformation As System.Windows.Forms.Label
    Friend WithEvents lblPopulationInformation As System.Windows.Forms.Label
    Friend WithEvents lblNickname As System.Windows.Forms.Label
    Friend WithEvents lblClimate As System.Windows.Forms.Label
    Friend WithEvents lblPopulation As System.Windows.Forms.Label
    Friend WithEvents lblStateOfX As System.Windows.Forms.Label
    Friend WithEvents radWashington As System.Windows.Forms.RadioButton
    Friend WithEvents radCalifornia As System.Windows.Forms.RadioButton
    Friend WithEvents radOregon As System.Windows.Forms.RadioButton
    Friend WithEvents grpStateSelection As System.Windows.Forms.GroupBox

End Class
