using Terraria.ModLoader;

namespace CheatSheet
{
	internal class CheatSheetSystem : ModSystem
	{
		public override void PostSetupRecipes() {
			CheatSheet.instance.SetupUI();
		}
	}
}
