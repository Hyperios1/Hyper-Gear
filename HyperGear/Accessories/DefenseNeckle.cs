using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HyperGear.Accessories
{
    public class DefenseNeckle : ModItem
    {
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Defense Neckle");
			Tooltip.SetDefault("Aint Much But Should Help");
		}
        public override void SetDefaults()
        {
            item.defense = 2;
            item.width = 28;
            item.height = 28;
            item.value = 100;
            item.rare = 2;
            item.accessory = true;
        }
  
        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Chain, 1);
			recipe.AddIngredient(ItemID.Daybloom, 5);
			recipe.AddIngredient(ItemID.Topaz, 5);
            recipe.AddIngredient(ItemID.GoldCoin);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}