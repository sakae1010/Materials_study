// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Materials_study : ModuleRules
{
	public Materials_study(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Materials_study",
			"Materials_study/Variant_Platforming",
			"Materials_study/Variant_Platforming/Animation",
			"Materials_study/Variant_Combat",
			"Materials_study/Variant_Combat/AI",
			"Materials_study/Variant_Combat/Animation",
			"Materials_study/Variant_Combat/Gameplay",
			"Materials_study/Variant_Combat/Interfaces",
			"Materials_study/Variant_Combat/UI",
			"Materials_study/Variant_SideScrolling",
			"Materials_study/Variant_SideScrolling/AI",
			"Materials_study/Variant_SideScrolling/Gameplay",
			"Materials_study/Variant_SideScrolling/Interfaces",
			"Materials_study/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
