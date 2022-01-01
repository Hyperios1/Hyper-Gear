using Terraria.ID;
using Terraria.ModLoader;

namespace HyperGear.Items
{
	public class CopperDubleaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Copper Dubleaxe");
			Tooltip.SetDefault("Yea It will work arent it?");
		}

		public override void SetDefaults() 
		{
			item.damage = 15;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 15000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 1;
			item.axe = 8;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 25);
			recipe.AddIngredient(ItemID.Torch, 25);
			recipe.AddIngredient(ItemID.BorealWood, 25);
			recipe.AddIngredient(ItemID.CopperAxe);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}