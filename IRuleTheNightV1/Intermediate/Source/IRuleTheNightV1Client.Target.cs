using UnrealBuildTool;

public class IRuleTheNightV1ClientTarget : TargetRules
{
	public IRuleTheNightV1ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("IRuleTheNightV1");
	}
}
