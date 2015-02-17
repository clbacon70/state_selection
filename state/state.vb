Public Class state
    ' Lab 5
    ' Carole Bacon
    ' 2.4.2015


    Dim sWASHINGTON_POPULATION As String  ' Using strings vs integers for these values so a comma can be used for ease of readability
    Dim sOREGON_POPULATION As String   ' Using strings vs integers for these values so a comma can be used for ease of readability
    Dim sCALIFORNIA_POPULATION As String  ' Using strings vs integers for these values so a comma can be used for ease of readability
    Dim sWASHINGTON_CLIMATE As String
    Dim sOREGON_CLIMATE As String
    Dim sCALIFORNIA_CLIMATE As String
    Dim sWASHINGTON_NICKNAME As String
    Dim sOREGON_NICKNAME As String
    Dim sCALIFORNIA_NICKNAME As String

    Private Sub radWashingtonOregonCalifornia_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radWashington.CheckedChanged, radOregon.CheckedChanged, radCalifornia.CheckedChanged
        Dim sPopulation As String = ""
        Dim sClimate As String = ""
        Dim sNickname As String = ""
        Dim sActiveStateName As String = ""

        If radWashington.Checked = True Then
            Me.picStateImage.Image = Image.FromFile("washington.BMP")   'Update picturebox with active state's image
            Me.tipStateAdvisory.SetToolTip(picStateImage, "Fountains with mountain in the background")  'Update tooltip on picturebox with appropriate comment
            Me.grpStateInformation.BackColor = Color.Blue ' Update background color
            sActiveStateName = "Washington" ' Update lblStateOfX with the active state's name
            sPopulation = "6,897,012" ' Update the population of the active state
            sClimate = "Oceanic in the West, and semi-arid in the East" ' Update climate of active state
            sNickname = "The Evergreen State" ' Update nickname of active state
        ElseIf radOregon.Checked = True Then
            'Adjust the above code to display the state of Oregon
            Me.picStateImage.Image = Image.FromFile("oregon.BMP")   'Update picturebox with active state's image
            Me.tipStateAdvisory.SetToolTip(picStateImage, "Mount Hood")  'Update tooltip on picturebox with appropriate comment
            Me.grpStateInformation.BackColor = Color.Orange 'Update background color of active state
            sActiveStateName = "Oregon" ' Update lblStateOfX with the active state's name
            sPopulation = "3,970,239"  ' Update the population of active state
            sClimate = "Oregon has a generally temperate climate" ' Update climate of active state
            sNickname = "The Beaver State" ' Update nickname of active state
        Else    ' California was selected
            'Adjust the code to display information about state of california
            Me.picStateImage.Image = Image.FromFile("california.BMP")   'Update picturebox with active state's image
            Me.tipStateAdvisory.SetToolTip(picStateImage, "A beautiful lighthouse")  'Update tooltip on picturebox with appropriate comment
            Me.grpStateInformation.BackColor = Color.Green 'Update background color of active state
            sActiveStateName = "California" ' Update lblStateOfX with the active state's name
            sPopulation = "38,802,500"  ' Update the population of active state
            sClimate = "California's climate varies widely, from Mediterranean to subarctic"
            sNickname = "The Golden State" ' Update nickname of active state
        End If

        Me.grpStateInformation.Visible = True   ' Make grpStateInformation visible
        Me.picStateImage.Visible = True     ' Update lblPopulationInformation with the active state's population information
        Me.lblPopulationInformation.Text = "The population of " & sActiveStateName & " is:" & vbCrLf & sPopulation  ' Update lblClimateInformation with the active state's climate information
        Me.lblClimateInformation.Text = "The climate of " & sActiveStateName & " is:" & vbCrLf & sClimate   ' Update lblNicknameInformation with the active state's nickname information
        Me.lblStateOfX.Text = "State of " & sActiveStateName    ' Set picStateImage to active state's image
        Me.lblNicknameInformation.Text = "The nickname of " & sActiveStateName & " is:" & vbCrLf & sNickname

    End Sub

    Private Sub btnClearAll_Click(sender As System.Object, e As System.EventArgs) Handles btnClearAll.Click
        ' Uncheck all radio buttons, hide state information and picture boxes and reset phone number controls
        If Me.radWashington.Checked = True Then radWashington.Checked = False
        If Me.radOregon.Checked = True Then radOregon.Checked = False
        If Me.radCalifornia.Checked = True Then radCalifornia.Checked = False
        Me.grpStateInformation.Visible = False
        Me.picStateImage.Visible = False
        Me.mskPhoneNumber.Text = ""
        Me.mskPhoneNumber.Visible = False
        Me.chkPhoneNumber.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        ' Close the program after confirming with the user that they truly want to close it.
        Dim dlrResult As DialogResult
        dlrResult = MessageBox.Show("Thank you for using the State Advisory program" & vbCrLf & "Are you sure you want to exit?", "Closing Program", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If dlrResult = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub chkPhoneNumber_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPhoneNumber.CheckedChanged
        ' Toggle the phone number masked textbox on and off
        If Me.chkPhoneNumber.Checked = True Then
            Me.mskPhoneNumber.Visible = True
        Else
            Me.mskPhoneNumber.Visible = False
        End If
    End Sub

    Private Sub frmStateAdvisory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
