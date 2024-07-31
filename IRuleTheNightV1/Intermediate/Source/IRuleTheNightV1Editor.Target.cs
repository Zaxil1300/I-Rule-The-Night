using UnrealBuildTool;

public class IRuleTheNightV1EditorTarget : TargetRules
{
	public IRuleTheNightV1EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("IRuleTheNightV1");
	}
}
