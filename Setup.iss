; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Sharp64"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "Willy Kimura"
#define MyAppURL "https://willykimura.home.blog"
#define MyAppExeName "Sharp64.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{f438fa20-9514-4cd0-9492-a11f7ee6870e}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=no
InfoBeforeFile=C:\Users\VitalRay\source\repos\apps\Sharp64\bin\Release\Information.txt
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=C:\Users\VitalRay\source\repos\apps\Sharp64\bin\Release
OutputBaseFilename=Sharp64 Setup
SetupIconFile=C:\Users\VitalRay\source\repos\apps\Sharp64\Assets\Icons\Sharp64-icon.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\VitalRay\source\repos\apps\Sharp64\bin\Debug\*"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VitalRay\source\repos\apps\Sharp64\Assets\Fonts\Product Sans Light.ttf"; DestDir: "{fonts}"; FontInstall: "Product Sans Light"; Flags: onlyifdoesntexist uninsneveruninstall
Source: "C:\Users\VitalRay\source\repos\apps\Sharp64\Assets\Fonts\Product Sans Light Italic.ttf"; DestDir: "{fonts}"; FontInstall: "Product Sans Light"; Flags: onlyifdoesntexist uninsneveruninstall
Source: "C:\Users\VitalRay\source\repos\apps\Sharp64\Assets\Fonts\Cascadia.ttf"; DestDir: "{fonts}"; FontInstall: "Cascadia Code"; Flags: onlyifdoesntexist uninsneveruninstall
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

