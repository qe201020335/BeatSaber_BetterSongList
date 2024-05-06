﻿using HarmonyLib;

namespace BetterSongList.HarmonyPatches {
	[HarmonyPatch(typeof(LevelSearchViewController), nameof(LevelSearchViewController.ResetOptionFilterSettings))]
	static class PresetFilter {
		static void Postfix(ref LevelFilter ____currentSearchFilter) {
			if(Config.Instance.AutoFilterUnowned)
				____currentSearchFilter.songOwned = true;
		}
	}
}
