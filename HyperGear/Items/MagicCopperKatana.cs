using Terraria.ID;
using Terraria.ModLoader;

namespace HyperGear.Items
{
	public class MagicCopperKatana : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Magic Copper Katana");
			Tooltip.SetDefault("Wosh Wosh.");
		}

		public override void SetDefaults() 
		{
			item.damage = 32;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 34000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 2;
			item.shoot = 173;
			item.shootSpeed = 10;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Spear, 1);
			recipe.AddIngredient(ItemID.WoodenSword, 1);
			recipe.AddIngredient(ItemID.StoneBlock, 20);
			recipe.AddIngredient(mod.GetItem("StarterCore"));
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}