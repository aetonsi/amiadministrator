# amiadministrator
Simple Windows cli tool to determine if the invocation is elevated.

# Usage
The tool can be used both via the exit code (0 if admin, 1 if not admin) and via its output ("yes" if admin, "no" if not admin).
Example in powershell core (pwsh):
```powershell
# use the program output
$admin = .\amiadministrator.exe
echo $admin # "yes" or "no"

# use the program exit code (suppress output with >$null)
.\amiadministrator.exe >$null && .\myprogram.exe || echo NOTADMIN # invokes "myprogram.exe" only if admin

```
