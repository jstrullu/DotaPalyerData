#define MyAppName "Dota Player Data"
#define MyAppVersion "1.0.0"
#define MyAppPublisher ""
#define MyAppURL "https://www.example.com/"
#define MyAppExeName "DotaPlayerData.UI.exe"
#define MyAppAssocName "DotaPlayer Data File"
#define MyAppAssocExt ".dpd"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt
#define public Dependency_Path_NetCoreCheck "dependencies\"

#include "CodeDependencies.iss"

[Setup]
AppId={code:GetAppID|''}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
ChangesAssociations=yes
DisableProgramGroupPage=yes
OutputDir=.
OutputBaseFilename=Dota Player Data Setup {#MyAppVersion}
SetupIconFile=DotaPlayerData.UI\bin\Release\net8.0-windows10.0.19041.0\win10-x64\publish\appicon.ico
Compression=lzma2/ultra
SolidCompression=yes
PrivilegesRequired=admin
DefaultGroupName={#MyAppName}
VersionInfoVersion={#MyAppVersion}
UsePreviousLanguage=no


ArchitecturesInstallIn64BitMode=x64

[Languages]
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Dirs]
Name: "{app}"; Permissions: everyone-full

[Files]
Source: "DotaPlayerData.UI\bin\Release\net8.0-windows10.0.19041.0\win10-x64\publish\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion ; Permissions: everyone-full
Source: "DotaPlayerData.UI\bin\Release\net8.0-windows10.0.19041.0\win10-x64\publish\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs; Permissions: everyone-full
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Registry]
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocExt}\OpenWithProgids"; ValueType: string; ValueName: "{#MyAppAssocKey}"; ValueData: ""; Flags: uninsdeletevalue
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}"; ValueType: string; ValueName: ""; ValueData: "{#MyAppAssocName}"; Flags: uninsdeletekey
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\{#MyAppExeName},0"
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
Root: HKA; Subkey: "Software\Classes\Applications\{#MyAppExeName}\SupportedTypes"; ValueType: string; ValueName: "{#MyAppAssocExt}"; ValueData: ""
Root: HKLM; Subkey: "Software\{#MyAppName}"; ValueType: string; ValueName: CurrentVersion; ValueData: {code:GetAppCurrentVersion|''}; Flags: uninsdeletekey

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Code]
function GetAppID(param: String): String;
	begin
		Result := 'AD5F497C-AA8C-445E-BD55-042665672A72';
	end;
function GetAppCurrentVersion(param: String): String;
	begin
		Result:='{#MyAppVersion}';
	end;

function GetPathInstalled(AppID: String): String;
	var
		PrevPath: String;
	begin
		PrevPath := '';
		if not RegQueryStringValue(HKLM, 'Software\Microsoft\Windows\CurrentVersion\Uninstall\'+AppID+'_is1', 'Inno Setup: App Path', PrevPath) then begin
			RegQueryStringValue(HKCU, 'Software\Microsoft\Windows\CurrentVersion\Uninstall\'+AppID+'_is1', 'Inno Setup: App Path', PrevPath);
		end;
		Result := PrevPath;
	end;

function GetInstalledVersion(): String;
	var
		InstalledVersion: String;
	begin
		InstalledVersion := '';
		RegQueryStringValue(HKLM, 'Software\{#MyAppName}', 'Version', InstalledVersion);
		Result := InstalledVersion;
	end;

function GetInstalledCurrentVersion(): String;
	var
		InstalledCurrentVersion: String;
	begin
		InstalledCurrentVersion := '';
		RegQueryStringValue(HKLM, 'Software\{#MyAppName}', 'CurrentVersion', InstalledCurrentVersion);
		Result := InstalledCurrentVersion;
	end;

function InitializeSetup(): Boolean;
	var
		Response: Integer;
		PrevDir: String;
		InstalledVersion: String;
		InstalledCurrentVersion: String;
		//VersionError: String;
	begin
      Dependency_AddDotNet80;
		Result := true;

		// read the installation folder
		PrevDir := GetPathInstalled(getAppID(''));

		if length(Prevdir) > 0 then begin
			// I found the folder so it's an upgrade.
			
			// compare versions
			InstalledCurrentVersion := GetInstalledCurrentVersion();
			InstalledVersion := GetAppCurrentVersion('');
			if (InstalledCurrentVersion < InstalledVersion) then begin
				Result := True;
			end else if (InstalledCurrentVersion = InstalledVersion) then begin
				Response := MsgBox(
					'It appears that the existing {#MyAppName} installation is already current.' + #13#13 +
					'Do you want to continue with the update installation?', mbError, MB_YESNO
				);
				Result := (Response = IDYES);
			end else begin
				Response := MsgBox(
					'It appears that the existing {#MyAppName} installation is newer than this update.' + #13#13 +
					'The existing installation is '+ InstalledCurrentVersion + '.  This update will change the installation to '+ InstalledVersion + '.' + #13#13 +
					'Do you want to continue with the update installation?', mbError, MB_YESNO
				);
				Result := (Response = IDYES);
			end;
		end else begin
			// Didn't find the folder so its a fresh installation.
			Result:=true;
		end;
    end;

function ShouldSkipPage(PageID: Integer): Boolean;
  var
    PrevDir:String;
	begin
		PrevDir := GetPathInstalled(getAppID(''));
		if length(Prevdir) > 0 then begin
		  // skip selectdir if It's an upgrade
		  if (PageID = wpSelectDir) then begin
			 Result := true;
		  end else if (PageID = wpSelectProgramGroup) then begin
			 Result := true;
  		end else if (PageID = wpSelectTasks) then begin
	 		  Result := true;
  		end else begin
  			Result := false;
  		end;
		end;
	end;