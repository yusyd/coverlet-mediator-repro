# coverlet-mediator-repro

## Reproduce

Run from the repository root:

```powershell
dotnet restore .\CoverletMediatorRepro.slnx --configfile .\nuget.config -p:NuGetAudit=false

Remove-Item -Recurse -Force .\artifacts\* -ErrorAction SilentlyContinue

dotnet test .\CoverletMediatorRepro.slnx `
  --no-restore `
  --configuration Release `
  --results-directory .\artifacts\TestResults `
  --collect:"XPlat Code Coverage;Format=cobertura" `
  --diag .\artifacts\vstest.diag.txt `
  -p:NuGetAudit=false
```
