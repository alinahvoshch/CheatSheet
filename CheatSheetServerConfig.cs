﻿using System.ComponentModel;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace CheatSheet
{
	class CheatSheetServerConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

		[DefaultValue(false)]
		public bool DisableCheatsForNonHostUsers { get; set; }

		public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref NetworkText message) {
			if (!CheatSheet.IsPlayerLocalServerOwner(Main.player[whoAmI])) {
				message = this.GetLocalization("YouAreNotServerOwnerCantChangeConfig").ToNetworkText();
				return false;
			}
			return base.AcceptClientChanges(pendingConfig, whoAmI, ref message);
		}
	}
}
