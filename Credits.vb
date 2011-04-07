Public Class Credits
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Enabled = True
        SelectMode.Enabled = True
        DFU.Enabled = True
        done.Enabled = True
        ebootlogos.Enabled = True
        MDIMain.MenuStrip1.Enabled = True
        ebuilding.Enabled = True
        ecustomapps.Enabled = True
        IdentifyIPSW.Enabled = True
        Expert.Enabled = True
        egeneral.Enabled = True
        Fail.Enabled = True
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.Enabled = True
        SelectMode.Enabled = True
        DFU.Enabled = True
        done.Enabled = True
        ebootlogos.Enabled = True
        ebuilding.Enabled = True
        ecustomapps.Enabled = True
        IdentifyIPSW.Enabled = True
        Expert.Enabled = True
        egeneral.Enabled = True
        Fail.Enabled = True
        Me.Close()
    End Sub
    Private Sub Credits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = MDIMain
        Form1.Enabled = False
        SelectMode.Enabled = False
        DFU.Enabled = False
        done.Enabled = False
        ebootlogos.Enabled = False
        ebuilding.Enabled = False
        ecustomapps.Enabled = False
        IdentifyIPSW.Enabled = False
        Expert.Enabled = False
        egeneral.Enabled = False
        Fail.Enabled = False
    End Sub

    Private Sub www_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://sn0wbreeze.info")
    End Sub
    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles posixninja.Click
        Process.Start("http://twitter.com/p0sixninja")
    End Sub

    Private Sub logo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.Click
        Process.Start("http://sn0wbreeze.info")
    End Sub
    Private Sub Label4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iH8sn0w.MouseEnter
        iH8sn0w.ForeColor = Color.Cyan
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iH8sn0w.Click
        Process.Start("http://twitter.com/iH8sn0w")
    End Sub

    Private Sub Label4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iH8sn0w.MouseLeave
        iH8sn0w.ForeColor = Color.White
    End Sub
    Private Sub Label17_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ipdev.MouseEnter
        ipdev.ForeColor = Color.Cyan
    End Sub

    Private Sub Label17_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ipdev.MouseLeave
        ipdev.ForeColor = Color.White
    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ipdev.Click
        Process.Start("http://twitter.com/iphone_dev")
    End Sub

    Private Sub Label15_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles posixninja.MouseEnter
        posixninja.ForeColor = Color.Cyan
    End Sub

    Private Sub Label15_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles posixninja.MouseLeave
        posixninja.ForeColor = Color.White
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles planetbeing.Click
        Process.Start("http://twitter.com/planetbeing")
    End Sub
    Private Sub Label16_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles planetbeing.MouseEnter
        planetbeing.ForeColor = Color.Cyan
    End Sub

    Private Sub Label16_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles planetbeing.MouseLeave
        planetbeing.ForeColor = Color.White
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles biloud43.Click
        Process.Start("http://twitter.com/biloud43")
    End Sub
    Private Sub Label10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles biloud43.MouseEnter
        biloud43.ForeColor = Color.Cyan
    End Sub

    Private Sub Label10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles biloud43.MouseLeave
        biloud43.ForeColor = Color.White
    End Sub
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Greekone79.Click
        Process.Start("http://twitter.com/greekone79")
    End Sub
    Private Sub Label12_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Greekone79.MouseEnter
        Greekone79.ForeColor = Color.Cyan
    End Sub

    Private Sub Label12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Greekone79.MouseLeave
        Greekone79.ForeColor = Color.White
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mk321024.Click
        Process.Start("http://twitter.com/mk321024")
    End Sub
    Private Sub Label7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles mk321024.MouseEnter
        mk321024.ForeColor = Color.Cyan
    End Sub

    Private Sub Label7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mk321024.MouseLeave
        mk321024.ForeColor = Color.White
    End Sub
    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vip3r.Click
        Process.Start("http://twitter.com/iVip3r")
    End Sub
    Private Sub Label11_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles vip3r.MouseEnter
        vip3r.ForeColor = Color.Cyan
    End Sub

    Private Sub Label11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles vip3r.MouseLeave
        vip3r.ForeColor = Color.White
    End Sub

    Private Sub Label2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msftguy.MouseEnter
        msftguy.ForeColor = Color.Cyan
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msftguy.MouseLeave
        msftguy.ForeColor = Color.White
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msftguy.Click
        Process.Start("http://twitter.com/msft_guy")
    End Sub

    Private Sub Label18_MouseEnter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThePirate.MouseEnter
        ThePirate.ForeColor = Color.Cyan
    End Sub

    Private Sub Label18_MouseLeave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThePirate.MouseLeave
        ThePirate.ForeColor = Color.White
    End Sub

    Private Sub Label18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThePirate.Click
        Process.Start("http://twitter.com/ThePiratep")
    End Sub

    Private Sub Label2_MouseEnter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cj.MouseEnter
        cj.ForeColor = Color.Cyan
    End Sub

    Private Sub Label2_MouseLeave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cj.MouseLeave
        cj.ForeColor = Color.White
    End Sub
    Private Sub Label6_MouseEnter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AKi_nG.MouseEnter
        AKi_nG.ForeColor = Color.Cyan
    End Sub

    Private Sub Label6_MouseLeave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AKi_nG.MouseLeave
        AKi_nG.ForeColor = Color.White
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AKi_nG.Click
        Process.Start("http://twitter.com/AKi_nG")
    End Sub

    Private Sub Label2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cj.Click
        Process.Start("http://twitter.com/iC_J")
    End Sub

    Private Sub Label22_MouseEnter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pod2g.MouseEnter
        pod2g.ForeColor = Color.Cyan
    End Sub

    Private Sub Label22_MouseLeave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pod2g.MouseLeave
        pod2g.ForeColor = Color.White
    End Sub
    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pod2g.Click
        Process.Start("http://twitter.com/pod2g")
    End Sub
    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click
        Process.Start("http://github.com/planetbeing/xpwn")
    End Sub
    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click
        Process.Start("http://github.com/iH8sn0w/xpwn")
    End Sub

    Private Sub comex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comex.Click
        Process.Start("http://twitter.com/comex")
    End Sub
    Private Sub comex_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comex.MouseLeave
        comex.ForeColor = Color.White
    End Sub
    Private Sub comex_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comex.MouseEnter
        comex.ForeColor = Color.Cyan
    End Sub
    Private Sub i0n1c_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles i0n1c.MouseLeave
        i0n1c.ForeColor = Color.White
    End Sub
    Private Sub i0n1c_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles i0n1c.MouseEnter
        i0n1c.ForeColor = Color.Cyan
    End Sub
    Private Sub i0n1c_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles i0n1c.Click
        Process.Start("http://twitter.com/i0n1c")
    End Sub
End Class