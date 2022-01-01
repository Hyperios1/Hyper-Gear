using Terraria.ID;
using Terraria.ModLoader;

namespace HyperGear.Items
{
	public class MinerEdge : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Miner Edge"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("It is that good that it can mine!.");
		}

		public override void SetDefaults() 
		{
			item.damage = 14;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 25000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.pick = 45;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SiltBlock, 10);
			recipe.AddIngredient(ItemID.Torch, 2);
			recipe.AddIngredient(ItemID.StoneBlock, 100);
			recipe.AddIngredient(ItemID.CopperPickaxe);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}