using Terraria.ID;
using Terraria.ModLoader;

namespace HyperGear.Items
{
	public class StarterCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Copper Core");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = 100;
			item.rare = ItemRarityID.Green;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 4);
			recipe.AddIngredient(mod.GetItem("CopperKatana"));
			recipe.SetResult(this, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.AddRecipe();

		}
	}
}