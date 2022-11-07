Module Program

    Sub Main()
        Dim identity = Security.Principal.WindowsIdentity.GetCurrent()
        Dim principal = New Security.Principal.WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(Security.Principal.WindowsBuiltInRole.Administrator)
        If isElevated Then
            Console.WriteLine("yes")
        Else
            Console.WriteLine("no")
        End If
    End Sub

End Module
