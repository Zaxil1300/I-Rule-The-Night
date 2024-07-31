using UnrealBuildTool;

public class IRuleTheNightV1Target : TargetRules
{
	public IRuleTheNightV1Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("IRuleTheNightV1");
	}
}
