Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub R_Info2_Click(sender As Object, e As EventArgs) Handles R_Info2.Click
        Log.Text = ("Reading information..")
        Process.Start("cmd", "/k fastboot getvar all")
    End Sub

    Private Sub R_Info_Click(sender As Object, e As EventArgs) Handles R_Info.Click
        Log.Text = ("Reading information..")
        Process.Start("cmd", "/k fastboot getvar all")
    End Sub

    Private Sub R_Info3_Click(sender As Object, e As EventArgs) Handles R_Info3.Click
        Log.Text = ("Reading information..")
        Process.Start("cmd", "/k fastboot getvar all")
    End Sub

    Private Sub R_Info4_Click(sender As Object, e As EventArgs) Handles R_Info4.Click
        Log.Text = ("Reading information..")
        Process.Start("cmd", "/k fastboot getvar all")
    End Sub

    Private Sub Soff_Click(sender As Object, e As EventArgs) Handles Soff.Click
        Log.Text = ("Writing flag 0..")
        Process.Start("cmd", "/k fastboot oem writesecureflag 0").WaitForExit()
    End Sub

    Private Sub Son_Click(sender As Object, e As EventArgs) Handles Son.Click
        Log.Text = ("Writing flag 3..")
        Process.Start("cmd", "/k fastboot oem writesecureflag 3")
    End Sub

    Private Sub ReactorButton4_Click(sender As Object, e As EventArgs) Handles ReactorButton4.Click
        Log.Text = ("Changing CID..")
        Process.Start("cmd", "/k fastboot oem writecid " + CidName.Text)
    End Sub

    Private Sub ResetFRP_Click(sender As Object, e As EventArgs) Handles ResetFRP.Click
        Log.Text = ("Erasing FRP Lock..")
        Process.Start("cmd", "/k fastboot erase frp")
    End Sub

    Private Sub SL1_Click(sender As Object, e As EventArgs) Handles SL1.Click
        Log.Text = ("Clear simlock v1..")
        Process.Start("cmd", "/k fastboot oem clearsimlocktype 0")
    End Sub

    Private Sub SL2_Click(sender As Object, e As EventArgs) Handles SL2.Click
        Log.Text = ("Clear simlock v2..")
        Process.Start("cmd", "/k fastboot oem clearsim 0")
    End Sub

    Private Sub SL3_Click(sender As Object, e As EventArgs) Handles SL3.Click
        Log.Text = ("Clear simlock v3..")
        Process.Start("cmd", "/k fastboot oem network unlock 0")
    End Sub

    Private Sub GOC_Click(sender As Object, e As EventArgs) Handles GOC.Click
        Log.Text = ("Reading oem command..")
        Process.Start("cmd", "/k fastboot oem ?")
    End Sub

    Private Sub GT_Click(sender As Object, e As EventArgs) Handles GT.Click
        Log.Text = ("Reading token..")
        Process.Start("cmd", "/k fastboot oem get_identifier_token")
        MsgBox("https://www.htcdev.com/bootloader/")
    End Sub

    Private Sub UnB_Click(sender As Object, e As EventArgs) Handles UnB.Click
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            Dim pathBL As String = OpenFileDialog2.FileName
            unfilePath.Text = pathBL
            Un_Boot.Enabled = True
        End If
    End Sub

    Private Sub Un_Boot_Tick(sender As Object, e As EventArgs) Handles Un_Boot.Tick
        Un_Boot.Enabled = False
        Process.Start("cmd", "/k fastboot flash unlocktoken " + Chr(34) + unFilePath.Text + Chr(34))
    End Sub

    Private Sub LockB_Click(sender As Object, e As EventArgs) Handles LockB.Click
        Log.Text = ("Relock Bootloader..")
        Process.Start("cmd", "/k fastboot oem lock")
    End Sub

    Private Sub HB_Mode_Click(sender As Object, e As EventArgs) Handles HB_Mode.Click
        Log.Text = ("rebooting to Hboot mode..")
        Process.Start("cmd", "/c fastboot oem gotohboot")
    End Sub

    Private Sub EraseCFG_Click(sender As Object, e As EventArgs) Handles EraseCFG.Click
        Log.Text = ("Erasing Configuration..")
        Process.Start("cmd", "/k fastboot oem eraseconfig")
    End Sub

    Private Sub RB_Click(sender As Object, e As EventArgs) Handles RB.Click
        Log.Text = ("Rebooting to Bootloader Mode..")
        Process.Start("cmd", "/c fastboot reboot-bootloader")
    End Sub

    Private Sub RB2_Click(sender As Object, e As EventArgs) Handles RB2.Click
        Log.Text = ("Rebooting to Bootloader Mode..")
        Process.Start("cmd", "/c fastboot reboot-bootloader")
    End Sub

    Private Sub RB3_Click(sender As Object, e As EventArgs) Handles RB3.Click
        Log.Text = ("Rebooting to Bootloader Mode..")
        Process.Start("cmd", "/c fastboot reboot-bootloader")
    End Sub

    Private Sub RB4_Click(sender As Object, e As EventArgs) Handles RB4.Click
        Log.Text = ("Rebooting to Bootloader Mode..")
        Process.Start("cmd", "/c fastboot reboot-bootloader")
    End Sub

    Private Sub RR_Click(sender As Object, e As EventArgs) Handles RR.Click
        Log.Text = ("Rebooting to RUU Mode..")
        Process.Start("cmd", "/c fastboot oem rebootRUU")
    End Sub

    Private Sub RR2_Click(sender As Object, e As EventArgs) Handles RR2.Click
        Log.Text = ("Rebooting to RUU Mode..")
        Process.Start("cmd", "/c fastboot oem rebootRUU")
    End Sub

    Private Sub RR3_Click(sender As Object, e As EventArgs) Handles RR3.Click
        Log.Text = ("Rebooting to RUU Mode..")
        Process.Start("cmd", "/c fastboot oem rebootRUU")
    End Sub

    Private Sub RR4_Click(sender As Object, e As EventArgs) Handles RR4.Click
        Log.Text = ("Rebooting to RUU Mode..")
        Process.Start("cmd", "/c fastboot oem rebootRUU")
    End Sub

    Private Sub RD_Click(sender As Object, e As EventArgs) Handles RD.Click
        Log.Text = ("Rebooting to Download Mode..")
        Process.Start("cmd", "/c fastboot oem reboot-download")
    End Sub

    Private Sub RD2_Click(sender As Object, e As EventArgs) Handles RD2.Click
        Log.Text = ("Rebooting to Download Mode..")
        Process.Start("cmd", "/c fastboot oem reboot-download")
    End Sub

    Private Sub RD3_Click(sender As Object, e As EventArgs) Handles RD3.Click
        Log.Text = ("Rebooting to Download Mode..")
        Process.Start("cmd", "/c fastboot oem reboot-download")
    End Sub

    Private Sub RD4_Click(sender As Object, e As EventArgs) Handles RD4.Click
        Log.Text = ("Rebooting to Download Mode..")
        Process.Start("cmd", "/c fastboot oem reboot-download")
    End Sub

    Private Sub RS_Click(sender As Object, e As EventArgs) Handles RS.Click
        Log.Text = ("Rebooting..")
        Process.Start("cmd", "/c fastboot reboot")
    End Sub

    Private Sub RS2_Click(sender As Object, e As EventArgs) Handles RS2.Click
        Log.Text = ("Rebooting..")
        Process.Start("cmd", "/c fastboot reboot")
    End Sub

    Private Sub RS3_Click(sender As Object, e As EventArgs) Handles RS3.Click
        Log.Text = ("Rebooting..")
        Process.Start("cmd", "/c fastboot reboot")
    End Sub

    Private Sub RS4_Click(sender As Object, e As EventArgs) Handles RS4.Click
        Log.Text = ("Rebooting..")
        Process.Start("cmd", "/c fastboot reboot")
    End Sub

    Private Sub RF_Click(sender As Object, e As EventArgs) Handles RF.Click
        Process.Start("cmd", "/c fastboot oem reboot-ftm")
    End Sub

    Private Sub RF2_Click(sender As Object, e As EventArgs) Handles RF2.Click
        Process.Start("cmd", "/c fastboot oem reboot-ftm")
    End Sub

    Private Sub RF3_Click(sender As Object, e As EventArgs) Handles RF3.Click
        Process.Start("cmd", "/c fastboot oem reboot-ftm")
    End Sub

    Private Sub RF4_Click(sender As Object, e As EventArgs) Handles RF4.Click
        Process.Start("cmd", "/c fastboot oem reboot-ftm")
    End Sub

    Private Sub RM_Click(sender As Object, e As EventArgs) Handles RM.Click
        Process.Start("cmd", "/c fastboot oem reboot-meta")
    End Sub

    Private Sub RM2_Click(sender As Object, e As EventArgs) Handles RM2.Click
        Process.Start("cmd", "/c fastboot oem reboot-meta")
    End Sub

    Private Sub RM3_Click(sender As Object, e As EventArgs) Handles RM3.Click
        Process.Start("cmd", "/c fastboot oem reboot-meta")
    End Sub

    Private Sub RM4_Click(sender As Object, e As EventArgs) Handles RM4.Click
        Process.Start("cmd", "/c fastboot oem reboot-meta")
    End Sub

    Private Sub RPO_Click(sender As Object, e As EventArgs) Handles RPO.Click
        Process.Start("cmd", "/c fastboot oem powerdown")
    End Sub

    Private Sub RPO2_Click(sender As Object, e As EventArgs) Handles RPO2.Click
        Process.Start("cmd", "/c fastboot oem powerdown")
    End Sub

    Private Sub RPO3_Click(sender As Object, e As EventArgs) Handles RPO3.Click
        Process.Start("cmd", "/c fastboot oem powerdown")
    End Sub

    Private Sub RPO4_Click(sender As Object, e As EventArgs) Handles RPO4.Click
        Process.Start("cmd", "/c fastboot oem powerdown")
    End Sub

    Private Sub ReactorButton46_Click(sender As Object, e As EventArgs) Handles ReactorButton46.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            FlashPath.Text = path
        End If
    End Sub

    Private Sub WriteOS_Click(sender As Object, e As EventArgs) Handles WriteOS.Click
        If (FlashPath.Text.Length = 0) Then
            MsgBox("Wybierz plik oprogramowania !!!")
            Exit Sub
        Else
            Log.Text = ("Rebooting to RUU mode")
            Process.Start("cmd", "/c fastboot oem rebootRUU").WaitForExit()
            TFlash.Enabled = True
        End If
    End Sub

    Private Sub TFlash_Tick(sender As Object, e As EventArgs) Handles TFlash.Tick
        TFlash.Enabled = False
        Log.Text = ("Flashing firmware...")
        Process.Start("cmd", "/k fastboot flash zip " + Chr(34) + FlashPath.Text + Chr(34)).WaitForExit()
        Log.Text = ("Finish.  Rebooting to Bootloader..")
        Process.Start("cmd", "/c fastboot reboot-bootloader").WaitForExit()
    End Sub

    Private Sub WriteRec_Click(sender As Object, e As EventArgs) Handles WriteRec.Click
        Process.Start("cmd", "/k fastboot flash recovery " + Chr(34) + FlashPath.Text + Chr(34))
    End Sub

    Private Sub WriteBoot_Click(sender As Object, e As EventArgs) Handles WriteBoot.Click
        Process.Start("cmd", "/k fastboot flash boot " + Chr(34) + FlashPath.Text + Chr(34))
    End Sub

    Private Sub WriteHOSD_Click(sender As Object, e As EventArgs) Handles WriteHOSD.Click
        Process.Start("cmd", "/k fastboot flash hosd " + Chr(34) + FlashPath.Text + Chr(34))
    End Sub

    Private Sub EraseP_Click(sender As Object, e As EventArgs) Handles EraseP.Click
        If RB_Sys.Checked Then
            Process.Start("cmd", "/k fastboot erase system").WaitForExit()
        End If
        If RB_UD.Checked Then
            Process.Start("cmd", "/k fastboot erase userdata").WaitForExit()
        End If
        If RB_Rec.Checked Then
            Process.Start("cmd", "/k fastboot erase recovery").WaitForExit()
        End If
        If RB_FRP.Checked Then
            Process.Start("cmd", "/k fastboot erase frp").WaitForExit()
        End If
        If RB_Boot.Checked Then
            Process.Start("cmd", "/k fastboot erase boot").WaitForExit()
        End If
        If RB_Cache.Checked Then
            Process.Start("cmd", "/k fastboot erase cache").WaitForExit()
        End If
    End Sub

    Private Sub RI1_Click(sender As Object, e As EventArgs) Handles RI1.Click
        Process.Start("cmd", "/k fastboot getvar imei")
    End Sub

    Private Sub RI2_Click(sender As Object, e As EventArgs) Handles RI2.Click
        Process.Start("cmd", "/k fastboot getvar imei2")
    End Sub

    Private Sub WriteImei1_Click(sender As Object, e As EventArgs) Handles WriteImei1.Click
        Process.Start("cmd", "/k fastboot oem writeimei " + WImei1.Text)
    End Sub

    Private Sub WriteImei2_Click(sender As Object, e As EventArgs) Handles WriteImei2.Click
        Process.Start("cmd", "/k fastboot oem writeimei2 " + WImei2.Text)
    End Sub

    Private Sub RMeid_Click(sender As Object, e As EventArgs) Handles RMeid.Click
        Process.Start("cmd", "/k fastboot getvar meid")
    End Sub

    Private Sub WriteMeid_Click(sender As Object, e As EventArgs) Handles WriteMeid.Click
        Process.Start("cmd", "/k fastboot oem writemeid " + WMeid.Text)
    End Sub

    Private Sub ReadSector_Click(sender As Object, e As EventArgs) Handles ReadSector.Click
        Process.Start("cmd", "/k fastboot oem get_sector_info_emmc")
    End Sub

    Private Sub ReadEMMC_Click(sender As Object, e As EventArgs) Handles ReadEMMC.Click
        Process.Start("cmd", "/k fastboot dump emmc backup.bin 0 " + Rsec.Text)
    End Sub

    Private Sub CheckADB_Click(sender As Object, e As EventArgs) Handles CheckADB.Click
        Process.Start("cmd", "/k adb devices").WaitForExit()
    End Sub

    Private Sub ReactorButton61_Click(sender As Object, e As EventArgs) Handles ReactorButton61.Click
        If OpenFileDialog3.ShowDialog() = DialogResult.OK Then
            Dim A_path As String = OpenFileDialog3.FileName
            APK_Path.Text = A_path
            Ins_APK.Enabled = True
        End If
    End Sub

    Private Sub Ins_APK_Tick(sender As Object, e As EventArgs) Handles Ins_APK.Tick
        Ins_APK.Enabled = False
        Process.Start("cmd", "/k adb install " + Chr(34) + APK_Path.Text + Chr(34)).WaitForExit()
    End Sub

    Private Sub R_B_A_Click(sender As Object, e As EventArgs) Handles R_B_A.Click
        Process.Start("cmd", "/c adb reboot-bootloader")
    End Sub

    Private Sub R_R_A_Click(sender As Object, e As EventArgs) Handles R_R_A.Click
        Process.Start("cmd", "/c adb reboot-recovery")
    End Sub

    Private Sub R_S_A_Click(sender As Object, e As EventArgs) Handles R_S_A.Click
        Process.Start("cmd", "/c adb reboot")
    End Sub
End Class
