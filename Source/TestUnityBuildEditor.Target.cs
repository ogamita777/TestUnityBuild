// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class TestUnityBuildEditorTarget : TargetRules
{
	public TestUnityBuildEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
		ExtraModuleNames.Add("TestUnityBuild");

		bUseUnityBuild = true;
		bForceUnityBuild = true;
		bUseAdaptiveUnityBuild = true;
	}
}
