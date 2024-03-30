<p align="center">
    <h1 align="center">
        <img src="https://raw.githubusercontent.com/aurumest/mview/main/docs/images/mview_icon.ico" width="50" height="50">
        <p>MView</p>
    </h1>
    <p align="center"><b>A RPG Maker MV/MZ Resource Editor</b></p>
    <p align="center">
        <a target="_blank" href="https://github.com/aurumest/mview/actions"><img alt="GitHub Workflow Status" src="https://img.shields.io/github/actions/workflow/status/aurumest/mview/release.yml?branch=main"></a>
        <a target="_blank" href="https://github.com/aurumest/mview/releases/latest"><img alt="GitHub release (latest by date)" src="https://img.shields.io/github/v/release/aurumest/mview"></a>
        <a target="_blank" href="https://github.com/aurumest/mview/releases/latest"><img alt="GitHub all releases" src="https://img.shields.io/github/downloads/aurumest/mview/total"></a>
        <a target="_blank" href="https://github.com/aurumest/mview/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/aurumest/mview"></a>
    </p>
</p>

## Usage
[See the documentaion](../main/docs/GUIDE.md) for instructions on how to use it.

## Build
### Requirements
 * __OS__ : Windows 10 or higher version(include server edtions)
 * __Tools__
   * [PowerShell 7](https://github.com/PowerShell/PowerShell)
   * [Visual Studio 2022](https://visualstudio.microsoft.com/)(include 'Desktop development with C++' and '.NET desktop development' workload)
   * [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download)

### Guide
1. Open a PowerShell terminal from `./scripts`.
2. Run the commands below.
```pwsh
Set-ExecutionPolicy Unrestricted
./publish.ps1 -target MView/MView.csproj -publishProfile (x64|arm64).pubxml -excludeSymbols $(true|false)
```

## License
The contents are freely available under the [MIT License](http://opensource.org/licenses/MIT).

The licenses of third-party libraries can be found [here](https://github.com/aurumest/mview/blob/main/docs/THIRD_PARTY_NOTICES.md).
