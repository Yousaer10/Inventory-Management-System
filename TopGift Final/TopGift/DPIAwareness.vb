'It will obtain the scaling settings from the primary monitor allowing the app to scale and render correctly, no matter the scaling settings
NotInheritable Class DPIAwareness

    <STAThread>
    Friend Shared Sub Main()
        SetProcessDPIAware()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New frmLogin())

    End Sub
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function SetProcessDPIAware() As Boolean
    End Function
End Class