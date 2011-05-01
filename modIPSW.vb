'w3st05
Imports Ionic.Zip
Imports ICSharpCode.SharpZipLib.Zip
Imports ICSharpCode.SharpZipLib.Zip.Compression
Imports System.IO

Module modIPSW
    'custom vars
    Public FINALRESIZE As String = ""
    Public IPSWVersion As String = ""
    Public iPhoneModel As String = ""
    Public iPod2GModel As String = ""
    Public iDevice As String = ""
    Public PreviousModel As String = ""
    Public ScreenSize As String = ""
    Public PreviousVersion As String = ""
    Public UserMode As String = ""
    Public ipsw As String = ""
    Public iBootyPath As String = ""
    Public NOR As Boolean = False
    Public InstallMS As Boolean = False
    Public stage As Int32 = 0
    Public PartitionSize As Int32 = 800
    Public ActivatePhone As Boolean = False
    Public EnableMultiTasking As Boolean = False
    Public DoiAsk As Boolean = False
    Public EnablePercentage As Boolean = False
    Public EnableWallpaper As Boolean = False
    Public EnableHDR As Boolean = False
    Public InstallSSH As Boolean = False
    Public UseUniPod As Boolean = False
    Public NORFlashDisabled As Boolean = False
    Public iBootyMethod As Boolean = False
    Public CydiaSelected As Boolean = True
    Public RockSelected As Boolean = False
    Public BootNeuter As Boolean = False
    Public BootneuterSelected As Boolean = False
    Public UseCustomBootLogo As Boolean = True
    Public BootLogo As String = "BootLogo.png"
    Public VerboseMode As Boolean = False
    Public UseCustomRecoveryLogo As Boolean = True
    Public RecoveryLogo As String = "RecoveryLogo.png"
    Public UseCustomLockBackground As Boolean = True
    Public CustomApps As String = ""
    Public DoIpatchKernel As Boolean = False
    Public DoIGiveAshit As Boolean = False
    Public JustPreserveBaseband As Boolean = False
    Public This3GSisold As Boolean = False
    Public DoIDeleteBuildManifest As Boolean = False
    Public Usepod2gsAwesomeKernelExploit As Boolean = False
    Public ThisiPodisMB As Boolean = False
    Public iWantziPadBB As Boolean = False
    Public iWantzAnimate As Boolean = False
    Public ICE2_iPad_eepPath As String = ""
    Public ICE2_iPad_flsPath As String = ""
    Public ICE2eepPath As String = ""
    Public ICE2flsPath As String = ""

    'build vars
    Public Bundle As String = ""
    Public Kernel As String = ""
    Public KernelPatched As String = ""
    Public ModelVar As String = ""
    Public RootFS As String = ""
    Public RootFSKey As String = ""
    Public Ramdisk As String = ""
    Public Board As String = ""
    Public RamdiskIV As String = ""
    Public RamdiskKey As String = ""
    Public iBootkIV As String = ""
    Public iBootKey As String = ""
    Public iBECIV As String = ""
    Public iBECKey As String = ""
    Public iBSSIV As String = ""
    Public iBSSKey As String = ""
    Public LLBIV As String = ""
    Public LLBKey As String = ""
    Public applelogoIV As String = ""
    Public applelogoKey As String = ""
    Public DeviceTreeIV As String = ""
    Public DeviceTreeKey As String = ""
    Public RecoveryModeIV As String = ""
    Public batfullIV As String = ""
    Public batfullKey As String = ""
    Public RecoveryModeKey As String = ""
    Public KernelCacheIV As String = ""
    Public KernelCacheKey As String = ""
    Public RootFSsize As Int32 = 1
    Public WTFIV As String = ""
    Public WTFKey As String = ""
    Public WTF2IV As String = ""
    Public WTF2Key As String = ""
    Public PatchWTF As Boolean = False
    Public Unwanted As String = ""
    Public WeNeedDeviceTree As Boolean = False
    Public Sub GetIPSWVars()
        If iPhoneModel = "iPad" Then
            Bundle = "iPad1,1_4.3.2_8H7.bundle"
            Kernel = "s5l8930x"
            ModelVar = "k48ap"
            Board = "k48"
            RootFS = "038-1024-007"
            RootFSKey = "25c0b2a27afd23b9ddc9555a28ba8e77548e62d9e2ef56700bc40d22b2c50416aee9313c"
            Ramdisk = "038-1035-007"
            RamdiskIV = ""
            RamdiskKey = ""
            iBootkIV = ""
            iBootKey = ""
            iBECIV = ""
            iBECKey = ""
            iBSSIV = "de7258db01e653c6d8ffe0ab18a5a5c7"
            iBSSKey = "6d0afca5d390a7e48399cd534c8fd7db5a3f8fd4361631f6dffca75fbafca6aa"
            LLBIV = ""
            LLBKey = ""
            batfullIV = ""
            batfullKey = ""
            applelogoIV = ""
            applelogoKey = ""
            RecoveryModeIV = ""
            RecoveryModeKey = ""
            KernelCacheIV = ""
            KernelCacheKey = ""
            Unwanted = "038-1031-007"
            DoIDeleteBuildManifest = False
        ElseIf iPhoneModel = "iPod Touch 3G" Then
            Bundle = "iPod3,1_4.3.2_8H7.bundle"
            Kernel = "s5l8922x"
            ModelVar = "n18ap"
            Board = "n18"
            RootFS = "038-1040-007"
            RootFSKey = "7085a2976bd57eceedcbbe88a270e1a5028133c288b8afb122c2f886830a9a641daf8bd4"
            Ramdisk = "038-1034-007"
            RamdiskIV = ""
            RamdiskKey = ""
            iBootkIV = ""
            iBootKey = ""
            iBECIV = ""
            iBECKey = ""
            iBSSIV = "a4ff016010ce6831cae2a7009113c16f"
            iBSSKey = "f7e6576f69cbcefbe96939efa39600cada2e13d12a6372499eff67f0566b86d2"
            LLBIV = ""
            LLBKey = ""
            DeviceTreeIV = ""
            DeviceTreeKey = ""
            applelogoIV = ""
            applelogoKey = ""
            RecoveryModeIV = ""
            RecoveryModeKey = ""
            KernelCacheIV = ""
            KernelCacheKey = ""
            Unwanted = "038-1039-007"
            DoIDeleteBuildManifest = False
        ElseIf iPhoneModel = "iPod Touch 4" Then
            Bundle = "iPod4,1_4.3.2_8H7.bundle"
            Kernel = "s5l8930x"
            ModelVar = "n81ap"
            Board = "n81"
            RootFS = "038-1023-007"
            RootFSKey = "401b22ae26cca1aa2e119c17a6c389a1ba6aea0fbff4912000a77df953f010637b35d0ee"
            Ramdisk = "038-1035-007"
            RamdiskIV = ""
            RamdiskKey = ""
            iBootkIV = ""
            iBootKey = ""
            iBECIV = ""
            iBECKey = ""
            iBSSIV = "682684c4247740ca26c6823e58a36cdf"
            iBSSKey = "ac17ad4e4e65d5d988b28bde260ade08a7b3f284a22b03a386b53dd761b4ccb5"
            LLBIV = ""
            LLBKey = ""
            batfullIV = ""
            batfullKey = ""
            applelogoIV = ""
            applelogoKey = ""
            RecoveryModeIV = ""
            RecoveryModeKey = ""
            KernelCacheIV = ""
            KernelCacheKey = ""
            Unwanted = "038-1031-007"
            DoIDeleteBuildManifest = False
        ElseIf iPhoneModel = "iPhone 3GS" Then
            Bundle = "iPhone2,1_4.3.2_8H7.bundle"
            Kernel = "s5l8920x"
            ModelVar = "n88ap"
            ICE2eepPath = "/usr/local/standalone/firmware/ICE2_05.16.02.eep"
            ICE2flsPath = "/usr/local/standalone/firmware/ICE2_05.16.02.fls"
            ICE2_iPad_eepPath = "/usr/local/standalone/firmware/ICE2_06.15.00.eep"
            ICE2_iPad_flsPath = "/usr/local/standalone/firmware/ICE2_06.15.00.fls"
            Board = "n88"
            RootFS = "038-1022-007"
            RootFSKey = "69a370c1b64b35f692e87e866bcd460a98a10c56ed05055eb7c675f101894ea504f7bc46"
            Ramdisk = "038-1033-007"
            RamdiskIV = ""
            RamdiskKey = ""
            iBootkIV = "096984dbafb19c1c708e5c7b1299f269"
            iBootKey = "6d14c496a0fe42f49898b06c70dca353a6634f67003715830c0c45b6aa822cbc"
            iBECIV = "0034860a2b91ffc9d09471d02f98d06d"
            iBECKey = "124ddf2693a216e33a6645e3624ba4cbeda541e42aed603162fc4c49a6795abf"
            iBSSIV = "181ee0b292538b2052dbd119770d7348"
            iBSSKey = "f131471b406795abf7ae70617dd30968e5ad6b847b84a1671d5801c04fc07643"
            LLBIV = "b889e456f735ee52858cca09df3c5909"
            LLBKey = "d700547fd945b5be12ec74f578838c746093ff7317e09fff1c88039989d2f7e3"
            applelogoIV = ""
            applelogoKey = ""
            RecoveryModeIV = ""
            RecoveryModeKey = ""
            KernelCacheIV = ""
            KernelCacheKey = ""
            Unwanted = "038-1030-007"
            If This3GSisold = True Then
                DoIDeleteBuildManifest = True
            Else
                DoIDeleteBuildManifest = False
            End If
        ElseIf iPhoneModel = "iPhone 4" And ModelVar = "n90ap" Then
            Bundle = "iPhone3,1_4.3.2_8H7.bundle"
            Kernel = "s5l8930x"
            ModelVar = "n90ap"
            Board = "n90"
            RootFS = "038-1025-007"
            RootFSKey = "30804cac61ba4df96999aa4e1ea3a2a18bfbe875534a66a0bb1add095e307a19a7176c82"
            Ramdisk = "038-1035-007"
            RamdiskIV = ""
            RamdiskKey = ""
            iBootkIV = ""
            iBootKey = ""
            iBECIV = ""
            iBECKey = ""
            iBSSIV = "cdd50b45ca1bac4f718d9eb23ce9f0a8"
            iBSSKey = "8ef00005aa2c01ae409d55e330171589af79d76ac86639e76003835d5d82ffc4"
            LLBIV = ""
            LLBKey = ""
            applelogoIV = ""
            applelogoKey = ""
            RecoveryModeIV = ""
            RecoveryModeKey = ""
            KernelCacheIV = ""
            KernelCacheKey = ""
            Unwanted = "038-1031-007"
            ScreenSize = "640x960"
            DoIDeleteBuildManifest = False
        ElseIf iPhoneModel = "iPhone 4" And ModelVar = "n92ap" Then
            Bundle = "iPhone3,3_4.2.7_8E303.bundle"
            Kernel = "s5l8930x"
            ModelVar = "n92ap"
            Board = "n92"
            RootFS = "038-0970-004"
            RootFSKey = "612f78042ddc5337ab1abecfb59a07e88ed3e80665a035ef02c3c48045057fc29ab0a4b5"
            Ramdisk = "038-0974-004"
            RamdiskIV = "8d612fbab555c8e8f548898b0e6d3cb0"
            RamdiskKey = "9ca594fef56655a7ad4dc1312dc4a499851d832c2eeb86f5a9ebfabe08ccedb6"
            iBootkIV = ""
            iBootKey = ""
            iBECIV = ""
            iBECKey = ""
            iBSSIV = "6863087c07128d170db61316205c5a45"
            iBSSKey = "cabd9afa6d7678f3f95d0ccf43d18f54e4ee2e6ac8025b2a528f3b07579ec305"
            LLBIV = ""
            LLBKey = ""
            applelogoIV = ""
            applelogoKey = ""
            RecoveryModeIV = ""
            RecoveryModeKey = ""
            KernelCacheIV = ""
            KernelCacheKey = ""
            Unwanted = "038-0971-004"
            ScreenSize = "640x960"
            DoIDeleteBuildManifest = False
        ElseIf iPhoneModel = "Apple TV 2" Then
            Bundle = "AppleTV2,1_4.3_8F202.bundle"
            Kernel = "s5l8930x"
            ModelVar = "k66ap"
            Board = "k66"
            RootFS = "038-0943-003"
            RootFSKey = "7fb6a5a1a5d74ceb61180c8740065b79ac87a5c15e554ad4b147ae9e1446254acc9d5e4a"
            Ramdisk = "038-0946-003"
            RamdiskIV = "87af8e20133c17d45dab42702eeb136d"
            RamdiskKey = "d9a0258b4f25101b15e260663937c3f6cda748d051bebe09212f51f0be72a89f"
            iBootkIV = ""
            iBootKey = ""
            iBECIV = ""
            iBECKey = ""
            iBSSIV = "17742baec33113889e5cbfcaa12fb4f0"
            iBSSKey = "998bd521b5b54641fbeb3f73d9959bae126db0bc7e90b7ede7440d3951016010"
            LLBIV = ""
            LLBKey = ""
            applelogoIV = ""
            applelogoKey = ""
            RecoveryModeIV = ""
            RecoveryModeKey = ""
            KernelCacheIV = ""
            KernelCacheKey = ""
            Unwanted = ""
            ScreenSize = "640x960"
            DoIDeleteBuildManifest = False
        End If
    End Sub
    Public Sub ExtractIPSW()
        Using zip1 As Ionic.Zip.ZipFile = Ionic.Zip.ZipFile.Read(ipsw)
            zip1.ExtractAll(tempPath & "\IPSW\")
            zip1.Dispose()
        End Using
    End Sub
    Public Sub PatchKernel()
        Exit Sub
    End Sub
    Public Sub DecryptRoofFS()
        Rename_File(tempPath & "\IPSW\" & RootFS & ".dmg", RootFS & ".dmg.orig")

        dmg_decrypt(tempPath & "\IPSW\" & RootFS & ".dmg.orig", tempPath & "\IPSW\DECRYPTED.dmg", RootFSKey)

        Delete_File(tempPath & "\IPSW\" & RootFS & ".dmg.orig")
    End Sub
    Public Sub vfdecrypt_rootfs()
        Rename_File(tempPath & "\IPSW\" & RootFS & ".dmg", RootFS & ".dmg.orig")

        vfdecrypt(tempPath & "\IPSW\" & RootFS & ".dmg.orig", tempPath & "\IPSW\" & RootFS & ".dmg", RootFSKey)

        Delete_File(tempPath & "\IPSW\" & RootFS & ".dmg.orig")
    End Sub
    Public Function ConvertMegabytesToBytes(ByVal megabytes As Double) As Double
        FINALRESIZE = megabytes * 1048576
    End Function
    Public Sub AddCydia()
        Delete_File(tempPath & "\Cydia.tar")
        Delete_File(tempPath & "\Cydia.zip")
        Delete_File(tempPath & "\Cydia_atv.zip")
        '
        If iPhoneModel = "Apple TV 2" Then
            If File_Exists(tempPath & "\Cydia_atv.tar") = False Then
                SaveToDisk("Cydia_atv.zip", tempPath & "\Cydia_atv.zip")
                Using zip1 As Ionic.Zip.ZipFile = Ionic.Zip.ZipFile.Read(tempPath & "\Cydia_atv.zip")
                    zip1.ExtractAll(tempPath & "\", True)
                    zip1.Dispose()
                End Using
            End If
            hfsplus_untar(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\Cydia.tar")
        Else
            ConvertMegabytesToBytes(PartitionSize)
            hfsplus_grow(tempPath & "\IPSW\DECRYPTED.dmg", FINALRESIZE)
            '
            If File_Exists(tempPath & "\Cydia.tar") = False Then
                SaveToDisk("Cydia.zip", tempPath & "\Cydia.zip")
                Using zip1 As Ionic.Zip.ZipFile = Ionic.Zip.ZipFile.Read(tempPath & "\Cydia.zip")
                    zip1.ExtractAll(tempPath & "\", True)
                    zip1.Dispose()
                End Using
            End If
            hfsplus_untar(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\Cydia.tar")
        End If
        File_Delete(tempPath & "\Cydia.zip")
        File_Delete(tempPath & "\Cydia.tar")
        File_Delete(tempPath & "\Cydia_atv.zip")
        File_Delete(tempPath & "\Cydia_atv.tar")
    End Sub
    Public Sub AddDebs()
        If iPhoneModel = "Apple TV 2" Then
            Exit Sub
        End If
        Dim DoNotInstallDebs = "bash" 'separate by , - name,name2,name3 etc.
        Dim installDeb As Boolean = True
        Dim DoNotInstallDebsArray
        DoNotInstallDebsArray = Split(DoNotInstallDebs, ",")

        If UserMode = "Simple" Then
            hfsplus_addall(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\debs")
        ElseIf UserMode = "Expert" Then

            'main deb
            For Each item In ecustomapps.lvSelectPackages.Items
                If item.Checked = True Then

                    'check to see if it should be installed
                    For Each deb In DoNotInstallDebsArray
                        If item.SubItems(4).text.indexof(deb) <> -1 Then
                            'we have a match
                            installDeb = False
                        End If
                    Next

                    If installDeb = True Then File_Copy(tempPath & "\debsCustom\" & item.SubItems(4).Text, tempPath & "\debs\private\var\root\Media\Cydia\AutoInstall\" & item.SubItems(4).Text, True)
                    installDeb = True


                    'dependants
                    If item.SubItems(5).Text <> "" Then
                        Dim dependants
                        dependants = Split(item.SubItems(5).Text, ",")
                        For Each item2 In dependants

                            'check to see if it should be installed
                            For Each deb In DoNotInstallDebsArray
                                If item2.indexof(deb) <> -1 Then
                                    'we have a match
                                    installDeb = False
                                End If
                            Next

                            If installDeb = True Then File_Copy(tempPath & "\debsCustom\" & item2, tempPath & "\debs\private\var\root\Media\Cydia\AutoInstall\" & item2, True)
                            installDeb = True
                        Next
                    End If
                End If
            Next

            hfsplus_addall(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\debs")

        End If
    End Sub
    Public Sub PatchFSTAB()
        hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/etc/fstab", "/etc/fstab_orig")
        hfsplus_extract(tempPath & "\IPSW\DECRYPTED.dmg", "/etc/fstab_orig", tempPath & "\fstab.orig")
        bspatch(tempPath & "\fstab.orig", tempPath & "\fstab.pwned", tempPath & "\fstab.patch")
        hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\fstab.pwned", "/etc/fstab")
    End Sub
    Public Sub PatchServices()
        ' Exit Sub
        hfsplus_extract(tempPath & "\IPSW\DECRYPTED.dmg", "/System/Library/Lockdown/Services.plist", tempPath & "\Services.plist.orig")
        hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/System/Library/Lockdown/Services.plist", "/System/Library/Lockdown/Services.plist.backup")
        bspatch(tempPath & "\Services.plist.orig", tempPath & "\Services.plist", tempPath & "\Services.patch")
        hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\Services.plist", "/System/Library/Lockdown/Services.plist")
    End Sub
    Public Sub DecryptRamdisk()
        Rename_File(tempPath & "\IPSW\" & Ramdisk & ".dmg", Ramdisk & ".dmg.orig")

        If iPhoneModel = "Apple TV 2" Or ModelVar = "n92ap" Then
            xpwntool(tempPath & "\IPSW\" & Ramdisk & ".dmg.orig", tempPath & "\IPSW\ramdisk_decrypted.dmg", RamdiskIV, RamdiskKey)
        Else
            xpwntool_nokeys(tempPath & "\IPSW\" & Ramdisk & ".dmg.orig", tempPath & "\IPSW\ramdisk_decrypted.dmg")
        End If
    End Sub
    Public Sub Stash_Da_Shit()
        If ModelVar = "n92ap" Then
            'Verizon iPhones/Apple TVs don't like dis. :P
            Exit Sub
        End If
        'Make Directories...
        hfsplus_mkdir(tempPath & "\IPSW\DECRYPTED.dmg", "/private/var/stash")

        'Move Zee files...
        hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/Applications", "/private/var/stash/Applications")
        hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/Library/Ringtones", "/private/var/stash/Ringtones")
        hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/Library/Wallpaper", "/private/var/stash/Wallpaper")
        ' hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/bin", "/private/var/stash/bin")
        hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/include", "/private/var/stash/include")
        hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/libexec", "/private/var/stash/libexec")
        hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/lib/pam", "/private/var/stash/pam")
        hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/share", "/private/var/stash/share")

        'Making dem' symlinks...
        hfsplus_symlink(tempPath & "\IPSW\DECRYPTED.dmg", "/Applications", "/private/var/stash/Applications")
        hfsplus_symlink(tempPath & "\IPSW\DECRYPTED.dmg", "/Library/Ringtones", "/private/var/stash/Ringtones")
        hfsplus_symlink(tempPath & "\IPSW\DECRYPTED.dmg", "/Library/Wallpaper", "/private/var/stash/Wallpaper")
        'hfsplus_symlink(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/bin", "/private/var/stash/bin")
        hfsplus_symlink(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/include", "/private/var/stash/include")
        hfsplus_symlink(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/lib/pam", "/private/var/stash/pam")
        hfsplus_symlink(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/libexec", "/private/var/stash/libexec")
        hfsplus_symlink(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/share", "/private/var/stash/share")
    End Sub
    Public Sub Fix_animate()
        If iWantzAnimate = True Then
            iWantzAnimate = False
            'Dramatic Background music. GO!
            SaveToDisk("animate", tempPath & "\animate")
            SaveToDisk("pie", tempPath & "\pie")
            SaveToDisk("animate.deb", tempPath & "\animate.deb")
            'Adding Binary...
            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\animate", "/usr/bin/animate")
            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/bin/animate", "100755")
            'Adding Deb...
            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\animate.deb", "/private/var/root/Media/Cydia/AutoInstall")
            'Adding fix...
            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\pie", "/sbin/crunchd")
            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/sbin/crunchd", "100755")
            'Stop the Dramatic Background music. NOW!!!! >:O
        Else
            Exit Sub
        End If
    End Sub
    Public Sub AddUltimateness()
        'Moving original launchd...
        If ModelVar = "n92ap" Then
            'Alright!!! Were going Verizon style. Slowly!!! ;D
            '
            'Moving that fucking piece of shit launchd.
            hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/sbin/launchd", "/sbin/punchd")
            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/sbin/punchd", "100755")
            hfsplus_chown(tempPath & "\IPSW\DECRYPTED.dmg", "/sbin/punchd", "0", "80")
            'Adding Kernel exploit (payload)...
            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\kern_sploit", "/usr/lib/kern_sploit")
            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/lib/kern_sploit", "100755")
            hfsplus_chown(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/lib/kern_sploit", "0", "80")
            'Adding hfs overflow (AKA pod2g love)...
            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\hfs_mdb", "/usr/lib/hfs_mdb")
            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/lib/hfs_mdb", "100755")
            hfsplus_chown(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/lib/hfs_mdb", "0", "80")
            'Add custom launchd...
            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\launchd", "/sbin/launchd")
            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/sbin/launchd", "104755")
            'Add iBooks fix...
            hfsplus_extract(tempPath & "\IPSW\DECRYPTED.dmg", "System/Library/LaunchDaemons/com.apple.fairplayd.N92.plist", tempPath & "\fairplay.plist.orig")
            bspatch(tempPath & "\fairplay.plist.orig", tempPath & "\fairplay.plist", tempPath & "\fairplayd.patch")
            hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "System/Library/LaunchDaemons/com.apple.fairplayd.N92.plist", "System/Library/LaunchDaemons/com.apple.fairplayd.N92.orig")
            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\fairplay.plist", "System/Library/LaunchDaemons/com.apple.fairplayd.N92.plist")
            'Add the dylib QUICK!!!!
            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\hunnypot.dylib", "/usr/lib/hunnypot.dylib")
            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/lib/hunnypot.dylib", "100755")
            '
            Delete_File(tempPath & "\fairplay.plist.orig")
            Delete_File(tempPath & "\fairplay.plist")
            If iWantzAnimate = True Then
                'Adding animate...
                SaveToDisk("animate", tempPath & "\animate")
                SaveToDisk("animate.deb", tempPath & "\animate.deb")
                'Adding Binary...
                hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\animate", "/usr/bin/animate")
                hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/bin/animate", "100755")
                'Adding Deb...
                hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\animate.deb", "/private/var/root/Media/Cydia/AutoInstall")
            End If
            'Done.
            Exit Sub
        End If

        If iWantzAnimate = True Then
            If iPhoneModel = "Apple TV 2" Then
                hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/sbin/launchd", "/sbin/crunchd")
            Else
                hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/sbin/launchd", "/sbin/crunchy")
            End If
        Else
            hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/sbin/launchd", "/sbin/crunchd")
        End If

        'Add custom launchd...
        hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\launchd", "/sbin/launchd")
        hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/sbin/launchd", "104755")

        If iPhoneModel = "Apple TV 2" Then
            'Ignore Me.
        Else
            Call Fix_animate()
        End If
    End Sub
    Public Sub PatchRamdisk()
        hfsplus_grow(tempPath & "\IPSW\ramdisk_decrypted.dmg", "27500000")

        hfsplus_extract(tempPath & "\IPSW\ramdisk_decrypted.dmg", "/usr/sbin/asr", tempPath & "\asr.orig")
        hfsplus_mv(tempPath & "\IPSW\ramdisk_decrypted.dmg", "/usr/sbin/asr", "/usr/sbin/asr_orig")
        bspatch(tempPath & "\asr.orig", tempPath & "\asr", tempPath & "\asr.patch")
        hfsplus_add(tempPath & "\IPSW\ramdisk_decrypted.dmg", tempPath & "\asr", "/usr/sbin/asr")
        hfsplus_chmod(tempPath & "\IPSW\ramdisk_decrypted.dmg", "/usr/sbin/asr", "100755")


        'Sexiness -- START
        If iPhoneModel = "Apple TV 2" Then
            'Ignore meh...
        Else
            hfsplus_rm(tempPath & "\IPSW\ramdisk_decrypted.dmg", "/usr/share/progressui/images-1x/applelogo.png")
            hfsplus_rm(tempPath & "\IPSW\ramdisk_decrypted.dmg", "/usr/share/progressui/images-2x/applelogo.png")

            hfsplus_add(tempPath & "\IPSW\ramdisk_decrypted.dmg", tempPath & "\applelogox1.png", "/usr/share/progressui/images-1x/applelogo.png")
            hfsplus_add(tempPath & "\IPSW\ramdisk_decrypted.dmg", tempPath & "\applelogox2.png", "/usr/share/progressui/images-2x/applelogo.png")
        End If
        'Sexiness -- STOP

        ReplateText(tempPath & "\options.plist", tempPath & "\options2.plist", "<--DO-I-FLASH-NOR1-->", "")
        ReplateText(tempPath & "\options2.plist", tempPath & "\options3.plist", "<--DO-I-FLASH-NOR2-->", "")

        'size changed so create custom options.plist
        ReplateText(tempPath & "\options3.plist", tempPath & "\options4.plist", "<integer>800</integer>", "<integer>" & PartitionSize & "</integer>")

        If iWantziPadBB = True Then
            ReplateText(tempPath & "\options4.plist", tempPath & "\optionsCustom.plist", "<--DO-I-FLASH-BB-->", "<true/>")
        Else
            ReplateText(tempPath & "\options4.plist", tempPath & "\optionsCustom.plist", "<--DO-I-FLASH-BB-->", "<false/>")
        End If
        If iPhoneModel = "Apple TV 2" Then
            hfsplus_mv(tempPath & "\IPSW\ramdisk_decrypted.dmg", "/usr/local/share/restore/options.plist", "/usr/local/share/restore/options.plist.orig")
            hfsplus_mv(tempPath & "\IPSW\ramdisk_decrypted.dmg", "/usr/local/share/restore/options.k66.plist", "/usr/local/share/restore/options.k66.plist.orig")
            hfsplus_add(tempPath & "\IPSW\ramdisk_decrypted.dmg", tempPath & "\optionsCustom.plist", "/usr/local/share/restore/options.k66.plist")
        Else
            hfsplus_add(tempPath & "\IPSW\ramdisk_decrypted.dmg", tempPath & "\optionsCustom.plist", "/usr/local/share/restore/options.plist")
        End If
        Delete_File(tempPath & "\optionsCustom.plist")

        If JustPreserveBaseband = True Then
            Call RebuildRamdisk()
        End If
    End Sub
    Public Sub RebuildRamdisk()
        xpwntool_template(tempPath & "\IPSW\ramdisk_decrypted.dmg", tempPath & "\IPSW\" & Ramdisk & ".dmg", tempPath & "\IPSW\" & Ramdisk & ".dmg.orig", RamdiskIV, RamdiskKey)

        Delete_File(tempPath & "\IPSW\" & Ramdisk & ".dmg.orig")
        Delete_File(tempPath & "\IPSW\ramdisk_decrypted.dmg")
    End Sub
    Public Sub PatchiBSS()
        'For Use in iREB -- Start
        If iPhoneModel = "iPhone 3GS" Then
            SaveToDisk("wait.img3", tempPath2 & "\iPhone3GS.True")
            SaveToDisk("pois0n.exe", tempPath2 & "\pois0n.exe")
        ElseIf iPhoneModel = "iPhone 4" Then
            SaveToDisk("wait.img3", tempPath2 & "\iPhone4.True")
            SaveToDisk("pois0n.exe", tempPath2 & "\pois0n.exe")
        ElseIf iPhoneModel = "iPod Touch 3G" Then
            SaveToDisk("wait.img3", tempPath2 & "\iPod3G.True")
            SaveToDisk("pois0n.exe", tempPath2 & "\pois0n.exe")
        ElseIf iPhoneModel = "iPod Touch 4" Then
            SaveToDisk("wait.img3", tempPath2 & "\iPod4.True")
            SaveToDisk("pois0n.exe", tempPath2 & "\pois0n.exe")
        ElseIf iPhoneModel = "iPad" Then
            SaveToDisk("wait.img3", tempPath2 & "\iPad.True")
            SaveToDisk("pois0n.exe", tempPath2 & "\pois0n.exe")
        ElseIf iPhoneModel = "Apple TV 2" Then
            SaveToDisk("wait.img3", tempPath2 & "\AppleTV2.True")
            SaveToDisk("pois0n.exe", tempPath2 & "\pois0n.exe")
        End If
        'For use in iREB -- End

        Rename_File(tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu", "iBSS." & ModelVar & ".RELEASE.dfu.orig")

        xpwntool(tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.orig", tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.decrypted", iBSSIV, iBSSKey)

        If This3GSisold = True Then
            bspatch(tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.decrypted", tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.patched", tempPath & "\iBSS." & ModelVar & ".RELEASE-old.patch")
        Else
            bspatch(tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.decrypted", tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.patched", tempPath & "\iBSS." & ModelVar & ".RELEASE.patch")
        End If
            xpwntool_template(tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.patched", tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu", tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.orig", iBSSIV, iBSSKey)

        Delete_File(tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.patched")
        Delete_File(tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.decrypted")
        Delete_File(tempPath & "\IPSW\Firmware\dfu\iBSS." & ModelVar & ".RELEASE.dfu.orig")
    End Sub
    Public Sub AddBootLogo()
        If This3GSisold = True Then
            SaveToDisk("rawr.img3", tempPath & "\rawr.img3")
            SaveToDisk("BootLogo.png", tempPath & "\BootLogo.png")
            If UserMode = "Simple" Or (UserMode = "Expert" And UseCustomBootLogo = True) Then
                cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\applelogo." & Kernel & ".img3"" /f /q"""
                ExecCmd(cmdline, True)
                cmdline = DFU.quote.Text & tempPath & "\imagetool.exe" & DFU.quote.Text & " inject " & DFU.quote.Text & tempPath & "\" & BootLogo & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\applelogo." & Kernel & ".img3" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\rawr.img3" & DFU.quote.Text
                ExecCmd(cmdline, True)
            End If
            File_Delete(tempPath & "\BootLogo.png")
        End If
    End Sub
    Public Sub AddCustomImages()
        If This3GSisold = True Then
            SaveToDisk("rawr.img3", tempPath & "\rawr.img3")
            SaveToDisk("RecoveryLogo.png", tempPath & "\RecoveryLogo.png")
            If UserMode = "Simple" Then
                cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\recoverymode." & Kernel & ".img3"" /f /q"""
                ExecCmd(cmdline, True)

                cmdline = DFU.quote.Text & tempPath & "\imagetool.exe" & DFU.quote.Text & " inject " & DFU.quote.Text & tempPath & "\" & RecoveryLogo & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\recoverymode." & Kernel & ".img3" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\rawr.img3" & DFU.quote.Text
                ExecCmd(cmdline, True)
            ElseIf UserMode = "Expert" Then
                If UseCustomRecoveryLogo = True Then
                    cmdline = "cmd /c ""DEL """ & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\recoverymode." & Kernel & ".img3"" /f /q"""
                    ExecCmd(cmdline, True)

                    cmdline = DFU.quote.Text & tempPath & "\imagetool.exe" & DFU.quote.Text & " inject " & DFU.quote.Text & tempPath & "\" & RecoveryLogo & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\recoverymode." & Kernel & ".img3" & DFU.quote.Text & " " & DFU.quote.Text & tempPath & "\rawr.img3" & DFU.quote.Text
                    ExecCmd(cmdline, True)
                End If
            End If
            File_Delete(tempPath & "\RecoveryLogo.png")
        End If

    End Sub
    Public Sub PatchLLB()
        If This3GSisold = True Then
            Rename_File(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\LLB." & ModelVar & ".RELEASE.img3", "LLB." & ModelVar & ".RELEASE.img3.orig")
            bspatch(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\LLB." & ModelVar & ".RELEASE.img3.orig", tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\LLB." & ModelVar & ".RELEASE.img3", tempPath & "\LLB." & ModelVar & ".RELEASE.patch")
            Delete_File(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\LLB." & ModelVar & ".RELEASE.img3.orig")
        End If
    End Sub
    Public Sub InstallingSSH()
        If File_Exists(tempPath & "\OpenSSH.tar") = False Then
            SaveToDisk("OpenSSH.zip", tempPath & "\OpenSSH.zip")
            Using zip1 As Ionic.Zip.ZipFile = Ionic.Zip.ZipFile.Read(tempPath & "\OpenSSH.zip")
                zip1.ExtractAll(tempPath & "\", True)
                zip1.Dispose()
            End Using
        End If
        File_Delete(tempPath & "\OpenSSH.zip")

        hfsplus_untar(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\OpenSSH.tar")

        InstallSSH = False
        File_Delete(tempPath & "\OpenSSH.tar")
    End Sub
    Public Sub Uploadkernel()
        'We can all dream...
        Exit Sub
    End Sub
    Public Sub DownloadiPadBaseband()
        SaveToDisk("msvcr100d.dll", tempPath & "\msvcr100d.dll")
        SaveToDisk("dl-bb.exe", tempPath & "\dl-bb.exe")

        cmdline = Quotation & tempPath & "\dl-bb.exe" & Quotation
        ExecCmd(cmdline, True)

        'Give it time to write to buffer.
        Sleep(2000)
        If File_Exists(tempPath & "\018-8374-001.dmg") = False Then
            MsgBox("Download FAILED! ABORTING...")
            Application.Exit()
        End If
    End Sub
    Public Sub iPadBaseband()
        'Moving cows...
        hfsplus_mv(tempPath & "\IPSW\ramdisk_decrypted.dmg", ICE2eepPath, ICE2eepPath & ".orig")
        hfsplus_mv(tempPath & "\IPSW\ramdisk_decrypted.dmg", ICE2flsPath, ICE2flsPath & ".orig")
        'Sorry cows...
        hfsplus_rm(tempPath & "\IPSW\ramdisk_decrypted.dmg", ICE2eepPath & ".orig")
        hfsplus_rm(tempPath & "\IPSW\ramdisk_decrypted.dmg", ICE2flsPath & ".orig")
        'You gotta be fucking kidding me...
        hfsplus_rm(tempPath & "\IPSW\ramdisk_decrypted.dmg", "/usr/local/standalone/firmware/ICE2_07.11.01.fls")
        hfsplus_rm(tempPath & "\IPSW\ramdisk_decrypted.dmg", "/usr/local/standalone/firmware/ICE2_07.11.01.eep")
        hfsplus_rm(tempPath & "\IPSW\ramdisk_decrypted.dmg", "/usr/local/standalone/firmware/Phoenix-2.0.4.zip")
        'Decrypt iPad 3.2.2 Ramdisk...
        xpwntool(tempPath & "\018-8374-001.dmg", tempPath & "\ipad_ramdisk.dmg", "3f6f0bdb71a33c801a9b67a616e9cfe3", "3188be37002aef49c9f54d91da23857f89045118c2bb1e6f1db906c98dbb5230")
        'Grab 06.15.00...
        hfsplus_extract(tempPath & "\ipad_ramdisk.dmg", ICE2_iPad_eepPath, tempPath & "\iPad.06.15.00.eep")
        hfsplus_extract(tempPath & "\ipad_ramdisk.dmg", ICE2_iPad_flsPath, tempPath & "\iPad.06.15.00.fls")
        'Take out the trash...
        Delete_File(tempPath & "\018-8374-001.dmg")
        Delete_File(tempPath & "\ipad_ramdisk.dmg")
        'Bringing in the new cows...
        hfsplus_add(tempPath & "\IPSW\ramdisk_decrypted.dmg", tempPath & "\iPad.06.15.00.eep", ICE2eepPath)
        hfsplus_add(tempPath & "\IPSW\ramdisk_decrypted.dmg", tempPath & "\iPad.06.15.00.fls", ICE2flsPath)
        'Branding the cows...
        hfsplus_chmod(tempPath & "\IPSW\ramdisk_decrypted.dmg", ICE2eepPath, "100644")
        hfsplus_chmod(tempPath & "\IPSW\ramdisk_decrypted.dmg", ICE2flsPath, "100644")
        'Moar branding... (Hardcore style)
        hfsplus_chown(tempPath & "\IPSW\ramdisk_decrypted.dmg", ICE2eepPath, "0", "80")
        hfsplus_chown(tempPath & "\IPSW\ramdisk_decrypted.dmg", ICE2flsPath, "0", "80")
    End Sub
    Public Sub Fix_ultrasn0w()
        Exit Sub
        'It goes a lil' something like this...
        If iPhoneModel = "iPhone 3GS" Then
            SaveToDisk("us_fix.tar", tempPath & "\us_fix.tar")

            hfsplus_untar(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\us_fix.tar")

            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/Library/MobileSubstrate/DynamicLibraries/us_fix.dylib", "100755")
            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/Library/MobileSubstrate/DynamicLibraries/us_fix.plist", "100755")

            Delete_File(tempPath & "\us_fix.tar")
        ElseIf iPhoneModel = "iPhone 4" Then
            SaveToDisk("us_fix_4.tar", tempPath & "\us_fix.tar")

            hfsplus_untar(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\us_fix.tar")

            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/Library/MobileSubstrate/DynamicLibraries/us_fix.dylib", "100755")
            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/Library/MobileSubstrate/DynamicLibraries/us_fix.plist", "100755")

            Delete_File(tempPath & "\us_fix.tar")
        Else
            Exit Sub
        End If
        '#WINNING
    End Sub
    Public Sub iBooty()
        Exit Sub

        Dim iBootyPath As String
        Dim obj As Object
        obj = CreateObject("WScript.Shell")
        iBootyPath = obj.SpecialFolders("desktop") & "\iBooty-for-" & IPSWVersion
        Shell("cmd /c taskkill /f /t /im iBooty.exe", AppWinStyle.Hide)
        If stage = 1 Then
            stage = 0
            If File_Exists(obj.SpecialFolders("desktop") & "\iBooty-for-" & IPSWVersion) = False Then
                Create_Directory(iBootyPath)
                Create_Directory(iBootyPath & "\files")
            End If
            SaveToDisk("s-irecovery.exe", iBootyPath & "\files\s-irecovery.exe")
            SaveToDisk("iBooty.exe", iBootyPath & "\iBooty.exe")
            'LLB patch to jump to ibec...

            If iPhoneModel = "iPhone 3GS" Then
                xpwntool(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\LLB." & ModelVar & ".RELEASE.img3", tempPath & "\llb.d", LLBIV, LLBKey)
                bspatch(tempPath & "\llb.d", tempPath & "\llb.pwned", tempPath & "\LLB." & ModelVar & ".RELEASE-iBooty.patch")
                xpwntool_template(tempPath & "\llb.pwned", iBootyPath & "\files\llb.3gs.dfu", tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\LLB." & ModelVar & ".RELEASE.img3", LLBIV, LLBKey)
                Exit Sub
            End If

            xpwntool(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\LLB." & ModelVar & ".RELEASE.img3", tempPath & "\llb.d", LLBIV, LLBKey)
            bspatch(tempPath & "\llb.d", tempPath & "\llb.pwned", tempPath & "\LLB." & ModelVar & ".RELEASE.patch")
            If iPhoneModel = "iPhone 4" Then
                xpwntool_template(tempPath & "\llb.pwned", iBootyPath & "\files\llb.4.dfu", tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\LLB." & ModelVar & ".RELEASE.img3", LLBIV, LLBKey)
            ElseIf iPhoneModel = "iPod Touch 3G" Then
                xpwntool_template(tempPath & "\llb.pwned", iBootyPath & "\files\llb.ipt3.dfu", tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\LLB." & ModelVar & ".RELEASE.img3", LLBIV, LLBKey)
            ElseIf iPhoneModel = "iPod Touch 4" Then
                xpwntool_template(tempPath & "\llb.pwned", iBootyPath & "\files\llb.ipt4.dfu", tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\LLB." & ModelVar & ".RELEASE.img3", LLBIV, LLBKey)
            ElseIf iPhoneModel = "iPad" Then
                xpwntool_template(tempPath & "\llb.pwned", iBootyPath & "\files\llb.ipad.dfu", tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\LLB." & ModelVar & ".RELEASE.img3", LLBIV, LLBKey)
            End If
        ElseIf stage = 2 Then
            stage = 0
            'Pwned iBoot flashes to ibec in nand0. :)

            xpwntool(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3", tempPath & "\iboot.d", iBootkIV, iBootKey)
            bspatch(tempPath & "\iboot.d", tempPath & "\iboot.pwned", tempPath & "\iBoot." & ModelVar & ".RELEASE.patch")
            xpwntool_template(tempPath & "\iboot.pwned", tempPath & "\iboot.img3", tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3", iBootkIV, iBootKey)

            If iPhoneModel = "iPhone 3GS" Then
                Delete_File(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\batteryfull.s5l8920x.img3")
                bspatch(tempPath & "\iboot.img3", tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\batteryfull.s5l8920x.img3", tempPath & "\iBoot." & ModelVar & ".RELEASE-iBooty.patch")
            ElseIf iPhoneModel = "iPhone 4" Or iPhoneModel = "iPod Touch 4" Then
                Delete_File(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\batteryfull-640x960.s5l8930x.img3")
                bspatch(tempPath & "\iboot.img3", tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\batteryfull-640x960.s5l8930x.img3", tempPath & "\iBoot." & ModelVar & ".RELEASE-iBooty.patch")
            ElseIf iPhoneModel = "iPod Touch 3G" Then
                Delete_File(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\batteryfull.s5l8922x.img3")
                bspatch(tempPath & "\iboot.img3", tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\batteryfull.s5l8922x.img3", tempPath & "\iBoot." & ModelVar & ".RELEASE-iBooty.patch")
            ElseIf iPhoneModel = "iPad" Then
                Delete_File(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\batteryfull.s5l8930x.img3")
                bspatch(tempPath & "\iboot.img3", tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\batteryfull.s5l8930x.img3", tempPath & "\iBoot." & ModelVar & ".RELEASE-iBooty.patch")
            End If
        End If
    End Sub
    Public Sub HacktivatePhone()
        If ModelVar = "n92ap" Then
            'Sowwy verizon i4. no <3 for u.
            Exit Sub
        End If
        SaveToDisk("youtube.tar", tempPath & "\youtube.tar")
        '
        hfsplus_extract(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/libexec/lockdownd", tempPath & "\lockdownd.orig")
        hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/libexec/lockdownd", "/usr/libexec/lockdownd.orig")
        bspatch(tempPath & "\lockdownd.orig", tempPath & "\lockdownd", tempPath & "\lockdownd.patch")
        hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\lockdownd", "/usr/libexec/lockdownd")
        hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/usr/libexec/lockdownd", "100755")
        '
        hfsplus_untar(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\youtube.tar")
        Delete_File(tempPath & "\youtube.tar")
    End Sub
    Public Sub CustomOptions()
        If iPhoneModel = "iPad" Then
            hfsplus_extract(tempPath & "\IPSW\DECRYPTED.dmg", "/Applications/Preferences.app/General.plist", tempPath & "\General.plist.orig")
            hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/Applications/Preferences.app/General.plist", "/Applications/Preferences.app/General_orig.plist")
            bspatch(tempPath & "\General.plist.orig", tempPath & "\General.plist", tempPath & "\General.patch")

            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\General.plist", "/Applications/Preferences.app/General.plist")
            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/Applications/Preferences.app/General.plist", "100644")

            'We might as well patch the Show Non-Default apps here...
            hfsplus_extract(tempPath & "\IPSW\DECRYPTED.dmg", "/System/Library/CoreServices/SpringBoard.app/K48AP.plist", tempPath & "\K48AP.plist.orig")
            hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/System/Library/CoreServices/SpringBoard.app/K48AP.plist", "/System/Library/CoreServices/SpringBoard.app/K48AP_orig.plist")
            bspatch(tempPath & "\K48AP.plist.orig", tempPath & "\K48AP.plist", tempPath & "\K48AP.patch")
            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\K48AP.plist", "/System/Library/CoreServices/SpringBoard.app/K48AP.plist")
            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/System/Library/CoreServices/SpringBoard.app/K48AP.plist", "100644")

            Delete_File(tempPath & "\K48AP.plist.orig")
            Delete_File(tempPath & "\K48AP.plist")
        End If
        If iPhoneModel = "iPhone 3GS" Then
            hfsplus_extract(tempPath & "\IPSW\DECRYPTED.dmg", "/System/Library/CoreServices/SpringBoard.app/N88AP.plist", tempPath & "\N88AP.plist.orig")
            hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/System/Library/CoreServices/SpringBoard.app/N88AP.plist", "/System/Library/CoreServices/SpringBoard/N88AP_orig.plist")
            bspatch(tempPath & "\N88AP.plist.orig", tempPath & "\N88AP.plist.pwned", tempPath & "\N88AP.patch")

            'General.plist Patch
            hfsplus_extract(tempPath & "\IPSW\DECRYPTED.dmg", "/Applications/Preferences.app/General.plist", tempPath & "\General.plist.orig")
            hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/Applications/Preferences.app/General.plist", "/Applications/Preferences.app/General_orig.plist")
            bspatch(tempPath & "\General.plist.orig", tempPath & "\General.plist", tempPath & "\General.patch")

            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\General.plist", "/Applications/Preferences.app/General.plist")
            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\N88AP.plist.pwned", "/System/Library/CoreServices/SpringBoard.app/N88AP.plist")

            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/System/Library/CoreServices/SpringBoard.app/N88AP.plist", "100644")
            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/Applications/Preferences.app/General.plist", "100644")

            Delete_File(tempPath & "\N88AP.plist.orig")
            Delete_File(tempPath & "\N88AP.plist.pwned")
        End If
        If iPhoneModel = "iPhone 4" And ModelVar = "n90ap" Then
            hfsplus_extract(tempPath & "\IPSW\DECRYPTED.dmg", "/System/Library/CoreServices/SpringBoard.app/N90AP.plist", tempPath & "\N90AP.plist.orig")
            hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/System/Library/CoreServices/SpringBoard.app/N90AP.plist", "/System/Library/CoreServices/SpringBoard/N90AP_orig.plist")
            bspatch(tempPath & "\N90AP.plist.orig", tempPath & "\N90AP.plist.pwned", tempPath & "\N90AP.patch")

            'General.plist Patch
            hfsplus_extract(tempPath & "\IPSW\DECRYPTED.dmg", "/Applications/Preferences.app/General.plist", tempPath & "\General.plist.orig")
            hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/Applications/Preferences.app/General.plist", "/Applications/Preferences.app/General_orig.plist")
            bspatch(tempPath & "\General.plist.orig", tempPath & "\General.plist", tempPath & "\General.patch")

            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\General.plist", "/Applications/Preferences.app/General.plist")
            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\N90AP.plist.pwned", "/System/Library/CoreServices/SpringBoard.app/N90AP.plist")

            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/System/Library/CoreServices/SpringBoard.app/N90AP.plist", "100644")
            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/Applications/Preferences.app/General.plist", "100644")

            Delete_File(tempPath & "\N90AP.plist.orig")
            Delete_File(tempPath & "\N90AP.plist.pwned")
        End If
        If iPhoneModel = "iPod Touch 3G" Then

            'iPod Touch 4 Options -- Battery Percentage Only.
            hfsplus_extract(tempPath & "\IPSW\DECRYPTED.dmg", "/System/Library/CoreServices/SpringBoard.app/N18AP.plist", tempPath & "\N18AP.plist.orig")
            hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/System/Library/CoreServices/SpringBoard.app/N18AP.plist", "/System/Library/CoreServices/SpringBoard/N18AP_orig.plist")
            bspatch(tempPath & "\N18AP.plist.orig", tempPath & "\N18AP.plist.pwned", tempPath & "\N18AP.patch")

            'General.plist Patch
            hfsplus_extract(tempPath & "\IPSW\DECRYPTED.dmg", "/Applications/Preferences.app/General.plist", tempPath & "\General.plist.orig")
            hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/Applications/Preferences.app/General.plist", "/Applications/Preferences.app/General_orig.plist")
            bspatch(tempPath & "\General.plist.orig", tempPath & "\General.plist", tempPath & "\General.patch")

            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\General.plist", "/Applications/Preferences.app/General.plist")
            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\N18AP.plist.pwned", "/System/Library/CoreServices/SpringBoard.app/N18AP.plist")

            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/System/Library/CoreServices/SpringBoard.app/N81AP.plist", "100644")
            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/Applications/Preferences.app/General.plist", "100644")

            Delete_File(tempPath & "\N18AP.plist.orig")
            Delete_File(tempPath & "\N18AP.plist.pwned")

        End If
        If iPhoneModel = "iPod Touch 4" Then
            'iPod Touch 4 Options -- Battery Percentage Only.
            hfsplus_extract(tempPath & "\IPSW\DECRYPTED.dmg", "/System/Library/CoreServices/SpringBoard.app/N81AP.plist", tempPath & "\N81AP.plist.orig")
            hfsplus_extract(tempPath & "\IPSW\DECRYPTED.dmg", "/Applications/Preferences.app/General.plist", tempPath & "\General.plist.orig")

            hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/System/Library/CoreServices/SpringBoard.app/N81AP.plist", "/System/Library/CoreServices/SpringBoard/N81AP.orig.plist")
            hfsplus_mv(tempPath & "\IPSW\DECRYPTED.dmg", "/Applications/Preferences.app/General.plist", "/Applications/Preferences.app/General_orig.plist")

            bspatch(tempPath & "\N81AP.plist.orig", tempPath & "\N81AP.plist.pwned", tempPath & "\N81AP.patch")
            'General.plist Patch
            bspatch(tempPath & "\General.plist.orig", tempPath & "\General.plist", tempPath & "\General.patch")

            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\N81AP.plist.pwned", "/System/Library/CoreServices/SpringBoard.app/N81AP.plist")
            hfsplus_add(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\General.plist", "/Applications/Preferences.app/General.plist")

            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/System/Library/CoreServices/SpringBoard.app/N81AP.plist", "100644")
            hfsplus_chmod(tempPath & "\IPSW\DECRYPTED.dmg", "/Applications/Preferences.app/General.plist", "100644")


            Delete_File(tempPath & "\N81AP.plist.orig")
            Delete_File(tempPath & "\N81AP.plist.pwned")
            Delete_File(tempPath & "\N81AP.plist.pwned1")
        End If
    End Sub
    Public Sub RebuildRootFS()
        dmg_rebuild(tempPath & "\IPSW\DECRYPTED.dmg", tempPath & "\IPSW\" & RootFS & ".dmg")

        Delete_File(tempPath & "\IPSW\DECRYPTED.dmg")
    End Sub

    Public Sub PatchiBoot()
        If This3GSisold = True Then
            Rename_File(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3", "iBoot." & ModelVar & ".RELEASE.img3.orig")

            xpwntool(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.orig", tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.decrypted", iBootkIV, iBootKey)
            bspatch(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.decrypted", tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.patched", tempPath & "\iBoot." & ModelVar & ".RELEASE.patch")
            xpwntool_template(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.patched", tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3", tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.orig", iBootkIV, iBootKey)
        Else
            Exit Sub
            stage = 2
            xpwntool(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3", tempPath & "\iboot.d", iBootkIV, iBootKey)
            bspatch(tempPath & "\iboot.d", tempPath & "\iboot.pwned", tempPath & "\iBoot." & ModelVar & ".RELEASE.patch")
            Call iBooty()
        End If

        Delete_File(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.orig")
        Delete_File(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.patched")
        Delete_File(tempPath & "\IPSW\Firmware\all_flash\all_flash." & ModelVar & ".production\iBoot." & ModelVar & ".RELEASE.img3.decrypted")

    End Sub
    Public Sub DeleteUnrequiredFiles()
        If DoIDeleteBuildManifest = True Then
            Delete_File(tempPath & "\IPSW\BuildManifest.plist")
        End If

        Delete_File(tempPath & "\IPSW\" & Unwanted & ".dmg")
    End Sub
    Public Sub CreateIPSW()
        'get desktop folder
        Dim obj As Object
        obj = CreateObject("WScript.Shell")

        'delete ipsw if already exists
        If File_Exists(obj.SpecialFolders("desktop") & "\sn0wbreeze_" & iPhoneModel & "-" & IPSWVersion & ".ipsw") = True Then
            File_Delete(obj.SpecialFolders("desktop") & "\sn0wbreeze_" & iPhoneModel & "-" & IPSWVersion & ".ipsw")
        End If
        'Zip(tempPath & "\ipsw\", obj.SpecialFolders("desktop") & "\sn0wbreeze_" & iPhoneModel & ".ipsw", "")
        Using zip1 As Ionic.Zip.ZipFile = New Ionic.Zip.ZipFile
            zip1.AddDirectory(tempPath & "\ipsw\")
            zip1.Save(obj.SpecialFolders("desktop") & "\sn0wbreeze_" & iPhoneModel & "-" & IPSWVersion & ".ipsw")
        End Using
    End Sub
    Public Sub Zip(ByVal inputFolderPath As String, ByVal outputPathAndFile As String, ByVal password As String)
        Dim ar As ArrayList = GenerateFileList(inputFolderPath)
        ' generate file list
        Dim TrimLength As Int32 = (Directory.GetParent(inputFolderPath)).ToString().Length
        ' find number of chars to remove // from orginal file path
        TrimLength += 1
        'remove '\'
        Dim ostream As FileStream
        Dim obuffer As Byte()
        Dim outPath As String = outputPathAndFile
        Dim oZipStream As New ZipOutputStream(File.Create(outPath))
        ' create zip stream
        If password IsNot Nothing AndAlso password <> [String].Empty Then
            oZipStream.Password = password
        End If
        oZipStream.SetLevel(0)
        ' maximum compression
        Dim oZipEntry As ICSharpCode.SharpZipLib.Zip.ZipEntry
        For Each Fil As String In ar
            ' for each file, generate a zipentry
            oZipEntry = New ICSharpCode.SharpZipLib.Zip.ZipEntry(Fil.Remove(0, TrimLength))
            oZipStream.PutNextEntry(oZipEntry)
            If Not Fil.EndsWith("/") Then
                ' if a file ends with '/' its a directory
                ostream = File.OpenRead(Fil)
                obuffer = New Byte(ostream.Length - 1) {}
                ostream.Read(obuffer, 0, obuffer.Length)
                oZipStream.Write(obuffer, 0, obuffer.Length)
            End If
        Next
        oZipStream.Finish()
        oZipStream.Close()
    End Sub
    Private Function GenerateFileList(ByVal Dir As String) As ArrayList
        Dim fils As New ArrayList()
        Dim Empty As Boolean = True
        For Each file As String In Directory.GetFiles(Dir)
            ' add each file in directory
            fils.Add(file)
            Empty = False
        Next

        If Empty Then
            If Directory.GetDirectories(Dir).Length = 0 Then
                ' if directory is completely empty, add it
                fils.Add(Dir)
            End If
        End If

        For Each dirs As String In Directory.GetDirectories(Dir)
            ' recursive
            For Each obj As Object In GenerateFileList(dirs)
                fils.Add(obj)
            Next
        Next
        ' return file list
        Return fils
    End Function
    Public Sub ZipOLD(ByVal SrcFile As String, ByVal DstFile As String, ByVal BufferSize As Int32)

        Dim astrFileNames() As String = Directory.GetFiles(SrcFile)
        Dim astrDirectoryNames() As String = Directory.GetDirectories(SrcFile)
        Dim strmZipOutputStream As ZipOutputStream

        strmZipOutputStream = New ZipOutputStream(File.Create(DstFile))

        REM Compression Level: 0-9
        REM 0: no(Compression)
        REM 9: maximum compression
        strmZipOutputStream.SetLevel(0)

        Dim strFile As String

        For Each strFolder In astrDirectoryNames

            For Each strFile In astrFileNames

                Dim strmFile As FileStream = File.OpenRead(strFile)
                Dim abyBuffer(strmFile.Length - 1) As Byte

                strmFile.Read(abyBuffer, 0, abyBuffer.Length)

                Dim IndexStart As Int32 = strFile.IndexOf("\ipsw\") + 6
                Dim IndexEnd As Int32 = Strings.Len(strFile) - (strFile.IndexOf("\ipsw\") + 6)
                strFile = strFile.Substring(IndexStart, IndexEnd)

                Dim objZipEntry As ICSharpCode.SharpZipLib.Zip.ZipEntry = New ICSharpCode.SharpZipLib.Zip.ZipEntry(strFile)

                objZipEntry.DateTime = DateTime.Now
                objZipEntry.Size = strmFile.Length
                strmFile.Close()
                strmZipOutputStream.PutNextEntry(objZipEntry)
                strmZipOutputStream.Write(abyBuffer, 0, abyBuffer.Length)
            Next

        Next

        strmZipOutputStream.Finish()
        strmZipOutputStream.Close()
    End Sub
    Public Sub UnZip(ByVal SrcFile As String, ByVal DstFile As String, ByVal BufferSize As Int32)

        Dim fileName As String = SrcFile 'Path.GetFullPath("../AcapCopy.zip")
        Dim destPath As String = DstFile 'Path.GetFullPath("../Unzipped/")

        If Not Directory.Exists(destPath) Then
            Directory.CreateDirectory(destPath)
        End If

        Dim inStream As New ZipInputStream(File.OpenRead(fileName))
        Dim outStream As FileStream

        Dim entry As ICSharpCode.SharpZipLib.Zip.ZipEntry
        Dim buff(BufferSize - 1) As Byte
        Dim bytes As Int32

        Do While True
            entry = inStream.GetNextEntry()

            If entry Is Nothing Then
                Exit Do
            End If

            If entry.IsDirectory = True Then
                Create_Directory(destPath + entry.Name)
            Else
                outStream = File.Create(destPath + entry.Name, BufferSize)

                Do While True
                    bytes = inStream.Read(buff, 0, BufferSize)
                    If bytes = 0 Then
                        Exit Do
                    End If

                    outStream.Write(buff, 0, bytes)
                Loop

                outStream.Close()
            End If

        Loop

        inStream.Close()
    End Sub
End Module