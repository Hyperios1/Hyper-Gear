using Terraria.ID;
using Terraria.ModLoader;

namespace HyperGear.Items
{
	public class CopperKatana : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Copper Katana");
			Tooltip.SetDefault("Wosh Wosh.");
		}

		public override void SetDefaults() 
		{
			item.damage = 26;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 34000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 2;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 25);
			recipe.AddIngredient(ItemID.Torch, 5);
			recipe.AddIngredient(ItemID.Granite, 25);
			recipe.AddIngredient(ItemID.CopperShortsword);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}