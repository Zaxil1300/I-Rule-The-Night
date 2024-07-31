using UnrealBuildTool;

public class IRuleTheNightV1ServerTarget : TargetRules
{
	public IRuleTheNightV1ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("IRuleTheNightV1");
	}
}
