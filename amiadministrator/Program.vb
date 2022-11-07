Module Program

    Sub Main()
        Dim identity = Security.Principal.WindowsIdentity.GetCurrent()
        Dim principal = New Security.Principal.WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(Security.Principal.WindowsBuiltInRole.Administrator)
        If isElevated Then
            Console.WriteLine("yes")
            Environment.Exit(0)
        Else
            Console.WriteLine("no")
            Environment.Exit(1)
        End If
    End Sub

End Module
