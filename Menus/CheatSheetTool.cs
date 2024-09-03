using CheatSheet.UI;
using Terraria.ModLoader;

namespace CheatSheet.Menus
{
	abstract class CheatSheetTool
	{
		public CheatSheetTool(Mod mod) {

		}

		public static UIImage hotbarButton;

		public abstract UIImage GetButton(Mod mod);
	}
}
