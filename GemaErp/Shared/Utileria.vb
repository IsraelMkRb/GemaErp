Module Utileria
    Public Sub ShowWait(parent As Form)
        DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(parent, GetType(Wait), False, True, False)
    End Sub

    Public Sub HideWait()
        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(False)
    End Sub
End Module
