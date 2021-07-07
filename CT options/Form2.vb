Public Class frmCToptions2
    Private Sub frmCToptions2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim windows(5) As String

        windows(0) = "windows 10"
        windows(1) = "windows 8"
        windows(2) = "windows 7"
        windows(3) = "windows vista"
        windows(4) = "windows xp"

        ComboBox1.Items.Add(windows(0))
        ComboBox1.Items.Add(windows(1))
        ComboBox1.Items.Add(windows(2))
        ComboBox1.Items.Add(windows(3))
        ComboBox1.Items.Add(windows(4))

        Dim office(5) As String

        office(0) = "office 2007"
        office(1) = "office 2013"
        office(2) = "office 2016"
        office(3) = "office 2019"

        ComboBox2.Items.Add(office(0))
        ComboBox2.Items.Add(office(1))
        ComboBox2.Items.Add(office(2))
        ComboBox2.Items.Add(office(3))

        Dim Anti(5) As String

        Anti(0) = "Auslogics Anti-Malware"
        Anti(1) = "ESET Internet Security"
        Anti(2) = "Kaspersky Internet"
        Anti(3) = "Malwarebytes Pro"
        Anti(4) = "Zemana AntiMalware Pro"

        ComboBox3.Items.Add(Anti(0))
        ComboBox3.Items.Add(Anti(1))
        ComboBox3.Items.Add(Anti(2))
        ComboBox3.Items.Add(Anti(3))


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Hide()
        frmCToptions1.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Dim closeOrnot As DialogResult
        closeOrnot = MessageBox.Show("Are you sure to close CT options program!", "CT options", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (closeOrnot = DialogResult.Yes) Then
            End
        End If
    End Sub

    Dim download_link As DialogResult
    Dim download_link1 As DialogResult


    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click

        If (CheckBox1.Checked) Then
            If (ComboBox1.SelectedIndex = 0) Then
                download_link = MessageBox.Show("with serial {yes} without serial {No}", "CT options", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                If (download_link = DialogResult.Yes) Then
                    Process.Start("https://getintopc.com/softwares/operating-systems/windows-10-pro-incl-office-2019-mar-2020-free-download-8135365/")
                ElseIf (download_link = DialogResult.No) Then
                    Process.Start("https://www.microsoft.com/en-us/software-download/windows10")
                Else
                End If
                ComboBox2.Items.Clear()
                ComboBox3.Items.Clear()
            End If

            If (ComboBox1.SelectedIndex = 1) Then
                download_link = MessageBox.Show("with serial {yes} without serial {No}", "CT options", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                If (download_link = DialogResult.Yes) Then
                    Process.Start("https://getintopc.com/softwares/operating-systems/windows-8-1-aio-8in1-updated-nov-2019-download-1703942/")
                ElseIf (download_link = DialogResult.No) Then
                    Process.Start("https://www.microsoft.com/en-us/software-download/windows8ISO")
                Else
                End If
                ComboBox2.Items.Clear()
                ComboBox3.Items.Clear()
            End If

            If (ComboBox1.SelectedIndex = 2) Then
                download_link = MessageBox.Show("with serial {yes} without serial {No}", "CT options", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                If (download_link = DialogResult.Yes) Then
                    Process.Start("https://getintopc.com/softwares/operating-systems/windows-7-sp1-ultimate-march-2020-free-download-5768633/")
                ElseIf (download_link = DialogResult.No) Then
                    Process.Start("https://www.microsoft.com/en-us/software-download/windows7")
                Else
                End If
                ComboBox2.Items.Clear()
                ComboBox3.Items.Clear()
            End If

            If (ComboBox1.SelectedIndex = 3) Then
                download_link = MessageBox.Show("with serial {yes} without serial {No}", "CT options", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                If (download_link = DialogResult.Yes) Then
                    Process.Start("https://getintopc.com/softwares/operating-systems/windows-vista-all-in-one-iso-free-download-3890996/")
                ElseIf (download_link = DialogResult.No) Then
                    Process.Start("https://www.microsoft.com/ar-sa/download/details.aspx?id=13158")
                Else
                End If
                ComboBox2.Items.Clear()
                ComboBox3.Items.Clear()
            End If

            If (ComboBox1.SelectedIndex = 4) Then
                download_link = MessageBox.Show("with serial {yes} without serial {No}", "CT options", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                If (download_link = DialogResult.Yes) Then
                    Process.Start("https://getintopc.com/softwares/windows-xp-pro-sp3-updated-june-2019-download-1669273/")
                ElseIf (download_link = DialogResult.No) Then
                    Process.Start("https://www.microsoft.com/en-us/Download/confirmation.aspx?id=18242")
                Else
                End If

                ComboBox2.Items.Clear()
                ComboBox3.Items.Clear()

            End If

            If (ComboBox2.SelectedIndex = 0) Then
                Process.Start("https://getintopc.com/softwares/office-tools/download-office-2007-sp3-enterprise-visio-pro-project-pro-2019-edition-6525379/")
                ComboBox1.Items.Clear()
                ComboBox3.Items.Clear()
            End If

            If (ComboBox2.SelectedIndex = 1) Then
                Process.Start("https://getintopc.com/softwares/office-tools/office-2013-pro-plus-sp1-vl-december-2019-free-download-1547828/")
                ComboBox1.Items.Clear()
                ComboBox3.Items.Clear()
            End If

            If (ComboBox2.SelectedIndex = 2) Then
                Process.Start("https://getintopc.com/softwares/office-tools/office-2016-pro-plus-vl-december-2019-free-download-6556292/")
                ComboBox1.Items.Clear()
                ComboBox3.Items.Clear()
            End If

            If (ComboBox2.SelectedIndex = 3) Then
                Process.Start("https://getintopc.com/softwares/office-tools/office-2019-retail-updated-sep-2019-free-download-6797377/")
                ComboBox1.Items.Clear()
                ComboBox3.Items.Clear()
            End If


            If (ComboBox3.SelectedIndex = 0) Then
                Process.Start("https://getintopc.com/softwares/security/auslogics-anti-malware-2020-free-download/")
                ComboBox1.Items.Clear()
                ComboBox2.Items.Clear()
            End If

            If (ComboBox3.SelectedIndex = 1) Then
                Process.Start("https://getintopc.com/softwares/security/eset-internet-security-2020-free-download/")
                ComboBox1.Items.Clear()
                ComboBox2.Items.Clear()
            End If

            If (ComboBox3.SelectedIndex = 2) Then
                Process.Start("https://getintopc.com/softwares/security/kaspersky-internet-security-2019-free-download-9802212/")
                ComboBox1.Items.Clear()
                ComboBox2.Items.Clear()
            End If

            If (ComboBox3.SelectedIndex = 3) Then
                Process.Start("https://getintopc.com/softwares/security/malwarebytes-premium-2019-free-download/")
                ComboBox1.Items.Clear()
                ComboBox2.Items.Clear()
            End If

            If (ComboBox3.SelectedIndex = 4) Then
                Process.Start("https://getintopc.com/softwares/security/zemana-antimalware-premium-2019-free-download/")
                ComboBox1.Items.Clear()
                ComboBox2.Items.Clear()
            End If

        Else

            If (ComboBox1.SelectedIndex = 0) Then
                download_link = MessageBox.Show("with serial {yes} without serial {No}", "CT options", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                If (download_link = DialogResult.Yes) Then
                    Process.Start("https://getintopc.com/softwares/operating-systems/windows-10-pro-incl-office-2019-mar-2020-free-download-8135365/")
                ElseIf (download_link = DialogResult.No) Then
                    Process.Start("https://www.microsoft.com/en-us/software-download/windows10")
                Else
                End If

            End If

            If (ComboBox1.SelectedIndex = 1) Then
                download_link = MessageBox.Show("with serial {yes} without serial {No}", "CT options", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                If (download_link = DialogResult.Yes) Then
                    Process.Start("https://getintopc.com/softwares/operating-systems/windows-8-1-aio-8in1-updated-nov-2019-download-1703942/")
                ElseIf (download_link = DialogResult.No) Then
                    Process.Start("https://www.microsoft.com/en-us/software-download/windows8ISO")
                Else
                End If

            End If

            If (ComboBox1.SelectedIndex = 2) Then
                download_link = MessageBox.Show("with serial {yes} without serial {No}", "CT options", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                If (download_link = DialogResult.Yes) Then
                    Process.Start("https://getintopc.com/softwares/operating-systems/windows-7-sp1-ultimate-march-2020-free-download-5768633/")
                ElseIf (download_link = DialogResult.No) Then
                    Process.Start("https://www.microsoft.com/en-us/software-download/windows7")
                Else
                End If

            End If

            If (ComboBox1.SelectedIndex = 3) Then
                download_link = MessageBox.Show("with serial {yes} without serial {No}", "CT options", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                If (download_link = DialogResult.Yes) Then
                    Process.Start("https://getintopc.com/softwares/operating-systems/windows-vista-all-in-one-iso-free-download-3890996/")
                ElseIf (download_link = DialogResult.No) Then
                    Process.Start("https://www.microsoft.com/ar-sa/download/details.aspx?id=13158")
                Else
                End If

            End If

            If (ComboBox1.SelectedIndex = 4) Then
                download_link = MessageBox.Show("with serial {yes} without serial {No}", "CT options", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                If (download_link = DialogResult.Yes) Then
                    Process.Start("https://getintopc.com/softwares/windows-xp-pro-sp3-updated-june-2019-download-1669273/")
                ElseIf (download_link = DialogResult.No) Then
                    Process.Start("https://www.microsoft.com/en-us/Download/confirmation.aspx?id=18242")
                Else
                End If

            End If

            If (ComboBox2.SelectedIndex = 0) Then
                Process.Start("https://getintopc.com/softwares/office-tools/download-office-2007-sp3-enterprise-visio-pro-project-pro-2019-edition-6525379/")
            End If

            If (ComboBox2.SelectedIndex = 1) Then
                Process.Start("https://getintopc.com/softwares/office-tools/office-2013-pro-plus-sp1-vl-december-2019-free-download-1547828/")
            End If

            If (ComboBox2.SelectedIndex = 2) Then
                Process.Start("https://getintopc.com/softwares/office-tools/office-2016-pro-plus-vl-december-2019-free-download-6556292/")
            End If

            If (ComboBox2.SelectedIndex = 3) Then
                Process.Start("https://getintopc.com/softwares/office-tools/office-2019-retail-updated-sep-2019-free-download-6797377/")
            End If


            If (ComboBox3.SelectedIndex = 0) Then
                Process.Start("https://getintopc.com/softwares/security/auslogics-anti-malware-2020-free-download/")
            End If

            If (ComboBox3.SelectedIndex = 1) Then
                Process.Start("https://getintopc.com/softwares/security/eset-internet-security-2020-free-download/")
            End If

            If (ComboBox3.SelectedIndex = 2) Then
                Process.Start("https://getintopc.com/softwares/security/kaspersky-internet-security-2019-free-download-9802212/")
            End If

            If (ComboBox3.SelectedIndex = 3) Then
                Process.Start("https://getintopc.com/softwares/security/malwarebytes-premium-2019-free-download/")
            End If

            If (ComboBox3.SelectedIndex = 4) Then
                Process.Start("https://getintopc.com/softwares/security/zemana-antimalware-premium-2019-free-download/")
            End If



        End If


























    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim media_Fire As DialogResult
        media_Fire = MessageBox.Show("we upload this file to media fire so rate us thanks!", "CT options", MessageBoxButtons.OK)
        If (media_Fire = DialogResult.OK) Then
            Process.Start("https://www.mediafire.com/file/qh290x84ucn2a66/Activation.zip/file")
        End If
    End Sub


End Class